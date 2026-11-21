using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000521 RID: 1313
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerCardItem : UiPanelBase
{
	// Token: 0x06004001 RID: 16385 RVA: 0x00166C90 File Offset: 0x00164E90
	[NullableContext(1)]
	public GuessJokerCardItem(GuessJokerCardData cardData)
	{
		this.CardData = cardData;
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x00166D30 File Offset: 0x00164F30
	public GuessJokerCardItem()
	{
	}

	// Token: 0x170008E8 RID: 2280
	// (get) Token: 0x06004003 RID: 16387 RVA: 0x00166DC8 File Offset: 0x00164FC8
	public GuessJokerCardData Data
	{
		get
		{
			if (this.CardData == null)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "CardData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.CardData;
		}
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x00166E04 File Offset: 0x00165004
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle))
		};
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x00166F90 File Offset: 0x00165190
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerCardItem.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerCardItem.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x00166FD4 File Offset: 0x001651D4
	protected override void OnStart()
	{
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.UpdateMoveProgress));
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(false);
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x00167028 File Offset: 0x00165228
	protected override void OnBeforeShow()
	{
		if (this.CardData == null)
		{
			return;
		}
		this.RefreshCardItem();
		this.CardFlip(this.CardData.GetBelongPlayerType().GetValueOrDefault() != EGuessJokerPlayerType.Ai, false);
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x00167064 File Offset: 0x00165264
	protected override void OnBeforeDestroy()
	{
		this.CardData = null;
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateMoveProgress));
			this.Delegate = null;
		}
		this.StopMove();
		this.XCurve = null;
		this.YCurve = null;
		this.ScaleCurve = null;
		base.GetItem(10).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x001670E7 File Offset: 0x001652E7
	[NullableContext(1)]
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "Change" && eventName == "Change")
		{
			this.RefreshBlankCard();
		}
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x0016710C File Offset: 0x0016530C
	[NullableContext(1)]
	private void SequenceFinishEvent(string sequenceName)
	{
		Action action;
		if (this.SequenceFinishCallbackMap.TryGetValue(sequenceName, out action) && action != null)
		{
			action();
			this.SequenceFinishCallbackMap.Remove(sequenceName);
		}
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x00167144 File Offset: 0x00165344
	public void RefreshCardItem()
	{
		if (this.CardData == null)
		{
			return;
		}
		int value = this.CardData.Value;
		if (this.CardData.IsBlank())
		{
			this.RefreshBlankCard();
		}
		else
		{
			if (this.CardData.IsJoker())
			{
				base.GetText(2).SetText("", true);
				base.GetText(5).SetText("", true);
			}
			else
			{
				UUIText text = base.GetText(2);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				UUIText text2 = base.GetText(5);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.SetTextureByPath(this.CardData.TexturePath, base.GetTexture(1), null, null);
		}
		base.GetItem(7).SetUIActive(this.CardData.IsBlank());
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x00167234 File Offset: 0x00165434
	private void RefreshBlankCard()
	{
		if (this.CardData == null)
		{
			return;
		}
		if (!this.CardData.IsBlank())
		{
			return;
		}
		int value = this.CardData.Value;
		if (this.CardData.HasChanged() && !this.CardData.IsChangedToJoker())
		{
			UUIText text = base.GetText(9);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			UUIText text2 = base.GetText(5);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		else
		{
			base.GetText(9).SetText("", true);
			base.GetText(5).SetText("", true);
		}
		base.GetText(2).SetText("", true);
		base.SetTextureByPath(this.CardData.TexturePath, base.GetTexture(1), null, null);
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x00167324 File Offset: 0x00165524
	public void RefreshCardChangeTexture()
	{
		if (this.CardData == null)
		{
			return;
		}
		if (!this.CardData.IsBlank())
		{
			return;
		}
		base.SetTextureByPath(this.CardData.TexturePath, base.GetTexture(13), null, null);
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x0016736C File Offset: 0x0016556C
	private void SetCardShow(bool isCardShow)
	{
		this.IsCardShow = isCardShow;
		base.GetItem(3).SetUIActive(!this.IsCardShow && !GuessJokerGamePlayModel.Instance.IsShowAiCards);
		base.GetItem(4).SetUIActive(this.IsCardShow || GuessJokerGamePlayModel.Instance.IsShowAiCards);
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x001673C5 File Offset: 0x001655C5
	[NullableContext(1)]
	public void BindClickCallback(Action<GuessJokerCardItem> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x001673CE File Offset: 0x001655CE
	protected void OnToggle(EToggleState state)
	{
		if (!this.IsClickEnable)
		{
			return;
		}
		Action<GuessJokerCardItem> clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback(this);
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x001673EA File Offset: 0x001655EA
	public void ToggleStateChange(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetSelfInteractive(!isSelect);
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x0016741E File Offset: 0x0016561E
	public void SetToggleState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x0016743C File Offset: 0x0016563C
	public void CardFlip(bool isCardShow, bool isNeedAim = true)
	{
		if (isNeedAim && isCardShow != this.IsCardShow)
		{
			string sequenceName = isCardShow ? "BackToFront" : "FrontToBack";
			this.PlayCardSequence(sequenceName, delegate
			{
				this.SetCardShow(isCardShow);
			});
			return;
		}
		this.SetCardShow(isCardShow);
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x001674AC File Offset: 0x001656AC
	public void CardUp(bool isUp, Action onComplete = null)
	{
		ICardPositionConfig cardPositionConfig = GuessJokerDefine.GetCardPositionConfig(this.PositionType);
		FVector2D currentPosition = this.GetCurrentPosition();
		Vector2D targetPosition = new Vector2D((double)currentPosition.X, (double)currentPosition.Y + (double)(isUp ? cardPositionConfig.UpOffset : (-cardPositionConfig.UpOffset)).Value);
		if (isUp)
		{
			AudioSystem.Instance.PostEvent("play_ui_springfestival_ghostcard_card_friction");
		}
		int jokerParamConfig = GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCardUpTime.ToString());
		this.SmoothMoveTo(targetPosition, onComplete, null, null, (float)jokerParamConfig);
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x00167567 File Offset: 0x00165767
	public void SetDark(bool isDark)
	{
		if (isDark)
		{
			this.PlayCardSequence("CardDark", null);
			return;
		}
		this.PlayCardSequence("CardBright", null);
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x00167588 File Offset: 0x00165788
	public void SetClickEnable(bool enable)
	{
		this.IsClickEnable = enable;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(enable ? (this.IsChoose ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked) : EToggleState.ETT_UnDetermined, false, false, false);
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetSelfInteractive(enable);
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x001675D6 File Offset: 0x001657D6
	public void SetChooseCardItem(bool isChoose)
	{
		if (isChoose)
		{
			this.PlayCardSequence("Sle", null);
			return;
		}
		this.PlayCardSequence("Unsle", null);
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x001675F4 File Offset: 0x001657F4
	public void SetSelectCardItem(Action finishCallback = null)
	{
		this.PlayCardSequence("Press", finishCallback);
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x00167604 File Offset: 0x00165804
	public void SetCheckCardItem(bool isCheck)
	{
		if (this.IsCardShow)
		{
			base.GetItem(12).SetUIActive(isCheck);
			return;
		}
		Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "只有ai能使用SetCheckCardItem", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x00167648 File Offset: 0x00165848
	[NullableContext(1)]
	public void PlayCardSequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		if (finishCallback != null)
		{
			this.SequenceFinishCallbackMap[sequenceName] = finishCallback;
		}
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x00167684 File Offset: 0x00165884
	public void SetBlankCardDisable()
	{
		base.GetTexture(14).SetUIActive(true);
		this.SetAlpha(0.3f);
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x0016769F File Offset: 0x0016589F
	[NullableContext(1)]
	public void UpdateCardData(GuessJokerCardData newCardData)
	{
		this.CardData = newCardData;
	}

	// Token: 0x0600401D RID: 16413 RVA: 0x001676A8 File Offset: 0x001658A8
	[NullableContext(1)]
	public void SetUiParent(UUIItem parentItem)
	{
		Vector tempWorldPos = this.TempWorldPos;
		FVectorDouble fvectorDouble = this.RootItem.D_K2_GetComponentLocation();
		tempWorldPos.FromUeVector(fvectorDouble);
		Transform itemWorldTrans = this.ItemWorldTrans;
		FTransform ftransform = parentItem.K2_GetComponentToWorld();
		itemWorldTrans.FromUeTransform(ftransform);
		this.ItemWorldTrans.InverseTransformPosition(this.TempWorldPos, this.TempWorldPos);
		this.GetOriginalItem().SetUIParent(parentItem, false);
		this.ParentUiItem = parentItem;
		this.RootItem.SetUIRelativeLocation(this.TempWorldPos.ToUeVectorOld());
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x00167723 File Offset: 0x00165923
	[NullableContext(1)]
	public void SetPosition(Vector2D position)
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetAnchorOffset(position.ToUeVector2D(false));
		}
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x00167740 File Offset: 0x00165940
	public void SetSize(float size)
	{
		if (this.RootItem != null)
		{
			UUIItem rootItem = this.RootItem;
			FVector fvector = new FVector(size, size, 1f);
			rootItem.SetUIRelativeScale3D(fvector);
			this.Size = size;
		}
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x00167778 File Offset: 0x00165978
	public void SetRotation(float angle)
	{
		if (this.RootItem != null)
		{
			FRotator frotator = new FRotator(0f, angle, 0f);
			this.RootItem.SetUIRelativeRotation(frotator);
			this.Rotation = angle;
		}
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x001677B3 File Offset: 0x001659B3
	public void SetAlpha(float alpha)
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetUIItemAlpha(alpha);
		}
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x001677CC File Offset: 0x001659CC
	[NullableContext(1)]
	public void SmoothMoveTo(Vector2D targetPosition, [Nullable(2)] Action onComplete = null, float? targetSize = null, float? targetRotation = null, float duration = -1f)
	{
		if (duration < 0f)
		{
			duration = (float)GuessJokerUtils.GetJokerParamConfig(EGuessJokerParamKey.GuessJokerCardMoveTime.ToString());
		}
		if (this.IsMoving)
		{
			this.StopMove();
		}
		this.MoveCompleteCallback = onComplete;
		this.IsMoving = true;
		FVector2D currentPosition = this.GetCurrentPosition();
		FVector2D fvector2D = targetPosition.ToUeVector2D(false);
		float size = this.Size;
		float valueOrDefault = targetSize.GetValueOrDefault(size);
		float rotation = this.Rotation;
		float valueOrDefault2 = targetRotation.GetValueOrDefault(rotation);
		if (MathF.Abs(currentPosition.X - fvector2D.X) < 0.01f && MathF.Abs(currentPosition.Y - fvector2D.Y) < 0.01f && size == valueOrDefault && MathF.Abs(rotation - valueOrDefault2) < 0.01f)
		{
			this.OnMoveComplete();
			return;
		}
		this.StartPosition.X = currentPosition.X;
		this.StartPosition.Y = currentPosition.Y;
		this.TargetPosition.X = fvector2D.X;
		this.TargetPosition.Y = fvector2D.Y;
		this.StartSize = size;
		this.TargetSize = valueOrDefault;
		this.StartRotation = rotation;
		this.TargetRotation = valueOrDefault2;
		this.MoveTween = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, 0f, 1f, duration / 1000f, 0f, LTweenEase.OutCubic);
		if (this.MoveTween != null)
		{
			this.MoveTween.OnCompleteCallBack.Bind(new Action(this.OnMoveComplete));
			return;
		}
		Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "SmoothMoveTo: MoveTween 创建失败，直接完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.OnMoveComplete();
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x0016797C File Offset: 0x00165B7C
	public void StopMove()
	{
		if (this.MoveTween != null)
		{
			this.MoveTween.Kill(false);
			this.MoveTween.OnCompleteCallBack.Unbind();
			this.MoveTween = null;
		}
		this.IsMoving = false;
		Action moveCompleteCallback = this.MoveCompleteCallback;
		if (moveCompleteCallback != null)
		{
			moveCompleteCallback();
		}
		this.MoveCompleteCallback = null;
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x001679D3 File Offset: 0x00165BD3
	public FVector2D GetCurrentPosition()
	{
		if (this.RootItem != null)
		{
			return this.RootItem.GetAnchorOffset();
		}
		return new FVector2D(0f, 0f);
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x001679F8 File Offset: 0x00165BF8
	private void UpdateMoveProgress(float progress)
	{
		if (this.RootItem != null)
		{
			float num = (this.XCurve != null) ? this.XCurve.GetFloatValue(progress) : progress;
			float num2 = (this.YCurve != null) ? this.YCurve.GetFloatValue(progress) : progress;
			float num3 = (this.ScaleCurve != null) ? this.ScaleCurve.GetFloatValue(progress) : progress;
			float inX = this.StartPosition.X + (this.TargetPosition.X - this.StartPosition.X) * num;
			float inY = this.StartPosition.Y + (this.TargetPosition.Y - this.StartPosition.Y) * num2;
			this.RootItem.SetAnchorOffset(new FVector2D(inX, inY));
			float num4 = this.StartSize + (this.TargetSize - this.StartSize) * num3;
			UUIItem rootItem = this.RootItem;
			FVector fvector = new FVector(num4, num4, 1f);
			rootItem.SetUIRelativeScale3D(fvector);
			this.Size = num4;
			float num5 = this.StartRotation + (this.TargetRotation - this.StartRotation) * progress;
			FRotator frotator = new FRotator(0f, num5, 0f);
			this.RootItem.SetUIRelativeRotation(frotator);
			this.Rotation = num5;
		}
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x00167B35 File Offset: 0x00165D35
	private void OnMoveComplete()
	{
		this.IsMoving = false;
		Action moveCompleteCallback = this.MoveCompleteCallback;
		if (moveCompleteCallback == null)
		{
			return;
		}
		moveCompleteCallback();
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x00167B50 File Offset: 0x00165D50
	private UniTask InitXCurve()
	{
		GuessJokerCardItem.<InitXCurve>d__68 <InitXCurve>d__;
		<InitXCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitXCurve>d__.<>4__this = this;
		<InitXCurve>d__.<>1__state = -1;
		<InitXCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitXCurve>d__68>(ref <InitXCurve>d__);
		return <InitXCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x00167B94 File Offset: 0x00165D94
	private UniTask InitYCurve()
	{
		GuessJokerCardItem.<InitYCurve>d__69 <InitYCurve>d__;
		<InitYCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitYCurve>d__.<>4__this = this;
		<InitYCurve>d__.<>1__state = -1;
		<InitYCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitYCurve>d__69>(ref <InitYCurve>d__);
		return <InitYCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x00167BD8 File Offset: 0x00165DD8
	private UniTask InitScaleCurve()
	{
		GuessJokerCardItem.<InitScaleCurve>d__70 <InitScaleCurve>d__;
		<InitScaleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitScaleCurve>d__.<>4__this = this;
		<InitScaleCurve>d__.<>1__state = -1;
		<InitScaleCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitScaleCurve>d__70>(ref <InitScaleCurve>d__);
		return <InitScaleCurve>d__.<>t__builder.Task;
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x00167C1B File Offset: 0x00165E1B
	public void SetChoose(bool isChoose, bool isPlayAnim)
	{
		if (this.IsChoose == isChoose)
		{
			return;
		}
		this.IsChoose = isChoose;
		if (isPlayAnim)
		{
			this.SetChooseCardItem(isChoose);
		}
		if (isChoose)
		{
			this.ToggleStateChange(true);
			return;
		}
		this.ToggleStateChange(false);
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x00167C4A File Offset: 0x00165E4A
	public bool GetChoose()
	{
		return this.IsChoose;
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x00167C52 File Offset: 0x00165E52
	public ECardPositionType GetPositionType()
	{
		return this.PositionType;
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x00167C5A File Offset: 0x00165E5A
	public void SetPositionType(ECardPositionType position)
	{
		this.PositionType = position;
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x00167C63 File Offset: 0x00165E63
	public void SetIndexInPanel(int index)
	{
		this.IndexInPanel = (int)(this.PositionType * (ECardPositionType)100 + index);
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x00167C78 File Offset: 0x00165E78
	public void SetHierarchyIndex(int index)
	{
		UUIItem uuiitem = this.GetOriginalItem() ?? this.RootItem;
		if (uuiitem != null)
		{
			uuiitem.SetHierarchyIndex(index);
		}
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x00167CA0 File Offset: 0x00165EA0
	public int GetGlobalIndex()
	{
		return this.IndexInPanel;
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x00167CA8 File Offset: 0x00165EA8
	public void SetChecking()
	{
		this.IsChecking = true;
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x00167CB1 File Offset: 0x00165EB1
	public void ClearCheckingSign()
	{
		if (this.IsChecking)
		{
			this.IsChecking = false;
			this.PlayCardSequence("EvilPressUnsle", null);
		}
	}

	// Token: 0x040032C7 RID: 12999
	private GuessJokerCardData CardData;

	// Token: 0x040032C8 RID: 13000
	private bool IsCardShow;

	// Token: 0x040032C9 RID: 13001
	private bool IsChoose;

	// Token: 0x040032CA RID: 13002
	private bool IsClickEnable;

	// Token: 0x040032CB RID: 13003
	private bool IsChecking;

	// Token: 0x040032CC RID: 13004
	[Nullable(1)]
	private Action<GuessJokerCardItem> ClickCallback = delegate(GuessJokerCardItem _)
	{
	};

	// Token: 0x040032CD RID: 13005
	private int IndexInPanel;

	// Token: 0x040032CE RID: 13006
	private ECardPositionType PositionType = ECardPositionType.Middle;

	// Token: 0x040032CF RID: 13007
	private float Size = 1f;

	// Token: 0x040032D0 RID: 13008
	private float Rotation;

	// Token: 0x040032D1 RID: 13009
	[Nullable(1)]
	protected readonly Transform ItemWorldTrans = Transform.Create();

	// Token: 0x040032D2 RID: 13010
	[Nullable(1)]
	protected readonly Vector TempWorldPos = Vector.Create();

	// Token: 0x040032D3 RID: 13011
	private Action MoveCompleteCallback;

	// Token: 0x040032D4 RID: 13012
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x040032D5 RID: 13013
	private ULTweener MoveTween;

	// Token: 0x040032D6 RID: 13014
	private bool IsMoving;

	// Token: 0x040032D7 RID: 13015
	private UCurveFloat XCurve;

	// Token: 0x040032D8 RID: 13016
	private UCurveFloat YCurve;

	// Token: 0x040032D9 RID: 13017
	private UCurveFloat ScaleCurve;

	// Token: 0x040032DA RID: 13018
	private FVector2D StartPosition = new FVector2D();

	// Token: 0x040032DB RID: 13019
	private FVector2D TargetPosition = new FVector2D();

	// Token: 0x040032DC RID: 13020
	private float StartSize = 1f;

	// Token: 0x040032DD RID: 13021
	private float TargetSize = 1f;

	// Token: 0x040032DE RID: 13022
	private float StartRotation;

	// Token: 0x040032DF RID: 13023
	private float TargetRotation;

	// Token: 0x040032E0 RID: 13024
	private GuessJokerCardBackItem BackItem;

	// Token: 0x040032E1 RID: 13025
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040032E2 RID: 13026
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x020067EE RID: 26606
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022463 RID: 140387
		public const int Toggle = 0;

		// Token: 0x04022464 RID: 140388
		public const int Texture = 1;

		// Token: 0x04022465 RID: 140389
		public const int NumberText = 2;

		// Token: 0x04022466 RID: 140390
		public const int BackItem = 3;

		// Token: 0x04022467 RID: 140391
		public const int FrontPanel = 4;

		// Token: 0x04022468 RID: 140392
		public const int NumberText2 = 5;

		// Token: 0x04022469 RID: 140393
		public const int GhostTipItem = 6;

		// Token: 0x0402246A RID: 140394
		public const int BlankTipItem = 7;

		// Token: 0x0402246B RID: 140395
		public const int BlankTipSprite = 8;

		// Token: 0x0402246C RID: 140396
		public const int BlankNumberText = 9;

		// Token: 0x0402246D RID: 140397
		public const int ChooseItem = 10;

		// Token: 0x0402246E RID: 140398
		public const int SelectItem = 11;

		// Token: 0x0402246F RID: 140399
		public const int CheckItem = 12;

		// Token: 0x04022470 RID: 140400
		public const int ChangeTexture = 13;

		// Token: 0x04022471 RID: 140401
		public const int DisableTexture = 14;
	}
}
