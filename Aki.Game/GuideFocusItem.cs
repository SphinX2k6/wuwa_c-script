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

// Token: 0x02001DC6 RID: 7622
[NullableContext(2)]
[Nullable(0)]
public class GuideFocusItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600E7B6 RID: 59318 RVA: 0x0036A157 File Offset: 0x00368357
	static GuideFocusItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideFocusItem.CreateStaticDefaultValue), new Action(GuideFocusItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600E7B7 RID: 59319 RVA: 0x0036A176 File Offset: 0x00368376
	public static void CreateStaticDefaultValue()
	{
		GuideFocusItem.IsOpenLog = false;
	}

	// Token: 0x0600E7B8 RID: 59320 RVA: 0x0036A17E File Offset: 0x0036837E
	public static void ResetStaticDefaultValue()
	{
		GuideFocusItem.IsOpenLog = false;
	}

	// Token: 0x0600E7B9 RID: 59321 RVA: 0x0036A188 File Offset: 0x00368388
	[NullableContext(1)]
	public GuideFocusItem(UUIItem attachedItem, UUIItem attachedItemForShow, GuideFocusView owner)
	{
		this.Owner = owner;
		this.Config = new GuideFocusNew?((GuideFocusNew)this.Owner.GetGuideStepInfo().ViewData.ViewConf);
		this.AttachedItem = attachedItem;
		this.AttachedItemForShow = attachedItemForShow;
	}

	// Token: 0x0600E7BA RID: 59322 RVA: 0x0036A219 File Offset: 0x00368419
	[NullableContext(1)]
	public void Init(UUIItem item)
	{
		if (item != null)
		{
			base.CreateThenShowByActorAsync(item.GetOwner(), null, false);
		}
	}

	// Token: 0x0600E7BB RID: 59323 RVA: 0x0036A230 File Offset: 0x00368430
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

	// Token: 0x0600E7BC RID: 59324 RVA: 0x0036A33C File Offset: 0x0036853C
	protected override UniTask OnBeforeStartAsync()
	{
		GuideFocusItem.<OnBeforeStartAsync>d__29 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuideFocusItem.<OnBeforeStartAsync>d__29>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E7BD RID: 59325 RVA: 0x0036A380 File Offset: 0x00368580
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

	// Token: 0x0600E7BE RID: 59326 RVA: 0x0036A6D0 File Offset: 0x003688D0
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

	// Token: 0x0600E7BF RID: 59327 RVA: 0x0036A7B0 File Offset: 0x003689B0
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

	// Token: 0x0600E7C0 RID: 59328 RVA: 0x0036A83F File Offset: 0x00368A3F
	protected override void OnAfterShow()
	{
		this.Owner.ReadyToShow = true;
	}

	// Token: 0x0600E7C1 RID: 59329 RVA: 0x0036A850 File Offset: 0x00368A50
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

	// Token: 0x0600E7C2 RID: 59330 RVA: 0x0036A8E0 File Offset: 0x00368AE0
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

	// Token: 0x0600E7C3 RID: 59331 RVA: 0x0036ABB4 File Offset: 0x00368DB4
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

	// Token: 0x0600E7C4 RID: 59332 RVA: 0x0036ACBC File Offset: 0x00368EBC
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

	// Token: 0x0600E7C5 RID: 59333 RVA: 0x0036AE10 File Offset: 0x00369010
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

	// Token: 0x0600E7C6 RID: 59334 RVA: 0x0036AF54 File Offset: 0x00369154
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

	// Token: 0x0600E7C7 RID: 59335 RVA: 0x0036B088 File Offset: 0x00369288
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

	// Token: 0x0600E7C8 RID: 59336 RVA: 0x0036B13C File Offset: 0x0036933C
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

	// Token: 0x0600E7C9 RID: 59337 RVA: 0x0036B1F4 File Offset: 0x003693F4
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

	// Token: 0x0600E7CA RID: 59338 RVA: 0x0036B2AC File Offset: 0x003694AC
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

	// Token: 0x0600E7CB RID: 59339 RVA: 0x0036B35C File Offset: 0x0036955C
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

	// Token: 0x0600E7CC RID: 59340 RVA: 0x0036B42D File Offset: 0x0036962D
	public void OnBaseViewCloseWhenFinish()
	{
		this.TextPart.OnBaseViewCloseWhenFinish();
	}

	// Token: 0x0600E7CD RID: 59341 RVA: 0x0036B43C File Offset: 0x0036963C
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

	// Token: 0x0600E7CE RID: 59342 RVA: 0x0036B584 File Offset: 0x00369784
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

	// Token: 0x0600E7CF RID: 59343 RVA: 0x0036B60C File Offset: 0x0036980C
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

	// Token: 0x0600E7D0 RID: 59344 RVA: 0x0036B678 File Offset: 0x00369878
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

	// Token: 0x0600E7D1 RID: 59345 RVA: 0x0036B740 File Offset: 0x00369940
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

	// Token: 0x0600E7D2 RID: 59346 RVA: 0x0036B75C File Offset: 0x0036995C
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

	// Token: 0x0600E7D3 RID: 59347 RVA: 0x0036BA6C File Offset: 0x00369C6C
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

	// Token: 0x0600E7D4 RID: 59348 RVA: 0x0036BAF4 File Offset: 0x00369CF4
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

	// Token: 0x04006B2D RID: 27437
	private const int CANVAS_CLIP_FEATHER = 10;

	// Token: 0x04006B2E RID: 27438
	private const float GUIDE_CURSOR_FOLLOW_THRESHOLD = 0.5f;

	// Token: 0x04006B2F RID: 27439
	public static bool IsOpenLog;

	// Token: 0x04006B30 RID: 27440
	private FocusItemText TextPart;

	// Token: 0x04006B31 RID: 27441
	public readonly GuideFocusView Owner;

	// Token: 0x04006B32 RID: 27442
	private readonly UUIItem AttachedItem;

	// Token: 0x04006B33 RID: 27443
	private readonly UUIItem AttachedItemForShow;

	// Token: 0x04006B34 RID: 27444
	private UUIItem MaskItem;

	// Token: 0x04006B35 RID: 27445
	public UUIItem RectItem;

	// Token: 0x04006B36 RID: 27446
	public readonly GuideFocusNew? Config;

	// Token: 0x04006B37 RID: 27447
	private bool IsFinishing;

	// Token: 0x04006B38 RID: 27448
	private bool IsDragging;

	// Token: 0x04006B39 RID: 27449
	private bool IsButtonDown;

	// Token: 0x04006B3A RID: 27450
	private UUIDraggableComponent ParentDraggableComponent;

	// Token: 0x04006B3B RID: 27451
	private UUISelectableComponent ParentSelectable;

	// Token: 0x04006B3C RID: 27452
	private ULGUIPointerEventData DragEventData;

	// Token: 0x04006B3D RID: 27453
	private FVector2D MultiAttachPivot = new FVector2D(0f, 0f);

	// Token: 0x04006B3E RID: 27454
	private FVector MultiAttachPos = new FVector(0f, 0f, 0f);

	// Token: 0x04006B3F RID: 27455
	private bool HasExecutedClick;

	// Token: 0x04006B40 RID: 27456
	private UUIItem GuideCursorFollowItem;

	// Token: 0x04006B41 RID: 27457
	private FVector2D LastGuideCursorViewportPos = new FVector2D(0f, 0f);

	// Token: 0x04006B42 RID: 27458
	private bool HasLastGuideCursorViewportPos;

	// Token: 0x02008398 RID: 33688
	[NullableContext(0)]
	private enum EFocusItem
	{
		// Token: 0x0402ADE1 RID: 175585
		ClickArea,
		// Token: 0x0402ADE2 RID: 175586
		RectBg,
		// Token: 0x0402ADE3 RID: 175587
		RectView,
		// Token: 0x0402ADE4 RID: 175588
		TextPart,
		// Token: 0x0402ADE5 RID: 175589
		PanelClickAnyWhere = 3
	}
}
