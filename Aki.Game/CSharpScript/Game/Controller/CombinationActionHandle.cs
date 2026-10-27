using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Controller
{
	// Token: 0x0200727A RID: 29306
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinationActionHandle
	{
		// Token: 0x06047D45 RID: 294213 RVA: 0x012606F3 File Offset: 0x0125E8F3
		public void Clear()
		{
			this.PressCombinationActionBindingList = null;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06047D46 RID: 294214 RVA: 0x01260707 File Offset: 0x0125E907
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x06047D47 RID: 294215 RVA: 0x01260710 File Offset: 0x0125E910
		public void PressAnyKey(string keyName)
		{
			if (this.PressMainKeyName == null)
			{
				if (InputSettingsManager.Instance.IsCombinationActionMainKey(keyName))
				{
					this.PressMainKey(keyName);
				}
				return;
			}
			IReadOnlyDictionary<string, InputCombinationActionBinding> combinationActionBindingByKeyName = InputSettingsManager.Instance.GetCombinationActionBindingByKeyName(this.PressMainKeyName, keyName);
			if (combinationActionBindingByKeyName == null || combinationActionBindingByKeyName.Count <= 0)
			{
				return;
			}
			List<InputCombinationActionBinding> list = new List<InputCombinationActionBinding>();
			foreach (InputCombinationActionBinding inputCombinationActionBinding in combinationActionBindingByKeyName.Values)
			{
				if (inputCombinationActionBinding.HasCombinationAction(this.PressMainKeyName, keyName))
				{
					list.Add(inputCombinationActionBinding);
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			if (this.PressSecondaryKeyName != null && this.PressSecondaryKeyName != keyName)
			{
				this.ReleaseAnyKey(this.PressSecondaryKeyName);
			}
			this.PressSecondaryKeyName = keyName;
			this.TriggerPressCombinationAction(list);
		}

		// Token: 0x06047D48 RID: 294216 RVA: 0x012607EC File Offset: 0x0125E9EC
		public void ReleaseAnyKey(string keyName)
		{
			if (this.PressSecondaryKeyName == keyName && this.PressCombinationActionBindingList != null)
			{
				this.TriggerReleaseCombinationAction();
				this.PressSecondaryKeyName = null;
				return;
			}
			if (this.PressMainKeyName == keyName)
			{
				this.ReleaseMainKey();
			}
		}

		// Token: 0x06047D49 RID: 294217 RVA: 0x01260828 File Offset: 0x0125EA28
		private void PressMainKey(string pressKeyName)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[Input]按下组合Action主键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MainKeyName", pressKeyName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PressMainKeyName = pressKeyName;
			this.PressMainKeyTimeStamp = (long)TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x06047D4A RID: 294218 RVA: 0x01260874 File Offset: 0x0125EA74
		private void ReleaseMainKey()
		{
			if (this.PressSecondaryKeyName != null && this.PressCombinationActionBindingList != null)
			{
				this.TriggerReleaseCombinationAction();
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[Input]抬起组合Action主键";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MainKeyName", this.PressMainKeyName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.PressCombinationActionBindingList = null;
			this.PressMainKeyName = null;
			this.PressMainKeyTimeStamp = 0L;
			this.PressSecondaryKeyName = null;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06047D4B RID: 294219 RVA: 0x012608EC File Offset: 0x0125EAEC
		private void TriggerPressCombinationAction(IReadOnlyList<InputCombinationActionBinding> combinationActionBindingList)
		{
			this.PressCombinationActionBindingList = combinationActionBindingList;
			foreach (InputCombinationActionBinding inputCombinationActionBinding in combinationActionBindingList)
			{
				string actionName = inputCombinationActionBinding.GetActionName();
				double num = (double)inputCombinationActionBinding.GetSecondaryKeyValidTime();
				if (num <= 0.0 || TimeUtil.Instance.GetServerTimeStamp() - (double)this.PressMainKeyTimeStamp <= num)
				{
					foreach (string item in inputCombinationActionBinding.GetBlockInputKeySet())
					{
						this.BlockInputKeySet.Add(item);
					}
					if (actionName != null)
					{
						InputDistributeController.Instance.InputAction(actionName, true);
					}
				}
			}
		}

		// Token: 0x06047D4C RID: 294220 RVA: 0x012609C4 File Offset: 0x0125EBC4
		private void TriggerReleaseCombinationAction()
		{
			if (this.PressCombinationActionBindingList == null)
			{
				return;
			}
			this.BlockInputKeySet.Clear();
			foreach (InputCombinationActionBinding inputCombinationActionBinding in this.PressCombinationActionBindingList)
			{
				string actionName = inputCombinationActionBinding.GetActionName();
				if (!string.IsNullOrEmpty(actionName))
				{
					try
					{
						InputDistributeController.Instance.InputAction(actionName, false);
					}
					catch (Exception)
					{
						Log.Instance.Error(ELogModule.InputSettings, ELogAuthor.XXJ, "抬起组合Action时出现异常", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			}
		}

		// Token: 0x06047D4D RID: 294221 RVA: 0x01260A68 File Offset: 0x0125EC68
		public bool CheckCombinationAction(string actionName)
		{
			if (this.PressMainKeyName == null)
			{
				return true;
			}
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(actionName);
			if (actionBinding != null)
			{
				ActionMapping? actionMappingConfig = actionBinding.GetActionMappingConfig();
				if (actionMappingConfig != null && actionMappingConfig.Value.IsIdleAction)
				{
					return true;
				}
				IEnumerable<string> keyNameList = actionBinding.GetKeyNameList();
				bool flag = UiManager.Instance.IsViewOpen(EUiViewName.ChineseZitherView);
				foreach (string secondaryKeyName in keyNameList)
				{
					if (InputSettingsManager.Instance.IsCombinationAction(this.PressMainKeyName, secondaryKeyName) && (!flag || this.IsCombinationActionOutputRespondable(this.PressMainKeyName, secondaryKeyName)))
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x06047D4E RID: 294222 RVA: 0x01260B34 File Offset: 0x0125ED34
		private bool IsCombinationActionOutputRespondable(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyDictionary<string, InputCombinationActionBinding> combinationActionBindingByKeyName = InputSettingsManager.Instance.GetCombinationActionBindingByKeyName(mainKeyName, secondaryKeyName);
			if (combinationActionBindingByKeyName == null)
			{
				return false;
			}
			foreach (InputCombinationActionBinding inputCombinationActionBinding in combinationActionBindingByKeyName.Values)
			{
				if (inputCombinationActionBinding.HasCombinationAction(mainKeyName, secondaryKeyName))
				{
					string actionName = inputCombinationActionBinding.GetActionName();
					if (!string.IsNullOrEmpty(actionName) && InputDistributeController.Instance.IsActionRespondable(actionName))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06047D4F RID: 294223 RVA: 0x01260BBC File Offset: 0x0125EDBC
		public bool CheckCombinationActionByAxisName(string axisName)
		{
			if (this.PressMainKeyName == null)
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
				if (InputSettingsManager.Instance.IsCombinationAction(this.PressMainKeyName, secondaryKeyName) && this.IsCombinationActionOutputBound(this.PressMainKeyName, secondaryKeyName))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06047D50 RID: 294224 RVA: 0x01260C58 File Offset: 0x0125EE58
		private bool IsCombinationActionOutputBound(string mainKeyName, string secondaryKeyName)
		{
			IReadOnlyDictionary<string, InputCombinationActionBinding> combinationActionBindingByKeyName = InputSettingsManager.Instance.GetCombinationActionBindingByKeyName(mainKeyName, secondaryKeyName);
			if (combinationActionBindingByKeyName == null)
			{
				return false;
			}
			foreach (InputCombinationActionBinding inputCombinationActionBinding in combinationActionBindingByKeyName.Values)
			{
				string actionName = inputCombinationActionBinding.GetActionName();
				if (!string.IsNullOrEmpty(actionName) && InputDistributeController.Instance.HasActionBind(actionName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04025C42 RID: 154690
		[Nullable(2)]
		private string PressMainKeyName;

		// Token: 0x04025C43 RID: 154691
		[Nullable(2)]
		private string PressSecondaryKeyName;

		// Token: 0x04025C44 RID: 154692
		private long PressMainKeyTimeStamp;

		// Token: 0x04025C45 RID: 154693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<InputCombinationActionBinding> PressCombinationActionBindingList;

		// Token: 0x04025C46 RID: 154694
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();
	}
}
