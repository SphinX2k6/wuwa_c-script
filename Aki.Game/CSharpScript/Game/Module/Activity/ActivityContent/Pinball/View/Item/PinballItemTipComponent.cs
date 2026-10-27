using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x0200634D RID: 25421
	public class PinballItemTipComponent : UiPanelBase, IItemTipsUiProxy
	{
		// Token: 0x0603FF84 RID: 262020 RVA: 0x00F79FD0 File Offset: 0x00F781D0
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

		// Token: 0x0603FF85 RID: 262021 RVA: 0x00F7A018 File Offset: 0x00F78218
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemTipComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemTipComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF86 RID: 262022 RVA: 0x00F7A05B File Offset: 0x00F7825B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603FF87 RID: 262023 RVA: 0x00F7A06E File Offset: 0x00F7826E
		protected override void OnBeforeShow()
		{
			this.PlayStartSequence();
		}

		// Token: 0x0603FF88 RID: 262024 RVA: 0x00F7A078 File Offset: 0x00F78278
		private void PlayStartSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603FF89 RID: 262025 RVA: 0x00F7A0A8 File Offset: 0x00F782A8
		public UniTask PlayCloseSequence()
		{
			PinballItemTipComponent.<PlayCloseSequence>d__8 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<PinballItemTipComponent.<PlayCloseSequence>d__8>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603FF8A RID: 262026 RVA: 0x00F7A0EB File Offset: 0x00F782EB
		[NullableContext(1)]
		public void Refresh(ItemTipsData data)
		{
			PinballItemTipsComponentContentComponent content = this.Content;
			if (content == null)
			{
				return;
			}
			content.Refresh(data);
		}

		// Token: 0x040215B0 RID: 136624
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040215B1 RID: 136625
		[Nullable(2)]
		private PinballItemTipsComponentContentComponent Content;

		// Token: 0x0200C567 RID: 50535
		private enum EPinballItemTipComponent
		{
			// Token: 0x0403B94B RID: 244043
			Item
		}
	}
}
