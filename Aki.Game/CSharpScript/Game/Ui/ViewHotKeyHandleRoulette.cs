using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D2 RID: 13778
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewHotKeyHandleRoulette : ViewHotKeyHandle
	{
		// Token: 0x06023130 RID: 143664 RVA: 0x009F9997 File Offset: 0x009F7B97
		public ViewHotKeyHandleRoulette(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x06023131 RID: 143665 RVA: 0x009F99A0 File Offset: 0x009F7BA0
		public override void Bind()
		{
			this.Init();
			InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnRouletteInputAction));
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
		}

		// Token: 0x06023132 RID: 143666 RVA: 0x009F99E0 File Offset: 0x009F7BE0
		protected override void UnBind()
		{
			InputDistributeController.Instance.UnBindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnRouletteInputAction));
			if (this.NeedAxisFlag)
			{
				InputDistributeController.Instance.UnBindAxes(new <>z__ReadOnlyArray<string>(new string[]
				{
					"LookUp",
					"Turn"
				}), new TInputHandle<float>(this.OnRouletteInputAxis));
			}
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
		}

		// Token: 0x06023133 RID: 143667 RVA: 0x009F9A5E File Offset: 0x009F7C5E
		private void OnActionKeyChanged(string actionName)
		{
			if (!string.IsNullOrEmpty(this.ActionName) && this.ActionName == actionName)
			{
				this.SetNeedAxisFlag(this.IsActionCombinationAxisMainKey());
			}
		}

		// Token: 0x06023134 RID: 143668 RVA: 0x009F9A88 File Offset: 0x009F7C88
		private void Init()
		{
			this.AxisDeadZone = ConfigCommonParamById.GetFloatConfig("Roulette_Gamepad_Open_DeadLimit").GetValueOrDefault();
			this.SetNeedAxisFlag(this.IsActionCombinationAxisMainKey());
		}

		// Token: 0x06023135 RID: 143669 RVA: 0x009F9ABC File Offset: 0x009F7CBC
		private bool IsActionCombinationAxisMainKey()
		{
			if (this.ActionName == null)
			{
				return false;
			}
			InputActionBinding actionBinding = InputSettingsManager.Instance.GetActionBinding(this.ActionName);
			if (actionBinding == null)
			{
				return false;
			}
			List<string> list = new List<string>();
			actionBinding.GetGamepadKeyNameList(list);
			return list.Count == 1 && InputSettingsManager.Instance.IsCombinationAxisMainKey(list[0]);
		}

		// Token: 0x06023136 RID: 143670 RVA: 0x009F9B14 File Offset: 0x009F7D14
		private void SetNeedAxisFlag(bool flag)
		{
			if (flag == this.NeedAxisFlag)
			{
				return;
			}
			if (flag)
			{
				InputDistributeController.Instance.BindAxes(new <>z__ReadOnlyArray<string>(new string[]
				{
					"LookUp",
					"Turn"
				}), new TInputHandle<float>(this.OnRouletteInputAxis));
			}
			else
			{
				InputDistributeController.Instance.UnBindAxes(new <>z__ReadOnlyArray<string>(new string[]
				{
					"LookUp",
					"Turn"
				}), new TInputHandle<float>(this.OnRouletteInputAxis));
			}
			this.NeedAxisFlag = flag;
		}

		// Token: 0x06023137 RID: 143671 RVA: 0x009F9B9C File Offset: 0x009F7D9C
		private void OnRouletteInputAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!this.NeedAxisFlag || !this.ActionFlag)
			{
				return;
			}
			if (value < -this.AxisDeadZone || value > this.AxisDeadZone)
			{
				this.AxisFlag = true;
				base.OnInputAction(this.ActionName, InputDistributeDefine.EActionType.Press, inputIdentification);
				this.AxisFlag = false;
				this.ActionFlag = false;
			}
		}

		// Token: 0x06023138 RID: 143672 RVA: 0x009F9BF0 File Offset: 0x009F7DF0
		private void OnRouletteInputAction(string name, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
		{
			this.ActionFlag = (value == InputDistributeDefine.EActionType.Press);
			base.OnInputAction(name, value, inputIdentification);
		}

		// Token: 0x06023139 RID: 143673 RVA: 0x009F9C05 File Offset: 0x009F7E05
		protected override bool SpecialConditionCheck()
		{
			return !Info.Instance.IsInGamepad() || !this.NeedAxisFlag || this.AxisFlag;
		}

		// Token: 0x0602313A RID: 143674 RVA: 0x009F9C28 File Offset: 0x009F7E28
		protected override void OnOpenViewImplement()
		{
			RouletteMainViewProxyBase currentRouletteMainViewProxy = RouletteController.Instance.GetCurrentRouletteMainViewProxy();
			currentRouletteMainViewProxy.ActionType = (ERouletteActionType)Convert.ToInt32(this.ViewParam[0]);
			RouletteController.Instance.OpenRouletteMainView(currentRouletteMainViewProxy);
		}

		// Token: 0x04013CFE RID: 81150
		private bool ActionFlag;

		// Token: 0x04013CFF RID: 81151
		private bool AxisFlag;

		// Token: 0x04013D00 RID: 81152
		private bool NeedAxisFlag;

		// Token: 0x04013D01 RID: 81153
		private float AxisDeadZone;
	}
}
