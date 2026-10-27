using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02001710 RID: 5904
[NullableContext(1)]
[Nullable(0)]
public class BlackScreenTransitionView : BlackScreenViewBase
{
	// Token: 0x0600A969 RID: 43369 RVA: 0x0026224C File Offset: 0x0026044C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A96A RID: 43370 RVA: 0x00262294 File Offset: 0x00260494
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseEvent), false);
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.ShowWithOutAnim, new Action(this.ShowWithOutAnimDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Show, new Action(this.ShowDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.HideWithOutAnim, new Action(this.HideWithOutAnimDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Hide, new Action(this.HideDelegate));
		base.GetTexture(0).SetAlpha(1f);
		LguiUtil.Instance.SetActorIsPermanent(this.RootActor, true, true);
		this.ViewData.TriggerCurrentStateDelegate();
	}

	// Token: 0x0600A96B RID: 43371 RVA: 0x00262358 File Offset: 0x00260558
	protected override void OnBeforeDestroy()
	{
		base.ResetPromiseData();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x0600A96C RID: 43372 RVA: 0x00262370 File Offset: 0x00260570
	private void OnCloseEvent(string sequenceName)
	{
		if (sequenceName == this.ShowAnimType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "开始动画结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", sequenceName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishShowPromise();
			return;
		}
		if (sequenceName == this.HideAnimType)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BlackScreen;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "关闭动画结束";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("动画名称", sequenceName);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishHidePromise();
			base.GetTexture(0).SetAlpha(1f);
			base.SetUiActive(false);
		}
	}

	// Token: 0x0600A96D RID: 43373 RVA: 0x00262414 File Offset: 0x00260614
	private void ShowWithOutAnimDelegate()
	{
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.XXJ, "开始显示黑屏", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(true);
		base.FinishShowPromise();
	}

	// Token: 0x0600A96E RID: 43374 RVA: 0x00262450 File Offset: 0x00260650
	private void ShowDelegate()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "开始显示黑屏";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", this.ShowAnimType);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName(this.ShowAnimType, false, null, false);
	}

	// Token: 0x0600A96F RID: 43375 RVA: 0x002624B4 File Offset: 0x002606B4
	private void HideWithOutAnimDelegate()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(true, true);
		}
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.XXJ, "开始隐藏黑屏", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.GetTexture(0).SetAlpha(1f);
		base.SetUiActive(false);
		base.FinishHidePromise();
	}

	// Token: 0x0600A970 RID: 43376 RVA: 0x00262514 File Offset: 0x00260714
	private void HideDelegate()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(true, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "开始隐藏黑屏";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", this.HideAnimType);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName(this.HideAnimType, false, null, false);
	}

	// Token: 0x0600A971 RID: 43377 RVA: 0x00262584 File Offset: 0x00260784
	private void ApplyColor(string colorType)
	{
		FColor color = (colorType == "White") ? ColorUtils.ColorWhile : ColorUtils.ColorBlack;
		base.GetTexture(0).SetColor(color);
	}

	// Token: 0x0600A972 RID: 43378 RVA: 0x002625B8 File Offset: 0x002607B8
	public override void ShowTemp(string showAnimType, string colorType)
	{
		base.CreateShowPromise();
		string showAnimType2 = this.ShowAnimType;
		this.ShowAnimType = showAnimType;
		this.ApplyColor(colorType);
		bool flag = showAnimType != "None";
		if (!this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Show : BlackScreenViewData.EState.ShowWithOutAnim))
		{
			this.ShowAnimType = showAnimType2;
		}
	}

	// Token: 0x0600A973 RID: 43379 RVA: 0x00262608 File Offset: 0x00260808
	public override void HideTemp(string hideAnimType)
	{
		base.CreateHidePromise();
		string hideAnimType2 = this.HideAnimType;
		this.HideAnimType = hideAnimType;
		bool flag = hideAnimType != "None";
		if (!this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Hide : BlackScreenViewData.EState.HideWithOutAnim))
		{
			this.HideAnimType = hideAnimType2;
		}
	}

	// Token: 0x04004D40 RID: 19776
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004D41 RID: 19777
	private string ShowAnimType = "None";

	// Token: 0x04004D42 RID: 19778
	private string HideAnimType = "None";

	// Token: 0x04004D43 RID: 19779
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();

	// Token: 0x02007CC4 RID: 31940
	[NullableContext(0)]
	private static class ECompDefine
	{
		// Token: 0x04028ECD RID: 167629
		public const int BlackTexture = 0;
	}
}
