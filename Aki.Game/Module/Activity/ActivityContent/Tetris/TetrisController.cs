using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002F99 RID: 12185
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TetrisController : ControllerBase
	{
		// Token: 0x0601CE55 RID: 118357 RVA: 0x008D431D File Offset: 0x008D251D
		public void OpenActivityTetris(int challengeId)
		{
			UiManager.Instance.OpenView(EUiViewName.TetrisPlayView, challengeId, null);
		}

		// Token: 0x0601CE56 RID: 118358 RVA: 0x008D4338 File Offset: 0x008D2538
		public UniTask OpenEndlessTetris(int challengeId)
		{
			TetrisController.<OpenEndlessTetris>d__3 <OpenEndlessTetris>d__;
			<OpenEndlessTetris>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenEndlessTetris>d__.challengeId = challengeId;
			<OpenEndlessTetris>d__.<>1__state = -1;
			<OpenEndlessTetris>d__.<>t__builder.Start<TetrisController.<OpenEndlessTetris>d__3>(ref <OpenEndlessTetris>d__);
			return <OpenEndlessTetris>d__.<>t__builder.Task;
		}

		// Token: 0x0601CE57 RID: 118359 RVA: 0x008D437B File Offset: 0x008D257B
		public long GetEntityId()
		{
			return this.EntityId;
		}

		// Token: 0x0601CE58 RID: 118360 RVA: 0x008D4383 File Offset: 0x008D2583
		public void SetEntityId(long entityId)
		{
			this.EntityId = entityId;
		}

		// Token: 0x0601CE59 RID: 118361 RVA: 0x008D438C File Offset: 0x008D258C
		public long GetHighestScore()
		{
			return this.HighestScore;
		}

		// Token: 0x0601CE5A RID: 118362 RVA: 0x008D4394 File Offset: 0x008D2594
		public void SetHighestScore(long score)
		{
			this.HighestScore = score;
		}

		// Token: 0x0601CE5B RID: 118363 RVA: 0x008D43A0 File Offset: 0x008D25A0
		public void SendCompleteRequest(TetrisFinishRequest request, [Nullable(2)] Action callback = null)
		{
			Net.Instance.Call(ERequestMessageId.TetrisFinishRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TetrisFinishResponse tetrisFinishResponse = msg as TetrisFinishResponse;
				if (tetrisFinishResponse == null)
				{
					return;
				}
				if (tetrisFinishResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(tetrisFinishResponse.ErrorCode, 16139, null, true, true);
				}
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}, 0);
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0601CE5C RID: 118364 RVA: 0x008D43D7 File Offset: 0x008D25D7
		public static TetrisController Instance
		{
			get
			{
				return TetrisController._Instance;
			}
		}

		// Token: 0x0601CE5D RID: 118365 RVA: 0x008D43DE File Offset: 0x008D25DE
		public static TetrisController GetOrCreateInstance()
		{
			if (TetrisController._Instance == null)
			{
				TetrisController.CreateInstance();
			}
			return TetrisController._Instance;
		}

		// Token: 0x0601CE5E RID: 118366 RVA: 0x008D43F2 File Offset: 0x008D25F2
		public static bool CreateInstance()
		{
			if (TetrisController._Instance != null)
			{
				return true;
			}
			TetrisController._Instance = new TetrisController();
			return true;
		}

		// Token: 0x0601CE5F RID: 118367 RVA: 0x008D4408 File Offset: 0x008D2608
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x008D440A File Offset: 0x008D260A
		public static void ResetStaticDefaultValue()
		{
			TetrisController._Instance = null;
		}

		// Token: 0x0601CE61 RID: 118369 RVA: 0x008D4412 File Offset: 0x008D2612
		static TetrisController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TetrisController.CreateStaticDefaultValue), new Action(TetrisController.ResetStaticDefaultValue));
		}

		// Token: 0x0400F3A0 RID: 62368
		private long EntityId;

		// Token: 0x0400F3A1 RID: 62369
		private long HighestScore;

		// Token: 0x0400F3A2 RID: 62370
		[Nullable(2)]
		private static TetrisController _Instance;
	}
}
