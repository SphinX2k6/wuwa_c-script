using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller
{
	// Token: 0x02003686 RID: 13958
	[NullableContext(1)]
	[Nullable(0)]
	public class RollbackManager
	{
		// Token: 0x06024358 RID: 148312 RVA: 0x00A3DE7C File Offset: 0x00A3C07C
		public RollbackManager(WuWaGoGameModeBase gameMode, WuWaGoGameData gameData)
		{
			this.GameMode = gameMode;
			this.GameData = gameData;
			this.GameData.RollbackPreStates.RegisterCommitHandler(new Action<Dictionary<int, IRollbackCapture>>(this.HandleCommit));
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x06024359 RID: 148313 RVA: 0x00A3DEB9 File Offset: 0x00A3C0B9
		public int Count
		{
			get
			{
				return this.Stack.Count;
			}
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x0602435A RID: 148314 RVA: 0x00A3DEC6 File Offset: 0x00A3C0C6
		public bool IsAvailable
		{
			get
			{
				return !this.IsRestoring && this.IsAcceptingInput && (this.Stack.Count > 0 || this.HasUnrolledDrops);
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0602435B RID: 148315 RVA: 0x00A3DEF0 File Offset: 0x00A3C0F0
		public bool IsRestoring
		{
			get
			{
				return this.CurrentRestoreJob != null;
			}
		}

		// Token: 0x0602435C RID: 148316 RVA: 0x00A3DEFB File Offset: 0x00A3C0FB
		public void SetAcceptingInput(bool accept)
		{
			if (this.IsAcceptingInput == accept)
			{
				return;
			}
			this.IsAcceptingInput = accept;
			this.RefreshAvailable();
		}

		// Token: 0x0602435D RID: 148317 RVA: 0x00A3DF14 File Offset: 0x00A3C114
		public void BeginPlayerActionTracking()
		{
			if (this.GetMaxRollbackCount() <= 0)
			{
				return;
			}
			this.GameData.RollbackPreStates.Begin();
		}

		// Token: 0x0602435E RID: 148318 RVA: 0x00A3DF30 File Offset: 0x00A3C130
		public void FlushPendingPlayerActionTracking()
		{
			this.GameData.RollbackPreStates.FlushPendingCommit();
		}

		// Token: 0x0602435F RID: 148319 RVA: 0x00A3DF42 File Offset: 0x00A3C142
		public void ResetPlayerActionCaptures()
		{
			this.GameData.RollbackPreStates.ResetCaptures();
		}

		// Token: 0x06024360 RID: 148320 RVA: 0x00A3DF54 File Offset: 0x00A3C154
		public void ResetForSavePoint()
		{
			this.GameData.RollbackPreStates.Discard();
			this.Stack.Clear();
			this.HasUnrolledDrops = false;
			this.CaptureSavePointSnapshot();
			this.RefreshAvailable();
		}

		// Token: 0x06024361 RID: 148321 RVA: 0x00A3DF84 File Offset: 0x00A3C184
		public void CaptureSavePointSnapshot()
		{
			this.SavePointSnapshot = RollbackManager.CaptureAllUnits(this.GameData);
		}

		// Token: 0x06024362 RID: 148322 RVA: 0x00A3DF97 File Offset: 0x00A3C197
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<IRollbackCapture> GetSavePointSnapshot()
		{
			return this.SavePointSnapshot;
		}

		// Token: 0x06024363 RID: 148323 RVA: 0x00A3DFA0 File Offset: 0x00A3C1A0
		public UniTask RollbackToLastStepAsync()
		{
			RollbackManager.<RollbackToLastStepAsync>d__25 <RollbackToLastStepAsync>d__;
			<RollbackToLastStepAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToLastStepAsync>d__.<>4__this = this;
			<RollbackToLastStepAsync>d__.<>1__state = -1;
			<RollbackToLastStepAsync>d__.<>t__builder.Start<RollbackManager.<RollbackToLastStepAsync>d__25>(ref <RollbackToLastStepAsync>d__);
			return <RollbackToLastStepAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024364 RID: 148324 RVA: 0x00A3DFE4 File Offset: 0x00A3C1E4
		public UniTask RollbackToSavePointAsync()
		{
			RollbackManager.<RollbackToSavePointAsync>d__26 <RollbackToSavePointAsync>d__;
			<RollbackToSavePointAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToSavePointAsync>d__.<>4__this = this;
			<RollbackToSavePointAsync>d__.<>1__state = -1;
			<RollbackToSavePointAsync>d__.<>t__builder.Start<RollbackManager.<RollbackToSavePointAsync>d__26>(ref <RollbackToSavePointAsync>d__);
			return <RollbackToSavePointAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024365 RID: 148325 RVA: 0x00A3E028 File Offset: 0x00A3C228
		public static List<IRollbackCapture> CaptureAllUnits(WuWaGoGameData gameData)
		{
			List<IRollbackCapture> list = new List<IRollbackCapture>();
			WuWaGoMainControlRole mainControlRole = gameData.MainControlRole;
			IRollbackCapture rollbackCapture = (mainControlRole != null) ? mainControlRole.CaptureRollback() : null;
			if (rollbackCapture != null)
			{
				list.Add(rollbackCapture);
			}
			foreach (WuWaGoBaseUnit wuWaGoBaseUnit in gameData.AllUnits.Values)
			{
				if (wuWaGoBaseUnit != mainControlRole)
				{
					IRollbackCapture rollbackCapture2 = wuWaGoBaseUnit.CaptureRollback();
					if (rollbackCapture2 != null)
					{
						list.Add(rollbackCapture2);
					}
				}
			}
			return list;
		}

		// Token: 0x06024366 RID: 148326 RVA: 0x00A3E0BC File Offset: 0x00A3C2BC
		public UniTask RestoreCapturesAsync(IReadOnlyList<IRollbackCapture> captures)
		{
			RollbackManager.<RestoreCapturesAsync>d__28 <RestoreCapturesAsync>d__;
			<RestoreCapturesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RestoreCapturesAsync>d__.<>4__this = this;
			<RestoreCapturesAsync>d__.captures = captures;
			<RestoreCapturesAsync>d__.<>1__state = -1;
			<RestoreCapturesAsync>d__.<>t__builder.Start<RollbackManager.<RestoreCapturesAsync>d__28>(ref <RestoreCapturesAsync>d__);
			return <RestoreCapturesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024367 RID: 148327 RVA: 0x00A3E107 File Offset: 0x00A3C307
		public void TickYield()
		{
			if (this.CurrentRestoreJob != null)
			{
				this.AdvanceRestoreJob();
			}
		}

		// Token: 0x06024368 RID: 148328 RVA: 0x00A3E118 File Offset: 0x00A3C318
		public void RefreshAvailable()
		{
			bool isAvailable = this.IsAvailable;
			if (isAvailable == this.LastEmittedAvailable)
			{
				return;
			}
			this.LastEmittedAvailable = isAvailable;
			EventSystem.Instance.Emit<bool>(EEventName.OnWuWaGoRollbackAvailable, isAvailable);
		}

		// Token: 0x06024369 RID: 148329 RVA: 0x00A3E150 File Offset: 0x00A3C350
		public void Clear()
		{
			this.Stack.Clear();
			this.SavePointSnapshot = null;
			this.HasUnrolledDrops = false;
			this.LastEmittedAvailable = false;
			this.IsAcceptingInput = false;
			if (this.CurrentRestoreJob != null)
			{
				RollbackManager.RestoreJob currentRestoreJob = this.CurrentRestoreJob;
				this.CurrentRestoreJob = null;
				this.GameData.RollbackPreStates.SetSuppressed(false);
				this.GameData.EndGridLinkBatch();
				currentRestoreJob.OnDone();
			}
			this.GameData.RollbackPreStates.Discard();
		}

		// Token: 0x0602436A RID: 148330 RVA: 0x00A3E1D0 File Offset: 0x00A3C3D0
		private void HandleCommit(Dictionary<int, IRollbackCapture> captures)
		{
			if (captures.Count == 0)
			{
				return;
			}
			WuWaGoRollbackSnapshot item = WuWaGoRollbackSnapshot.CreateFromCaptures(this.GameData.Round, captures);
			this.Stack.Add(item);
			int maxRollbackCount = this.GetMaxRollbackCount();
			if (this.Stack.Count > maxRollbackCount)
			{
				this.Stack.RemoveAt(0);
				this.HasUnrolledDrops = true;
			}
			this.RefreshAvailable();
		}

		// Token: 0x0602436B RID: 148331 RVA: 0x00A3E234 File Offset: 0x00A3C434
		private UniTask RestoreSavePointInternalAsync()
		{
			RollbackManager.<RestoreSavePointInternalAsync>d__33 <RestoreSavePointInternalAsync>d__;
			<RestoreSavePointInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RestoreSavePointInternalAsync>d__.<>4__this = this;
			<RestoreSavePointInternalAsync>d__.<>1__state = -1;
			<RestoreSavePointInternalAsync>d__.<>t__builder.Start<RollbackManager.<RestoreSavePointInternalAsync>d__33>(ref <RestoreSavePointInternalAsync>d__);
			return <RestoreSavePointInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602436C RID: 148332 RVA: 0x00A3E278 File Offset: 0x00A3C478
		private void StartRestoreJob(IReadOnlyList<IRollbackCapture> captures, Action onDone)
		{
			this.GameData.RollbackPreStates.Discard();
			this.GameData.BeginGridLinkBatch();
			this.GameData.RollbackPreStates.SetSuppressed(true);
			this.CurrentRestoreJob = new RollbackManager.RestoreJob
			{
				Captures = captures,
				Index = 0,
				OnDone = onDone
			};
			this.RefreshAvailable();
			if (captures.Count == 0)
			{
				this.FinishRestoreJob();
			}
		}

		// Token: 0x0602436D RID: 148333 RVA: 0x00A3E2E8 File Offset: 0x00A3C4E8
		private void AdvanceRestoreJob()
		{
			RollbackManager.RestoreJob currentRestoreJob = this.CurrentRestoreJob;
			int num = 16;
			int num2 = Math.Min(currentRestoreJob.Index + num, currentRestoreJob.Captures.Count);
			for (int i = currentRestoreJob.Index; i < num2; i++)
			{
				currentRestoreJob.Captures[i].Restore();
			}
			currentRestoreJob.Index = num2;
			if (num2 >= currentRestoreJob.Captures.Count)
			{
				this.FinishRestoreJob();
			}
		}

		// Token: 0x0602436E RID: 148334 RVA: 0x00A3E358 File Offset: 0x00A3C558
		private void FinishRestoreJob()
		{
			RollbackManager.RestoreJob currentRestoreJob = this.CurrentRestoreJob;
			this.CurrentRestoreJob = null;
			this.GameData.RollbackPreStates.SetSuppressed(false);
			this.GameData.RebuildGirdsMap();
			this.GameData.EndGridLinkBatch();
			this.GameMode.NotifyGameplayEntityLinkServiceRollbackRestore();
			this.GameMode.RestoreDeactivatedRoleControllersFromRollback();
			this.GameMode.NotifyAllControllersRollbackRestore();
			this.RefreshAvailable();
			currentRestoreJob.OnDone();
		}

		// Token: 0x0602436F RID: 148335 RVA: 0x00A3E3CA File Offset: 0x00A3C5CA
		private int GetMaxRollbackCount()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			if (setting == null)
			{
				return 3;
			}
			return setting.MaxRollbackCount;
		}

		// Token: 0x040142C3 RID: 82627
		private const int DEFAULT_MAX_ROLLBACK_COUNT = 3;

		// Token: 0x040142C4 RID: 82628
		private const int DEFAULT_RESTORE_BATCH_SIZE = 16;

		// Token: 0x040142C5 RID: 82629
		private readonly List<WuWaGoRollbackSnapshot> Stack = new List<WuWaGoRollbackSnapshot>();

		// Token: 0x040142C6 RID: 82630
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<IRollbackCapture> SavePointSnapshot;

		// Token: 0x040142C7 RID: 82631
		private bool HasUnrolledDrops;

		// Token: 0x040142C8 RID: 82632
		private bool LastEmittedAvailable;

		// Token: 0x040142C9 RID: 82633
		private bool IsAcceptingInput;

		// Token: 0x040142CA RID: 82634
		[Nullable(2)]
		private RollbackManager.RestoreJob CurrentRestoreJob;

		// Token: 0x040142CB RID: 82635
		private readonly WuWaGoGameModeBase GameMode;

		// Token: 0x040142CC RID: 82636
		private readonly WuWaGoGameData GameData;

		// Token: 0x0200935C RID: 37724
		[Nullable(0)]
		[RequiredMember]
		private class RestoreJob
		{
			// Token: 0x06043C60 RID: 277600 RVA: 0x01410186 File Offset: 0x0140E386
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public RestoreJob()
			{
			}

			// Token: 0x0402E1AB RID: 188843
			[RequiredMember]
			public IReadOnlyList<IRollbackCapture> Captures;

			// Token: 0x0402E1AC RID: 188844
			public int Index;

			// Token: 0x0402E1AD RID: 188845
			[RequiredMember]
			public Action OnDone;
		}
	}
}
