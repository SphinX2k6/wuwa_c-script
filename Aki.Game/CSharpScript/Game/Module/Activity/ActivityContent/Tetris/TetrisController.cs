using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FE7 RID: 24551
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TetrisController : ControllerBase
	{
		// Token: 0x0603E30B RID: 254731 RVA: 0x00F02E07 File Offset: 0x00F01007
		public void OpenActivityTetris(int challengeId)
		{
			UiManager.Instance.OpenView(EUiViewName.TetrisPlayView, challengeId, null);
		}

		// Token: 0x0603E30C RID: 254732 RVA: 0x00F02E20 File Offset: 0x00F01020
		public UniTask OpenEndlessTetris(int challengeId)
		{
			TetrisController.<OpenEndlessTetris>d__3 <OpenEndlessTetris>d__;
			<OpenEndlessTetris>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenEndlessTetris>d__.challengeId = challengeId;
			<OpenEndlessTetris>d__.<>1__state = -1;
			<OpenEndlessTetris>d__.<>t__builder.Start<TetrisController.<OpenEndlessTetris>d__3>(ref <OpenEndlessTetris>d__);
			return <OpenEndlessTetris>d__.<>t__builder.Task;
		}

		// Token: 0x0603E30D RID: 254733 RVA: 0x00F02E63 File Offset: 0x00F01063
		public long GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x0603E30E RID: 254734 RVA: 0x00F02E6B File Offset: 0x00F0106B
		public void SetEntityId(long entityId)
		{
			this.EntityId = entityId;
		}

		// Token: 0x0603E30F RID: 254735 RVA: 0x00F02E74 File Offset: 0x00F01074
		public long GetHighestScore()
		{
			return this.HighestScore;
		}

		// Token: 0x0603E310 RID: 254736 RVA: 0x00F02E7C File Offset: 0x00F0107C
		public void SetHighestScore(long score)
		{
			this.HighestScore = score;
		}

		// Token: 0x0603E311 RID: 254737 RVA: 0x00F02E88 File Offset: 0x00F01088
		public void SendCompleteRequest(TetrisFinishRequest request, [Nullable(2)] Action callback = null)
		{
			Net.Instance.Call(ERequestMessageId.TetrisFinishRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TetrisFinishResponse tetrisFinishResponse = (TetrisFinishResponse)msg;
				if (tetrisFinishResponse == null)
				{
					return;
				}
				if (tetrisFinishResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(tetrisFinishResponse.ErrorCode, 25865, null, true, true);
				}
				if (callback != null)
				{
					callback();
				}
			}, 0);
		}

		// Token: 0x17009046 RID: 36934
		// (get) Token: 0x0603E312 RID: 254738 RVA: 0x00F02EBF File Offset: 0x00F010BF
		public static TetrisController Instance
		{
			get
			{
				return TetrisController._Instance;
			}
		}

		// Token: 0x0603E313 RID: 254739 RVA: 0x00F02EC6 File Offset: 0x00F010C6
		public static TetrisController GetOrCreateInstance()
		{
			if (TetrisController._Instance == null)
			{
				TetrisController.CreateInstance();
			}
			return TetrisController._Instance;
		}

		// Token: 0x0603E314 RID: 254740 RVA: 0x00F02EDA File Offset: 0x00F010DA
		public static bool CreateInstance()
		{
			if (TetrisController._Instance != null)
			{
				return true;
			}
			TetrisController._Instance = new TetrisController();
			return true;
		}

		// Token: 0x0603E315 RID: 254741 RVA: 0x00F02EF0 File Offset: 0x00F010F0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E316 RID: 254742 RVA: 0x00F02EF2 File Offset: 0x00F010F2
		public static void ResetStaticDefaultValue()
		{
			TetrisController._Instance = null;
		}

		// Token: 0x0603E317 RID: 254743 RVA: 0x00F02EFA File Offset: 0x00F010FA
		static TetrisController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TetrisController.CreateStaticDefaultValue), new Action(TetrisController.ResetStaticDefaultValue));
		}

		// Token: 0x040207DB RID: 133083
		private long EntityId;

		// Token: 0x040207DC RID: 133084
		private long HighestScore;

		// Token: 0x040207DD RID: 133085
		[Nullable(2)]
		private static TetrisController _Instance;
	}
}
