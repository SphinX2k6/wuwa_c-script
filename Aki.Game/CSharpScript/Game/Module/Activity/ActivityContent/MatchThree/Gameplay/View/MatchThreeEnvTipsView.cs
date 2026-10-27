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
	// Token: 0x020064D7 RID: 25815
	public class MatchThreeEnvTipsView : UiPanelBase
	{
		// Token: 0x06040C54 RID: 265300 RVA: 0x00FAF468 File Offset: 0x00FAD668
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

		// Token: 0x06040C55 RID: 265301 RVA: 0x00FAF4B0 File Offset: 0x00FAD6B0
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06040C56 RID: 265302 RVA: 0x00FAF4C3 File Offset: 0x00FAD6C3
		[NullableContext(1)]
		public void SetContent(string textId, int remainingRounds, int generateCount)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, new <>z__ReadOnlyArray<object>(new object[]
			{
				remainingRounds,
				generateCount
			}));
		}

		// Token: 0x06040C57 RID: 265303 RVA: 0x00FAF4F4 File Offset: 0x00FAD6F4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeEnvTipsView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeEnvTipsView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06040C58 RID: 265304 RVA: 0x00FAF537 File Offset: 0x00FAD737
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x04021BE3 RID: 138211
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C6D8 RID: 50904
		private enum EComponent
		{
			// Token: 0x0403C0B1 RID: 245937
			TextTip
		}
	}
}
