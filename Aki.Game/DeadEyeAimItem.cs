using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A7C RID: 6780
[NullableContext(1)]
[Nullable(0)]
public class DeadEyeAimItem : UiPanelBase
{
	// Token: 0x0600C7B2 RID: 51122 RVA: 0x002D7AF4 File Offset: 0x002D5CF4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7B3 RID: 51123 RVA: 0x002D7B3C File Offset: 0x002D5D3C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		item.SetUIActive(true);
		this.Size.Set((double)item.Width, (double)item.Height);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600C7B4 RID: 51124 RVA: 0x002D7B9C File Offset: 0x002D5D9C
	protected override void OnAfterShow()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C7B5 RID: 51125 RVA: 0x002D7BCC File Offset: 0x002D5DCC
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeAimItem.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeAimItem.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7B6 RID: 51126 RVA: 0x002D7C0F File Offset: 0x002D5E0F
	public Vector2D GetAimRange()
	{
		return this.Size;
	}

	// Token: 0x0600C7B7 RID: 51127 RVA: 0x002D7C18 File Offset: 0x002D5E18
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			DeadEyeModeModel.Instance.ViewStartSequenceFinish = true;
			Log.Instance.Info(ELogModule.DeadEye, ELogAuthor.YSQ, "死眼玩法：播放AimItem动画完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x04005C38 RID: 23608
	private readonly Vector2D Size = Vector2D.Create();

	// Token: 0x04005C39 RID: 23609
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02007FC9 RID: 32713
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04029B89 RID: 170889
		public const int NormalItem = 0;
	}
}
