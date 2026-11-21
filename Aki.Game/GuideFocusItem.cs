using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001288 RID: 4744
[NullableContext(2)]
[Nullable(0)]
public class GuideFocusItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600BBD5 RID: 48085 RVA: 0x00375DEB File Offset: 0x00373FEB
	static GuideFocusItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideFocusItem.CreateStaticDefaultValue), new Action(GuideFocusItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x00375E0A File Offset: 0x0037400A
	public static void CreateStaticDefaultValue()
	{
		GuideFocusItem.IsOpenLog = false;
	}

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x00375E12 File Offset: 0x00374012
	public static void ResetStaticDefaultValue()
	{
		GuideFocusItem.IsOpenLog = false;
	}

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x00375E1C File Offset: 0x0037401C
	[NullableContext(1)]
	public GuideFocusItem(UUIItem attachedItem, UUIItem attachedItemForShow, GuideFocusView owner)
	{
		this.Owner = owner;
		this.Config = new GuideFocusNew?((GuideFocusNew)this.Owner.GetGuideStepInfo().ViewData.ViewConf);
		this.AttachedItem = attachedItem;
		this.AttachedItemForShow = attachedItemForShow;
	}

	// Token: 0x0600BBD9 RID: 48089 RVA: 0x00375EAD File Offset: 0x003740AD
	[NullableContext(1)]
	public void Init(UUIItem item)
	{
		if (item != null)
		{
			base.CreateThenShowByActorAsync(item.GetOwner(), null, false);
		}
	}

	// Token: 0x0600BBDA RID: 48090 RVA: 0x00375EC4 File Offset: 0x003740C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x00375FD0 File Offset: 0x003741D0
	protected override UniTask OnBeforeStartAsync()
	{
		GuideFocusItem.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuideFocusItem.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BBDC RID: 48092 RVA: 0x00376014 File Offset: 0x00374214
	protected override void OnStart()
	{
		ULGUICanvas ulguicanvas = LguiUtil.Instance.GetChildActorByHierarchyIndex(base.GetOriginalActor() as AUIBaseActor, 0).GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas;
		if (this.Config.Value.OnlyFrame)
		{
			base.GetItem(3).SetUIActive(false);
		}
		else
		{
			base.GetItem(3).SetUIActive(true);
			this.TextPart.ShowText();
		}
		if (this.Config.Value.OnlyText)
		{
			base.GetItem(2).SetUIActive(false);
			ulguicanvas.clipFeatherNew = new FMargin(0f, 0f, 0f, 0f);
		}
		else
		{
			base.GetItem(2).SetUIActive(true);
			ulguicanvas.clipFeatherNew = new FMargin(10f, 10f, 10f, 10f);
		}
		this.MaskItem = base.GetItem(1);
		this.RectItem = base.GetItem(2);
		base.GetItem(1).SetUIActive(this.Config.Value.UseMask);
		this.ParentSelectable = (this.AttachedItem.GetOwner().GetComponentByClass(UUISelectableComponent.StaticClass()) as UUISelectableComponent);
		UUIButtonComponent button = base.GetButton(0);
		button.OnPointDownCallBack.Bind(new Action(this.OnButtonPointerDownCallBack));
		button.OnPointUpCallBack.Bind(new Action(this.OnButtonPointerUpCallBack));
		if (this.Config.Value.EnableHover)
		{
			button.OnPointEnterCallBack.Bind(new Action(this.OnButtonHover));
			button.OnPointExitCallBack.Bind(new Action(this.OnButtonUnHover));
		}
		UUIItem panelClickAnyWhere = base.GetItem(3);
		panelClickAnyWhere.SetUIActive(false);
		if (this.Config.Value.ClickAnywhere)
		{
			int clickAnywhereShowTime = this.Config.Value.ClickAnywhereShowTime;
			if (clickAnywhereShowTime > 0)
			{
				button.RootUIComp.Get().SetRaycastTarget(false);
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					panelClickAnyWhere.SetUIActive(true);
					button.RootUIComp.Get().SetRaycastTarget(true);
				}, (float)clickAnywhereShowTime, null, null, true, 1f);
			}
		}
		this.ParentDraggableComponent = (this.AttachedItem.GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
		UUIDraggableComponent uuidraggableComponent = button.RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
		uuidraggableComponent.OnPointerDownCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnDraggablePointerDownCallBack(eventData);
		});
		uuidraggableComponent.OnPointerBeginDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnDraggablePointerBeginDragCallBack(eventData);
		});
		uuidraggableComponent.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnDraggablePointerDragCallBack(eventData);
		});
		uuidraggableComponent.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnDraggablePointerEndDragCallBack(eventData);
		});
		uuidraggableComponent.OnPointerUpCallBack.Bind(delegate(ULGUIPointerEventData eventData)
		{
			this.OnDraggablePointerUpCallBack(eventData);
		});
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x00376364 File Offset: 0x00374564
	protected override void OnBeforeShow()
	{
		GuideFocusView owner = this.Owner;
		if (owner != null && ((owner.Config != null) ? new bool?(owner.Config.GetValueOrDefault().UseMask) : null).GetValueOrDefault())
		{
			if (GuideController.Instance.CheckHasNewTagInHookNameForShow(this.Owner.Config.Value))
			{
				this.GuideCursorFollowItem = this.AttachedItemForShow;
				UiNavigationNewController.Instance.SetNavigationFocusForGuide(this.AttachedItemForShow);
			}
			else
			{
				this.GuideCursorFollowItem = this.AttachedItem;
				UiNavigationNewController.Instance.SetNavigationFocusForGuide(this.AttachedItem);
			}
			UiNavigationGlobalData.AddBlockListenerFocusTag("GuideFocus");
			return;
		}
		if (ObjectUtils.IsValid(this.ParentSelectable))
		{
			UUISelectableComponent parentSelectable = this.ParentSelectable;
			if (parentSelectable == null)
			{
				return;
			}
			parentSelectable.FocusListenerDelegate.Bind(new Action(this.TryFinishByClick));
		}
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x00376444 File Offset: 0x00374644
	protected override void OnAfterHide()
	{
		this.GuideCursorFollowItem = null;
		this.HasLastGuideCursorViewportPos = false;
		GuideFocusView owner = this.Owner;
		if (owner != null && ((owner.Config != null) ? new bool?(owner.Config.GetValueOrDefault().UseMask) : null).GetValueOrDefault())
		{
			UiNavigationGlobalData.DeleteBlockListenerFocusTag("GuideFocus");
			UiNavigationNewController.Instance.ResetNavigationFocusForGuide();
			return;
		}
		if (ObjectUtils.IsValid(this.ParentSelectable))
		{
			this.ParentSelectable.FocusListenerDelegate.Unbind();
		}
	}

	// Token: 0x0600BBDF RID: 48095 RVA: 0x003764D3 File Offset: 0x003746D3
	protected override void OnAfterShow()
	{
		this.Owner.ReadyToShow = true;
	}

	// Token: 0x0600BBE0 RID: 48096 RVA: 0x003764E4 File Offset: 0x003746E4
	private void TryFinishByClick()
	{
		if (!this.Config.Value.UseClick)
		{
			return;
		}
		if (this.IsFinishing)
		{
			return;
		}
		this.IsFinishing = true;
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "TryFinishByClick done", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.Owner.DoCloseByFinished();
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "DoCloseByFinished", default(ReadOnlySpan<ValueTuple<string, object>>));
		}, null, null);
	}

	// Token: 0x0600BBE1 RID: 48097 RVA: 0x00376574 File Offset: 0x00374774
	private void OnButtonClick()
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUISelectableComponent parentSelectable = this.ParentSelectable;
		this.TryFinishByClick();
		if (this.HasExecutedClick)
		{
			return;
		}
		this.HasExecutedClick = true;
		if (parentSelectable == null || !parentSelectable.IsValid())
		{
			return;
		}
		if (parentSelectable == null || !parentSelectable.IsInteractable() || !this.AttachedItem.bIsUIActive)
		{
			return;
		}
		UUIExtendButtonComponent uuiextendButtonComponent = parentSelectable as UUIExtendButtonComponent;
		if (uuiextendButtonComponent != null && !uuiextendButtonComponent.OnClickCallBack.IsBound() && uuiextendButtonComponent.HelpGroupId > 0)
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonClick execute parent SetDelegateForHelpClick UIExtendButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			HelpController.Instance.OpenHelpById(uuiextendButtonComponent.HelpGroupId);
			return;
		}
		UUIButtonComponent uuibuttonComponent = parentSelectable as UUIButtonComponent;
		if (uuibuttonComponent != null)
		{
			if (uuibuttonComponent.OnClickCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick execute parent OnClickCallBack UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuibuttonComponent.OnClickCallBack.Execute();
				return;
			}
		}
		else
		{
			UUISelectableButtonComponent uuiselectableButtonComponent = parentSelectable as UUISelectableButtonComponent;
			if (uuiselectableButtonComponent != null)
			{
				if (uuiselectableButtonComponent.OnClickCallBack.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick execute parent OnClickCallBack UISelectableButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					uuiselectableButtonComponent.OnClickCallBack.Execute();
					return;
				}
			}
			else
			{
				UUIToggleComponent uuitoggleComponent = parentSelectable as UUIToggleComponent;
				if (uuitoggleComponent != null)
				{
					uuitoggleComponent.SetState(!uuitoggleComponent.IsOn, true);
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick execute parent SetState UIToggleComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
				}
				else
				{
					UUIExtendToggle uuiextendToggle = parentSelectable as UUIExtendToggle;
					if (uuiextendToggle != null)
					{
						if (GuideFocusItem.IsOpenLog)
						{
							Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick execute parent SetToggleState ETT_Checked UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						if (this.Config.Value.EnableAllToggleState)
						{
							if (uuiextendToggle.GetToggleState() == EToggleState.ETT_UnChecked)
							{
								uuiextendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
							}
							else if (uuiextendToggle.GetToggleState() == EToggleState.ETT_Checked)
							{
								uuiextendToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
							}
						}
						else if (uuiextendToggle.GetToggleState() == EToggleState.ETT_UnChecked)
						{
							uuiextendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
						}
						if (uuiextendToggle.GetToggleState() == EToggleState.ETT_UnDetermined && uuiextendToggle.OnUndeterminedClicked != null && GuideFocusItem.IsOpenLog)
						{
							Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TZJ, "OnButtonClick execute parent OnUndeterminedClicked UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
							uuiextendToggle.OnUndeterminedClicked.Broadcast();
							return;
						}
					}
					else
					{
						UUISliderComponent uuisliderComponent = parentSelectable as UUISliderComponent;
						if (uuisliderComponent != null && uuisliderComponent.OnValueChangeCb.IsBound())
						{
							if (GuideFocusItem.IsOpenLog)
							{
								Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonClick execute parent OnValueChangeCb UISliderComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
							}
							uuisliderComponent.OnValueChangeCb.Execute(uuisliderComponent.Value);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BBE2 RID: 48098 RVA: 0x00376848 File Offset: 0x00374A48
	private void OnButtonPointerDownCallBack()
	{
		if (this.IsFinishing)
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerDownCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUISelectableComponent parentSelectable = this.ParentSelectable;
		if (parentSelectable == null || !parentSelectable.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerDownCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.IsButtonDown = true;
		UUIButtonComponent uuibuttonComponent = parentSelectable as UUIButtonComponent;
		if (uuibuttonComponent != null)
		{
			if (uuibuttonComponent.OnPointDownCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerDownCallBack execute parent UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuibuttonComponent.OnPointDownCallBack.Execute();
				return;
			}
		}
		else
		{
			UUIExtendToggle uuiextendToggle = parentSelectable as UUIExtendToggle;
			if (uuiextendToggle != null && uuiextendToggle.OnPointDownCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerDownCallBack execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuiextendToggle.OnPointDownCallBack.Execute(EToggleState.ETT_Checked);
			}
		}
	}

	// Token: 0x0600BBE3 RID: 48099 RVA: 0x00376950 File Offset: 0x00374B50
	private void OnButtonPointerUpCallBack()
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerUpCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUISelectableComponent parentSelectable = this.ParentSelectable;
		if (parentSelectable == null || !parentSelectable.IsValid())
		{
			return;
		}
		this.IsButtonDown = false;
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerUpCallBack execute self TryFinishByClick", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIButtonComponent uuibuttonComponent = parentSelectable as UUIButtonComponent;
		if (uuibuttonComponent != null)
		{
			if (uuibuttonComponent.OnPointUpCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerUpCallBack execute parent UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				this.TryFinishByClick();
				uuibuttonComponent.OnPointUpCallBack.Execute();
				return;
			}
		}
		else
		{
			UUIExtendToggle uuiextendToggle = parentSelectable as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				if (uuiextendToggle.OnPointUpCallBack.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerUpCallBack execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					this.TryFinishByClick();
					uuiextendToggle.OnPointUpCallBack.Execute(EToggleState.ETT_Checked);
				}
				if (uuiextendToggle.OnPointUpCallBackWithEventData.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnButtonPointerUpCallBack execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					this.TryFinishByClick();
					uuiextendToggle.OnPointUpCallBackWithEventData.Execute(EToggleState.ETT_Checked, null);
				}
			}
		}
	}

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x00376AA4 File Offset: 0x00374CA4
	private void OnButtonHover()
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonHover enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUISelectableComponent parentSelectable = this.ParentSelectable;
		if (parentSelectable == null || !parentSelectable.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonHover execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIButtonComponent uuibuttonComponent = parentSelectable as UUIButtonComponent;
		if (uuibuttonComponent != null)
		{
			if (uuibuttonComponent.OnPointEnterCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonHover execute parent UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuibuttonComponent.OnPointEnterCallBack.Execute();
				return;
			}
		}
		else
		{
			UUIExtendToggle uuiextendToggle = parentSelectable as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				if (uuiextendToggle.OnHover.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonHover execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					uuiextendToggle.OnHover.Broadcast();
				}
				if (uuiextendToggle.OnPointEnterCallBack.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonHover execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					EToggleState toggleState = uuiextendToggle.GetToggleState();
					uuiextendToggle.OnPointEnterCallBack.Execute(toggleState);
				}
			}
		}
	}

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x00376BE8 File Offset: 0x00374DE8
	private void OnButtonUnHover()
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonUnHover enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUISelectableComponent parentSelectable = this.ParentSelectable;
		if (parentSelectable == null || !parentSelectable.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonUnHover execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIButtonComponent uuibuttonComponent = parentSelectable as UUIButtonComponent;
		if (uuibuttonComponent != null)
		{
			if (uuibuttonComponent.OnPointExitCallBack.IsBound())
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonUnHover execute parent UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuibuttonComponent.OnPointExitCallBack.Execute();
				return;
			}
		}
		else
		{
			UUIExtendToggle uuiextendToggle = parentSelectable as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				if (GuideFocusItem.IsOpenLog)
				{
					Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonUnHover execute parent UIExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				uuiextendToggle.OnUnHover.Broadcast();
				if (uuiextendToggle.OnPointExitCallBack.IsBound())
				{
					if (GuideFocusItem.IsOpenLog)
					{
						Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "OnButtonUnHover execute parent UIButtonComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					EToggleState toggleState = uuiextendToggle.GetToggleState();
					uuiextendToggle.OnPointExitCallBack.Execute(toggleState);
				}
			}
		}
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x00376D1C File Offset: 0x00374F1C
	[NullableContext(1)]
	private void OnDraggablePointerDownCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsFinishing)
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDownCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIDraggableComponent parentDraggableComponent = this.ParentDraggableComponent;
		if (parentDraggableComponent == null || !parentDraggableComponent.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDownCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (parentDraggableComponent.OnPointerDownCallBack.IsBound())
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDownCallBack execute parent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			parentDraggableComponent.OnPointerDownCallBack.Execute(eventData);
		}
	}

	// Token: 0x0600BBE7 RID: 48103 RVA: 0x00376DD0 File Offset: 0x00374FD0
	[NullableContext(1)]
	private void OnDraggablePointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsFinishing)
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerBeginDragCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIDraggableComponent parentDraggableComponent = this.ParentDraggableComponent;
		if (parentDraggableComponent == null || !parentDraggableComponent.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerBeginDragCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.IsDragging = true;
		if (parentDraggableComponent.OnPointerBeginDragCallBack.IsBound())
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerBeginDragCallBack execute parent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			parentDraggableComponent.OnPointerBeginDragCallBack.Execute(eventData);
		}
	}

	// Token: 0x0600BBE8 RID: 48104 RVA: 0x00376E88 File Offset: 0x00375088
	[NullableContext(1)]
	private void OnDraggablePointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsFinishing)
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDragCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIDraggableComponent parentDraggableComponent = this.ParentDraggableComponent;
		if (parentDraggableComponent == null || !parentDraggableComponent.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDragCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.DragEventData = eventData;
		if (parentDraggableComponent.OnPointerDragCallBack.IsBound())
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerDragCallBack execute parent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			parentDraggableComponent.OnPointerDragCallBack.Execute(eventData);
		}
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x00376F40 File Offset: 0x00375140
	[NullableContext(1)]
	private void OnDraggablePointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerEndDragCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIDraggableComponent parentDraggableComponent = this.ParentDraggableComponent;
		if (parentDraggableComponent == null || !parentDraggableComponent.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerEndDragCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.IsDragging = false;
		if (parentDraggableComponent.OnPointerEndDragCallBack.IsBound())
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerEndDragCallBack execute parent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			parentDraggableComponent.OnPointerEndDragCallBack.Execute(eventData);
		}
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x00376FF0 File Offset: 0x003751F0
	[NullableContext(1)]
	private void OnDraggablePointerUpCallBack(ULGUIPointerEventData eventData)
	{
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerUpCallBack enter", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		UUIDraggableComponent parentDraggableComponent = this.ParentDraggableComponent;
		if (parentDraggableComponent == null || !parentDraggableComponent.IsValid())
		{
			return;
		}
		if (GuideFocusItem.IsOpenLog)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerUpCallBack execute self", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (parentDraggableComponent.OnPointerUpCallBack.IsBound())
		{
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerUpCallBack execute parent", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			parentDraggableComponent.OnPointerUpCallBack.Execute(eventData);
			if (GuideFocusItem.IsOpenLog)
			{
				Log.Instance.Warn(ELogModule.Guide, ELogAuthor.TL, "OnDraggablePointerUpCallBack execute TryFinishByClick", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.TryFinishByClick();
		}
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x003770C1 File Offset: 0x003752C1
	public void OnBaseViewCloseWhenFinish()
	{
		this.TextPart.OnBaseViewCloseWhenFinish();
	}

	// Token: 0x0600BBEC RID: 48108 RVA: 0x003770D0 File Offset: 0x003752D0
	protected override void OnBeforeDestroy()
	{
		this.IsFinishing = true;
		if (this.IsDragging)
		{
			this.OnDraggablePointerEndDragCallBack(this.DragEventData);
			this.OnDraggablePointerUpCallBack(this.DragEventData);
			this.IsDragging = false;
			this.DragEventData = null;
		}
		if (this.IsButtonDown)
		{
			this.OnButtonPointerUpCallBack();
			this.IsButtonDown = false;
		}
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			if (this.Config != null && this.Config.GetValueOrDefault().EnableHover)
			{
				button.OnPointEnterCallBack.Unbind();
				button.OnPointExitCallBack.Unbind();
			}
			AActor owner = button.RootUIComp.Get().GetOwner();
			UUIDraggableComponent uuidraggableComponent = ((owner != null) ? owner.GetComponentByClass(UUIDraggableComponent.StaticClass()) : null) as UUIDraggableComponent;
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerDownCallBack.Unbind();
				uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
				uuidraggableComponent.OnPointerDragCallBack.Unbind();
				uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
				uuidraggableComponent.OnPointerUpCallBack.Unbind();
			}
		}
		InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0600BBED RID: 48109 RVA: 0x00377218 File Offset: 0x00375418
	[NullableContext(1)]
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		int num = int.Parse(touchIdName);
		UUIButtonComponent button = base.GetButton(0);
		if (!ObjectUtils.IsValid(button) || !ObjectUtils.IsValid(this.AttachedItem))
		{
			return;
		}
		TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)num);
		USceneComponent usceneComponent;
		if (touchFingerData == null)
		{
			usceneComponent = null;
		}
		else
		{
			ULGUIPointerEventData pointerEventData = touchFingerData.GetPointerEventData();
			usceneComponent = ((pointerEventData != null) ? pointerEventData.pressComponent : null);
		}
		USceneComponent usceneComponent2 = usceneComponent;
		if (usceneComponent2 == null)
		{
			return;
		}
		if (usceneComponent2.GetOwner() != button.GetOwner())
		{
			return;
		}
		EventSystem.Instance.Emit<int, AActor>(EEventName.GuideTouchIdInject, num, this.AttachedItem.GetOwner());
	}

	// Token: 0x0600BBEE RID: 48110 RVA: 0x003772A0 File Offset: 0x003754A0
	public void OnTick(float delta)
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem == null || !rootItem.IsValid())
		{
			return;
		}
		UUIItem attachedItem = this.AttachedItem;
		if (attachedItem == null || !attachedItem.IsValid())
		{
			return;
		}
		this.ApplyButtonFollow();
		this.ApplyBgFollow();
		this.ApplyGuideCursorFollow();
		FocusItemText textPart = this.TextPart;
		if (textPart == null)
		{
			return;
		}
		textPart.OnTick(delta);
	}

	// Token: 0x0600BBEF RID: 48111 RVA: 0x0037730C File Offset: 0x0037550C
	private void ApplyGuideCursorFollow()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		UUIItem guideCursorFollowItem = this.GuideCursorFollowItem;
		if (guideCursorFollowItem == null || !guideCursorFollowItem.IsValid())
		{
			return;
		}
		UUIItem uuiitem = guideCursorFollowItem;
		bool bIsScaledByDPI = true;
		FVector2D fvector2D = new FVector2D(0.5f, 0.5f);
		FVector2D positionInViewportWithPivot = uuiitem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D);
		if (this.HasLastGuideCursorViewportPos)
		{
			float num = Math.Abs(positionInViewportWithPivot.X - this.LastGuideCursorViewportPos.X);
			float num2 = Math.Abs(positionInViewportWithPivot.Y - this.LastGuideCursorViewportPos.Y);
			if (num < 0.5f && num2 < 0.5f)
			{
				return;
			}
		}
		this.LastGuideCursorViewportPos.X = positionInViewportWithPivot.X;
		this.LastGuideCursorViewportPos.Y = positionInViewportWithPivot.Y;
		this.HasLastGuideCursorViewportPos = true;
		UiNavigationNewController.Instance.RefreshNavigationMousePositionForGuide(guideCursorFollowItem);
	}

	// Token: 0x0600BBF0 RID: 48112 RVA: 0x003773D4 File Offset: 0x003755D4
	public void OnDurationChange(float remainDuration)
	{
		if (!base.GetActive())
		{
			return;
		}
		FocusItemText textPart = this.TextPart;
		if (textPart == null)
		{
			return;
		}
		textPart.OnDurationChange(remainDuration);
	}

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x003773F0 File Offset: 0x003755F0
	public void ApplyButtonFollow()
	{
		UUIItem attachedItemForShow = this.AttachedItemForShow;
		FVectorDouble fvectorDouble = attachedItemForShow.D_K2_GetComponentScale();
		if (this.Owner.GetGuideStepInfo().ViewData.IsMultiAttach)
		{
			List<UUIItem> multiAttachItems = this.Owner.GetGuideStepInfo().ViewData.GetMultiAttachItems();
			float[] array = new float[]
			{
				10000f,
				10000f
			};
			float[] array2 = new float[2];
			foreach (UUIItem item in (multiAttachItems ?? new List<UUIItem>()))
			{
				ValueTuple<float, float, float, float> attachItemBound = this.GetAttachItemBound(item);
				array[0] = Math.Min(array[0], attachItemBound.Item1);
				array[1] = Math.Min(array[1], attachItemBound.Item2);
				array2[0] = Math.Max(array2[0], attachItemBound.Item3);
				array2[1] = Math.Max(array2[1], attachItemBound.Item4);
			}
			this.RootItem.SetPivot(this.MultiAttachPivot);
			this.MultiAttachPos.Set(array[1], array[0], this.MultiAttachPos.Z);
			this.RootItem.SetLGUISpaceAbsolutePosition(this.MultiAttachPos);
			this.RootItem.SetHeight(array2[0] - array[0]);
			this.RootItem.SetWidth(array2[1] - array[1]);
		}
		else
		{
			FHitResult fhitResult = new FHitResult();
			this.RootItem.D_K2_SetWorldLocation(attachedItemForShow.D_K2_GetComponentLocation(), false, ref fhitResult, false);
			this.RootItem.SetPivot(attachedItemForShow.GetPivot());
			this.RootItem.SetHeight((float)((double)attachedItemForShow.Height * fvectorDouble.Y));
			this.RootItem.SetWidth((float)((double)attachedItemForShow.Width * fvectorDouble.X));
		}
		UUIItem attachedItem = this.AttachedItem;
		UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
		if (this.Config.Value.ClickAnywhere)
		{
			FHitResult fhitResult2 = new FHitResult();
			uuiitem.D_K2_SetWorldLocation(UiLayer.Instance.UiRootItem.D_K2_GetComponentLocation(), false, ref fhitResult2, false);
			uuiitem.SetPivot(UiLayer.Instance.UiRootItem.GetPivot());
			uuiitem.SetHeight(UiLayer.Instance.UiRootItem.Height);
			uuiitem.SetWidth(UiLayer.Instance.UiRootItem.Width);
			return;
		}
		if (this.Config.Value.ExpandClickArea)
		{
			uuiitem.SetPivot(attachedItemForShow.GetPivot());
			uuiitem.SetHeight(attachedItemForShow.Height);
			uuiitem.SetWidth(attachedItemForShow.Width);
			uuiitem.D_SetRelativeScale3D(attachedItemForShow.D_K2_GetComponentScale());
			FHitResult fhitResult3 = new FHitResult();
			uuiitem.D_K2_SetWorldLocation(attachedItemForShow.D_K2_GetComponentLocation(), false, ref fhitResult3, false);
			return;
		}
		uuiitem.SetPivot(attachedItem.GetPivot());
		uuiitem.SetHeight(attachedItem.Height);
		uuiitem.SetWidth(attachedItem.Width);
		uuiitem.D_SetRelativeScale3D(attachedItem.D_K2_GetComponentScale());
		FHitResult fhitResult4 = new FHitResult();
		uuiitem.D_K2_SetWorldLocation(attachedItem.D_K2_GetComponentLocation(), false, ref fhitResult4, false);
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x00377700 File Offset: 0x00375900
	public void ApplyBgFollow()
	{
		if (!this.Config.Value.UseMask)
		{
			return;
		}
		UUIItem maskItem = this.MaskItem;
		FHitResult fhitResult = new FHitResult();
		maskItem.D_K2_SetWorldLocation(UiLayer.Instance.UiRootItem.D_K2_GetComponentLocation(), false, ref fhitResult, false);
		maskItem.SetPivot(UiLayer.Instance.UiRootItem.GetPivot());
		maskItem.SetHeight(UiLayer.Instance.UiRootItem.Height);
		maskItem.SetWidth(UiLayer.Instance.UiRootItem.Width);
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x00377788 File Offset: 0x00375988
	[NullableContext(0)]
	private ValueTuple<float, float, float, float> GetAttachItemBound([Nullable(1)] UUIItem item)
	{
		FVector lguispaceCenterAbsolutePosition = item.GetLGUISpaceCenterAbsolutePosition();
		FVectorDouble fvectorDouble = item.D_K2_GetComponentScale();
		double num = (double)item.Width * fvectorDouble.X;
		double num2 = (double)item.Height * fvectorDouble.Y;
		double num3 = (double)lguispaceCenterAbsolutePosition.Y - num2 / 2.0;
		double num4 = (double)lguispaceCenterAbsolutePosition.Y + num2 / 2.0;
		double num5 = (double)lguispaceCenterAbsolutePosition.X - num / 2.0;
		double num6 = (double)lguispaceCenterAbsolutePosition.X + num / 2.0;
		return new ValueTuple<float, float, float, float>((float)num3, (float)num5, (float)num4, (float)num6);
	}

	// Token: 0x04006C0E RID: 27662
	private const int CANVAS_CLIP_FEATHER = 10;

	// Token: 0x04006C0F RID: 27663
	private const float GUIDE_CURSOR_FOLLOW_THRESHOLD = 0.5f;

	// Token: 0x04006C10 RID: 27664
	public static bool IsOpenLog;

	// Token: 0x04006C11 RID: 27665
	private FocusItemText TextPart;

	// Token: 0x04006C12 RID: 27666
	public readonly GuideFocusView Owner;

	// Token: 0x04006C13 RID: 27667
	private readonly UUIItem AttachedItem;

	// Token: 0x04006C14 RID: 27668
	private readonly UUIItem AttachedItemForShow;

	// Token: 0x04006C15 RID: 27669
	private UUIItem MaskItem;

	// Token: 0x04006C16 RID: 27670
	public UUIItem RectItem;

	// Token: 0x04006C17 RID: 27671
	public readonly GuideFocusNew? Config;

	// Token: 0x04006C18 RID: 27672
	private bool IsFinishing;

	// Token: 0x04006C19 RID: 27673
	private bool IsDragging;

	// Token: 0x04006C1A RID: 27674
	private bool IsButtonDown;

	// Token: 0x04006C1B RID: 27675
	private UUIDraggableComponent ParentDraggableComponent;

	// Token: 0x04006C1C RID: 27676
	private UUISelectableComponent ParentSelectable;

	// Token: 0x04006C1D RID: 27677
	private ULGUIPointerEventData DragEventData;

	// Token: 0x04006C1E RID: 27678
	private FVector2D MultiAttachPivot = new FVector2D(0f, 0f);

	// Token: 0x04006C1F RID: 27679
	private FVector MultiAttachPos = new FVector(0f, 0f, 0f);

	// Token: 0x04006C20 RID: 27680
	private bool HasExecutedClick;

	// Token: 0x04006C21 RID: 27681
	private UUIItem GuideCursorFollowItem;

	// Token: 0x04006C22 RID: 27682
	private FVector2D LastGuideCursorViewportPos = new FVector2D(0f, 0f);

	// Token: 0x04006C23 RID: 27683
	private bool HasLastGuideCursorViewportPos;

	// Token: 0x02007520 RID: 29984
	[NullableContext(0)]
	private enum EFocusItem
	{
		// Token: 0x04026107 RID: 155911
		ClickArea,
		// Token: 0x04026108 RID: 155912
		RectBg,
		// Token: 0x04026109 RID: 155913
		RectView,
		// Token: 0x0402610A RID: 155914
		TextPart,
		// Token: 0x0402610B RID: 155915
		PanelClickAnyWhere = 3
	}
}
