using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E1E RID: 19998
	[NullableContext(1)]
	[Nullable(0)]
	public class GroundSwordStackItem : GridProxyAbstract<ESwordStackState>
	{
		// Token: 0x060324D5 RID: 206037 RVA: 0x00E1A318 File Offset: 0x00E18518
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060324D6 RID: 206038 RVA: 0x00E1A3A2 File Offset: 0x00E185A2
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060324D7 RID: 206039 RVA: 0x00E1A3B5 File Offset: 0x00E185B5
		protected override void OnBeforeDestroy()
		{
			this.TransitionToken++;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060324D8 RID: 206040 RVA: 0x00E1A3E0 File Offset: 0x00E185E0
		public override void Refresh(ESwordStackState data, bool isSelected, int gridIndex)
		{
			if (this.State == data)
			{
				return;
			}
			ESwordStackState state = this.State;
			this.State = data;
			this.PlayTransition(state, data);
		}

		// Token: 0x060324D9 RID: 206041 RVA: 0x00E1A410 File Offset: 0x00E18610
		private void PlayTransition(ESwordStackState oldState, ESwordStackState newState)
		{
			int num = this.TransitionToken + 1;
			this.TransitionToken = num;
			int token = num;
			this.PlayTransitionAsync(oldState, newState, token).Forget();
		}

		// Token: 0x060324DA RID: 206042 RVA: 0x00E1A440 File Offset: 0x00E18640
		private UniTask PlayTransitionAsync(ESwordStackState oldState, ESwordStackState newState, int token)
		{
			GroundSwordStackItem.<PlayTransitionAsync>d__13 <PlayTransitionAsync>d__;
			<PlayTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTransitionAsync>d__.<>4__this = this;
			<PlayTransitionAsync>d__.oldState = oldState;
			<PlayTransitionAsync>d__.newState = newState;
			<PlayTransitionAsync>d__.token = token;
			<PlayTransitionAsync>d__.<>1__state = -1;
			<PlayTransitionAsync>d__.<>t__builder.Start<GroundSwordStackItem.<PlayTransitionAsync>d__13>(ref <PlayTransitionAsync>d__);
			return <PlayTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060324DB RID: 206043 RVA: 0x00E1A49C File Offset: 0x00E1869C
		[NullableContext(0)]
		private UniTask<bool> PlaySequenceAsync([Nullable(1)] string sequenceName, int token)
		{
			GroundSwordStackItem.<PlaySequenceAsync>d__14 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.token = token;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<GroundSwordStackItem.<PlaySequenceAsync>d__14>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401AAA2 RID: 109218
		private const string SequenceFull = "Full";

		// Token: 0x0401AAA3 RID: 109219
		private const string SequencePreUse = "PreUse";

		// Token: 0x0401AAA4 RID: 109220
		private const string SequenceUse = "Use";

		// Token: 0x0401AAA5 RID: 109221
		private const string SequenceUnlock = "Unlock";

		// Token: 0x0401AAA6 RID: 109222
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401AAA7 RID: 109223
		private ESwordStackState State = ESwordStackState.Lock;

		// Token: 0x0401AAA8 RID: 109224
		private int TransitionToken;

		// Token: 0x0200ABC4 RID: 43972
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035284 RID: 217732
			SprIconNor,
			// Token: 0x04035285 RID: 217733
			PnlLight,
			// Token: 0x04035286 RID: 217734
			SprIconLock
		}
	}
}
