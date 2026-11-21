using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02004262 RID: 16994
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentHandCardItem : UiPanelBase
	{
		// Token: 0x0602AFD3 RID: 176083 RVA: 0x00C183CA File Offset: 0x00C165CA
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x0602AFD4 RID: 176084 RVA: 0x00C183F0 File Offset: 0x00C165F0
		protected override void OnStart()
		{
			this.CardSequence = new UiSequencePlayer(this.RootItem);
			this.TweenLogic = new PhantomArenaCardTweenLogic();
			this.TweenLogic.Init(base.GetItem(0));
			base.GetItem(0).SetAlpha(0f);
		}

		// Token: 0x0602AFD5 RID: 176085 RVA: 0x00C1843C File Offset: 0x00C1663C
		protected override void OnBeforeDestroy()
		{
			this.TweenLogic.Destroy();
			this.CardSequence.Clear();
		}

		// Token: 0x0602AFD6 RID: 176086 RVA: 0x00C18454 File Offset: 0x00C16654
		public void SetAreaItem(OpponentArea areaItem)
		{
			this.AreaItem = areaItem;
		}

		// Token: 0x0602AFD7 RID: 176087 RVA: 0x00C18460 File Offset: 0x00C16660
		public UniTask PlayStartTimeLocationTween(UUIItem fromItem, int delayTime)
		{
			OpponentHandCardItem.<PlayStartTimeLocationTween>d__8 <PlayStartTimeLocationTween>d__;
			<PlayStartTimeLocationTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartTimeLocationTween>d__.<>4__this = this;
			<PlayStartTimeLocationTween>d__.fromItem = fromItem;
			<PlayStartTimeLocationTween>d__.delayTime = delayTime;
			<PlayStartTimeLocationTween>d__.<>1__state = -1;
			<PlayStartTimeLocationTween>d__.<>t__builder.Start<OpponentHandCardItem.<PlayStartTimeLocationTween>d__8>(ref <PlayStartTimeLocationTween>d__);
			return <PlayStartTimeLocationTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFD8 RID: 176088 RVA: 0x00C184B4 File Offset: 0x00C166B4
		public UniTask PlayEndTimeLocationTween(UUIItem toItem, int delayTime)
		{
			OpponentHandCardItem.<PlayEndTimeLocationTween>d__9 <PlayEndTimeLocationTween>d__;
			<PlayEndTimeLocationTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEndTimeLocationTween>d__.<>4__this = this;
			<PlayEndTimeLocationTween>d__.toItem = toItem;
			<PlayEndTimeLocationTween>d__.delayTime = delayTime;
			<PlayEndTimeLocationTween>d__.<>1__state = -1;
			<PlayEndTimeLocationTween>d__.<>t__builder.Start<OpponentHandCardItem.<PlayEndTimeLocationTween>d__9>(ref <PlayEndTimeLocationTween>d__);
			return <PlayEndTimeLocationTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFD9 RID: 176089 RVA: 0x00C18508 File Offset: 0x00C16708
		public UniTask PlayAddCardTween(UUIItem fromItem)
		{
			OpponentHandCardItem.<PlayAddCardTween>d__10 <PlayAddCardTween>d__;
			<PlayAddCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAddCardTween>d__.<>4__this = this;
			<PlayAddCardTween>d__.fromItem = fromItem;
			<PlayAddCardTween>d__.<>1__state = -1;
			<PlayAddCardTween>d__.<>t__builder.Start<OpponentHandCardItem.<PlayAddCardTween>d__10>(ref <PlayAddCardTween>d__);
			return <PlayAddCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFDA RID: 176090 RVA: 0x00C18554 File Offset: 0x00C16754
		public UniTask PlayBackToLibraryTween(UUIItem toItem)
		{
			OpponentHandCardItem.<PlayBackToLibraryTween>d__11 <PlayBackToLibraryTween>d__;
			<PlayBackToLibraryTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackToLibraryTween>d__.<>4__this = this;
			<PlayBackToLibraryTween>d__.toItem = toItem;
			<PlayBackToLibraryTween>d__.<>1__state = -1;
			<PlayBackToLibraryTween>d__.<>t__builder.Start<OpponentHandCardItem.<PlayBackToLibraryTween>d__11>(ref <PlayBackToLibraryTween>d__);
			return <PlayBackToLibraryTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFDB RID: 176091 RVA: 0x00C185A0 File Offset: 0x00C167A0
		public UniTask PlayBackToRecycleTween(UUIItem toItem)
		{
			OpponentHandCardItem.<PlayBackToRecycleTween>d__12 <PlayBackToRecycleTween>d__;
			<PlayBackToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackToRecycleTween>d__.<>4__this = this;
			<PlayBackToRecycleTween>d__.toItem = toItem;
			<PlayBackToRecycleTween>d__.<>1__state = -1;
			<PlayBackToRecycleTween>d__.<>t__builder.Start<OpponentHandCardItem.<PlayBackToRecycleTween>d__12>(ref <PlayBackToRecycleTween>d__);
			return <PlayBackToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFDC RID: 176092 RVA: 0x00C185EB File Offset: 0x00C167EB
		public void PlaySequence(string sequenceName, bool isReverse = false)
		{
			this.CardSequence.StopPrevSequence(false, true);
			this.CardSequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x0602AFDD RID: 176093 RVA: 0x00C18608 File Offset: 0x00C16808
		public UniTask DissolveByLibrary()
		{
			OpponentHandCardItem.<DissolveByLibrary>d__14 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<OpponentHandCardItem.<DissolveByLibrary>d__14>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFDE RID: 176094 RVA: 0x00C1864C File Offset: 0x00C1684C
		public UniTask PlayRemoveSequence()
		{
			OpponentHandCardItem.<PlayRemoveSequence>d__15 <PlayRemoveSequence>d__;
			<PlayRemoveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRemoveSequence>d__.<>4__this = this;
			<PlayRemoveSequence>d__.<>1__state = -1;
			<PlayRemoveSequence>d__.<>t__builder.Start<OpponentHandCardItem.<PlayRemoveSequence>d__15>(ref <PlayRemoveSequence>d__);
			return <PlayRemoveSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFDF RID: 176095 RVA: 0x00C18690 File Offset: 0x00C16890
		public UniTask PlayMoveInSequence()
		{
			OpponentHandCardItem.<PlayMoveInSequence>d__16 <PlayMoveInSequence>d__;
			<PlayMoveInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveInSequence>d__.<>4__this = this;
			<PlayMoveInSequence>d__.<>1__state = -1;
			<PlayMoveInSequence>d__.<>t__builder.Start<OpponentHandCardItem.<PlayMoveInSequence>d__16>(ref <PlayMoveInSequence>d__);
			return <PlayMoveInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x04017424 RID: 95268
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x04017425 RID: 95269
		protected UiSequencePlayer CardSequence;

		// Token: 0x04017426 RID: 95270
		protected OpponentArea AreaItem;

		// Token: 0x02009F0F RID: 40719
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040316FB RID: 202491
			public const int CardItem = 0;
		}
	}
}
