using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AFC RID: 6908
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06011305 RID: 70405 RVA: 0x0050D488 File Offset: 0x0050B688
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISliderComponent));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIItem)));
		}
	}

	// Token: 0x06011306 RID: 70406 RVA: 0x0050D5C0 File Offset: 0x0050B7C0
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteDragItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteDragItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011307 RID: 70407 RVA: 0x0050D604 File Offset: 0x0050B804
	protected override void OnStart()
	{
		base.OnStart();
		this.Dot = (base.GetButton(2).GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		this.DurationBar = base.GetSlider(5);
		UUISliderComponent durationBar = this.DurationBar;
		if (durationBar != null)
		{
			durationBar.SetValue(1f, true);
		}
		UUISliderComponent durationBar2 = this.DurationBar;
		if (durationBar2 != null)
		{
			durationBar2.SetSelfInteractive(false);
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		if (Info.Instance.IsInTouch())
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
		else
		{
			UUIItem item2 = base.GetItem(6);
			this.LevelSequencePlayer = new LevelSequencePlayer(item2);
			base.SetAttachRootItem(item2);
		}
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		UUIDraggableComponent draggable = base.GetDraggable(1);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
		UUIButtonComponent button = base.GetButton(2);
		button.OnPointDownCallBack.Bind(new Action(this.OnButtonDown));
		button.OnPointUpCallBack.Bind(new Action(this.OnButtonUp));
		base.SetUiActive(false);
	}

	// Token: 0x06011308 RID: 70408 RVA: 0x0050D771 File Offset: 0x0050B971
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06011309 RID: 70409 RVA: 0x0050D77C File Offset: 0x0050B97C
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

	// Token: 0x0601130A RID: 70410 RVA: 0x0050D7B0 File Offset: 0x0050B9B0
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag != null)
		{
			this.DragLength = scommonQte_Drag.SlideLength;
			this.Direction = (float)scommonQte_Drag.Direction;
		}
		string text = (scommonQte_Drag != null) ? scommonQte_Drag.UIConfig.TextId : null;
		UUIText text2 = base.GetText(3);
		if (!string.IsNullOrEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(text2, text, Array.Empty<object>());
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(this.CommonQteContext != null && !this.CommonQteContext.IsPermanent);
		}
		UUIItem item2 = base.GetItem(0);
		FRotator frotator = new FRotator(0f, this.Direction + 180f, 0f);
		item2.SetUIRelativeRotation(frotator);
		this.Direction *= 0.017453292f;
	}

	// Token: 0x0601130B RID: 70411 RVA: 0x0050D88C File Offset: 0x0050BA8C
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

	// Token: 0x0601130C RID: 70412 RVA: 0x0050D90C File Offset: 0x0050BB0C
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

	// Token: 0x0601130D RID: 70413 RVA: 0x0050D964 File Offset: 0x0050BB64
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_Drag scommonQte_Drag = this.CommonQteContext.GetUiConfig() as SCommonQte_Drag;
			if (scommonQte_Drag != null)
			{
				SCommonQteButton uiconfig = scommonQte_Drag.UIConfig;
				this.RootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
				this.RootItem.SetAnchorOffset(uiconfig.AnchorOffset);
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
			}
		}
	}

	// Token: 0x0601130E RID: 70414 RVA: 0x0050D9D6 File Offset: 0x0050BBD6
	protected override void OnQtePause()
	{
		base.OnQtePause();
		this.Input.IsValid = false;
	}

	// Token: 0x0601130F RID: 70415 RVA: 0x0050D9EA File Offset: 0x0050BBEA
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06011310 RID: 70416 RVA: 0x0050D9ED File Offset: 0x0050BBED
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
	}

	// Token: 0x06011311 RID: 70417 RVA: 0x0050DA25 File Offset: 0x0050BC25
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
	}

	// Token: 0x06011312 RID: 70418 RVA: 0x0050DA60 File Offset: 0x0050BC60
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

	// Token: 0x06011313 RID: 70419 RVA: 0x0050DAB4 File Offset: 0x0050BCB4
	[NullableContext(1)]
	private void OnInputTurn(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.Input.IsValid = true;
		this.Input.Vector.X = (double)(value * this.DragLength * 1.43f);
		this.HasInputTurn = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06011314 RID: 70420 RVA: 0x0050DB2C File Offset: 0x0050BD2C
	[NullableContext(1)]
	private void OnInputLookup(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.Input.IsValid = true;
		this.Input.Vector.Y = (double)(-(double)value * this.DragLength * 1.43f);
		this.HasInputLookup = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06011315 RID: 70421 RVA: 0x0050DBA3 File Offset: 0x0050BDA3
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x06011316 RID: 70422 RVA: 0x0050DBD0 File Offset: 0x0050BDD0
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.StartDragPosition = null;
			this.Input.IsValid = false;
			return;
		}
		FVector localPointInPlane = eventData.GetLocalPointInPlane();
		this.Input.Vector.Y = (double)(localPointInPlane.Y - this.StartDragPosition.Value.Y);
		this.Input.Vector.X = (double)(localPointInPlane.X - this.StartDragPosition.Value.X);
	}

	// Token: 0x06011317 RID: 70423 RVA: 0x0050DC6C File Offset: 0x0050BE6C
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.StartDragPosition = null;
		this.Input.IsValid = false;
		this.Input.Vector.Reset();
		this.SetIsDragging(false);
	}

	// Token: 0x06011318 RID: 70424 RVA: 0x0050DCB9 File Offset: 0x0050BEB9
	private void OnButtonDown()
	{
		this.Input.IsValid = true;
	}

	// Token: 0x06011319 RID: 70425 RVA: 0x0050DCC7 File Offset: 0x0050BEC7
	private void OnButtonUp()
	{
		this.Input.IsValid = false;
		this.Input.Vector.Reset();
	}

	// Token: 0x0601131A RID: 70426 RVA: 0x0050DCE5 File Offset: 0x0050BEE5
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

	// Token: 0x0601131B RID: 70427 RVA: 0x0050DD1C File Offset: 0x0050BF1C
	protected override void OnTickQteItem(float delta)
	{
		if (!this.CommonQteContext.IsPermanent)
		{
			UUISliderComponent durationBar = this.DurationBar;
			if (durationBar != null)
			{
				CommonQteDragContext commonQteContext = this.CommonQteContext;
				durationBar.SetValue((commonQteContext != null) ? commonQteContext.GetRemainingTimeProgress() : 1f, true);
			}
		}
		if (!this.Input.IsValid)
		{
			if (!this.HasResetDot)
			{
				this.Input.Vector.Reset();
				this.HasResetDot = true;
				this.Dot.SetAnchorOffsetX(0f);
				this.Dot.SetAnchorOffsetY(0f);
			}
			return;
		}
		this.HasResetDot = false;
		float num = (float)this.Input.Vector.Size2D();
		float angle = (float)this.Input.Vector.HeadingAngle();
		if (num < this.DragLength)
		{
			this.Dot.SetAnchorOffsetX((float)this.Input.Vector.X);
			this.Dot.SetAnchorOffsetY((float)this.Input.Vector.Y);
		}
		else
		{
			float num2 = this.DragLength / num;
			this.Dot.SetAnchorOffsetX((float)(this.Input.Vector.X * (double)num2));
			this.Dot.SetAnchorOffsetY((float)(this.Input.Vector.Y * (double)num2));
		}
		this.CommonQteContext.SetDraggingInfo(num, angle);
	}

	// Token: 0x04009729 RID: 38697
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x0400972A RID: 38698
	private UUIItem Dot;

	// Token: 0x0400972B RID: 38699
	private UUISliderComponent DurationBar;

	// Token: 0x0400972C RID: 38700
	private InputMultiKeyItem KeyItem;

	// Token: 0x0400972D RID: 38701
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400972E RID: 38702
	private float DragLength;

	// Token: 0x0400972F RID: 38703
	private bool HasResetDot;

	// Token: 0x04009730 RID: 38704
	private float Direction;

	// Token: 0x04009731 RID: 38705
	[Nullable(1)]
	private readonly CommonQteDragItem.InputHandle Input = new CommonQteDragItem.InputHandle();

	// Token: 0x04009732 RID: 38706
	private bool HasInputTurn;

	// Token: 0x04009733 RID: 38707
	private bool HasInputLookup;

	// Token: 0x04009734 RID: 38708
	private bool IsDragging;

	// Token: 0x04009735 RID: 38709
	private FVector? StartDragPosition;

	// Token: 0x02007DDB RID: 32219
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BE8 RID: 166888
		Offset,
		// Token: 0x04028BE9 RID: 166889
		Drag,
		// Token: 0x04028BEA RID: 166890
		Dot,
		// Token: 0x04028BEB RID: 166891
		Description,
		// Token: 0x04028BEC RID: 166892
		DurationPanel,
		// Token: 0x04028BED RID: 166893
		DurationBar,
		// Token: 0x04028BEE RID: 166894
		AnimItem,
		// Token: 0x04028BEF RID: 166895
		HotKey
	}

	// Token: 0x02007DDC RID: 32220
	[NullableContext(0)]
	private class InputHandle
	{
		// Token: 0x04028BF0 RID: 166896
		[Nullable(1)]
		public Vector Vector = Vector.Create();

		// Token: 0x04028BF1 RID: 166897
		public bool IsValid;
	}
}
