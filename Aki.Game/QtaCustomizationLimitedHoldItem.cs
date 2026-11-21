using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BAB RID: 7083
[NullableContext(1)]
[Nullable(0)]
public class QtaCustomizationLimitedHoldItem : QtaItemBase
{
	// Token: 0x06011A52 RID: 72274 RVA: 0x00534C7C File Offset: 0x00532E7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011A53 RID: 72275 RVA: 0x00534DF0 File Offset: 0x00532FF0
	protected override UniTask OnBeforeStartAsync()
	{
		QtaCustomizationLimitedHoldItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011A54 RID: 72276 RVA: 0x00534E34 File Offset: 0x00533034
	protected override void OnStart()
	{
		base.OnStart();
		for (int i = 5; i <= 9; i++)
		{
			base.InitTweenAnim(i);
		}
		base.SetUiActive(false);
	}

	// Token: 0x06011A55 RID: 72277 RVA: 0x00534E64 File Offset: 0x00533064
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (!this.IsQtaEnd)
		{
			QtaCustomizationContext qtaContext = this.QtaContext;
			if (qtaContext != null && qtaContext.IsActive())
			{
				QtaController.Instance.StopQta(this.QtaContext.HandleId, false);
			}
		}
		this.UnbindAction();
		this.QtaContext = null;
		this.QtaHandle = -1;
		this.QtaActions.Clear();
	}

