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

// Token: 0x02002611 RID: 9745
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013E23 RID: 81443 RVA: 0x004FE64C File Offset: 0x004FC84C
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

	// Token: 0x06013E24 RID: 81444 RVA: 0x004FE784 File Offset: 0x004FC984
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteDragItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteDragItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E25 RID: 81445 RVA: 0x004FE7C8 File Offset: 0x004FC9C8
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

	// Token: 0x06013E26 RID: 81446 RVA: 0x004FE935 File Offset: 0x004FCB35
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013E27 RID: 81447 RVA: 0x004FE940 File Offset: 0x004FCB40
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

	// Token: 0x06013E28 RID: 81448 RVA: 0x004FE974 File Offset: 0x004FCB74
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

	// Token: 0x06013E29 RID: 81449 RVA: 0x004FEA50 File Offset: 0x004FCC50
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

	// Token: 0x06013E2A RID: 81450 RVA: 0x004FEAD0 File Offset: 0x004FCCD0
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

	// Token: 0x06013E2B RID: 81451 RVA: 0x004FEB28 File Offset: 0x004FCD28
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

	// Token: 0x06013E2C RID: 81452 RVA: 0x004FEB9A File Offset: 0x004FCD9A
	protected override void OnQtePause()
	{
		base.OnQtePause();
		this.Input.IsValid = false;
	}

	// Token: 0x06013E2D RID: 81453 RVA: 0x004FEBAE File Offset: 0x004FCDAE
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013E2E RID: 81454 RVA: 0x004FEBB1 File Offset: 0x004FCDB1
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
	}

	// Token: 0x06013E2F RID: 81455 RVA: 0x004FEBE9 File Offset: 0x004FCDE9
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
	}

	// Token: 0x06013E30 RID: 81456 RVA: 0x004FEC24 File Offset: 0x004FCE24
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

	// Token: 0x06013E31 RID: 81457 RVA: 0x004FEC78 File Offset: 0x004FCE78
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

	// Token: 0x06013E32 RID: 81458 RVA: 0x004FECF0 File Offset: 0x004FCEF0
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

	// Token: 0x06013E33 RID: 81459 RVA: 0x004FED67 File Offset: 0x004FCF67
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x06013E34 RID: 81460 RVA: 0x004FED94 File Offset: 0x004FCF94
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

	// Token: 0x06013E35 RID: 81461 RVA: 0x004FEE30 File Offset: 0x004FD030
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

	// Token: 0x06013E36 RID: 81462 RVA: 0x004FEE7D File Offset: 0x004FD07D
	private void OnButtonDown()
	{
		this.Input.IsValid = true;
	}

	// Token: 0x06013E37 RID: 81463 RVA: 0x004FEE8B File Offset: 0x004FD08B
	private void OnButtonUp()
	{
		this.Input.IsValid = false;
		this.Input.Vector.Reset();
	}

	// Token: 0x06013E38 RID: 81464 RVA: 0x004FEEA9 File Offset: 0x004FD0A9
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

	// Token: 0x06013E39 RID: 81465 RVA: 0x004FEEE0 File Offset: 0x004FD0E0
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

	// Token: 0x040095D2 RID: 38354
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x040095D3 RID: 38355
	private UUIItem Dot;

	// Token: 0x040095D4 RID: 38356
	private UUISliderComponent DurationBar;

	// Token: 0x040095D5 RID: 38357
	private InputMultiKeyItem KeyItem;

	// Token: 0x040095D6 RID: 38358
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095D7 RID: 38359
	private float DragLength;

	// Token: 0x040095D8 RID: 38360
	private bool HasResetDot;

	// Token: 0x040095D9 RID: 38361
	private float Direction;

	// Token: 0x040095DA RID: 38362
	[Nullable(1)]
	private readonly CommonQteDragItem.InputHandle Input = new CommonQteDragItem.InputHandle();

	// Token: 0x040095DB RID: 38363
	private bool HasInputTurn;

	// Token: 0x040095DC RID: 38364
	private bool HasInputLookup;

	// Token: 0x040095DD RID: 38365
	private bool IsDragging;

	// Token: 0x040095DE RID: 38366
	private FVector? StartDragPosition;

	// Token: 0x02008C52 RID: 35922
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8D1 RID: 186577
		Offset,
		// Token: 0x0402D8D2 RID: 186578
		Drag,
		// Token: 0x0402D8D3 RID: 186579
		Dot,
		// Token: 0x0402D8D4 RID: 186580
		Description,
		// Token: 0x0402D8D5 RID: 186581
		DurationPanel,
		// Token: 0x0402D8D6 RID: 186582
		DurationBar,
		// Token: 0x0402D8D7 RID: 186583
		AnimItem,
		// Token: 0x0402D8D8 RID: 186584
		HotKey
	}

	// Token: 0x02008C53 RID: 35923
	[NullableContext(0)]
	private class InputHandle
	{
		// Token: 0x0402D8D9 RID: 186585
		[Nullable(1)]
		public Vector Vector = Vector.Create();

		// Token: 0x0402D8DA RID: 186586
		public bool IsValid;
	}
}
