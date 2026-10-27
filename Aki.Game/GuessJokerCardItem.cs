using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200106D RID: 4205
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerCardItem : UiPanelBase
{
	// Token: 0x06006C6C RID: 27756 RVA: 0x0015E35C File Offset: 0x0015C55C
	[NullableContext(1)]
	public GuessJokerCardItem(GuessJokerCardData cardData)
	{
		this.CardData = cardData;
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x0015E3FC File Offset: 0x0015C5FC
	public GuessJokerCardItem()
	{
	}

	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x06006C6E RID: 27758 RVA: 0x0015E494 File Offset: 0x0015C694
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

	// Token: 0x06006C6F RID: 27759 RVA: 0x0015E4D0 File Offset: 0x0015C6D0
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

	// Token: 0x06006C70 RID: 27760 RVA: 0x0015E65C File Offset: 0x0015C85C
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerCardItem.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerCardItem.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006C71 RID: 27761 RVA: 0x0015E6A0 File Offset: 0x0015C8A0
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

	// Token: 0x06006C72 RID: 27762 RVA: 0x0015E6F4 File Offset: 0x0015C8F4
	protected override void OnBeforeShow()
	{
		if (this.CardData == null)
		{
			return;
		}
		this.RefreshCardItem();
		this.CardFlip(this.CardData.GetBelongPlayerType().GetValueOrDefault() != EGuessJokerPlayerType.Ai, false);
	}

	// Token: 0x06006C73 RID: 27763 RVA: 0x0015E730 File Offset: 0x0015C930
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

	// Token: 0x06006C74 RID: 27764 RVA: 0x0015E7B3 File Offset: 0x0015C9B3
	[NullableContext(1)]
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "Change" && eventName == "Change")
		{
			this.RefreshBlankCard();
		}
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x0015E7D8 File Offset: 0x0015C9D8
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

	// Token: 0x06006C76 RID: 27766 RVA: 0x0015E810 File Offset: 0x0015CA10
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

	// Token: 0x06006C77 RID: 27767 RVA: 0x0015E900 File Offset: 0x0015CB00
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

	// Token: 0x06006C78 RID: 27768 RVA: 0x0015E9F0 File Offset: 0x0015CBF0
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

	// Token: 0x06006C79 RID: 27769 RVA: 0x0015EA38 File Offset: 0x0015CC38
	private void SetCardShow(bool isCardShow)
	{
		this.IsCardShow = isCardShow;
		base.GetItem(3).SetUIActive(!this.IsCardShow && !GuessJokerGamePlayModel.Instance.IsShowAiCards);
		base.GetItem(4).SetUIActive(this.IsCardShow || GuessJokerGamePlayModel.Instance.IsShowAiCards);
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x0015EA91 File Offset: 0x0015CC91
	[NullableContext(1)]
	public void BindClickCallback(Action<GuessJokerCardItem> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x0015EA9A File Offset: 0x0015CC9A
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

	// Token: 0x06006C7C RID: 27772 RVA: 0x0015EAB6 File Offset: 0x0015CCB6
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

	// Token: 0x06006C7D RID: 27773 RVA: 0x0015EAEA File Offset: 0x0015CCEA
	public void SetToggleState(bool isSelect)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x0015EB08 File Offset: 0x0015CD08
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

	// Token: 0x06006C7F RID: 27775 RVA: 0x0015EB78 File Offset: 0x0015CD78
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

	// Token: 0x06006C80 RID: 27776 RVA: 0x0015EC33 File Offset: 0x0015CE33
	public void SetDark(bool isDark)
	{
		if (isDark)
		{
			this.PlayCardSequence("CardDark", null);
			return;
		}
		this.PlayCardSequence("CardBright", null);
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x0015EC54 File Offset: 0x0015CE54
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

	// Token: 0x06006C82 RID: 27778 RVA: 0x0015ECA2 File Offset: 0x0015CEA2
	public void SetChooseCardItem(bool isChoose)
	{
		if (isChoose)
		{
			this.PlayCardSequence("Sle", null);
			return;
		}
		this.PlayCardSequence("Unsle", null);
	}

	// Token: 0x06006C83 RID: 27779 RVA: 0x0015ECC0 File Offset: 0x0015CEC0
	public void SetSelectCardItem(Action finishCallback = null)
	{
		this.PlayCardSequence("Press", finishCallback);
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x0015ECD0 File Offset: 0x0015CED0
	public void SetCheckCardItem(bool isCheck)
	{
		if (this.IsCardShow)
		{
			base.GetItem(12).SetUIActive(isCheck);
			return;
		}
		Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "只有ai能使用SetCheckCardItem", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x0015ED14 File Offset: 0x0015CF14
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

	// Token: 0x06006C86 RID: 27782 RVA: 0x0015ED50 File Offset: 0x0015CF50
	public void SetBlankCardDisable()
	{
		base.GetTexture(14).SetUIActive(true);
		this.SetAlpha(0.3f);
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x0015ED6B File Offset: 0x0015CF6B
	[NullableContext(1)]
	public void UpdateCardData(GuessJokerCardData newCardData)
	{
		this.CardData = newCardData;
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x0015ED74 File Offset: 0x0015CF74
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

	// Token: 0x06006C89 RID: 27785 RVA: 0x0015EDEF File Offset: 0x0015CFEF
	[NullableContext(1)]
	public void SetPosition(Vector2D position)
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetAnchorOffset(position.ToUeVector2D(false));
		}
	}

	// Token: 0x06006C8A RID: 27786 RVA: 0x0015EE0C File Offset: 0x0015D00C
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

	// Token: 0x06006C8B RID: 27787 RVA: 0x0015EE44 File Offset: 0x0015D044
	public void SetRotation(float angle)
	{
		if (this.RootItem != null)
		{
			FRotator frotator = new FRotator(0f, angle, 0f);
			this.RootItem.SetUIRelativeRotation(frotator);
			this.Rotation = angle;
		}
	}

	// Token: 0x06006C8C RID: 27788 RVA: 0x0015EE7F File Offset: 0x0015D07F
	public void SetAlpha(float alpha)
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetUIItemAlpha(alpha);
		}
	}

	// Token: 0x06006C8D RID: 27789 RVA: 0x0015EE98 File Offset: 0x0015D098
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

	// Token: 0x06006C8E RID: 27790 RVA: 0x0015F048 File Offset: 0x0015D248
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

	// Token: 0x06006C8F RID: 27791 RVA: 0x0015F09F File Offset: 0x0015D29F
	public FVector2D GetCurrentPosition()
	{
		if (this.RootItem != null)
		{
			return this.RootItem.GetAnchorOffset();
		}
		return new FVector2D(0f, 0f);
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x0015F0C4 File Offset: 0x0015D2C4
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

	// Token: 0x06006C91 RID: 27793 RVA: 0x0015F201 File Offset: 0x0015D401
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

	// Token: 0x06006C92 RID: 27794 RVA: 0x0015F21C File Offset: 0x0015D41C
	private UniTask InitXCurve()
	{
		GuessJokerCardItem.<InitXCurve>d__68 <InitXCurve>d__;
		<InitXCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitXCurve>d__.<>4__this = this;
		<InitXCurve>d__.<>1__state = -1;
		<InitXCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitXCurve>d__68>(ref <InitXCurve>d__);
		return <InitXCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06006C93 RID: 27795 RVA: 0x0015F260 File Offset: 0x0015D460
	private UniTask InitYCurve()
	{
		GuessJokerCardItem.<InitYCurve>d__69 <InitYCurve>d__;
		<InitYCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitYCurve>d__.<>4__this = this;
		<InitYCurve>d__.<>1__state = -1;
		<InitYCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitYCurve>d__69>(ref <InitYCurve>d__);
		return <InitYCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06006C94 RID: 27796 RVA: 0x0015F2A4 File Offset: 0x0015D4A4
	private UniTask InitScaleCurve()
	{
		GuessJokerCardItem.<InitScaleCurve>d__70 <InitScaleCurve>d__;
		<InitScaleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitScaleCurve>d__.<>4__this = this;
		<InitScaleCurve>d__.<>1__state = -1;
		<InitScaleCurve>d__.<>t__builder.Start<GuessJokerCardItem.<InitScaleCurve>d__70>(ref <InitScaleCurve>d__);
		return <InitScaleCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06006C95 RID: 27797 RVA: 0x0015F2E7 File Offset: 0x0015D4E7
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

	// Token: 0x06006C96 RID: 27798 RVA: 0x0015F316 File Offset: 0x0015D516
	public bool GetChoose()
	{
		return this.IsChoose;
	}

	// Token: 0x06006C97 RID: 27799 RVA: 0x0015F31E File Offset: 0x0015D51E
	public ECardPositionType GetPositionType()
	{
		return this.PositionType;
	}

	// Token: 0x06006C98 RID: 27800 RVA: 0x0015F326 File Offset: 0x0015D526
	public void SetPositionType(ECardPositionType position)
	{
		this.PositionType = position;
	}

	// Token: 0x06006C99 RID: 27801 RVA: 0x0015F32F File Offset: 0x0015D52F
	public void SetIndexInPanel(int index)
	{
		this.IndexInPanel = (int)(this.PositionType * (ECardPositionType)100 + index);
	}

	// Token: 0x06006C9A RID: 27802 RVA: 0x0015F344 File Offset: 0x0015D544
	public void SetHierarchyIndex(int index)
	{
		UUIItem uuiitem = this.GetOriginalItem() ?? this.RootItem;
		if (uuiitem != null)
		{
			uuiitem.SetHierarchyIndex(index);
		}
	}

	// Token: 0x06006C9B RID: 27803 RVA: 0x0015F36C File Offset: 0x0015D56C
	public int GetGlobalIndex()
	{
		return this.IndexInPanel;
	}

	// Token: 0x06006C9C RID: 27804 RVA: 0x0015F374 File Offset: 0x0015D574
	public void SetChecking()
	{
		this.IsChecking = true;
	}

	// Token: 0x06006C9D RID: 27805 RVA: 0x0015F37D File Offset: 0x0015D57D
	public void ClearCheckingSign()
	{
		if (this.IsChecking)
		{
			this.IsChecking = false;
			this.PlayCardSequence("EvilPressUnsle", null);
		}
	}

	// Token: 0x0400322E RID: 12846
	private GuessJokerCardData CardData;

	// Token: 0x0400322F RID: 12847
	private bool IsCardShow;

	// Token: 0x04003230 RID: 12848
	private bool IsChoose;

	// Token: 0x04003231 RID: 12849
	private bool IsClickEnable;

	// Token: 0x04003232 RID: 12850
	private bool IsChecking;

	// Token: 0x04003233 RID: 12851
	[Nullable(1)]
	private Action<GuessJokerCardItem> ClickCallback = delegate(GuessJokerCardItem _)
	{
	};

	// Token: 0x04003234 RID: 12852
	private int IndexInPanel;

	// Token: 0x04003235 RID: 12853
	private ECardPositionType PositionType = ECardPositionType.Middle;

	// Token: 0x04003236 RID: 12854
	private float Size = 1f;

	// Token: 0x04003237 RID: 12855
	private float Rotation;

	// Token: 0x04003238 RID: 12856
	[Nullable(1)]
	protected readonly Transform ItemWorldTrans = Transform.Create();

	// Token: 0x04003239 RID: 12857
	[Nullable(1)]
	protected readonly Vector TempWorldPos = Vector.Create();

	// Token: 0x0400323A RID: 12858
	private Action MoveCompleteCallback;

	// Token: 0x0400323B RID: 12859
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x0400323C RID: 12860
	private ULTweener MoveTween;

	// Token: 0x0400323D RID: 12861
	private bool IsMoving;

	// Token: 0x0400323E RID: 12862
	private UCurveFloat XCurve;

	// Token: 0x0400323F RID: 12863
	private UCurveFloat YCurve;

	// Token: 0x04003240 RID: 12864
	private UCurveFloat ScaleCurve;

	// Token: 0x04003241 RID: 12865
	private FVector2D StartPosition = new FVector2D();

	// Token: 0x04003242 RID: 12866
	private FVector2D TargetPosition = new FVector2D();

	// Token: 0x04003243 RID: 12867
	private float StartSize = 1f;

	// Token: 0x04003244 RID: 12868
	private float TargetSize = 1f;

	// Token: 0x04003245 RID: 12869
	private float StartRotation;

	// Token: 0x04003246 RID: 12870
	private float TargetRotation;

	// Token: 0x04003247 RID: 12871
	private GuessJokerCardBackItem BackItem;

	// Token: 0x04003248 RID: 12872
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003249 RID: 12873
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x0200765A RID: 30298
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027118 RID: 160024
		public const int Toggle = 0;

		// Token: 0x04027119 RID: 160025
		public const int Texture = 1;

		// Token: 0x0402711A RID: 160026
		public const int NumberText = 2;

		// Token: 0x0402711B RID: 160027
		public const int BackItem = 3;

		// Token: 0x0402711C RID: 160028
		public const int FrontPanel = 4;

		// Token: 0x0402711D RID: 160029
		public const int NumberText2 = 5;

		// Token: 0x0402711E RID: 160030
		public const int GhostTipItem = 6;

		// Token: 0x0402711F RID: 160031
		public const int BlankTipItem = 7;

		// Token: 0x04027120 RID: 160032
		public const int BlankTipSprite = 8;

		// Token: 0x04027121 RID: 160033
		public const int BlankNumberText = 9;

		// Token: 0x04027122 RID: 160034
		public const int ChooseItem = 10;

		// Token: 0x04027123 RID: 160035
		public const int SelectItem = 11;

		// Token: 0x04027124 RID: 160036
		public const int CheckItem = 12;

		// Token: 0x04027125 RID: 160037
		public const int ChangeTexture = 13;

		// Token: 0x04027126 RID: 160038
		public const int DisableTexture = 14;
	}
}
