using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FA RID: 25594
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinationAxisHandle
	{
		// Token: 0x0603E112 RID: 254226 RVA: 0x01201527 File Offset: 0x011FF727
		public void Clear()
		{
			this.PressCombinationAxisBindingMap = null;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x0603E113 RID: 254227 RVA: 0x0120153B File Offset: 0x011FF73B
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x0603E114 RID: 254228 RVA: 0x01201544 File Offset: 0x011FF744
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

		// Token: 0x0603E115 RID: 254229 RVA: 0x01201597 File Offset: 0x011FF797
		public void ReleaseAnyKey(string keyName)
		{
			if (this.PressMainKeyName == keyName)
			{
				this.ReleaseMainKey();
				return;
			}
			this.PressOtherKeySet.Remove(keyName);
		}

		// Token: 0x0603E116 RID: 254230 RVA: 0x012015BC File Offset: 0x011FF7BC
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

		// Token: 0x0603E117 RID: 254231 RVA: 0x0120161C File Offset: 0x011FF81C
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

		// Token: 0x0603E118 RID: 254232 RVA: 0x012016DC File Offset: 0x011FF8DC
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

		// Token: 0x0603E119 RID: 254233 RVA: 0x0120195C File Offset: 0x011FFB5C
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

		// Token: 0x0603E11A RID: 254234 RVA: 0x012019C8 File Offset: 0x011FFBC8
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

		// Token: 0x0603E11B RID: 254235 RVA: 0x01201A6C File Offset: 0x011FFC6C
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

		// Token: 0x04020F07 RID: 134919
		[Nullable(2)]
		private string PressMainKeyName;

		// Token: 0x04020F08 RID: 134920
		public long PressMainKeyTimeStamp;

		// Token: 0x04020F09 RID: 134921
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private IReadOnlyDictionary<string, List<InputCombinationAxisBinding>> PressCombinationAxisBindingMap;

		// Token: 0x04020F0A RID: 134922
		private readonly HashSet<string> PressOtherKeySet = new HashSet<string>();

		// Token: 0x04020F0B RID: 134923
		public bool InCombinationAxis;

		// Token: 0x04020F0C RID: 134924
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x04020F0D RID: 134925
		private readonly HashSet<string> FrameAxisNameSet = new HashSet<string>();
	}
}
