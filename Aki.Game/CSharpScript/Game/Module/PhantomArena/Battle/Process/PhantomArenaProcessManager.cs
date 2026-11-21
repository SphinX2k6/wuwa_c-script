using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Process
{
	// Token: 0x0200425C RID: 16988
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaProcessManager
	{
		// Token: 0x1700563D RID: 22077
		// (get) Token: 0x0602AF5E RID: 175966 RVA: 0x00C167ED File Offset: 0x00C149ED
		public EPlayingCardProcessState State
		{
			get
			{
				return this.StateInternal;
			}
		}

		// Token: 0x1700563E RID: 22078
		// (get) Token: 0x0602AF5F RID: 175967 RVA: 0x00C167F5 File Offset: 0x00C149F5
		public bool IsInOwnPlaying
		{
			get
			{
				return this.StateInternal == EPlayingCardProcessState.OwnPlaying;
			}
		}

		// Token: 0x1700563F RID: 22079
		// (get) Token: 0x0602AF60 RID: 175968 RVA: 0x00C16801 File Offset: 0x00C14A01
		public bool IsNotInOwnPlaying
		{
			get
			{
				return this.StateInternal < EPlayingCardProcessState.OwnPlaying;
			}
		}

		// Token: 0x0602AF61 RID: 175969 RVA: 0x00C16810 File Offset: 0x00C14A10
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

		// Token: 0x0602AF62 RID: 175970 RVA: 0x00C16924 File Offset: 0x00C14B24
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

		// Token: 0x0602AF63 RID: 175971 RVA: 0x00C16A3C File Offset: 0x00C14C3C
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

		// Token: 0x0602AF64 RID: 175972 RVA: 0x00C16A88 File Offset: 0x00C14C88
		private UniTask HandleStateList()
		{
			PhantomArenaProcessManager.<HandleStateList>d__16 <HandleStateList>d__;
			<HandleStateList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleStateList>d__.<>4__this = this;
			<HandleStateList>d__.<>1__state = -1;
			<HandleStateList>d__.<>t__builder.Start<PhantomArenaProcessManager.<HandleStateList>d__16>(ref <HandleStateList>d__);
			return <HandleStateList>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF65 RID: 175973 RVA: 0x00C16ACB File Offset: 0x00C14CCB
		public void SetState(EPlayingCardProcessState state)
		{
			this.SetStateAsync(state).Forget();
		}

		// Token: 0x0602AF66 RID: 175974 RVA: 0x00C16AD9 File Offset: 0x00C14CD9
		public void Clear()
		{
			this.PendingList.Clear();
			this.StateMap.Clear();
			this.IsClear = true;
		}

		// Token: 0x04017400 RID: 95232
		private readonly Dictionary<EPlayingCardProcessState, Func<UniTask>> StateMap = new Dictionary<EPlayingCardProcessState, Func<UniTask>>();

		// Token: 0x04017401 RID: 95233
		private readonly List<EPlayingCardProcessState> PendingList = new List<EPlayingCardProcessState>();

		// Token: 0x04017402 RID: 95234
		private bool IsInPending;

		// Token: 0x04017403 RID: 95235
		private bool IsClear;

		// Token: 0x04017404 RID: 95236
		private readonly Dictionary<EPlayingCardProcessState, List<EPlayingCardProcessState>> StateParentMap;

		// Token: 0x04017405 RID: 95237
		private EPlayingCardProcessState StateInternal;

		// Token: 0x04017406 RID: 95238
		protected PhantomArenaBattleProxy Proxy;
	}
}
