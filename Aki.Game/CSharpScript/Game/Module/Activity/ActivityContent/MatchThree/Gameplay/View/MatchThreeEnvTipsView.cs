using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005455 RID: 21589
	public class MatchThreeEnvTipsView : UiPanelBase
	{
		// Token: 0x06035918 RID: 219416 RVA: 0x00EF64B0 File Offset: 0x00EF46B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035919 RID: 219417 RVA: 0x00EF64F8 File Offset: 0x00EF46F8
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x0603591A RID: 219418 RVA: 0x00EF650B File Offset: 0x00EF470B
		[NullableContext(1)]
		public void SetContent(string textId, int remainingRounds, int generateCount)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, new <>z__ReadOnlyArray<object>(new object[]
			{
				remainingRounds,
				generateCount
			}));
		}

		// Token: 0x0603591B RID: 219419 RVA: 0x00EF653C File Offset: 0x00EF473C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeEnvTipsView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeEnvTipsView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603591C RID: 219420 RVA: 0x00EF657F File Offset: 0x00EF477F
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401C514 RID: 115988
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B0BE RID: 45246
		private enum EComponent
		{
			// Token: 0x04036A0C RID: 223756
			TextTip
		}
	}
}
