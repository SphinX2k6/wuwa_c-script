using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005428 RID: 21544
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class MatchThreeController : ControllerBase
	{
		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x06035822 RID: 219170 RVA: 0x00EF1A0C File Offset: 0x00EEFC0C
		// (set) Token: 0x06035823 RID: 219171 RVA: 0x00EF1A14 File Offset: 0x00EEFC14
		public MatchThreeGameplayContext Context { get; private set; }

		// Token: 0x1700681C RID: 26652
		// (get) Token: 0x06035824 RID: 219172 RVA: 0x00EF1A1D File Offset: 0x00EEFC1D
		// (set) Token: 0x06035825 RID: 219173 RVA: 0x00EF1A25 File Offset: 0x00EEFC25
		public MatchThreePresenter CurrentPresenter { get; private set; }

		// Token: 0x06035826 RID: 219174 RVA: 0x00EF1A30 File Offset: 0x00EEFC30
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

		// Token: 0x06035827 RID: 219175 RVA: 0x00EF1A9C File Offset: 0x00EEFC9C
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

		// Token: 0x06035828 RID: 219176 RVA: 0x00EF1B14 File Offset: 0x00EEFD14
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

		// Token: 0x06035829 RID: 219177 RVA: 0x00EF1B57 File Offset: 0x00EEFD57
		public void RetryAfterWinAfterClose()
		{
			this.CompleteRetryAfterWinAsync().Forget();
		}

		// Token: 0x0603582A RID: 219178 RVA: 0x00EF1B64 File Offset: 0x00EEFD64
		private UniTask CompleteRetryAfterWinAsync()
		{
			MatchThreeController.<CompleteRetryAfterWinAsync>d__15 <CompleteRetryAfterWinAsync>d__;
			<CompleteRetryAfterWinAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CompleteRetryAfterWinAsync>d__.<>4__this = this;
			<CompleteRetryAfterWinAsync>d__.<>1__state = -1;
			<CompleteRetryAfterWinAsync>d__.<>t__builder.Start<MatchThreeController.<CompleteRetryAfterWinAsync>d__15>(ref <CompleteRetryAfterWinAsync>d__);
			return <CompleteRetryAfterWinAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603582B RID: 219179 RVA: 0x00EF1BA8 File Offset: 0x00EEFDA8
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

		// Token: 0x0603582C RID: 219180 RVA: 0x00EF1BF3 File Offset: 0x00EEFDF3
		public void Restart(bool lowerDifficulty = false)
		{
			MatchThreePresenter currentPresenter = this.CurrentPresenter;
			if (currentPresenter == null)
			{
				return;
			}
			currentPresenter.RestartAsync(lowerDifficulty).Forget<bool>();
		}

		// Token: 0x0603582D RID: 219181 RVA: 0x00EF1C0B File Offset: 0x00EEFE0B
		public void Rewind(int turns = 1)
		{
			MatchThreePresenter currentPresenter = this.CurrentPresenter;
			if (currentPresenter == null)
			{
				return;
			}
			currentPresenter.RewindAsync(turns).Forget();
		}

		// Token: 0x0603582E RID: 219182 RVA: 0x00EF1C23 File Offset: 0x00EEFE23
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

		// Token: 0x0603582F RID: 219183 RVA: 0x00EF1C5E File Offset: 0x00EEFE5E
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

		// Token: 0x1700681D RID: 26653
		// (get) Token: 0x06035830 RID: 219184 RVA: 0x00EF1C8B File Offset: 0x00EEFE8B
		[Nullable(1)]
		public static MatchThreeController Instance
		{
			[NullableContext(1)]
			get
			{
				return MatchThreeController._Instance;
			}
		}

		// Token: 0x06035831 RID: 219185 RVA: 0x00EF1C92 File Offset: 0x00EEFE92
		[NullableContext(1)]
		public static MatchThreeController GetOrCreateInstance()
		{
			if (MatchThreeController._Instance == null)
			{
				MatchThreeController.CreateInstance();
			}
			return MatchThreeController._Instance;
		}

		// Token: 0x06035832 RID: 219186 RVA: 0x00EF1CA6 File Offset: 0x00EEFEA6
		public static bool CreateInstance()
		{
			if (MatchThreeController._Instance != null)
			{
				return true;
			}
			MatchThreeController._Instance = new MatchThreeController();
			return true;
		}

		// Token: 0x06035833 RID: 219187 RVA: 0x00EF1CBC File Offset: 0x00EEFEBC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035834 RID: 219188 RVA: 0x00EF1CBE File Offset: 0x00EEFEBE
		public static void ResetStaticDefaultValue()
		{
			MatchThreeController._Instance = null;
		}

		// Token: 0x06035835 RID: 219189 RVA: 0x00EF1CC6 File Offset: 0x00EEFEC6
		static MatchThreeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatchThreeController.CreateStaticDefaultValue), new Action(MatchThreeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C3FC RID: 115708
		private UniTaskCompletionSource<bool> SettlementCompletionSource;

		// Token: 0x0401C3FD RID: 115709
		private MatchThreeGameplayContext SettlementContext;

		// Token: 0x0401C3FE RID: 115710
		private MatchThreeGameplayContext PendingRetryContext;

		// Token: 0x0401C3FF RID: 115711
		private static MatchThreeController _Instance;
	}
}
