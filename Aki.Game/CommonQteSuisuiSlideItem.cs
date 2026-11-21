using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B09 RID: 6921
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSuisuiSlideItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06011407 RID: 70663 RVA: 0x0051307C File Offset: 0x0051127C
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06011408 RID: 70664 RVA: 0x00513114 File Offset: 0x00511314
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSuisuiSlideItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSuisuiSlideItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011409 RID: 70665 RVA: 0x00513158 File Offset: 0x00511358
	protected override void OnStart()
	{
		base.OnStart();
		base.SetUiActive(false);
		UUIItem item = base.GetItem(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(item);
		base.SetAttachRootItem(item);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		UUIDraggableComponent draggable = base.GetDraggable(1);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDownCallBack));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUpCallBack));
	}

	// Token: 0x0601140A RID: 70666 RVA: 0x0051321E File Offset: 0x0051141E
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x0601140B RID: 70667 RVA: 0x00513229 File Offset: 0x00511429
	[NullableContext(1)]
	protected override void OnRefreshActionUi(string action)
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = action
			}, false);
		}
		InputMultiKeyItem keyItem2 = this.KeyItem;
		if (keyItem2 == null)
		{
			return;
		}
		keyItem2.Show(null);
	}

	// Token: 0x0601140C RID: 70668 RVA: 0x0051325C File Offset: 0x0051145C
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag == null)
		{
			return;
		}
		this.LeftSlideLength = Math.Max(0f, scommonQte_Drag.LeftSlideLength);
		this.RightSlideLength = Math.Max(0f, scommonQte_Drag.RightSlideLength);
		this.LerpSpeed = scommonQte_Drag.LerpSpeed / 1000f;
		this.RewardSpeed = ((scommonQte_Drag.RewardSpeed > 0f) ? (scommonQte_Drag.RewardSpeed / 1000f) : this.LerpSpeed);
		this.CheckByRealTimeInput = scommonQte_Drag.CheckByRealTimeInput;
		this.BackwardWhenFail = scommonQte_Drag.BackwardWhenFail;
		this.IsBackingToCenter = false;
	}

	// Token: 0x0601140D RID: 70669 RVA: 0x00513300 File Offset: 0x00511500
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			if (this.IsQteEnd)
			{
				return;
			}
			this.IsQteStart = true;
			this.IsQteInteractive = true;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
			if (!this.IsMobile)
			{
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.Show(null);
				return;
			}
		}
		else if (sequenceName == "Close")
		{
			base.Destroy(null);
		}
	}

	// Token: 0x0601140E RID: 70670 RVA: 0x00513380 File Offset: 0x00511580
	protected override void OnPlayQteStart()
	{
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (this.IsQteInteractive && !this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}
	}

	// Token: 0x0601140F RID: 70671 RVA: 0x005133D8 File Offset: 0x005115D8
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext == null)
		{
			return;
		}
		SCommonQte_Drag scommonQte_Drag = this.CommonQteContext.GetUiConfig() as SCommonQte_Drag;
		if (scommonQte_Drag == null)
		{
			return;
		}
		SCommonQteButton uiconfig = scommonQte_Drag.UIConfig;
		this.RootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
		this.RootItem.SetAnchorOffset(uiconfig.AnchorOffset);
		if (this.IsAttaching)
		{
			this.Reattach(this.CommonQteContext);
		}
	}

	// Token: 0x06011410 RID: 70672 RVA: 0x0051344C File Offset: 0x0051164C
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06011411 RID: 70673 RVA: 0x0051344F File Offset: 0x0051164F
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06011412 RID: 70674 RVA: 0x00513488 File Offset: 0x00511688
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06011413 RID: 70675 RVA: 0x005134C4 File Offset: 0x005116C4
	protected override void OnHandleQteEnd()
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.Hide(null);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06011414 RID: 70676 RVA: 0x00513516 File Offset: 0x00511716
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (!Info.Instance.IsInGamepad())
		{
			this.InputX = 0f;
			this.HasInputTurn = false;
		}
		this.DerivedOffset = 0f;
		this.SetIsDragging(false);
	}

	// Token: 0x06011415 RID: 70677 RVA: 0x00513548 File Offset: 0x00511748
	[NullableContext(1)]
	private void OnInputTurn(string name, float value, InputIdentification inputIdentification)
	{
		if (!this.IsValidSlideInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.InputX = value;
		this.HasInputTurn = (value != 0f);
		this.SetIsDragging(this.HasInputTurn);
	}

	// Token: 0x06011416 RID: 70678 RVA: 0x00513583 File Offset: 0x00511783
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsBackingToCenter)
		{
			return;
		}
		this.DerivedOffset = this.CacheOffset;
	}

	// Token: 0x06011417 RID: 70679 RVA: 0x0051359A File Offset: 0x0051179A
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsBackingToCenter)
		{
			return;
		}
		this.DerivedOffset = 0f;
	}

	// Token: 0x06011418 RID: 70680 RVA: 0x005135B0 File Offset: 0x005117B0
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.IsValidSlideInput())
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x06011419 RID: 70681 RVA: 0x005135D4 File Offset: 0x005117D4
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.IsValidSlideInput())
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.StartDragPosition = null;
			return;
		}
		if (this.StartDragPosition == null)
		{
			return;
		}
		FVector localPointInPlane = eventData.GetLocalPointInPlane();
		this.InputX = localPointInPlane.X - this.StartDragPosition.Value.X;
	}

	// Token: 0x0601141A RID: 70682 RVA: 0x00513636 File Offset: 0x00511836
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.IsValidSlideInput())
		{
			return;
		}
		this.DerivedOffset = 0f;
		this.StartDragPosition = null;
		this.InputX = 0f;
		this.SetIsDragging(false);
	}

	// Token: 0x0601141B RID: 70683 RVA: 0x0051366A File Offset: 0x0051186A
	private void SetIsDragging(bool isDragging)
	{
		if (isDragging == this.IsDragging)
		{
			return;
		}
		this.IsDragging = isDragging;
		if (isDragging)
		{
			CommonQteDragContext commonQteContext = this.CommonQteContext;
			if (commonQteContext == null)
			{
				return;
			}
			commonQteContext.Response();
			return;
		}
		else
		{
			CommonQteDragContext commonQteContext2 = this.CommonQteContext;
			if (commonQteContext2 == null)
			{
				return;
			}
			commonQteContext2.ResponseEnd();
			return;
		}
	}

	// Token: 0x0601141C RID: 70684 RVA: 0x005136A1 File Offset: 0x005118A1
	private bool IsValidSlideInput()
	{
		return !this.IsBackingToCenter && base.IsValidInput() && this.HasBindAction;
	}

	// Token: 0x0601141D RID: 70685 RVA: 0x005136BC File Offset: 0x005118BC
	protected override void OnTickQteItem(float delta)
	{
		if (this.IsBackingToCenter)
		{
			this.UpdateBackingToCenter(delta);
			return;
		}
		bool flag = !this.IsDragging && (double)Math.Abs(this.CacheOffset) > 1E-08;
		float num2;
		if (Info.Instance.IsInGamepad())
		{
			float num = (this.InputX >= 0f) ? this.RightSlideLength : (-this.LeftSlideLength);
			if (this.LerpSpeed > 0f)
			{
				if ((double)Math.Abs(this.InputX) <= 1E-08)
				{
					this.CacheOffset = MathUtils.Instance.InterpConstantTo(this.CacheOffset, 0f, delta, this.LerpSpeed);
				}
				else
				{
					this.CacheOffset = MathUtils.Instance.InterpConstantTo(this.CacheOffset, num, delta, this.LerpSpeed * Math.Abs(this.InputX));
				}
			}
			else
			{
				this.CacheOffset = num;
			}
			num2 = this.CacheOffset;
		}
		else
		{
			num2 = this.InputX + this.DerivedOffset;
			if (this.LerpSpeed > 0f)
			{
				this.CacheOffset = MathUtils.Instance.InterpConstantTo(this.CacheOffset, num2, delta, this.LerpSpeed);
			}
			else
			{
				this.CacheOffset = num2;
			}
		}
		this.CacheOffset = this.ClampOffset(this.CacheOffset);
		float num3 = this.OffsetToProgress(this.CacheOffset);
		this.CommonQteContext.SetDraggingInfo(num3, 0f);
		float num4 = this.OffsetToProgress(num2);
		float length = this.CheckByRealTimeInput ? num4 : num3;
		float progress = (this.CheckByRealTimeInput && !this.BackwardWhenFail) ? num4 : num3;
		CommonQteDragContext commonQteContext = this.CommonQteContext;
		if (!commonQteContext.IsPending())
		{
			return;
		}
		if (flag && (double)Math.Abs(this.CacheOffset) <= 1E-08)
		{
			this.CacheOffset = 0f;
			commonQteContext.SetDraggingInfo(0.5f, 0f);
			commonQteContext.StopMoveAudioAndSyncProgress();
		}
		bool flag2 = commonQteContext.CheckDragComplete(length, 0f);
		if (flag2 || commonQteContext.CheckDragFail(progress))
		{
			if (!flag2)
			{
				if (this.BackwardWhenFail)
				{
					this.StartBackingToCenter();
					return;
				}
				if (this.CheckByRealTimeInput)
				{
					commonQteContext.SetPreResult(false);
				}
				commonQteContext.QteFail();
				return;
			}
			else
			{
				if (this.CheckByRealTimeInput)
				{
					commonQteContext.SetPreResult(true);
				}
				commonQteContext.CheckQteConditionAndDoSuccess();
			}
		}
	}

	// Token: 0x0601141E RID: 70686 RVA: 0x00513900 File Offset: 0x00511B00
	private float ClampOffset(float offset)
	{
		float min = (this.LeftSlideLength > 0f) ? (-this.LeftSlideLength) : 0f;
		float max = (this.RightSlideLength > 0f) ? this.RightSlideLength : 0f;
		return MathUtils.Instance.Clamp(offset, min, max);
	}

	// Token: 0x0601141F RID: 70687 RVA: 0x00513954 File Offset: 0x00511B54
	private float OffsetToProgress(float offset)
	{
		float num = this.ClampOffset(offset);
		if (num < 0f)
		{
			if (this.LeftSlideLength <= 0f)
			{
				return 0.5f;
			}
			return MathUtils.Instance.Clamp(0.5f + num / (2f * this.LeftSlideLength), 0f, 0.5f);
		}
		else
		{
			if (this.RightSlideLength <= 0f)
			{
				return 0.5f;
			}
			return MathUtils.Instance.Clamp(0.5f + num / (2f * this.RightSlideLength), 0.5f, 1f);
		}
	}

	// Token: 0x06011420 RID: 70688 RVA: 0x005139E8 File Offset: 0x00511BE8
	private float ProgressToOffset(float progress)
	{
		float num = MathUtils.Instance.Clamp(progress, 0f, 1f);
		if (num < 0.5f)
		{
			return (num - 0.5f) * 2f * this.LeftSlideLength;
		}
		return (num - 0.5f) * 2f * this.RightSlideLength;
	}

	// Token: 0x06011421 RID: 70689 RVA: 0x00513A3C File Offset: 0x00511C3C
	private void StartBackingToCenter()
	{
		this.IsBackingToCenter = true;
		this.InputX = 0f;
		this.HasInputTurn = false;
		this.DerivedOffset = 0f;
		this.StartDragPosition = null;
		this.SetIsDragging(false);
	}

	// Token: 0x06011422 RID: 70690 RVA: 0x00513A78 File Offset: 0x00511C78
	private void UpdateBackingToCenter(float delta)
	{
		float num = this.OffsetToProgress(this.CacheOffset);
		float num2 = (num < 0.5f) ? this.LeftSlideLength : this.RightSlideLength;
		float interpSpeed = (num2 > 0f) ? (this.RewardSpeed * 0.5f / num2) : 0f;
		float num3;
		if (this.RewardSpeed > 0f && num2 > 0f)
		{
			num3 = MathUtils.Instance.InterpConstantTo(num, 0.5f, delta, interpSpeed);
		}
		else
		{
			num3 = 0.5f;
		}
		this.CacheOffset = this.ProgressToOffset(num3);
		CommonQteDragContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null)
		{
			commonQteContext.SetDraggingInfo(num3, 0f);
		}
		if ((double)Math.Abs(num3 - 0.5f) <= 1E-08)
		{
			this.CacheOffset = 0f;
			this.IsBackingToCenter = false;
			CommonQteDragContext commonQteContext2 = this.CommonQteContext;
			if (commonQteContext2 != null)
			{
				commonQteContext2.SetDraggingInfo(0.5f, 0f);
			}
			CommonQteDragContext commonQteContext3 = this.CommonQteContext;
			if (commonQteContext3 == null)
			{
				return;
			}
			commonQteContext3.StopMoveAudioAndSyncProgress();
		}
	}

	// Token: 0x040097A3 RID: 38819
	private const float CENTER_PROGRESS = 0.5f;

	// Token: 0x040097A4 RID: 38820
	private InputMultiKeyItem KeyItem;

	// Token: 0x040097A5 RID: 38821
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040097A6 RID: 38822
	private float LeftSlideLength;

	// Token: 0x040097A7 RID: 38823
	private float RightSlideLength;

	// Token: 0x040097A8 RID: 38824
	private float LerpSpeed;

	// Token: 0x040097A9 RID: 38825
	private float RewardSpeed;

	// Token: 0x040097AA RID: 38826
	private float CacheOffset;

	// Token: 0x040097AB RID: 38827
	private float DerivedOffset;

	// Token: 0x040097AC RID: 38828
	private float InputX;

	// Token: 0x040097AD RID: 38829
	private bool HasInputTurn;

	// Token: 0x040097AE RID: 38830
	private bool IsDragging;

	// Token: 0x040097AF RID: 38831
	private bool CheckByRealTimeInput;

	// Token: 0x040097B0 RID: 38832
	private bool BackwardWhenFail;

	// Token: 0x040097B1 RID: 38833
	private bool IsBackingToCenter;

	// Token: 0x040097B2 RID: 38834
	private FVector? StartDragPosition;

	// Token: 0x02007DF5 RID: 32245
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028C6E RID: 167022
		Perfab,
		// Token: 0x04028C6F RID: 167023
		Drag,
		// Token: 0x04028C70 RID: 167024
		HotKey
	}
}
