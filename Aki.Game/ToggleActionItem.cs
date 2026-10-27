using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019CD RID: 6605
[NullableContext(2)]
[Nullable(0)]
public class ToggleActionItem : UiPanelBase
{
	// Token: 0x1700101C RID: 4124
	// (get) Token: 0x0600C0CE RID: 49358 RVA: 0x002B80E9 File Offset: 0x002B62E9
	// (set) Token: 0x0600C0CF RID: 49359 RVA: 0x002B80F1 File Offset: 0x002B62F1
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

	// Token: 0x0600C0D0 RID: 49360 RVA: 0x002B80FC File Offset: 0x002B62FC
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

	// Token: 0x0600C0D1 RID: 49361 RVA: 0x002B81E4 File Offset: 0x002B63E4
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

	// Token: 0x0600C0D2 RID: 49362 RVA: 0x002B82C4 File Offset: 0x002B64C4
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

	// Token: 0x0600C0D3 RID: 49363 RVA: 0x002B836C File Offset: 0x002B656C
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

	// Token: 0x0600C0D4 RID: 49364 RVA: 0x002B841C File Offset: 0x002B661C
	private FIntPoint GetViewportSize()
	{
		APlayerController characterController = Global.CharacterController;
		int inX = 0;
		int inY = 0;
		characterController.GetViewportSize(ref inX, ref inY);
		return new FIntPoint(inX, inY);
	}

	// Token: 0x0600C0D5 RID: 49365 RVA: 0x002B8442 File Offset: 0x002B6642
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

	// Token: 0x0600C0D6 RID: 49366 RVA: 0x002B846C File Offset: 0x002B666C
	public void ShowSequenceOnBegin()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("show", false, null, false);
	}

	// Token: 0x0600C0D7 RID: 49367 RVA: 0x002B8494 File Offset: 0x002B6694
	public UniTask PlayReleaseSequence()
	{
		ToggleActionItem.<PlayReleaseSequence>d__29 <PlayReleaseSequence>d__;
		<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayReleaseSequence>d__.<>4__this = this;
		<PlayReleaseSequence>d__.<>1__state = -1;
		<PlayReleaseSequence>d__.<>t__builder.Start<ToggleActionItem.<PlayReleaseSequence>d__29>(ref <PlayReleaseSequence>d__);
		return <PlayReleaseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C0D8 RID: 49368 RVA: 0x002B84D7 File Offset: 0x002B66D7
	public void SetRaycastTarget(bool bCheck)
	{
		base.GetRootItem().SetRaycastTarget(bCheck);
	}

	// Token: 0x0600C0D9 RID: 49369 RVA: 0x002B84E8 File Offset: 0x002B66E8
	public void PlayAppearSequence()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C0DA RID: 49370 RVA: 0x002B8510 File Offset: 0x002B6710
	public void SetPanelAlpha(float alpha)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetAlpha(alpha);
	}

	// Token: 0x0600C0DB RID: 49371 RVA: 0x002B8524 File Offset: 0x002B6724
	public UniTask PlayDisappearSequence()
	{
		ToggleActionItem.<PlayDisappearSequence>d__33 <PlayDisappearSequence>d__;
		<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDisappearSequence>d__.<>4__this = this;
		<PlayDisappearSequence>d__.<>1__state = -1;
		<PlayDisappearSequence>d__.<>t__builder.Start<ToggleActionItem.<PlayDisappearSequence>d__33>(ref <PlayDisappearSequence>d__);
		return <PlayDisappearSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C0DC RID: 49372 RVA: 0x002B8567 File Offset: 0x002B6767
	[NullableContext(1)]
	public void SetFunction(Action<bool?> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600C0DD RID: 49373 RVA: 0x002B8570 File Offset: 0x002B6770
	[NullableContext(1)]
	public UUIExtendToggle GetToggleItem()
	{
		return this.Toggle;
	}

	// Token: 0x0600C0DE RID: 49374 RVA: 0x002B8578 File Offset: 0x002B6778
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

	// Token: 0x0600C0DF RID: 49375 RVA: 0x002B85E4 File Offset: 0x002B67E4
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

	// Token: 0x0600C0E0 RID: 49376 RVA: 0x002B8888 File Offset: 0x002B6A88
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

	// Token: 0x0600C0E1 RID: 49377 RVA: 0x002B892A File Offset: 0x002B6B2A
	public void SetToggleTextGray(bool flag)
	{
		base.GetText(0).SetIsGray(flag);
	}

	// Token: 0x0600C0E2 RID: 49378 RVA: 0x002B8939 File Offset: 0x002B6B39
	[NullableContext(1)]
	public UUIText GetToggleText()
	{
		return base.GetText(0);
	}

	// Token: 0x040056B1 RID: 22193
	private const int DELAY_REFRESH_TIME = 100;

	// Token: 0x040056B2 RID: 22194
	private const int FONT_SIZE = 38;

	// Token: 0x040056B3 RID: 22195
	private const float TRACKING_ICON_SIZE = 1.2f;

	// Token: 0x040056B4 RID: 22196
	protected UUIExtendToggle Toggle;

	// Token: 0x040056B5 RID: 22197
	private UUIItem ToggleItem;

	// Token: 0x040056B6 RID: 22198
	private UUIText ToggleText;

	// Token: 0x040056B7 RID: 22199
	protected string Text;

	// Token: 0x040056B8 RID: 22200
	protected int ToggleIndexInline;

	// Token: 0x040056B9 RID: 22201
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040056BA RID: 22202
	private Action<bool?> ToggleFunction;

	// Token: 0x040056BB RID: 22203
	private float DefaultFontSize;

	// Token: 0x040056BC RID: 22204
	public float DefaultToggleItemHeight;

	// Token: 0x040056BD RID: 22205
	private UUISizeControlByOther TextSizeControlByOther;

	// Token: 0x040056BE RID: 22206
	private Ticker Ticker;

	// Token: 0x040056BF RID: 22207
	private FIntPoint? CurrentViewportSize;

	// Token: 0x040056C0 RID: 22208
	private bool IsSingleRow = true;

	// Token: 0x040056C1 RID: 22209
	private TimerHandle DelayRefreshTextHeightTimer;

	// Token: 0x040056C2 RID: 22210
	public bool IsPlayingReleaseSequence;

	// Token: 0x02007EF3 RID: 32499
	[NullableContext(0)]
	private class EToggleActionItemType
	{
		// Token: 0x040297A6 RID: 169894
		public const int ToggleText = 0;

		// Token: 0x040297A7 RID: 169895
		public const int Toggle = 1;

		// Token: 0x040297A8 RID: 169896
		public const int Texture = 2;

		// Token: 0x040297A9 RID: 169897
		public const int PanelItem = 3;
	}
}
