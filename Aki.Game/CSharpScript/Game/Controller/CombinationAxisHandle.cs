using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x0200727B RID: 29307
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinationAxisHandle
	{
		// Token: 0x06047D52 RID: 294226 RVA: 0x01260CE7 File Offset: 0x0125EEE7
		public void Clear()
		{
			this.PressCombinationAxisBindingMap = null;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06047D53 RID: 294227 RVA: 0x01260CFB File Offset: 0x0125EEFB
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x06047D54 RID: 294228 RVA: 0x01260D04 File Offset: 0x0125EF04
		public void PressAnyKey(string keyName)
		{
			if (this.PressMainKeyName != null)
			{
				if (this.PressOtherKeySet.Count > 0)
				{
					this.PressOtherKeySet.Add(keyName);
				}
				return;
			}
			if (InputSettingsManager.Instance.IsCombinationAxisMainKey(keyName))
			{
				this.PressMainKey(keyName);
				return;
			}
			this.PressOtherKeySet.Add(keyName);
		}

		// Token: 0x06047D55 RID: 294229 RVA: 0x01260D57 File Offset: 0x0125EF57
		public void ReleaseAnyKey(string keyName)
		{
			if (this.PressMainKeyName == keyName)
			{
				this.ReleaseMainKey();
				return;
			}
			this.PressOtherKeySet.Remove(keyName);
		}

		// Token: 0x06047D56 RID: 294230 RVA: 0x01260D7C File Offset: 0x0125EF7C
		private void PressMainKey(string keyName)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[Input]按下组合Axis主键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MainKeyName", keyName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PressMainKeyName = keyName;
			this.PressMainKeyTimeStamp = (long)TimeUtil.Instance.GetServerTimeStamp();
			this.PressCombinationAxisBindingMap = InputSettingsManager.Instance.GetCombinationAxisBindingMapByMainKeyName(keyName);
		}

		// Token: 0x06047D57 RID: 294231 RVA: 0x01260DDC File Offset: 0x0125EFDC
		private void ReleaseMainKey()
		{
			if (this.PressCombinationAxisBindingMap == null)
			{
				return;
			}
			foreach (List<InputCombinationAxisBinding> list in this.PressCombinationAxisBindingMap.Values)
			{
				foreach (InputCombinationAxisBinding inputCombinationAxisBinding in list)
				{
					string axisName = inputCombinationAxisBinding.GetAxisName();
					InputDistributeController.Instance.InputAxis(axisName, 0f, false);
				}
			}
			this.PressCombinationAxisBindingMap = null;
			this.PressMainKeyName = null;
			this.PressMainKeyTimeStamp = 0L;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06047D58 RID: 294232 RVA: 0x01260E9C File Offset: 0x0125F09C
		public void Tick(float delta)
		{
			this.BlockInputKeySet.Clear();
			if (this.PressOtherKeySet.Count > 0)
			{
				this.InCombinationAxis = false;
				return;
			}
			if (this.PressCombinationAxisBindingMap == null)
			{
				this.InCombinationAxis = false;
				return;
			}
			if (this.PressCombinationAxisBindingMap.Count <= 0)
			{
				this.InCombinationAxis = false;
				return;
			}
			bool inCombinationAxis = false;
			TsCharacterController characterController = Global.CharacterController;
			if (Info.Instance.AxisInputOptimize)
			{
				this.FrameAxisNameSet.Clear();
				using (IEnumerator<KeyValuePair<string, List<InputCombinationAxisBinding>>> enumerator = this.PressCombinationAxisBindingMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, List<InputCombinationAxisBinding>> keyValuePair = enumerator.Current;
						string key = keyValuePair.Key;
						FKey ueKey = InputSettings.Instance.GetUeKey(key);
						float inputAnalogKeyState = characterController.GetInputAnalogKeyState(ueKey);
						foreach (InputCombinationAxisBinding inputCombinationAxisBinding in keyValuePair.Value)
						{
							string axisName = inputCombinationAxisBinding.GetAxisName();
							if (!string.IsNullOrEmpty(axisName) && !this.FrameAxisNameSet.Contains(axisName))
							{
								if (inputAnalogKeyState != 0f)
								{
									this.FrameAxisNameSet.Add(axisName);
								}
								float value = inputAnalogKeyState * inputCombinationAxisBinding.GetSourceAxisValue(key).Value;
								this.TryAddBlockInputKeys(inputCombinationAxisBinding, axisName);
								if (Math.Abs(value) > 0.02f)
								{
									inCombinationAxis = true;
								}
								InputDistributeController.Instance.InputAxis(axisName, value, false);
							}
						}
					}
					goto IL_238;
				}
			}
			foreach (KeyValuePair<string, List<InputCombinationAxisBinding>> keyValuePair2 in this.PressCombinationAxisBindingMap)
			{
				string key2 = keyValuePair2.Key;
				FKey ueKey2 = InputSettings.Instance.GetUeKey(key2);
				float inputAnalogKeyState2 = characterController.GetInputAnalogKeyState(ueKey2);
				foreach (InputCombinationAxisBinding inputCombinationAxisBinding2 in keyValuePair2.Value)
				{
					string axisName2 = inputCombinationAxisBinding2.GetAxisName();
					float value2 = inputAnalogKeyState2 * inputCombinationAxisBinding2.GetSourceAxisValue(key2).Value;
					this.TryAddBlockInputKeys(inputCombinationAxisBinding2, axisName2);
					if (Math.Abs(value2) > 0.02f)
					{
						inCombinationAxis = true;
					}
					InputDistributeController.Instance.InputAxis(axisName2, value2, false);
				}
			}
			IL_238:
			this.InCombinationAxis = inCombinationAxis;
		}

		// Token: 0x06047D59 RID: 294233 RVA: 0x0126111C File Offset: 0x0125F31C
		private void TryAddBlockInputKeys(InputCombinationAxisBinding combinationAxisBinding, [Nullable(2)] string axisName)
		{
			if (string.IsNullOrEmpty(axisName) || !InputDistributeController.Instance.IsAxisRespondable(axisName))
			{
				return;
			}
			foreach (string item in combinationAxisBinding.GetBlockInputKeySet())
			{
				this.BlockInputKeySet.Add(item);
			}
		}

		// Token: 0x06047D5A RID: 294234 RVA: 0x01261188 File Offset: 0x0125F388
		public bool CheckCombinationAxis(string axisName)
		{
			if (this.PressMainKeyName == null)
			{
				return true;
			}
			if (!this.InCombinationAxis)
			{
				return true;
			}
			InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
			if (axisBinding == null)
			{
				return true;
			}
			List<string> list = new List<string>();
			axisBinding.GetKeyNameList(list);
			foreach (string secondaryKeyName in list)
			{
				if (InputSettingsManager.Instance.IsCombinationAxis(this.PressMainKeyName, secondaryKeyName) && this.IsCombinationAxisOutputBound(this.PressMainKeyName, secondaryKeyName))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06047D5B RID: 294235 RVA: 0x0126122C File Offset: 0x0125F42C
		private bool IsCombinationAxisOutputBound(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyList<InputCombinationAxisBinding> combinationAxisBindingByKeyName = InputSettingsManager.Instance.GetCombinationAxisBindingByKeyName(mainKeyName, secondaryKeyName);
			if (combinationAxisBindingByKeyName == null)
			{
				return false;
			}
			foreach (InputCombinationAxisBinding inputCombinationAxisBinding in combinationAxisBindingByKeyName)
			{
				string axisName = inputCombinationAxisBinding.GetAxisName();
				if (!string.IsNullOrEmpty(axisName) && InputDistributeController.Instance.HasAxisBind(axisName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04025C47 RID: 154695
		[Nullable(2)]
		private string PressMainKeyName;

		// Token: 0x04025C48 RID: 154696
		public long PressMainKeyTimeStamp;

		// Token: 0x04025C49 RID: 154697
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private IReadOnlyDictionary<string, List<InputCombinationAxisBinding>> PressCombinationAxisBindingMap;

		// Token: 0x04025C4A RID: 154698
		private readonly HashSet<string> PressOtherKeySet = new HashSet<string>();

		// Token: 0x04025C4B RID: 154699
		public bool InCombinationAxis;

		// Token: 0x04025C4C RID: 154700
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x04025C4D RID: 154701
		private readonly HashSet<string> FrameAxisNameSet = new HashSet<string>();
	}
}