	// Token: 0x06011A56 RID: 72278 RVA: 0x00534EC8 File Offset: 0x005330C8
	protected override UniTask OnShowAsyncImplementImplement()
	{
		QtaCustomizationLimitedHoldItem.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06011A57 RID: 72279 RVA: 0x00534F0C File Offset: 0x0053310C
	protected override UniTask OnHideAsyncImplementImplement()
	{
		QtaCustomizationLimitedHoldItem.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06011A58 RID: 72280 RVA: 0x00534F50 File Offset: 0x00533150
	public override void SetQtaContext(QtaContextBase context)
	{
		QtaCustomizationContext qtaCustomizationContext = context as QtaCustomizationContext;
		if (qtaCustomizationContext == null)
		{
			return;
		}
		this.QtaHandle = context.HandleId;
		this.QtaContext = qtaCustomizationContext;
		this.QtaActions = (context.GetActions() ?? new List<string>());
		bool valid = ((QtaCustomizationLimitedHoldLogic)this.QtaContext.QtaCustomizationLogic).IsWithinRange();
		QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
		if (bgBarLogic != null)
		{
			bgBarLogic.SetValid(valid);
		}
		this.RefreshValidState(valid, true);
		base.SetQtaActive(context);
	}

	// Token: 0x06011A59 RID: 72281 RVA: 0x00534FC8 File Offset: 0x005331C8
	protected override void OnPlayQtaStart()
	{
		if (!this.IsQtaActive || this.IsQtaEnd || this.IsQtaPause || this.QtaContext == null)
		{
			return;
		}
		this.IsQtaPlayStart = true;
		base.SetUiActive(true);
		this.SetSelfActive(true);
		this.SetActive(true);
		this.BindAction();
		QtaCustomizationLimitedHoldLogic qtaCustomizationLimitedHoldLogic = this.QtaContext.QtaCustomizationLogic as QtaCustomizationLimitedHoldLogic;
		if (qtaCustomizationLimitedHoldLogic != null)
		{
			QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
			if (bgBarLogic != null)
			{
				bgBarLogic.SetBgParam(qtaCustomizationLimitedHoldLogic.GetBgValue(0));
			}
			QtaCustomizationLimitedHoldItemBar bgBarLogic2 = this.BgBarLogic;
			if (bgBarLogic2 != null)
			{
				bgBarLogic2.SetBgPercent(qtaCustomizationLimitedHoldLogic.GetBgProgress(0));
			}
		}
		this.QtaContext.UpdateTime(0f);
		QtaController.Instance.SetExpiredTimer(this.QtaContext);
		this.OnTick(0f);
	}

	// Token: 0x06011A5A RID: 72282 RVA: 0x00535088 File Offset: 0x00533288
	private void RefreshValidState(bool valid, bool isStart = false)
	{
		if (isStart)
		{
			base.GetItem(2).SetUIActive(valid);
			base.GetItem(3).SetUIActive(!valid);
			return;
		}
		this.TweenAnimPlayer.StopTweenAnim((!valid) ? 6 : 7);
		this.TweenAnimPlayer.PlayTweenAnim(valid ? 6 : 7);
	}

	// Token: 0x06011A5B RID: 72283 RVA: 0x005350DA File Offset: 0x005332DA
	private void SetSelfActive(bool active)
	{
		if (!active)
		{
			base.Destroy(null);
			return;
		}
		if (this.IsQtaEnd)
		{
			return;
		}
		this.IsQtaStart = true;
		this.CanInteractive = true;
	}

	// Token: 0x06011A5C RID: 72284 RVA: 0x00535100 File Offset: 0x00533300
	protected override void RefreshOnBattleUiVisibleChanged()
	{
		QtaCustomizationContext qtaContext = this.QtaContext;
		bool flag;
		if (qtaContext == null)
		{
			flag = true;
		}
		else
		{
			EQtaSource? source = qtaContext.Source;
			EQtaSource eqtaSource = EQtaSource.Battle;
			flag = !(source.GetValueOrDefault() == eqtaSource & source != null);
		}
		if (flag)
		{
			return;
		}
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQta);
		this.SetActive(childVisible);
	}

	// Token: 0x06011A5D RID: 72285 RVA: 0x00535154 File Offset: 0x00533354
	private void BindAction()
	{
		if (this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = true;
		if (!this.IsMobile)
		{
			foreach (string text in this.QtaActions)
			{
				InputDistributeController.Instance.BindActionIgnoreLimit(text, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (text == "幻象1")
				{
					InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
		}
	}

	// Token: 0x06011A5E RID: 72286 RVA: 0x005351F8 File Offset: 0x005333F8
	private void UnbindAction()
	{
		if (!this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = false;
		if (!this.IsMobile)
		{
			foreach (string text in this.QtaActions)
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit(text, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (text == "幻象1")
				{
					InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
		}
	}

	// Token: 0x06011A5F RID: 72287 RVA: 0x0053529C File Offset: 0x0053349C
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
	{
		if (!base.IsValidInput())
		{
			return;
		}
		this.OnInput(actionType);
	}

	// Token: 0x06011A60 RID: 72288 RVA: 0x005352B0 File Offset: 0x005334B0
	private void OnInputInteract(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
	{
		if (Info.Instance.IsInGamepad())
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			GamepadSwitchInteractData gamepadSwitchInteractData;
			if (instance == null)
			{
				gamepadSwitchInteractData = null;
			}
			else
			{
				SkillButtonUiGamepadDataBase gamepadData = instance.GamepadData;
				gamepadSwitchInteractData = ((gamepadData != null) ? gamepadData.SwitchInteractData : null);
			}
			GamepadSwitchInteractData gamepadSwitchInteractData2 = gamepadSwitchInteractData;
			if (gamepadSwitchInteractData2 == null || !gamepadSwitchInteractData2.IsSwitchInteractOpen || gamepadSwitchInteractData2.State != EGamepadSwitchInteractState.Explore || !this.QtaActions.Contains("幻象1"))
			{
				return;
			}
		}
		this.OnInputCallback(actionName, actionType, _);
	}

	// Token: 0x06011A61 RID: 72289 RVA: 0x00535317 File Offset: 0x00533517
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.QtaContext != null && this.QtaContext.IsActive() && this.QtaContext.IsPending())
		{
			this.QtaContext.QtaResponse(actionType == InputDistributeDefine.EActionType.Press);
		}
	}

	// Token: 0x06011A62 RID: 72290 RVA: 0x0053534A File Offset: 0x0053354A
	public override void OnQtaMoment(EQtaMomentName qtaMoment)
	{
		if (qtaMoment == EQtaMomentName.EnterValidRange)
		{
			this.RefreshValidState(true, false);
		}
		else if (qtaMoment == EQtaMomentName.ExitValidRange)
		{
			this.RefreshValidState(false, false);
		}
		QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
		if (bgBarLogic == null)
		{
			return;
		}
		bgBarLogic.SetValid(qtaMoment == EQtaMomentName.EnterValidRange);
	}

	// Token: 0x06011A63 RID: 72291 RVA: 0x0053537A File Offset: 0x0053357A
	protected override void HandleQtaEnd()
	{
		if (this.IsQtaEnd)
		{
			return;
		}
		this.IsQtaEnd = true;
		this.UnbindAction();
		base.ClearTickTimer();
		this.SetSelfActive(false);
	}

	// Token: 0x06011A64 RID: 72292 RVA: 0x0053539F File Offset: 0x0053359F
	protected override void OnQtaPause()
	{
		this.UnbindAction();
		if (this.QtaContext != null)
		{
			QtaController.Instance.PauseQta(this.QtaContext.HandleId);
		}
	}

	// Token: 0x06011A65 RID: 72293 RVA: 0x005353C4 File Offset: 0x005335C4
	protected override void OnQtaResume()
	{
		if (this.IsQtaPlayStart)
		{
			this.BindAction();
		}
		if (!this.IsQtaPlayStart)
		{
			base.PlayQtaStart();
		}
		if (this.QtaContext != null)
		{
			QtaController.Instance.ResumeQta(this.QtaContext.HandleId);
		}
	}

	// Token: 0x06011A66 RID: 72294 RVA: 0x00535400 File Offset: 0x00533600
	protected override void OnTick(float delta)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null || !rootItem.IsValid())
		{
			this.HandleQtaEnd();
			return;
		}
		if (!this.IsQtaStart || this.IsQtaEnd || this.IsQtaPause)
		{
			return;
		}
		if (this.QtaContext == null || this.QtaContext.IsInvalid())
		{
			this.HandleQtaEnd();
			return;
		}
		this.QtaContext.UpdateTime(delta);
		if (!this.QtaContext.IsInvalid())
		{
			this.TmpRotation.Yaw = this.QtaContext.GetProgress() * 360f;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIRelativeRotation(this.TmpRotation);
			}
			QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
			if (bgBarLogic == null)
			{
				return;
			}
			QtaCustomizationBaseLogic qtaCustomizationLogic = this.QtaContext.QtaCustomizationLogic;
			bgBarLogic.SetBgPercent((qtaCustomizationLogic != null) ? qtaCustomizationLogic.GetBgProgress(0) : 0f);
		}
	}

	// Token: 0x04009A44 RID: 39492
	private List<string> QtaActions = new List<string>();

	// Token: 0x04009A45 RID: 39493
	private bool HasBindAction;

	// Token: 0x04009A46 RID: 39494
	[Nullable(2)]
	private QtaCustomizationContext QtaContext;

	// Token: 0x04009A47 RID: 39495
	[Nullable(2)]
	private QtaCustomizationLimitedHoldItemBar BgBarLogic;

	// Token: 0x04009A48 RID: 39496
	private FRotator TmpRotation = new FRotator();

	// Token: 0x02007EAD RID: 32429
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04029020 RID: 167968
		public const int PnlBgBar = 0;

		// Token: 0x04029021 RID: 167969
		public const int BgItem = 1;

		// Token: 0x04029022 RID: 167970
		public const int Arrow1 = 2;

		// Token: 0x04029023 RID: 167971
		public const int Arrow2 = 3;

		// Token: 0x04029024 RID: 167972
		public const int PnlArrow = 4;

		// Token: 0x04029025 RID: 167973
		public const int AniIn = 5;

		// Token: 0x04029026 RID: 167974
		public const int AniToYellow = 6;

		// Token: 0x04029027 RID: 167975
		public const int AniToBlue = 7;

		// Token: 0x04029028 RID: 167976
		public const int AniSuccessOut = 8;

		// Token: 0x04029029 RID: 167977
		public const int AniNormalOut = 9;
	}
}
