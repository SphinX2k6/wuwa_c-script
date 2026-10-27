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

// Token: 0x0200261E RID: 9758
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSuisuiSlideItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013F25 RID: 81701 RVA: 0x005041B8 File Offset: 0x005023B8
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

	// Token: 0x06013F26 RID: 81702 RVA: 0x00504250 File Offset: 0x00502450
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSuisuiSlideItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSuisuiSlideItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F27 RID: 81703 RVA: 0x00504294 File Offset: 0x00502494
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

	// Token: 0x06013F28 RID: 81704 RVA: 0x0050435A File Offset: 0x0050255A
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013F29 RID: 81705 RVA: 0x00504365 File Offset: 0x00502565
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

	// Token: 0x06013F2A RID: 81706 RVA: 0x00504398 File Offset: 0x00502598
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

	// Token: 0x06013F2B RID: 81707 RVA: 0x0050443C File Offset: 0x0050263C
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

	// Token: 0x06013F2C RID: 81708 RVA: 0x005044BC File Offset: 0x005026BC
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

	// Token: 0x06013F2D RID: 81709 RVA: 0x00504514 File Offset: 0x00502714
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

	// Token: 0x06013F2E RID: 81710 RVA: 0x00504588 File Offset: 0x00502788
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013F2F RID: 81711 RVA: 0x0050458B File Offset: 0x0050278B
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013F30 RID: 81712 RVA: 0x005045C4 File Offset: 0x005027C4
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013F31 RID: 81713 RVA: 0x00504600 File Offset: 0x00502800
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

	// Token: 0x06013F32 RID: 81714 RVA: 0x00504652 File Offset: 0x00502852
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

	// Token: 0x06013F33 RID: 81715 RVA: 0x00504684 File Offset: 0x00502884
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

	// Token: 0x06013F34 RID: 81716 RVA: 0x005046BF File Offset: 0x005028BF
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsBackingToCenter)
		{
			return;
		}
		this.DerivedOffset = this.CacheOffset;
	}

	// Token: 0x06013F35 RID: 81717 RVA: 0x005046D6 File Offset: 0x005028D6
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		if (this.IsBackingToCenter)
		{
			return;
		}
		this.DerivedOffset = 0f;
	}

	// Token: 0x06013F36 RID: 81718 RVA: 0x005046EC File Offset: 0x005028EC
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!this.IsValidSlideInput())
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x06013F37 RID: 81719 RVA: 0x00504710 File Offset: 0x00502910
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

	// Token: 0x06013F38 RID: 81720 RVA: 0x00504772 File Offset: 0x00502972
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

	// Token: 0x06013F39 RID: 81721 RVA: 0x005047A6 File Offset: 0x005029A6
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

	// Token: 0x06013F3A RID: 81722 RVA: 0x005047DD File Offset: 0x005029DD
	private bool IsValidSlideInput()
	{
		return !this.IsBackingToCenter && base.IsValidInput() && this.HasBindAction;
	}

	// Token: 0x06013F3B RID: 81723 RVA: 0x005047F8 File Offset: 0x005029F8
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

	// Token: 0x06013F3C RID: 81724 RVA: 0x00504A3C File Offset: 0x00502C3C
	private float ClampOffset(float offset)
	{
		float min = (this.LeftSlideLength > 0f) ? (-this.LeftSlideLength) : 0f;
		float max = (this.RightSlideLength > 0f) ? this.RightSlideLength : 0f;
		return MathUtils.Instance.Clamp(offset, min, max);
	}

	// Token: 0x06013F3D RID: 81725 RVA: 0x00504A90 File Offset: 0x00502C90
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

	// Token: 0x06013F3E RID: 81726 RVA: 0x00504B24 File Offset: 0x00502D24
	private float ProgressToOffset(float progress)
	{
		float num = MathUtils.Instance.Clamp(progress, 0f, 1f);
		if (num < 0.5f)
		{
			return (num - 0.5f) * 2f * this.LeftSlideLength;
		}
		return (num - 0.5f) * 2f * this.RightSlideLength;
	}

	// Token: 0x06013F3F RID: 81727 RVA: 0x00504B78 File Offset: 0x00502D78
	private void StartBackingToCenter()
	{
		this.IsBackingToCenter = true;
		this.InputX = 0f;
		this.HasInputTurn = false;
		this.DerivedOffset = 0f;
		this.StartDragPosition = null;
		this.SetIsDragging(false);
	}

	// Token: 0x06013F40 RID: 81728 RVA: 0x00504BB4 File Offset: 0x00502DB4
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

	// Token: 0x0400964C RID: 38476
	private const float CENTER_PROGRESS = 0.5f;

	// Token: 0x0400964D RID: 38477
	private InputMultiKeyItem KeyItem;

	// Token: 0x0400964E RID: 38478
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400964F RID: 38479
	private float LeftSlideLength;

	// Token: 0x04009650 RID: 38480
	private float RightSlideLength;

	// Token: 0x04009651 RID: 38481
	private float LerpSpeed;

	// Token: 0x04009652 RID: 38482
	private float RewardSpeed;

	// Token: 0x04009653 RID: 38483
	private float CacheOffset;

	// Token: 0x04009654 RID: 38484
	private float DerivedOffset;

	// Token: 0x04009655 RID: 38485
	private float InputX;

	// Token: 0x04009656 RID: 38486
	private bool HasInputTurn;

	// Token: 0x04009657 RID: 38487
	private bool IsDragging;

	// Token: 0x04009658 RID: 38488
	private bool CheckByRealTimeInput;

	// Token: 0x04009659 RID: 38489
	private bool BackwardWhenFail;

	// Token: 0x0400965A RID: 38490
	private bool IsBackingToCenter;

	// Token: 0x0400965B RID: 38491
	private FVector? StartDragPosition;

	// Token: 0x02008C6C RID: 35948
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D957 RID: 186711
		Perfab,
		// Token: 0x0402D958 RID: 186712
		Drag,
		// Token: 0x0402D959 RID: 186713
		HotKey
	}
}
