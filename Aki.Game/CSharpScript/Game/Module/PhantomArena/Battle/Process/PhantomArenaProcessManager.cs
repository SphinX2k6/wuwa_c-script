using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Process
{
	// Token: 0x0200528C RID: 21132
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaProcessManager
	{
		// Token: 0x1700827D RID: 33405
		// (get) Token: 0x06036063 RID: 221283 RVA: 0x00CC90E9 File Offset: 0x00CC72E9
		public EPlayingCardProcessState State
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x1700827E RID: 33406
		// (get) Token: 0x06036064 RID: 221284 RVA: 0x00CC90F1 File Offset: 0x00CC72F1
		public bool IsInOwnPlaying
		{
			get
			{
				return this.StateInternal == EPlayingCardProcessState.OwnPlaying;
			}
		}

		// Token: 0x1700827F RID: 33407
		// (get) Token: 0x06036065 RID: 221285 RVA: 0x00CC90FD File Offset: 0x00CC72FD
		public bool IsNotInOwnPlaying
		{
			get
			{
				return this.StateInternal < EPlayingCardProcessState.OwnPlaying;
			}
		}

		// Token: 0x06036066 RID: 221286 RVA: 0x00CC910C File Offset: 0x00CC730C
		public PhantomArenaProcessManager(PhantomArenaBattleProxy proxy)
		{
			Dictionary<EPlayingCardProcessState, List<EPlayingCardProcessState>> dictionary = new Dictionary<EPlayingCardProcessState, List<EPlayingCardProcessState>>();
			dictionary[EPlayingCardProcessState.OwnChangeCard] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.TimeStart
			};
			dictionary[EPlayingCardProcessState.BothDrawCard] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OwnChangeCard,
				EPlayingCardProcessState.TimeStart
			};
			dictionary[EPlayingCardProcessState.OpponentTimeStart] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.BothDrawCard
			};
			dictionary[EPlayingCardProcessState.OpponentPlaying] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OpponentTimeStart
			};
			dictionary[EPlayingCardProcessState.GameOverByOpponent] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OpponentPlaying
			};
			dictionary[EPlayingCardProcessState.OwnTimeStart] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OpponentPlaying,
				EPlayingCardProcessState.GameOverByOpponent
			};
			dictionary[EPlayingCardProcessState.ShowOwnCoreCard] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OwnTimeStart
			};
			dictionary[EPlayingCardProcessState.OwnPlaying] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OwnTimeStart,
				EPlayingCardProcessState.ShowOwnCoreCard
			};
			dictionary[EPlayingCardProcessState.TimeEnd] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.OwnPlaying
			};
			dictionary[EPlayingCardProcessState.JumpLoading] = new List<EPlayingCardProcessState>
			{
				EPlayingCardProcessState.TimeEnd
			};
			this.StateParentMap = dictionary;
			base..ctor();
			this.Proxy = proxy;
		}

		// Token: 0x06036067 RID: 221287 RVA: 0x00CC9220 File Offset: 0x00CC7420
		public void InitStateMap()
		{
			this.StateMap[EPlayingCardProcessState.TimeStart] = delegate()
			{
				this.Proxy.ShowTimeStart();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.OwnChangeCard] = delegate()
			{
				this.Proxy.ShowOwnChangeCard();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.BothDrawCard] = (() => this.Proxy.ShowBothDrawCard());
			this.StateMap[EPlayingCardProcessState.OpponentTimeStart] = delegate()
			{
				this.Proxy.ShowOpponentStartPanel();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.OpponentPlaying] = (() => this.Proxy.StartAiOperation());
			this.StateMap[EPlayingCardProcessState.GameOverByOpponent] = delegate()
			{
				this.Proxy.ShowGameOver();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.OwnTimeStart] = delegate()
			{
				this.Proxy.ShowOwnStartPanel();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.ShowOwnCoreCard] = delegate()
			{
				this.Proxy.ShowOwnCoreCard();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.OwnPlaying] = delegate()
			{
				this.Proxy.ShowOwnPlaying();
				return UniTask.CompletedTask;
			};
			this.StateMap[EPlayingCardProcessState.TimeEnd] = (() => this.Proxy.RoundOver());
			this.StateMap[EPlayingCardProcessState.JumpLoading] = delegate()
			{
				this.Proxy.JumpLoading();
				return UniTask.CompletedTask;
			};
		}

		// Token: 0x06036068 RID: 221288 RVA: 0x00CC9338 File Offset: 0x00CC7538
		private UniTask SetStateAsync(EPlayingCardProcessState state)
		{
			PhantomArenaProcessManager.<SetStateAsync>d__15 <SetStateAsync>d__;
			<SetStateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetStateAsync>d__.<>4__this = this;
			<SetStateAsync>d__.state = state;
			<SetStateAsync>d__.<>1__state = -1;
			<SetStateAsync>d__.<>t__builder.Start<PhantomArenaProcessManager.<SetStateAsync>d__15>(ref <SetStateAsync>d__);
			return <SetStateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036069 RID: 221289 RVA: 0x00CC9384 File Offset: 0x00CC7584
		private UniTask HandleStateList()
		{
			PhantomArenaProcessManager.<HandleStateList>d__16 <HandleStateList>d__;
			<HandleStateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleStateList>d__.<>4__this = this;
			<HandleStateList>d__.<>1__state = -1;
			<HandleStateList>d__.<>t__builder.Start<PhantomArenaProcessManager.<HandleStateList>d__16>(ref <HandleStateList>d__);
			return <HandleStateList>d__.<>t__builder.Task;
		}

		// Token: 0x0603606A RID: 221290 RVA: 0x00CC93C7 File Offset: 0x00CC75C7
		public void SetState(EPlayingCardProcessState state)
		{
			this.SetStateAsync(state).Forget();
		}

		// Token: 0x0603606B RID: 221291 RVA: 0x00CC93D5 File Offset: 0x00CC75D5
		public void Clear()
		{
			this.PendingList.Clear();
			this.StateMap.Clear();
			this.IsClear = true;
		}

		// Token: 0x0401C9CB RID: 117195
		private readonly Dictionary<EPlayingCardProcessState, Func<UniTask>> StateMap = new Dictionary<EPlayingCardProcessState, Func<UniTask>>();

		// Token: 0x0401C9CC RID: 117196
		private readonly List<EPlayingCardProcessState> PendingList = new List<EPlayingCardProcessState>();

		// Token: 0x0401C9CD RID: 117197
		private bool IsInPending;

		// Token: 0x0401C9CE RID: 117198
		private bool IsClear;

		// Token: 0x0401C9CF RID: 117199
		private readonly Dictionary<EPlayingCardProcessState, List<EPlayingCardProcessState>> StateParentMap;

		// Token: 0x0401C9D0 RID: 117200
		private EPlayingCardProcessState StateInternal;

		// Token: 0x0401C9D1 RID: 117201
		protected PhantomArenaBattleProxy Proxy;
	}
}
