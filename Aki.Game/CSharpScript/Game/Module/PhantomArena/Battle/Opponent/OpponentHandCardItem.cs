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
	// Token: 0x02005292 RID: 21138
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentHandCardItem : UiPanelBase
	{
		// Token: 0x060360D8 RID: 221400 RVA: 0x00CCACC6 File Offset: 0x00CC8EC6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060360D9 RID: 221401 RVA: 0x00CCACEC File Offset: 0x00CC8EEC
		protected override void OnStart()
		{
			this.CardSequence = new UiSequencePlayer(this.RootItem);
			this.TweenLogic = new PhantomArenaCardTweenLogic();
			this.TweenLogic.Init(base.GetItem(0));
			base.GetItem(0).SetAlpha(0f);
		}

		// Token: 0x060360DA RID: 221402 RVA: 0x00CCAD38 File Offset: 0x00CC8F38
		protected override void OnBeforeDestroy()
		{
			this.TweenLogic.Destroy();
			this.CardSequence.Clear();
		}

		// Token: 0x060360DB RID: 221403 RVA: 0x00CCAD50 File Offset: 0x00CC8F50
		public void SetAreaItem(OpponentArea areaItem)
		{
			this.AreaItem = areaItem;
		}

		// Token: 0x060360DC RID: 221404 RVA: 0x00CCAD5C File Offset: 0x00CC8F5C
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

		// Token: 0x060360DD RID: 221405 RVA: 0x00CCADB0 File Offset: 0x00CC8FB0
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

		// Token: 0x060360DE RID: 221406 RVA: 0x00CCAE04 File Offset: 0x00CC9004
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

		// Token: 0x060360DF RID: 221407 RVA: 0x00CCAE50 File Offset: 0x00CC9050
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

		// Token: 0x060360E0 RID: 221408 RVA: 0x00CCAE9C File Offset: 0x00CC909C
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

		// Token: 0x060360E1 RID: 221409 RVA: 0x00CCAEE7 File Offset: 0x00CC90E7
		public void PlaySequence(string sequenceName, bool isReverse = false)
		{
			this.CardSequence.StopPrevSequence(false, true);
			this.CardSequence.PlaySequencePurely(sequenceName, false, isReverse);
		}

		// Token: 0x060360E2 RID: 221410 RVA: 0x00CCAF04 File Offset: 0x00CC9104
		public UniTask DissolveByLibrary()
		{
			OpponentHandCardItem.<DissolveByLibrary>d__14 <DissolveByLibrary>d__;
			<DissolveByLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveByLibrary>d__.<>4__this = this;
			<DissolveByLibrary>d__.<>1__state = -1;
			<DissolveByLibrary>d__.<>t__builder.Start<OpponentHandCardItem.<DissolveByLibrary>d__14>(ref <DissolveByLibrary>d__);
			return <DissolveByLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x060360E3 RID: 221411 RVA: 0x00CCAF48 File Offset: 0x00CC9148
		public UniTask PlayRemoveSequence()
		{
			OpponentHandCardItem.<PlayRemoveSequence>d__15 <PlayRemoveSequence>d__;
			<PlayRemoveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRemoveSequence>d__.<>4__this = this;
			<PlayRemoveSequence>d__.<>1__state = -1;
			<PlayRemoveSequence>d__.<>t__builder.Start<OpponentHandCardItem.<PlayRemoveSequence>d__15>(ref <PlayRemoveSequence>d__);
			return <PlayRemoveSequence>d__.<>t__builder.Task;
		}

		// Token: 0x060360E4 RID: 221412 RVA: 0x00CCAF8C File Offset: 0x00CC918C
		public UniTask PlayMoveInSequence()
		{
			OpponentHandCardItem.<PlayMoveInSequence>d__16 <PlayMoveInSequence>d__;
			<PlayMoveInSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMoveInSequence>d__.<>4__this = this;
			<PlayMoveInSequence>d__.<>1__state = -1;
			<PlayMoveInSequence>d__.<>t__builder.Start<OpponentHandCardItem.<PlayMoveInSequence>d__16>(ref <PlayMoveInSequence>d__);
			return <PlayMoveInSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0401C9EF RID: 117231
		protected PhantomArenaCardTweenLogic TweenLogic;

		// Token: 0x0401C9F0 RID: 117232
		protected UiSequencePlayer CardSequence;

		// Token: 0x0401C9F1 RID: 117233
		protected OpponentArea AreaItem;

		// Token: 0x0200B4D7 RID: 46295
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036CA8 RID: 224424
			public const int CardItem = 0;
		}
	}
}
