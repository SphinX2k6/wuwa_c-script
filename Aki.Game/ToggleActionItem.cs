using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E8C RID: 3724
[NullableContext(2)]
[Nullable(0)]
public class ToggleActionItem : UiPanelBase
{
	// Token: 0x17001041 RID: 4161
	// (get) Token: 0x060094DB RID: 38107 RVA: 0x002C30B5 File Offset: 0x002C12B5
	// (set) Token: 0x060094DC RID: 38108 RVA: 0x002C30BD File Offset: 0x002C12BD
	public int ToggleIndex
	{
		get
		{
			return this.ToggleIndexInline;
		}
		set
		{
			this.ToggleIndexInline = value;
		}
	}

	// Token: 0x060094DD RID: 38109 RVA: 0x002C30C8 File Offset: 0x002C12C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060094DE RID: 38110 RVA: 0x002C31B0 File Offset: 0x002C13B0
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(1);
		AUIBaseActor auibaseActor = this.Toggle.GetOwner() as AUIBaseActor;
		this.ToggleItem = auibaseActor.GetUIItem();
		this.ToggleText = base.GetText(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.Toggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
		this.TextSizeControlByOther = (base.GetRootActor().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther);
		UUIText text = base.GetText(0);
		this.DefaultFontSize = text.GetSize();
		this.DefaultToggleItemHeight = this.ToggleItem.GetHeight();
		this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "ToggleActionItemTick", ETickingGroup.TG_PrePhysics, true, 0, true);
		this.CurrentViewportSize = new FIntPoint?(this.GetViewportSize());
	}

	// Token: 0x060094DF RID: 38111 RVA: 0x002C3290 File Offset: 0x002C1490
	protected override void OnBeforeDestroy()
	{
		this.Toggle = null;
		this.Text = null;
		this.ToggleText = null;
		this.ToggleItem = null;
		this.IsPlayingReleaseSequence = false;
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		this.TextSizeControlByOther = null;
		if (this.Ticker != null)
		{
			TickSystem.Instance.Remove(this.Ticker.Id);
			this.Ticker = null;
		}
		if (this.DelayRefreshTextHeightTimer != null && TimerSystem.GameplayTimeInstance.Has(this.DelayRefreshTextHeightTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayRefreshTextHeightTimer);
			this.DelayRefreshTextHeightTimer = null;
		}
	}

	// Token: 0x060094E0 RID: 38112 RVA: 0x002C3338 File Offset: 0x002C1538
	private void OnTick(float _)
	{
		FIntPoint viewportSize = this.GetViewportSize();
		int? num = (this.CurrentViewportSize != null) ? new int?(this.CurrentViewportSize.GetValueOrDefault().X) : null;
		int num2 = viewportSize.X;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			num = ((this.CurrentViewportSize != null) ? new int?(this.CurrentViewportSize.GetValueOrDefault().Y) : null);
			num2 = viewportSize.Y;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				return;
			}
		}
		this.CurrentViewportSize = new FIntPoint?(viewportSize);
		this.RefreshTextHeight();
	}

	// Token: 0x060094E1 RID: 38113 RVA: 0x002C33E8 File Offset: 0x002C15E8
	private FIntPoint GetViewportSize()
	{
		APlayerController characterController = Global.CharacterController;
		int inX = 0;
		int inY = 0;
		characterController.GetViewportSize(ref inX, ref inY);
		return new FIntPoint(inX, inY);
	}

	// Token: 0x060094E2 RID: 38114 RVA: 0x002C340E File Offset: 0x002C160E
	protected void ToggleClick(EToggleState toggleState)
	{
		if (this.IsPlayingReleaseSequence)
		{
			return;
		}
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(new bool?(toggleState == EToggleState.ETT_Checked));
		}
	}

	// Token: 0x060094E3 RID: 38115 RVA: 0x002C3438 File Offset: 0x002C1638
	public void ShowSequenceOnBegin()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("show", false, null, false);
	}

	// Token: 0x060094E4 RID: 38116 RVA: 0x002C3460 File Offset: 0x002C1660
	public UniTask PlayReleaseSequence()
	{
		ToggleActionItem.<PlayReleaseSequence>d__29 <PlayReleaseSequence>d__;
		<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayReleaseSequence>d__.<>4__this = this;
		<PlayReleaseSequence>d__.<>1__state = -1;
		<PlayReleaseSequence>d__.<>t__builder.Start<ToggleActionItem.<PlayReleaseSequence>d__29>(ref <PlayReleaseSequence>d__);
		return <PlayReleaseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060094E5 RID: 38117 RVA: 0x002C34A3 File Offset: 0x002C16A3
	public void SetRaycastTarget(bool bCheck)
	{
		base.GetRootItem().SetRaycastTarget(bCheck);
	}

	// Token: 0x060094E6 RID: 38118 RVA: 0x002C34B4 File Offset: 0x002C16B4
	public void PlayAppearSequence()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060094E7 RID: 38119 RVA: 0x002C34DC File Offset: 0x002C16DC
	public void SetPanelAlpha(float alpha)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetAlpha(alpha);
	}

	// Token: 0x060094E8 RID: 38120 RVA: 0x002C34F0 File Offset: 0x002C16F0
	public UniTask PlayDisappearSequence()
	{
		ToggleActionItem.<PlayDisappearSequence>d__33 <PlayDisappearSequence>d__;
		<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDisappearSequence>d__.<>4__this = this;
		<PlayDisappearSequence>d__.<>1__state = -1;
		<PlayDisappearSequence>d__.<>t__builder.Start<ToggleActionItem.<PlayDisappearSequence>d__33>(ref <PlayDisappearSequence>d__);
		return <PlayDisappearSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060094E9 RID: 38121 RVA: 0x002C3533 File Offset: 0x002C1733
	[NullableContext(1)]
	public void SetFunction(Action<bool?> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x060094EA RID: 38122 RVA: 0x002C353C File Offset: 0x002C173C
	[NullableContext(1)]
	public UUIExtendToggle GetToggleItem()
	{
		return this.Toggle;
	}

	// Token: 0x060094EB RID: 38123 RVA: 0x002C3544 File Offset: 0x002C1744
	[NullableContext(1)]
	public void SetToggleText(string inText)
	{
		this.Text = inText;
		base.GetText(0).SetText(inText, true);
		if (this.ToggleText == null)
		{
			return;
		}
		this.ToggleText.SetText(inText, true);
		if (this.DelayRefreshTextHeightTimer == null)
		{
			this.DelayRefreshTextHeightTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RefreshTextHeight();
				this.DelayRefreshTextHeightTimer = null;
			}, 100f, null, null, true, 1f);
		}
	}

	// Token: 0x060094EC RID: 38124 RVA: 0x002C35B0 File Offset: 0x002C17B0
	private unsafe void RefreshTextHeight()
	{
		if (this.ToggleText == null || this.ToggleItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[RefreshTextHeight] Refresh Invalid";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("text", this.Text);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ToggleText.SetFontSize(this.DefaultFontSize);
		this.ToggleText.GetRealSize();
		bool flag = this.ToggleText.GetRenderLineNum() < 2;
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.UiCommon;
		ELogAuthor author2 = ELogAuthor.FZX;
		string message2 = "[RefreshTextHeight] IsSingleRow";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isSingleRow", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.IsSingleRow", this.IsSingleRow);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("text", this.Text);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		if (this.IsSingleRow == flag)
		{
			return;
		}
		this.IsSingleRow = flag;
		if (this.IsSingleRow)
		{
			UUISizeControlByOther textSizeControlByOther = this.TextSizeControlByOther;
			if (textSizeControlByOther != null)
			{
				textSizeControlByOther.SetControlHeight(false);
			}
			this.ToggleText.SetFontSize(this.DefaultFontSize);
			this.ToggleText.GetRealSize();
			if (this.ToggleText.GetRenderLineNum() >= 2)
			{
				this.ToggleText.SetFontSize(38f);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.UiCommon;
				ELogAuthor author3 = ELogAuthor.FZX;
				string message3 = "[RefreshTextHeight] Enlarge fail";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("text", this.Text);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			UUIItem toggleItem = this.ToggleItem;
			if (toggleItem != null)
			{
				toggleItem.SetHeight(this.DefaultToggleItemHeight);
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.UiCommon;
			ELogAuthor author4 = ELogAuthor.FZX;
			string message4 = "[RefreshTextHeight] Single height set";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("text", this.Text);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		this.ToggleText.SetFontSize(38f);
		UUISizeControlByOther textSizeControlByOther2 = this.TextSizeControlByOther;
		if (textSizeControlByOther2 != null)
		{
			textSizeControlByOther2.SetControlHeight(true);
		}
		this.ToggleText.SetFontSize(38f);
		this.ToggleText.GetRealSize();
		if (this.ToggleText.GetRenderLineNum() < 2)
		{
			UUISizeControlByOther textSizeControlByOther3 = this.TextSizeControlByOther;
			if (textSizeControlByOther3 != null)
			{
				textSizeControlByOther3.SetControlHeight(false);
			}
			this.IsSingleRow = true;
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.UiCommon;
			ELogAuthor author5 = ELogAuthor.FZX;
			string message5 = "[RefreshTextHeight] Single after reduce size";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("text", this.Text);
			instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return;
		}
		UUISizeControlByOther textSizeControlByOther4 = this.TextSizeControlByOther;
		if (textSizeControlByOther4 != null)
		{
			textSizeControlByOther4.SetControlHeight(true);
		}
		Log instance6 = Log.Instance;
		ELogModule module6 = ELogModule.UiCommon;
		ELogAuthor author6 = ELogAuthor.FZX;
		string message6 = "[RefreshTextHeight] Not single after reduce size";
		ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("text", this.Text);
		instance6.Info(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
	}

	// Token: 0x060094ED RID: 38125 RVA: 0x002C3854 File Offset: 0x002C1A54
	[NullableContext(1)]
	public void SetToggleTexture(string path, bool isTracking = false)
	{
		ToggleActionItem.<>c__DisplayClass38_0 CS$<>8__locals1 = new ToggleActionItem.<>c__DisplayClass38_0();
		CS$<>8__locals1.iconTexture = base.GetTexture(2);
		if (CS$<>8__locals1.iconTexture != null)
		{
			CS$<>8__locals1.iconTexture.SetUIItemScale(new FVector(isTracking ? 1.2f : 1f));
			ToggleActionItem.<>c__DisplayClass38_0 CS$<>8__locals2 = CS$<>8__locals1;
			AActor owner = base.GetTexture(2).GetOwner();
			CS$<>8__locals2.transition = (((owner != null) ? owner.GetComponentByClass(UUIExtendToggleTextureTransition.StaticClass()) : null) as UUIExtendToggleTextureTransition);
			Action<bool> callback = null;
			if (CS$<>8__locals1.transition != null)
			{
				callback = delegate(bool _)
				{
					UUIExtendToggleTextureTransition transition = CS$<>8__locals1.transition;
					if (transition == null)
					{
						return;
					}
					transition.SetAllTransitionStateTexture(CS$<>8__locals1.iconTexture.GetTexture());
				};
			}
			base.SetTextureByPath(path, CS$<>8__locals1.iconTexture, null, callback);
		}
	}

	// Token: 0x060094EE RID: 38126 RVA: 0x002C38F6 File Offset: 0x002C1AF6
	public void SetToggleTextGray(bool flag)
	{
		base.GetText(0).SetIsGray(flag);
	}

	// Token: 0x060094EF RID: 38127 RVA: 0x002C3905 File Offset: 0x002C1B05
	[NullableContext(1)]
	public UUIText GetToggleText()
	{
		return base.GetText(0);
	}

	// Token: 0x04005763 RID: 22371
	private const int DELAY_REFRESH_TIME = 100;

	// Token: 0x04005764 RID: 22372
	private const int FONT_SIZE = 38;

	// Token: 0x04005765 RID: 22373
	private const float TRACKING_ICON_SIZE = 1.2f;

	// Token: 0x04005766 RID: 22374
	protected UUIExtendToggle Toggle;

	// Token: 0x04005767 RID: 22375
	private UUIItem ToggleItem;

	// Token: 0x04005768 RID: 22376
	private UUIText ToggleText;

	// Token: 0x04005769 RID: 22377
	protected string Text;

	// Token: 0x0400576A RID: 22378
	protected int ToggleIndexInline;

	// Token: 0x0400576B RID: 22379
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400576C RID: 22380
	private Action<bool?> ToggleFunction;

	// Token: 0x0400576D RID: 22381
	private float DefaultFontSize;

	// Token: 0x0400576E RID: 22382
	public float DefaultToggleItemHeight;

	// Token: 0x0400576F RID: 22383
	private UUISizeControlByOther TextSizeControlByOther;

	// Token: 0x04005770 RID: 22384
	private Ticker Ticker;

	// Token: 0x04005771 RID: 22385
	private FIntPoint? CurrentViewportSize;

	// Token: 0x04005772 RID: 22386
	private bool IsSingleRow = true;

	// Token: 0x04005773 RID: 22387
	private TimerHandle DelayRefreshTextHeightTimer;

	// Token: 0x04005774 RID: 22388
	public bool IsPlayingReleaseSequence;

	// Token: 0x02007082 RID: 28802
	[NullableContext(0)]
	private class EToggleActionItemType
	{
		// Token: 0x04024AE3 RID: 150243
		public const int ToggleText = 0;

		// Token: 0x04024AE4 RID: 150244
		public const int Toggle = 1;

		// Token: 0x04024AE5 RID: 150245
		public const int Texture = 2;

		// Token: 0x04024AE6 RID: 150246
		public const int PanelItem = 3;
	}
}
