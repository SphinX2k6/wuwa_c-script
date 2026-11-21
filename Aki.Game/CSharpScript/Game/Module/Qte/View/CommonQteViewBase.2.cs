using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Qte.View
{
	// Token: 0x02003F9B RID: 16283
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonQteViewBase<[Nullable(0)] TContextType> : CommonQteViewBase where TContextType : CommonQteContextBase
	{
		// Token: 0x060292F9 RID: 168697 RVA: 0x00B906F5 File Offset: 0x00B8E8F5
		protected CommonQteViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060292FA RID: 168698 RVA: 0x00B90710 File Offset: 0x00B8E910
		protected override void OnRegisterComponent()
		{
			this.IsMobile = Info.Instance.IsInTouch();
		}

		// Token: 0x060292FB RID: 168699 RVA: 0x00B90724 File Offset: 0x00B8E924
		protected override void OnStart()
		{
			UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, 2);
			if (floatUnit != null)
			{
				base.SetParentUiItem(floatUnit);
			}
		}

		// Token: 0x060292FC RID: 168700 RVA: 0x00B9074C File Offset: 0x00B8E94C
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvents();
			this.UnbindAction();
			if (!this.IsQteEnd)
			{
				TContextType tcontextType = this.CommonQteContext;
				if (tcontextType != null && tcontextType.IsActive())
				{
					CommonQteController.Instance.StopQte(this.CommonQteContext.HandleId);
				}
			}
			this.CommonQteContext = default(TContextType);
			this.QteHandle = -1;
			this.QteAction = "";
		}

		// Token: 0x060292FD RID: 168701 RVA: 0x00B907C0 File Offset: 0x00B8E9C0
		protected void BindAction()
		{
			if (this.HasBindAction)
			{
				return;
			}
			this.HasBindAction = true;
			if (!this.IsMobile && this.IsUseBaseAction() && !string.IsNullOrEmpty(this.QteAction))
			{
				InputDistributeController.Instance.BindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (this.QteAction == "幻象1")
				{
					InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
			this.OnBindAction();
		}

		// Token: 0x060292FE RID: 168702 RVA: 0x00B9084C File Offset: 0x00B8EA4C
		protected void UnbindAction()
		{
			if (!this.HasBindAction)
			{
				return;
			}
			this.HasBindAction = false;
			if (!this.IsMobile && this.IsUseBaseAction() && !string.IsNullOrEmpty(this.QteAction))
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (this.QteAction == "幻象1")
				{
					InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
			this.OnUnbindAction();
		}

		// Token: 0x060292FF RID: 168703 RVA: 0x00B908D5 File Offset: 0x00B8EAD5
		protected virtual void OnBindAction()
		{
		}

		// Token: 0x06029300 RID: 168704 RVA: 0x00B908D7 File Offset: 0x00B8EAD7
		protected virtual void OnUnbindAction()
		{
		}

		// Token: 0x06029301 RID: 168705 RVA: 0x00B908D9 File Offset: 0x00B8EAD9
		protected virtual bool IsUseBaseAction()
		{
			return true;
		}

		// Token: 0x06029302 RID: 168706 RVA: 0x00B908DC File Offset: 0x00B8EADC
		protected void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!this.IsValidInput())
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.OnInputPress();
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.OnInputRelease();
			}
		}

		// Token: 0x06029303 RID: 168707 RVA: 0x00B908FC File Offset: 0x00B8EAFC
		private void OnInputInteract(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (Info.Instance.IsInGamepad())
			{
				SkillButtonUiModel instance = SkillButtonUiModel.Instance;
				bool flag;
				if (instance == null)
				{
					flag = false;
				}
				else
				{
					SkillButtonUiGamepadDataBase gamepadData = instance.GamepadData;
					flag = ((gamepadData != null) ? new bool?(gamepadData.SwitchInteractData.IsSwitchInteractOpen) : null).GetValueOrDefault();
				}
				if (flag)
				{
					SkillButtonUiModel instance2 = SkillButtonUiModel.Instance;
					bool flag2;
					if (instance2 == null)
					{
						flag2 = false;
					}
					else
					{
						SkillButtonUiGamepadDataBase gamepadData2 = instance2.GamepadData;
						flag2 = (((gamepadData2 != null) ? new EGamepadSwitchInteractState?(gamepadData2.SwitchInteractData.State) : null).GetValueOrDefault() == EGamepadSwitchInteractState.Explore);
					}
					if (flag2 && this.QteAction == "幻象1")
					{
						this.OnInputCallback(this.QteAction, actionType, inputIdentification);
						return;
					}
				}
			}
		}

		// Token: 0x06029304 RID: 168708 RVA: 0x00B909AE File Offset: 0x00B8EBAE
		protected virtual void OnInputPress()
		{
		}

		// Token: 0x06029305 RID: 168709 RVA: 0x00B909B0 File Offset: 0x00B8EBB0
		protected virtual void OnInputRelease()
		{
		}

		// Token: 0x06029306 RID: 168710 RVA: 0x00B909B2 File Offset: 0x00B8EBB2
		public override void OnInputTest()
		{
			this.OnInputPress();
		}

		// Token: 0x06029307 RID: 168711 RVA: 0x00B909BA File Offset: 0x00B8EBBA
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			this.ResumeQte(false);
		}

		// Token: 0x06029308 RID: 168712 RVA: 0x00B909C9 File Offset: 0x00B8EBC9
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.PauseQte();
		}

		// Token: 0x06029309 RID: 168713 RVA: 0x00B909D8 File Offset: 0x00B8EBD8
		private void BindEvents()
		{
			if (this.IsBindEvents)
			{
				return;
			}
			this.IsBindEvents = true;
			EventSystem.Instance.Emit<string>(EEventName.DisableCustomInputData, this.ViewInfo.Name);
			BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.PanelQTE, new Action(this.OnBattleUiVisibleChanged));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
			EventSystem.Instance.Add(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}

		// Token: 0x0602930A RID: 168714 RVA: 0x00B90A68 File Offset: 0x00B8EC68
		private void UnbindEvents()
		{
			if (!this.IsBindEvents)
			{
				return;
			}
			this.IsBindEvents = false;
			EventSystem.Instance.Emit<string>(EEventName.EnableCacheCustomInputData, this.ViewInfo.Name);
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.PanelQTE, new Action(this.OnBattleUiVisibleChanged));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
			EventSystem.Instance.Remove(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
		}

		// Token: 0x0602930B RID: 168715 RVA: 0x00B90AF8 File Offset: 0x00B8ECF8
		private void OnCommonQteEnd(int? handleId)
		{
			int qteHandle = this.QteHandle;
			int? num = handleId;
			if (!(qteHandle == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.HandleQteEnd();
		}

		// Token: 0x0602930C RID: 168716 RVA: 0x00B90B28 File Offset: 0x00B8ED28
		private void OnBattleUiVisibleChanged()
		{
			if (this.CommonQteContext == null)
			{
				return;
			}
			EQteSource? source = this.CommonQteContext.Source;
			EQteSource eqteSource = EQteSource.Battle;
			if (!(source.GetValueOrDefault() == eqteSource & source != null))
			{
				return;
			}
			bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
			if (base.GetActive() != childVisible)
			{
				this.SetActive(childVisible);
			}
		}

		// Token: 0x0602930D RID: 168717 RVA: 0x00B90B8D File Offset: 0x00B8ED8D
		private void OnTriggerUiTimeDilation()
		{
			if (this.IsQteEnd)
			{
				return;
			}
			if (CommonQteController.Instance.IsSelfTriggeringTimeDilationChange())
			{
				return;
			}
			if (Time.Instance.TimeDilation == 0f)
			{
				this.PauseQte();
				return;
			}
			this.ResumeQte(true);
		}

		// Token: 0x0602930E RID: 168718 RVA: 0x00B90BC4 File Offset: 0x00B8EDC4
		protected void PauseQte()
		{
			if (this.IsQtePause || this.IsQteEnd)
			{
				return;
			}
			this.IsQtePause = true;
			if (this.IsQteActive)
			{
				this.OnQtePause();
			}
		}

		// Token: 0x0602930F RID: 168719 RVA: 0x00B90BEC File Offset: 0x00B8EDEC
		protected void ResumeQte(bool delay = false)
		{
			if (!this.IsQtePause || this.IsQteEnd)
			{
				return;
			}
			this.IsQtePause = false;
			if (this.IsQteActive)
			{
				if (delay)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						UUIItem rootItem = this.RootItem;
						if (rootItem == null || !rootItem.IsValid())
						{
							return;
						}
						this.OnQteResume();
					}, null, null);
					return;
				}
				this.OnQteResume();
			}
		}

		// Token: 0x06029310 RID: 168720 RVA: 0x00B90C3C File Offset: 0x00B8EE3C
		protected virtual void OnQtePause()
		{
			this.UnbindAction();
			if (this.CommonQteContext != null)
			{
				CommonQteController.Instance.PauseQte(this.CommonQteContext.HandleId);
			}
		}

		// Token: 0x06029311 RID: 168721 RVA: 0x00B90C6C File Offset: 0x00B8EE6C
		protected virtual void OnQteResume()
		{
			if (this.IsQteActive)
			{
				this.BindAction();
			}
			if (this.CommonQteContext != null)
			{
				CommonQteController.Instance.ResumeQte(this.CommonQteContext.HandleId);
			}
			if (!this.IsQtePlayStart)
			{
				this.PlayQteStart();
			}
		}

		// Token: 0x06029312 RID: 168722 RVA: 0x00B90CBC File Offset: 0x00B8EEBC
		protected void HandleQteEnd()
		{
			if (this.IsQteEnd)
			{
				return;
			}
			this.IsQteEnd = true;
			this.OnHandleQteEnd();
			this.UnbindAction();
		}

		// Token: 0x06029313 RID: 168723 RVA: 0x00B90CDA File Offset: 0x00B8EEDA
		protected virtual void OnHandleQteEnd()
		{
		}

		// Token: 0x06029314 RID: 168724 RVA: 0x00B90CDC File Offset: 0x00B8EEDC
		protected bool IsValidInput()
		{
			return this.IsQteInteractive && !this.IsQteEnd && !this.IsQtePause;
		}

		// Token: 0x06029315 RID: 168725 RVA: 0x00B90CFC File Offset: 0x00B8EEFC
		public override void SetQteContext(CommonQteContextBase context)
		{
			if (!this.IsContextMatched(context))
			{
				return;
			}
			this.QteHandle = context.HandleId;
			this.CommonQteContext = (TContextType)((object)context);
			string action = context.GetAction(null);
			if (!string.IsNullOrEmpty(action))
			{
				this.QteAction = action;
				this.OnRefreshActionUi(action);
			}
			this.LoopDuration = (float)Math.Max(0.0, (double)context.Duration * TimeUtil.Instance.Millisecond);
			this.IsQteInteractive = false;
			this.IsShowBorder = false;
			object uiConfig = context.GetUiConfig();
			if (uiConfig != null)
			{
				this.ApplyBaseUiConfig(uiConfig);
			}
			this.TryApplyQteUiConfig(uiConfig);
			this.TryApplyQteIcon(context);
			this.RefreshUiOffset();
			this.SetQteActive(context);
			this.PlayQteStart();
		}

		// Token: 0x06029316 RID: 168726 RVA: 0x00B90DB8 File Offset: 0x00B8EFB8
		private void ApplyBaseUiConfig(object uiConfig)
		{
			SCommonQte_SingleClick scommonQte_SingleClick = uiConfig as SCommonQte_SingleClick;
			bool flag;
			if (scommonQte_SingleClick == null)
			{
				SCommonQte_ContinuousClick scommonQte_ContinuousClick = uiConfig as SCommonQte_ContinuousClick;
				if (scommonQte_ContinuousClick == null)
				{
					SCommonQte_LongPress scommonQte_LongPress = uiConfig as SCommonQte_LongPress;
					if (scommonQte_LongPress == null)
					{
						SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
						flag = (scommonQte_Drag != null && scommonQte_Drag.InteractiveTiming == ECommonQteInteractiveTiming.始终);
					}
					else
					{
						flag = (scommonQte_LongPress.InteractiveTiming == ECommonQteInteractiveTiming.始终);
					}
				}
				else
				{
					flag = (scommonQte_ContinuousClick.InteractiveTiming == ECommonQteInteractiveTiming.始终);
				}
			}
			else
			{
				flag = (scommonQte_SingleClick.InteractiveTiming == ECommonQteInteractiveTiming.始终);
			}
			this.IsQteInteractive = flag;
			SCommonQte_SingleClick scommonQte_SingleClick2 = uiConfig as SCommonQte_SingleClick;
			if (scommonQte_SingleClick2 == null)
			{
				SCommonQte_ContinuousClick scommonQte_ContinuousClick2 = uiConfig as SCommonQte_ContinuousClick;
				flag = (scommonQte_ContinuousClick2 != null && scommonQte_ContinuousClick2.IsShowBorder);
			}
			else
			{
				flag = scommonQte_SingleClick2.IsShowBorder;
			}
			this.IsShowBorder = flag;
		}

		// Token: 0x06029317 RID: 168727 RVA: 0x00B90E89 File Offset: 0x00B8F089
		protected virtual bool IsContextMatched(CommonQteContextBase context)
		{
			return context is TContextType;
		}

		// Token: 0x06029318 RID: 168728 RVA: 0x00B90E94 File Offset: 0x00B8F094
		protected virtual void OnRefreshActionUi(string action)
		{
		}

		// Token: 0x06029319 RID: 168729 RVA: 0x00B90E96 File Offset: 0x00B8F096
		[NullableContext(2)]
		protected virtual void TryApplyQteUiConfig(object uiConfig)
		{
		}

		// Token: 0x0602931A RID: 168730 RVA: 0x00B90E98 File Offset: 0x00B8F098
		protected virtual void TryApplyQteIcon(CommonQteContextBase context)
		{
			IQteResource resource = context.Resource;
			ULGUITexturePackerSpriteData ulguitexturePackerSpriteData = (resource != null) ? resource.Icon : null;
			if (ulguitexturePackerSpriteData != null)
			{
				this.OnRefreshIcon(ulguitexturePackerSpriteData);
			}
		}

		// Token: 0x0602931B RID: 168731 RVA: 0x00B90EC2 File Offset: 0x00B8F0C2
		protected virtual void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
		{
		}

		// Token: 0x0602931C RID: 168732 RVA: 0x00B90EC4 File Offset: 0x00B8F0C4
		protected void SetQteActive(CommonQteContextBase context)
		{
			this.IsQteActive = true;
			if (context.Source.GetValueOrDefault() == EQteSource.CG)
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.VideoView);
				if (viewByName != null)
				{
					UUIItem rootItem = viewByName.GetRootItem();
					if (rootItem != null)
					{
						base.GetRootItem().SetUIParent(rootItem, false);
					}
				}
			}
			else
			{
				EQteSource? source = context.Source;
				EQteSource eqteSource = EQteSource.Battle;
				if (source.GetValueOrDefault() == eqteSource & source != null)
				{
					bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
					if (base.GetActive() != childVisible)
					{
						this.SetActive(childVisible);
					}
					if (!childVisible || Time.Instance.TimeDilation == 0f)
					{
						this.PauseQte();
					}
				}
				else if (context.Source.GetValueOrDefault() == EQteSource.Level && Time.Instance.TimeDilation == 0f)
				{
					this.PauseQte();
				}
			}
			this.BindEvents();
			if (!this.IsQtePause)
			{
				this.BindAction();
			}
		}

		// Token: 0x0602931D RID: 168733 RVA: 0x00B90FB4 File Offset: 0x00B8F1B4
		public unsafe override void PlayQteStart()
		{
			Log.Instance.Info(ELogModule.CommonQte, ELogAuthor.WWJ, "[CommonQteViewBase] PlayQteStart", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.IsQtePlayStart || !this.IsQteActive || this.IsQteEnd || this.IsQtePause || this.CommonQteContext == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonQte;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "[CommonQteViewBase] PlayQteStart Failed";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsQtePlayStart", this.IsQtePlayStart);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsQteActive", this.IsQteActive);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsQteEnd", this.IsQteEnd);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsQtePause", this.IsQtePause);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
				string item = "CommonQteContext";
				TContextType tcontextType = this.CommonQteContext;
				ptr = new ValueTuple<string, object>(item, (tcontextType != null) ? new int?(tcontextType.HandleId) : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				return;
			}
			this.IsQtePlayStart = true;
			this.OnPlayQteStart();
			CommonQteController.Instance.SetExpiredTimer(this.CommonQteContext);
		}

		// Token: 0x0602931E RID: 168734 RVA: 0x00B91121 File Offset: 0x00B8F321
		protected virtual void OnPlayQteStart()
		{
		}

		// Token: 0x0602931F RID: 168735 RVA: 0x00B91124 File Offset: 0x00B8F324
		protected override void OnTick(float delta)
		{
			if (!this.IsQteStart || this.IsQteEnd || this.IsQtePause)
			{
				return;
			}
			if (this.CommonQteContext == null || this.CommonQteContext.IsInvalid())
			{
				this.HandleQteEnd();
				return;
			}
			this.CommonQteContext.UpdateTime(delta);
			if (this.CommonQteContext != null)
			{
				this.OnTickQteView(delta);
			}
			CommonQteModel instance = CommonQteModel.Instance;
			if (instance != null && instance.IsRefreshMode)
			{
				this.RefreshUiOffset();
			}
		}

		// Token: 0x06029320 RID: 168736 RVA: 0x00B911AE File Offset: 0x00B8F3AE
		protected virtual void OnTickQteView(float delta)
		{
		}

		// Token: 0x06029321 RID: 168737 RVA: 0x00B911B0 File Offset: 0x00B8F3B0
		protected virtual void RefreshUiOffset()
		{
		}

		// Token: 0x040166C6 RID: 91846
		protected bool IsMobile;

		// Token: 0x040166C7 RID: 91847
		protected bool IsQteActive;

		// Token: 0x040166C8 RID: 91848
		protected bool IsQtePlayStart;

		// Token: 0x040166C9 RID: 91849
		protected bool IsQteStart;

		// Token: 0x040166CA RID: 91850
		protected bool IsQteEnd;

		// Token: 0x040166CB RID: 91851
		protected bool IsQteInteractive;

		// Token: 0x040166CC RID: 91852
		protected bool IsQtePause;

		// Token: 0x040166CD RID: 91853
		protected bool HasBindAction;

		// Token: 0x040166CE RID: 91854
		protected string QteAction = "";

		// Token: 0x040166CF RID: 91855
		protected int QteHandle = -1;

		// Token: 0x040166D0 RID: 91856
		[Nullable(2)]
		protected TContextType CommonQteContext;

		// Token: 0x040166D1 RID: 91857
		protected float LoopDuration;

		// Token: 0x040166D2 RID: 91858
		protected bool IsShowBorder;

		// Token: 0x040166D3 RID: 91859
		protected bool IsBindEvents;
	}
}
