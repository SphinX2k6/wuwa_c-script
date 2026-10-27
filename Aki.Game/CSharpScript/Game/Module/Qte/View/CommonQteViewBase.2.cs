using System;
using System.Reflection;
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
	// Token: 0x02004FD2 RID: 20434
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonQteViewBase<[Nullable(0)] TContextType> : CommonQteViewBase where TContextType : CommonQteContextBase
	{
		// Token: 0x0603448B RID: 214155 RVA: 0x00C46F3D File Offset: 0x00C4513D
		protected CommonQteViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603448C RID: 214156 RVA: 0x00C46F58 File Offset: 0x00C45158
		protected override void OnRegisterComponent()
		{
			this.IsMobile = Info.Instance.IsInTouch();
		}

		// Token: 0x0603448D RID: 214157 RVA: 0x00C46F6C File Offset: 0x00C4516C
		protected override void OnStart()
		{
			UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, 2);
			if (floatUnit != null)
			{
				base.SetParentUiItem(floatUnit);
			}
		}

		// Token: 0x0603448E RID: 214158 RVA: 0x00C46F94 File Offset: 0x00C45194
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

		// Token: 0x0603448F RID: 214159 RVA: 0x00C47008 File Offset: 0x00C45208
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

		// Token: 0x06034490 RID: 214160 RVA: 0x00C47094 File Offset: 0x00C45294
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

		// Token: 0x06034491 RID: 214161 RVA: 0x00C4711D File Offset: 0x00C4531D
		protected virtual void OnBindAction()
		{
		}

		// Token: 0x06034492 RID: 214162 RVA: 0x00C4711F File Offset: 0x00C4531F
		protected virtual void OnUnbindAction()
		{
		}

		// Token: 0x06034493 RID: 214163 RVA: 0x00C47121 File Offset: 0x00C45321
		protected virtual bool IsUseBaseAction()
		{
			return true;
		}

		// Token: 0x06034494 RID: 214164 RVA: 0x00C47124 File Offset: 0x00C45324
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

		// Token: 0x06034495 RID: 214165 RVA: 0x00C47144 File Offset: 0x00C45344
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

		// Token: 0x06034496 RID: 214166 RVA: 0x00C471F6 File Offset: 0x00C453F6
		protected virtual void OnInputPress()
		{
		}

		// Token: 0x06034497 RID: 214167 RVA: 0x00C471F8 File Offset: 0x00C453F8
		protected virtual void OnInputRelease()
		{
		}

		// Token: 0x06034498 RID: 214168 RVA: 0x00C471FA File Offset: 0x00C453FA
		public override void OnInputTest()
		{
			this.OnInputPress();
		}

		// Token: 0x06034499 RID: 214169 RVA: 0x00C47202 File Offset: 0x00C45402
		protected override void OnAfterShow()
		{
			base.OnAfterShow();
			this.ResumeQte(false);
		}

		// Token: 0x0603449A RID: 214170 RVA: 0x00C47211 File Offset: 0x00C45411
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			this.PauseQte();
		}

		// Token: 0x0603449B RID: 214171 RVA: 0x00C47220 File Offset: 0x00C45420
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

		// Token: 0x0603449C RID: 214172 RVA: 0x00C472B0 File Offset: 0x00C454B0
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

		// Token: 0x0603449D RID: 214173 RVA: 0x00C47340 File Offset: 0x00C45540
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

		// Token: 0x0603449E RID: 214174 RVA: 0x00C47370 File Offset: 0x00C45570
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

		// Token: 0x0603449F RID: 214175 RVA: 0x00C473D5 File Offset: 0x00C455D5
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

		// Token: 0x060344A0 RID: 214176 RVA: 0x00C4740C File Offset: 0x00C4560C
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

		// Token: 0x060344A1 RID: 214177 RVA: 0x00C47434 File Offset: 0x00C45634
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

		// Token: 0x060344A2 RID: 214178 RVA: 0x00C47484 File Offset: 0x00C45684
		protected virtual void OnQtePause()
		{
			this.UnbindAction();
			if (this.CommonQteContext != null)
			{
				CommonQteController.Instance.PauseQte(this.CommonQteContext.HandleId);
			}
		}

		// Token: 0x060344A3 RID: 214179 RVA: 0x00C474B4 File Offset: 0x00C456B4
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

		// Token: 0x060344A4 RID: 214180 RVA: 0x00C47504 File Offset: 0x00C45704
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

		// Token: 0x060344A5 RID: 214181 RVA: 0x00C47522 File Offset: 0x00C45722
		protected virtual void OnHandleQteEnd()
		{
		}

		// Token: 0x060344A6 RID: 214182 RVA: 0x00C47524 File Offset: 0x00C45724
		protected bool IsValidInput()
		{
			return this.IsQteInteractive && !this.IsQteEnd && !this.IsQtePause;
		}

		// Token: 0x060344A7 RID: 214183 RVA: 0x00C47544 File Offset: 0x00C45744
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

		// Token: 0x060344A8 RID: 214184 RVA: 0x00C47600 File Offset: 0x00C45800
		private void ApplyBaseUiConfig(object uiConfig)
		{
			Type type = uiConfig.GetType();
			PropertyInfo property = type.GetProperty("InteractiveTiming");
			if (property != null)
			{
				object value = property.GetValue(uiConfig);
				if (value is TEnumAsByte<ECommonQteInteractiveTiming>)
				{
					TEnumAsByte<ECommonQteInteractiveTiming> left = (TEnumAsByte<ECommonQteInteractiveTiming>)value;
					this.IsQteInteractive = (left == ECommonQteInteractiveTiming.始终);
				}
			}
			PropertyInfo property2 = type.GetProperty("IsShowBorder");
			if (property2 != null)
			{
				object value2 = property2.GetValue(uiConfig);
				if (value2 is bool)
				{
					bool isShowBorder = (bool)value2;
					this.IsShowBorder = isShowBorder;
				}
			}
		}

		// Token: 0x060344A9 RID: 214185 RVA: 0x00C47688 File Offset: 0x00C45888
		protected virtual bool IsContextMatched(CommonQteContextBase context)
		{
			return context is TContextType;
		}

		// Token: 0x060344AA RID: 214186 RVA: 0x00C47693 File Offset: 0x00C45893
		protected virtual void OnRefreshActionUi(string action)
		{
		}

		// Token: 0x060344AB RID: 214187 RVA: 0x00C47695 File Offset: 0x00C45895
		[NullableContext(2)]
		protected virtual void TryApplyQteUiConfig(object uiConfig)
		{
		}

		// Token: 0x060344AC RID: 214188 RVA: 0x00C47698 File Offset: 0x00C45898
		protected virtual void TryApplyQteIcon(CommonQteContextBase context)
		{
			IQteResource resource = context.Resource;
			ULGUITexturePackerSpriteData ulguitexturePackerSpriteData = (resource != null) ? resource.Icon : null;
			if (ulguitexturePackerSpriteData != null)
			{
				this.OnRefreshIcon(ulguitexturePackerSpriteData);
			}
		}

		// Token: 0x060344AD RID: 214189 RVA: 0x00C476C2 File Offset: 0x00C458C2
		protected virtual void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
		{
		}

		// Token: 0x060344AE RID: 214190 RVA: 0x00C476C4 File Offset: 0x00C458C4
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

		// Token: 0x060344AF RID: 214191 RVA: 0x00C477B4 File Offset: 0x00C459B4
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

		// Token: 0x060344B0 RID: 214192 RVA: 0x00C47921 File Offset: 0x00C45B21
		protected virtual void OnPlayQteStart()
		{
		}

		// Token: 0x060344B1 RID: 214193 RVA: 0x00C47924 File Offset: 0x00C45B24
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

		// Token: 0x060344B2 RID: 214194 RVA: 0x00C479AE File Offset: 0x00C45BAE
		protected virtual void OnTickQteView(float delta)
		{
		}

		// Token: 0x060344B3 RID: 214195 RVA: 0x00C479B0 File Offset: 0x00C45BB0
		protected virtual void RefreshUiOffset()
		{
		}

		// Token: 0x0401BCF1 RID: 113905
		protected bool IsMobile;

		// Token: 0x0401BCF2 RID: 113906
		protected bool IsQteActive;

		// Token: 0x0401BCF3 RID: 113907
		protected bool IsQtePlayStart;

		// Token: 0x0401BCF4 RID: 113908
		protected bool IsQteStart;

		// Token: 0x0401BCF5 RID: 113909
		protected bool IsQteEnd;

		// Token: 0x0401BCF6 RID: 113910
		protected bool IsQteInteractive;

		// Token: 0x0401BCF7 RID: 113911
		protected bool IsQtePause;

		// Token: 0x0401BCF8 RID: 113912
		protected bool HasBindAction;

		// Token: 0x0401BCF9 RID: 113913
		protected string QteAction = "";

		// Token: 0x0401BCFA RID: 113914
		protected int QteHandle = -1;

		// Token: 0x0401BCFB RID: 113915
		[Nullable(2)]
		protected TContextType CommonQteContext;

		// Token: 0x0401BCFC RID: 113916
		protected float LoopDuration;

		// Token: 0x0401BCFD RID: 113917
		protected bool IsShowBorder;

		// Token: 0x0401BCFE RID: 113918
		protected bool IsBindEvents;
	}
}
