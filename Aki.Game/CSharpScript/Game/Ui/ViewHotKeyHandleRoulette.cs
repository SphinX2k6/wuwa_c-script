using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A1 RID: 18081
	[NullableContext(1)]
	[Nullable(0)]
	public class ViewHotKeyHandleRoulette : ViewHotKeyHandle
	{
		// Token: 0x0602E9E4 RID: 190948 RVA: 0x00ACB0C3 File Offset: 0x00AC92C3
		public ViewHotKeyHandleRoulette(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602E9E5 RID: 190949 RVA: 0x00ACB0CC File Offset: 0x00AC92CC
		public override void Bind()
		{
			this.Init();
			InputDistributeController.Instance.BindAction(this.ActionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnRouletteInputAction));
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
		}

		// Token: 0x0602E9E6 RID: 190950 RVA: 0x00ACB10C File Offset: 0x00AC930C
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

		// Token: 0x0602E9E7 RID: 190951 RVA: 0x00ACB18A File Offset: 0x00AC938A
		private void OnActionKeyChanged(string actionName)
		{
			if (!string.IsNullOrEmpty(this.ActionName) && this.ActionName == actionName)
			{
				this.SetNeedAxisFlag(this.IsActionCombinationAxisMainKey());
			}
		}

		// Token: 0x0602E9E8 RID: 190952 RVA: 0x00ACB1B4 File Offset: 0x00AC93B4
		private void Init()
		{
			this.AxisDeadZone = ConfigCommonParamById.GetFloatConfig("Roulette_Gamepad_Open_DeadLimit").GetValueOrDefault();
			this.SetNeedAxisFlag(this.IsActionCombinationAxisMainKey());
		}

		// Token: 0x0602E9E9 RID: 190953 RVA: 0x00ACB1E8 File Offset: 0x00AC93E8
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

		// Token: 0x0602E9EA RID: 190954 RVA: 0x00ACB240 File Offset: 0x00AC9440
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

		// Token: 0x0602E9EB RID: 190955 RVA: 0x00ACB2C8 File Offset: 0x00AC94C8
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

		// Token: 0x0602E9EC RID: 190956 RVA: 0x00ACB31C File Offset: 0x00AC951C
		private void OnRouletteInputAction(string name, InputDistributeDefine.EActionType value, InputIdentification inputIdentification)
		{
			this.ActionFlag = (value == InputDistributeDefine.EActionType.Press);
			base.OnInputAction(name, value, inputIdentification);
		}

		// Token: 0x0602E9ED RID: 190957 RVA: 0x00ACB331 File Offset: 0x00AC9531
		protected override bool SpecialConditionCheck()
		{
			return !Info.Instance.IsInGamepad() || !this.NeedAxisFlag || this.AxisFlag;
		}

		// Token: 0x0602E9EE RID: 190958 RVA: 0x00ACB354 File Offset: 0x00AC9554
		protected override void OnOpenViewImplement()
		{
			RouletteMainViewProxyBase currentRouletteMainViewProxy = RouletteController.Instance.GetCurrentRouletteMainViewProxy();
			currentRouletteMainViewProxy.ActionType = (ERouletteActionType)Convert.ToInt32(this.ViewParam[0]);
			RouletteController.Instance.OpenRouletteMainView(currentRouletteMainViewProxy);
		}

		// Token: 0x04019659 RID: 104025
		private bool ActionFlag;

		// Token: 0x0401965A RID: 104026
		private bool AxisFlag;

		// Token: 0x0401965B RID: 104027
		private bool NeedAxisFlag;

		// Token: 0x0401965C RID: 104028
		private float AxisDeadZone;
	}
}
