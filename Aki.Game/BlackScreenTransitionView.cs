using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02000BC8 RID: 3016
[NullableContext(1)]
[Nullable(0)]
public class BlackScreenTransitionView : BlackScreenViewBase
{
	// Token: 0x06007D4A RID: 32074 RVA: 0x0026C710 File Offset: 0x0026A910
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

	// Token: 0x06007D4B RID: 32075 RVA: 0x0026C758 File Offset: 0x0026A958
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

	// Token: 0x06007D4C RID: 32076 RVA: 0x0026C81C File Offset: 0x0026AA1C
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

	// Token: 0x06007D4D RID: 32077 RVA: 0x0026C834 File Offset: 0x0026AA34
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

	// Token: 0x06007D4E RID: 32078 RVA: 0x0026C8D8 File Offset: 0x0026AAD8
	private void ShowWithOutAnimDelegate()
	{
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.XXJ, "开始显示黑屏", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(true);
		base.FinishShowPromise();
	}

	// Token: 0x06007D4F RID: 32079 RVA: 0x0026C914 File Offset: 0x0026AB14
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

	// Token: 0x06007D50 RID: 32080 RVA: 0x0026C978 File Offset: 0x0026AB78
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

	// Token: 0x06007D51 RID: 32081 RVA: 0x0026C9D8 File Offset: 0x0026ABD8
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

	// Token: 0x06007D52 RID: 32082 RVA: 0x0026CA48 File Offset: 0x0026AC48
	private void ApplyColor(string colorType)
	{
		FColor color = (colorType == "White") ? ColorUtils.ColorWhile : ColorUtils.ColorBlack;
		base.GetTexture(0).SetColor(color);
	}

	// Token: 0x06007D53 RID: 32083 RVA: 0x0026CA7C File Offset: 0x0026AC7C
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

	// Token: 0x06007D54 RID: 32084 RVA: 0x0026CACC File Offset: 0x0026ACCC
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

	// Token: 0x06007D55 RID: 32085 RVA: 0x0026CB14 File Offset: 0x0026AD14
	public override void CompleteShowImmediately()
	{
		if (!(this.ShowAnimType == "None"))
		{
			CustomPromise showPromise = base.ShowPromise;
			if (showPromise != null && showPromise.IsPending && this.LevelSequencePlayer != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BlackScreen;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "无动画打开请求,立即完成显示动画";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", this.ShowAnimType);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.LevelSequencePlayer.StopCurrentSequence(true, true);
				base.GetTexture(0).SetAlpha(1f);
				return;
			}
		}
	}

	// Token: 0x04004DE8 RID: 19944
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004DE9 RID: 19945
	private string ShowAnimType = "None";

	// Token: 0x04004DEA RID: 19946
	private string HideAnimType = "None";

	// Token: 0x04004DEB RID: 19947
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();

	// Token: 0x02006E49 RID: 28233
	[NullableContext(0)]
	private static class ECompDefine
	{
		// Token: 0x040241F6 RID: 147958
		public const int BlackTexture = 0;
	}
}
