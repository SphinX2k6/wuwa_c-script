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
	// Token: 0x02005E39 RID: 24121
	[NullableContext(1)]
	[Nullable(0)]
	public class GroundSwordStackItem : GridProxyAbstract<ESwordStackState>
	{
		// Token: 0x0603D545 RID: 251205 RVA: 0x00EC8DAC File Offset: 0x00EC6FAC
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

		// Token: 0x0603D546 RID: 251206 RVA: 0x00EC8E36 File Offset: 0x00EC7036
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603D547 RID: 251207 RVA: 0x00EC8E49 File Offset: 0x00EC7049
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

		// Token: 0x0603D548 RID: 251208 RVA: 0x00EC8E74 File Offset: 0x00EC7074
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

		// Token: 0x0603D549 RID: 251209 RVA: 0x00EC8EA4 File Offset: 0x00EC70A4
		private void PlayTransition(ESwordStackState oldState, ESwordStackState newState)
		{
			int num = this.TransitionToken + 1;
			this.TransitionToken = num;
			int token = num;
			this.PlayTransitionAsync(oldState, newState, token).Forget();
		}

		// Token: 0x0603D54A RID: 251210 RVA: 0x00EC8ED4 File Offset: 0x00EC70D4
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

		// Token: 0x0603D54B RID: 251211 RVA: 0x00EC8F30 File Offset: 0x00EC7130
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

		// Token: 0x0401FFDB RID: 131035
		private const string SequenceFull = "Full";

		// Token: 0x0401FFDC RID: 131036
		private const string SequencePreUse = "PreUse";

		// Token: 0x0401FFDD RID: 131037
		private const string SequenceUse = "Use";

		// Token: 0x0401FFDE RID: 131038
		private const string SequenceUnlock = "Unlock";

		// Token: 0x0401FFDF RID: 131039
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401FFE0 RID: 131040
		private ESwordStackState State = ESwordStackState.Lock;

		// Token: 0x0401FFE1 RID: 131041
		private int TransitionToken;

		// Token: 0x0200C1B5 RID: 49589
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A892 RID: 239762
			SprIconNor,
			// Token: 0x0403A893 RID: 239763
			PnlLight,
			// Token: 0x0403A894 RID: 239764
			SprIconLock
		}
	}
}
