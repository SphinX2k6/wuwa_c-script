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
	// Token: 0x0200563E RID: 22078
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class DropCatchGameplayController : UiControllerBase
	{
		// Token: 0x17006996 RID: 27030
		// (get) Token: 0x060368C0 RID: 223424 RVA: 0x00F38C7C File Offset: 0x00F36E7C
		// (set) Token: 0x060368BF RID: 223423 RVA: 0x00F38C73 File Offset: 0x00F36E73
		public bool EnableDebug
		{
			get
			{
				return false;
			}
			set
			{
				this.EnableDebugInternal = value;
			}
		}

		// Token: 0x060368C1 RID: 223425 RVA: 0x00F38C7F File Offset: 0x00F36E7F
		public void StartGameplay(int gameplayId)
		{
			if (this.GameplayProxy == null)
			{
				this.GameplayProxy = new DropCatchGameplayProxy();
			}
			this.GameplayProxy.StartGameplay(gameplayId);
		}

		// Token: 0x060368C2 RID: 223426 RVA: 0x00F38CA4 File Offset: 0x00F36EA4
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

		// Token: 0x060368C3 RID: 223427 RVA: 0x00F38CEC File Offset: 0x00F36EEC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(dropCatchLevelFinishResponse.Error, 23994, null, true, true);
				}
				successCallback();
			}, 0);
		}

		// Token: 0x060368C4 RID: 223428 RVA: 0x00F38D56 File Offset: 0x00F36F56
		public void EndGameplay()
		{
			DropCatchGameplayProxy gameplayProxy = this.GameplayProxy;
			if (gameplayProxy != null)
			{
				gameplayProxy.EndGameplay();
			}
			this.GameplayProxy = null;
		}

		// Token: 0x060368C5 RID: 223429 RVA: 0x00F38D70 File Offset: 0x00F36F70
		public override bool Clear()
		{
			this.EndGameplay();
			return base.Clear();
		}

		// Token: 0x060368C6 RID: 223430 RVA: 0x00F38D80 File Offset: 0x00F36F80
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

		// Token: 0x060368C7 RID: 223431 RVA: 0x00F38DC4 File Offset: 0x00F36FC4
		public UniTask RequestHistoryScore()
		{
			DropCatchGameplayController.<RequestHistoryScore>d__11 <RequestHistoryScore>d__;
			<RequestHistoryScore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestHistoryScore>d__.<>1__state = -1;
			<RequestHistoryScore>d__.<>t__builder.Start<DropCatchGameplayController.<RequestHistoryScore>d__11>(ref <RequestHistoryScore>d__);
			return <RequestHistoryScore>d__.<>t__builder.Task;
		}

		// Token: 0x17006997 RID: 27031
		// (get) Token: 0x060368C8 RID: 223432 RVA: 0x00F38DFF File Offset: 0x00F36FFF
		public static DropCatchGameplayController Instance
		{
			get
			{
				return DropCatchGameplayController._Instance;
			}
		}

		// Token: 0x060368C9 RID: 223433 RVA: 0x00F38E06 File Offset: 0x00F37006
		public static DropCatchGameplayController GetOrCreateInstance()
		{
			if (DropCatchGameplayController._Instance == null)
			{
				DropCatchGameplayController.CreateInstance();
			}
			return DropCatchGameplayController._Instance;
		}

		// Token: 0x060368CA RID: 223434 RVA: 0x00F38E1A File Offset: 0x00F3701A
		public static bool CreateInstance()
		{
			if (DropCatchGameplayController._Instance != null)
			{
				return true;
			}
			DropCatchGameplayController._Instance = new DropCatchGameplayController();
			return true;
		}

		// Token: 0x060368CB RID: 223435 RVA: 0x00F38E30 File Offset: 0x00F37030
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060368CC RID: 223436 RVA: 0x00F38E32 File Offset: 0x00F37032
		public static void ResetStaticDefaultValue()
		{
			DropCatchGameplayController._Instance = null;
		}

		// Token: 0x060368CD RID: 223437 RVA: 0x00F38E3A File Offset: 0x00F3703A
		static DropCatchGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchGameplayController.CreateStaticDefaultValue), new Action(DropCatchGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CD1B RID: 118043
		private bool EnableDebugInternal;

		// Token: 0x0401CD1C RID: 118044
		[Nullable(2)]
		private DropCatchGameplayProxy GameplayProxy;

		// Token: 0x0401CD1D RID: 118045
		[Nullable(2)]
		private static DropCatchGameplayController _Instance;
	}
}
