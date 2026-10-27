using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay
{
	// Token: 0x020066EE RID: 26350
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DropCatchGameplayController : UiControllerBase
	{
		// Token: 0x17009657 RID: 38487
		// (get) Token: 0x06041D74 RID: 269684 RVA: 0x00FF7878 File Offset: 0x00FF5A78
		// (set) Token: 0x06041D73 RID: 269683 RVA: 0x00FF786F File Offset: 0x00FF5A6F
		public bool EnableDebug
		{
			get
			{
				return !Info.Instance.IsBuildShipping && this.EnableDebugInternal;
			}
			set
			{
				this.EnableDebugInternal = value;
			}
		}

		// Token: 0x06041D75 RID: 269685 RVA: 0x00FF788E File Offset: 0x00FF5A8E
		public void StartGameplay(int gameplayId)
		{
			if (this.GameplayProxy == null)
			{
				this.GameplayProxy = new DropCatchGameplayProxy();
			}
			this.GameplayProxy.StartGameplay(gameplayId);
		}

		// Token: 0x06041D76 RID: 269686 RVA: 0x00FF78B0 File Offset: 0x00FF5AB0
		public int GetCurrentGameplayId()
		{
			DropCatchGameplayProxy gameplayProxy = this.GameplayProxy;
			int? num;
			if (gameplayProxy == null)
			{
				num = null;
			}
			else
			{
				DropCatchGameplayViewModel gameplayViewModel = gameplayProxy.GetGameplayViewModel();
				num = ((gameplayViewModel != null) ? new int?(gameplayViewModel.GetCurGameplayId()) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x06041D77 RID: 269687 RVA: 0x00FF78F8 File Offset: 0x00FF5AF8
		public void SettleGameplay(IDropCatchSettleGameplay @params, Action successCallback)
		{
			DropCatchLevelFinishRequest dropCatchLevelFinishRequest = DropCatchLevelFinishRequest.Create();
			dropCatchLevelFinishRequest.DropCatchId = @params.GameplayId;
			dropCatchLevelFinishRequest.Score = (int)MathUtils.Instance.Clamp(@params.Score, 0f, 2.1474836E+09f);
			Net.Instance.Call(ERequestMessageId.DropCatchLevelFinishRequest, dropCatchLevelFinishRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DropCatchLevelFinishResponse dropCatchLevelFinishResponse = (DropCatchLevelFinishResponse)msg;
				if (dropCatchLevelFinishResponse == null)
				{
					return;
				}
				if (dropCatchLevelFinishResponse.Error != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(dropCatchLevelFinishResponse.Error, 21819, null, true, true);
				}
				successCallback();
			}, 0);
		}

		// Token: 0x06041D78 RID: 269688 RVA: 0x00FF7962 File Offset: 0x00FF5B62
		public void EndGameplay()
		{
			DropCatchGameplayProxy gameplayProxy = this.GameplayProxy;
			if (gameplayProxy != null)
			{
				gameplayProxy.EndGameplay();
			}
			this.GameplayProxy = null;
		}

		// Token: 0x06041D79 RID: 269689 RVA: 0x00FF797C File Offset: 0x00FF5B7C
		public override bool Clear()
		{
			this.EndGameplay();
			return base.Clear();
		}

		// Token: 0x06041D7A RID: 269690 RVA: 0x00FF798C File Offset: 0x00FF5B8C
		public void ExecuteCommand(string command)
		{
			CommandData commandData = Json.Parse<CommandData>(command, null);
			if (commandData == null)
			{
				return;
			}
			DropCatchGameplayProxy gameplayProxy = this.GameplayProxy;
			if (gameplayProxy == null)
			{
				return;
			}
			DropCatchGameplayLogic gameplayLogic = gameplayProxy.GetGameplayLogic();
			if (gameplayLogic == null)
			{
				return;
			}
			gameplayLogic.GetGameplayCommandMgr().ExecuteCommand(commandData.CommandName, commandData.Params);
		}

		// Token: 0x06041D7B RID: 269691 RVA: 0x00FF79D0 File Offset: 0x00FF5BD0
		public UniTask RequestHistoryScore()
		{
			DropCatchGameplayController.<RequestHistoryScore>d__11 <RequestHistoryScore>d__;
			<RequestHistoryScore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestHistoryScore>d__.<>1__state = -1;
			<RequestHistoryScore>d__.<>t__builder.Start<DropCatchGameplayController.<RequestHistoryScore>d__11>(ref <RequestHistoryScore>d__);
			return <RequestHistoryScore>d__.<>t__builder.Task;
		}

		// Token: 0x17009658 RID: 38488
		// (get) Token: 0x06041D7C RID: 269692 RVA: 0x00FF7A0B File Offset: 0x00FF5C0B
		public static DropCatchGameplayController Instance
		{
			get
			{
				return DropCatchGameplayController._Instance;
			}
		}

		// Token: 0x06041D7D RID: 269693 RVA: 0x00FF7A12 File Offset: 0x00FF5C12
		public static DropCatchGameplayController GetOrCreateInstance()
		{
			if (DropCatchGameplayController._Instance == null)
			{
				DropCatchGameplayController.CreateInstance();
			}
			return DropCatchGameplayController._Instance;
		}

		// Token: 0x06041D7E RID: 269694 RVA: 0x00FF7A26 File Offset: 0x00FF5C26
		public static bool CreateInstance()
		{
			if (DropCatchGameplayController._Instance != null)
			{
				return true;
			}
			DropCatchGameplayController._Instance = new DropCatchGameplayController();
			return true;
		}

		// Token: 0x06041D7F RID: 269695 RVA: 0x00FF7A3C File Offset: 0x00FF5C3C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041D80 RID: 269696 RVA: 0x00FF7A3E File Offset: 0x00FF5C3E
		public static void ResetStaticDefaultValue()
		{
			DropCatchGameplayController._Instance = null;
		}

		// Token: 0x06041D81 RID: 269697 RVA: 0x00FF7A46 File Offset: 0x00FF5C46
		static DropCatchGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchGameplayController.CreateStaticDefaultValue), new Action(DropCatchGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x040224C2 RID: 140482
		private bool EnableDebugInternal;

		// Token: 0x040224C3 RID: 140483
		[Nullable(2)]
		private DropCatchGameplayProxy GameplayProxy;

		// Token: 0x040224C4 RID: 140484
		[Nullable(2)]
		private static DropCatchGameplayController _Instance;
	}
}
