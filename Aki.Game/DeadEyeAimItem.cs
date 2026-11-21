using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F3B RID: 3899
[NullableContext(1)]
[Nullable(0)]
public class DeadEyeAimItem : UiPanelBase
{
	// Token: 0x06009BC2 RID: 39874 RVA: 0x002E2C10 File Offset: 0x002E0E10
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

	// Token: 0x06009BC3 RID: 39875 RVA: 0x002E2C58 File Offset: 0x002E0E58
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		item.SetUIActive(true);
		this.Size.Set((double)item.Width, (double)item.Height);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x06009BC4 RID: 39876 RVA: 0x002E2CB8 File Offset: 0x002E0EB8
	protected override void OnAfterShow()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06009BC5 RID: 39877 RVA: 0x002E2CE8 File Offset: 0x002E0EE8
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeAimItem.<OnBeforeHideAsync>d__6 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeAimItem.<OnBeforeHideAsync>d__6>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BC6 RID: 39878 RVA: 0x002E2D2B File Offset: 0x002E0F2B
	public Vector2D GetAimRange()
	{
		return this.Size;
	}

	// Token: 0x06009BC7 RID: 39879 RVA: 0x002E2D34 File Offset: 0x002E0F34
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			DeadEyeModeModel.Instance.ViewStartSequenceFinish = true;
			Log.Instance.Info(ELogModule.DeadEye, ELogAuthor.YSQ, "死眼玩法：播放AimItem动画完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x04005D07 RID: 23815
	private readonly Vector2D Size = Vector2D.Create();

	// Token: 0x04005D08 RID: 23816
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02007158 RID: 29016
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04024EC6 RID: 151238
		public const int NormalItem = 0;
	}
}
