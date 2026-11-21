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
	// Token: 0x020052CB RID: 21195
	public class PinballItemTipComponent : UiPanelBase, IItemTipsUiProxy
	{
		// Token: 0x06034C45 RID: 216133 RVA: 0x00EC0F30 File Offset: 0x00EBF130
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

		// Token: 0x06034C46 RID: 216134 RVA: 0x00EC0F78 File Offset: 0x00EBF178
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemTipComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemTipComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034C47 RID: 216135 RVA: 0x00EC0FBB File Offset: 0x00EBF1BB
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06034C48 RID: 216136 RVA: 0x00EC0FCE File Offset: 0x00EBF1CE
		protected override void OnBeforeShow()
		{
			this.PlayStartSequence();
		}

		// Token: 0x06034C49 RID: 216137 RVA: 0x00EC0FD8 File Offset: 0x00EBF1D8
		private void PlayStartSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06034C4A RID: 216138 RVA: 0x00EC1008 File Offset: 0x00EBF208
		public UniTask PlayCloseSequence()
		{
			PinballItemTipComponent.<PlayCloseSequence>d__8 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<PinballItemTipComponent.<PlayCloseSequence>d__8>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06034C4B RID: 216139 RVA: 0x00EC104B File Offset: 0x00EBF24B
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

		// Token: 0x0401BEDF RID: 114399
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401BEE0 RID: 114400
		[Nullable(2)]
		private PinballItemTipsComponentContentComponent Content;

		// Token: 0x0200AF4E RID: 44878
		private enum EPinballItemTipComponent
		{
			// Token: 0x040362AD RID: 221869
			Item
		}
	}
}
