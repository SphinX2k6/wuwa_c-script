using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063F9 RID: 25593
	[NullableContext(1)]
	[Nullable(0)]
	public class CombinationActionHandle
	{
		// Token: 0x0603E105 RID: 254213 RVA: 0x01200F33 File Offset: 0x011FF133
		public void Clear()
		{
			this.PressCombinationActionBindingList = null;
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x0603E106 RID: 254214 RVA: 0x01200F47 File Offset: 0x011FF147
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x0603E107 RID: 254215 RVA: 0x01200F50 File Offset: 0x011FF150
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

		// Token: 0x0603E108 RID: 254216 RVA: 0x0120102C File Offset: 0x011FF22C
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

		// Token: 0x0603E109 RID: 254217 RVA: 0x01201068 File Offset: 0x011FF268
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

		// Token: 0x0603E10A RID: 254218 RVA: 0x012010B4 File Offset: 0x011FF2B4
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

		// Token: 0x0603E10B RID: 254219 RVA: 0x0120112C File Offset: 0x011FF32C
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

		// Token: 0x0603E10C RID: 254220 RVA: 0x01201204 File Offset: 0x011FF404
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

		// Token: 0x0603E10D RID: 254221 RVA: 0x012012A8 File Offset: 0x011FF4A8
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

		// Token: 0x0603E10E RID: 254222 RVA: 0x01201374 File Offset: 0x011FF574
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

		// Token: 0x0603E10F RID: 254223 RVA: 0x012013FC File Offset: 0x011FF5FC
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

		// Token: 0x0603E110 RID: 254224 RVA: 0x01201498 File Offset: 0x011FF698
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

		// Token: 0x04020F02 RID: 134914
		[Nullable(2)]
		private string PressMainKeyName;

		// Token: 0x04020F03 RID: 134915
		[Nullable(2)]
		private string PressSecondaryKeyName;

		// Token: 0x04020F04 RID: 134916
		private long PressMainKeyTimeStamp;

		// Token: 0x04020F05 RID: 134917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<InputCombinationActionBinding> PressCombinationActionBindingList;

		// Token: 0x04020F06 RID: 134918
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();
	}
}
