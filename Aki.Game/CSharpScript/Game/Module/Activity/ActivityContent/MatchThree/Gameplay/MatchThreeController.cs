using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064AA RID: 25770
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class MatchThreeController : ControllerBase
	{
		// Token: 0x170094B9 RID: 38073
		// (get) Token: 0x06040B5E RID: 265054 RVA: 0x00FAA9C4 File Offset: 0x00FA8BC4
		// (set) Token: 0x06040B5F RID: 265055 RVA: 0x00FAA9CC File Offset: 0x00FA8BCC
		public MatchThreeGameplayContext Context { get; private set; }

		// Token: 0x170094BA RID: 38074
		// (get) Token: 0x06040B60 RID: 265056 RVA: 0x00FAA9D5 File Offset: 0x00FA8BD5
		// (set) Token: 0x06040B61 RID: 265057 RVA: 0x00FAA9DD File Offset: 0x00FA8BDD
		public MatchThreePresenter CurrentPresenter { get; private set; }

		// Token: 0x06040B62 RID: 265058 RVA: 0x00FAA9E8 File Offset: 0x00FA8BE8
		[NullableContext(1)]
		public void Start(MatchThreeGameplayContext context)
		{
			if (this.CurrentPresenter != null || this.Context != null)
			{
				return;
			}
			this.ClearSettlementState(false);
			this.Context = context;
			MatchThreeGame matchThreeGame = MatchThreeGame.Create(context.LevelId, context.RoleId, 0);
			if (matchThreeGame == null)
			{
				this.Context = null;
				return;
			}
			this.CurrentPresenter = new MatchThreePresenter(matchThreeGame);
			UiManager.Instance.OpenView(EUiViewName.MatchThreeGameplayView, this.CurrentPresenter, null);
		}

		// Token: 0x06040B63 RID: 265059 RVA: 0x00FAAA54 File Offset: 0x00FA8C54
		[NullableContext(1)]
		public void SubmitResult(Dictionary<EGoalCondType, int> results)
		{
			MatchThreeGameplayContext context = this.Context;
			if (context == null)
			{
				return;
			}
			UniTaskCompletionSource<bool> completionSource = new UniTaskCompletionSource<bool>();
			this.SettlementContext = context;
			this.SettlementCompletionSource = completionSource;
			if (context.IsGm)
			{
				completionSource.TrySetResult(true);
				return;
			}
			ActivityMatchThreeController.Instance.SendCompleteRequest(context.LevelId, context.TraceId, results, delegate(bool success)
			{
				completionSource.TrySetResult(success);
			});
		}

		// Token: 0x06040B64 RID: 265060 RVA: 0x00FAAACC File Offset: 0x00FA8CCC
		[NullableContext(0)]
		public UniTask<bool> PrepareRetryAfterWinAsync()
		{
			MatchThreeController.<PrepareRetryAfterWinAsync>d__13 <PrepareRetryAfterWinAsync>d__;
			<PrepareRetryAfterWinAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareRetryAfterWinAsync>d__.<>4__this = this;
			<PrepareRetryAfterWinAsync>d__.<>1__state = -1;
			<PrepareRetryAfterWinAsync>d__.<>t__builder.Start<MatchThreeController.<PrepareRetryAfterWinAsync>d__13>(ref <PrepareRetryAfterWinAsync>d__);
			return <PrepareRetryAfterWinAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040B65 RID: 265061 RVA: 0x00FAAB0F File Offset: 0x00FA8D0F
		public void RetryAfterWinAfterClose()
		{
			this.CompleteRetryAfterWinAsync().Forget();
		}

		// Token: 0x06040B66 RID: 265062 RVA: 0x00FAAB1C File Offset: 0x00FA8D1C
		private UniTask CompleteRetryAfterWinAsync()
		{
			MatchThreeController.<CompleteRetryAfterWinAsync>d__15 <CompleteRetryAfterWinAsync>d__;
			<CompleteRetryAfterWinAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CompleteRetryAfterWinAsync>d__.<>4__this = this;
			<CompleteRetryAfterWinAsync>d__.<>1__state = -1;
			<CompleteRetryAfterWinAsync>d__.<>t__builder.Start<MatchThreeController.<CompleteRetryAfterWinAsync>d__15>(ref <CompleteRetryAfterWinAsync>d__);
			return <CompleteRetryAfterWinAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040B67 RID: 265063 RVA: 0x00FAAB60 File Offset: 0x00FA8D60
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<string> RequestStartTraceIdAsync(int levelId, int roleId)
		{
			MatchThreeController.<RequestStartTraceIdAsync>d__16 <RequestStartTraceIdAsync>d__;
			<RequestStartTraceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
			<RequestStartTraceIdAsync>d__.levelId = levelId;
			<RequestStartTraceIdAsync>d__.roleId = roleId;
			<RequestStartTraceIdAsync>d__.<>1__state = -1;
			<RequestStartTraceIdAsync>d__.<>t__builder.Start<MatchThreeController.<RequestStartTraceIdAsync>d__16>(ref <RequestStartTraceIdAsync>d__);
			return <RequestStartTraceIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040B68 RID: 265064 RVA: 0x00FAABAB File Offset: 0x00FA8DAB
		public void Restart(bool lowerDifficulty = false)
		{
			MatchThreePresenter currentPresenter = this.CurrentPresenter;
			if (currentPresenter == null)
			{
				return;
			}
			currentPresenter.RestartAsync(lowerDifficulty).Forget<bool>();
		}

		// Token: 0x06040B69 RID: 265065 RVA: 0x00FAABC3 File Offset: 0x00FA8DC3
		public void Rewind(int turns = 1)
		{
			MatchThreePresenter currentPresenter = this.CurrentPresenter;
			if (currentPresenter == null)
			{
				return;
			}
			currentPresenter.RewindAsync(turns).Forget();
		}

		// Token: 0x06040B6A RID: 265066 RVA: 0x00FAABDB File Offset: 0x00FA8DDB
		public void End(bool closeGameplayView = true)
		{
			MatchThreePresenter currentPresenter = this.CurrentPresenter;
			if (currentPresenter != null)
			{
				currentPresenter.Dispose();
			}
			this.CurrentPresenter = null;
			this.Context = null;
			this.ClearSettlementState(true);
			if (closeGameplayView)
			{
				UiManager.Instance.CloseView(EUiViewName.MatchThreeGameplayView, null);
			}
		}

		// Token: 0x06040B6B RID: 265067 RVA: 0x00FAAC16 File Offset: 0x00FA8E16
		private void ClearSettlementState(bool cancelPending)
		{
			if (cancelPending)
			{
				UniTaskCompletionSource<bool> settlementCompletionSource = this.SettlementCompletionSource;
				if (settlementCompletionSource != null)
				{
					settlementCompletionSource.TrySetResult(false);
				}
			}
			this.SettlementCompletionSource = null;
			this.SettlementContext = null;
			this.PendingRetryContext = null;
		}

		// Token: 0x170094BB RID: 38075
		// (get) Token: 0x06040B6C RID: 265068 RVA: 0x00FAAC43 File Offset: 0x00FA8E43
		[Nullable(1)]
		public static MatchThreeController Instance
		{
			[NullableContext(1)]
			get
			{
				return MatchThreeController._Instance;
			}
		}

		// Token: 0x06040B6D RID: 265069 RVA: 0x00FAAC4A File Offset: 0x00FA8E4A
		[NullableContext(1)]
		public static MatchThreeController GetOrCreateInstance()
		{
			if (MatchThreeController._Instance == null)
			{
				MatchThreeController.CreateInstance();
			}
			return MatchThreeController._Instance;
		}

		// Token: 0x06040B6E RID: 265070 RVA: 0x00FAAC5E File Offset: 0x00FA8E5E
		public static bool CreateInstance()
		{
			if (MatchThreeController._Instance != null)
			{
				return true;
			}
			MatchThreeController._Instance = new MatchThreeController();
			return true;
		}

		// Token: 0x06040B6F RID: 265071 RVA: 0x00FAAC74 File Offset: 0x00FA8E74
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040B70 RID: 265072 RVA: 0x00FAAC76 File Offset: 0x00FA8E76
		public static void ResetStaticDefaultValue()
		{
			MatchThreeController._Instance = null;
		}

		// Token: 0x06040B71 RID: 265073 RVA: 0x00FAAC7E File Offset: 0x00FA8E7E
		static MatchThreeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatchThreeController.CreateStaticDefaultValue), new Action(MatchThreeController.ResetStaticDefaultValue));
		}

		// Token: 0x04021ACB RID: 137931
		private UniTaskCompletionSource<bool> SettlementCompletionSource;

		// Token: 0x04021ACC RID: 137932
		private MatchThreeGameplayContext SettlementContext;

		// Token: 0x04021ACD RID: 137933
		private MatchThreeGameplayContext PendingRetryContext;

		// Token: 0x04021ACE RID: 137934
		private static MatchThreeController _Instance;
	}
}
