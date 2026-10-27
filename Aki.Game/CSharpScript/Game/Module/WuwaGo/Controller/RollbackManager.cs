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
	// Token: 0x02004755 RID: 18261
	[NullableContext(1)]
	[Nullable(0)]
	public class RollbackManager
	{
		// Token: 0x0602FB8E RID: 195470 RVA: 0x00B0DE88 File Offset: 0x00B0C088
		public RollbackManager(WuWaGoGameModeBase gameMode, WuWaGoGameData gameData)
		{
			this.GameMode = gameMode;
			this.GameData = gameData;
			this.GameData.RollbackPreStates.RegisterCommitHandler(new Action<Dictionary<int, IRollbackCapture>>(this.HandleCommit));
		}

		// Token: 0x17007746 RID: 30534
		// (get) Token: 0x0602FB8F RID: 195471 RVA: 0x00B0DEC5 File Offset: 0x00B0C0C5
		public int Count
		{
			get
			{
				return this.Stack.Count;
			}
		}

		// Token: 0x17007747 RID: 30535
		// (get) Token: 0x0602FB90 RID: 195472 RVA: 0x00B0DED2 File Offset: 0x00B0C0D2
		public bool IsAvailable
		{
			get
			{
				return !this.IsRestoring && this.IsAcceptingInput && (this.Stack.Count > 0 || this.HasUnrolledDrops);
			}
		}

		// Token: 0x17007748 RID: 30536
		// (get) Token: 0x0602FB91 RID: 195473 RVA: 0x00B0DEFC File Offset: 0x00B0C0FC
		public bool IsRestoring
		{
			get
			{
				return this.CurrentRestoreJob != null;
			}
		}

		// Token: 0x0602FB92 RID: 195474 RVA: 0x00B0DF07 File Offset: 0x00B0C107
		public void SetAcceptingInput(bool accept)
		{
			if (this.IsAcceptingInput == accept)
			{
				return;
			}
			this.IsAcceptingInput = accept;
			this.RefreshAvailable();
		}

		// Token: 0x0602FB93 RID: 195475 RVA: 0x00B0DF20 File Offset: 0x00B0C120
		public void BeginPlayerActionTracking()
		{
			if (this.GetMaxRollbackCount() <= 0)
			{
				return;
			}
			this.GameData.RollbackPreStates.Begin();
		}

		// Token: 0x0602FB94 RID: 195476 RVA: 0x00B0DF3C File Offset: 0x00B0C13C
		public void FlushPendingPlayerActionTracking()
		{
			this.GameData.RollbackPreStates.FlushPendingCommit();
		}

		// Token: 0x0602FB95 RID: 195477 RVA: 0x00B0DF4E File Offset: 0x00B0C14E
		public void ResetPlayerActionCaptures()
		{
			this.GameData.RollbackPreStates.ResetCaptures();
		}

		// Token: 0x0602FB96 RID: 195478 RVA: 0x00B0DF60 File Offset: 0x00B0C160
		public void ResetForSavePoint()
		{
			this.GameData.RollbackPreStates.Discard();
			this.Stack.Clear();
			this.HasUnrolledDrops = false;
			this.CaptureSavePointSnapshot();
			this.RefreshAvailable();
		}

		// Token: 0x0602FB97 RID: 195479 RVA: 0x00B0DF90 File Offset: 0x00B0C190
		public void CaptureSavePointSnapshot()
		{
			this.SavePointSnapshot = RollbackManager.CaptureAllUnits(this.GameData);
		}

		// Token: 0x0602FB98 RID: 195480 RVA: 0x00B0DFA3 File Offset: 0x00B0C1A3
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<IRollbackCapture> GetSavePointSnapshot()
		{
			return this.SavePointSnapshot;
		}

		// Token: 0x0602FB99 RID: 195481 RVA: 0x00B0DFAC File Offset: 0x00B0C1AC
		public UniTask RollbackToLastStepAsync()
		{
			RollbackManager.<RollbackToLastStepAsync>d__25 <RollbackToLastStepAsync>d__;
			<RollbackToLastStepAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToLastStepAsync>d__.<>4__this = this;
			<RollbackToLastStepAsync>d__.<>1__state = -1;
			<RollbackToLastStepAsync>d__.<>t__builder.Start<RollbackManager.<RollbackToLastStepAsync>d__25>(ref <RollbackToLastStepAsync>d__);
			return <RollbackToLastStepAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FB9A RID: 195482 RVA: 0x00B0DFF0 File Offset: 0x00B0C1F0
		public UniTask RollbackToSavePointAsync()
		{
			RollbackManager.<RollbackToSavePointAsync>d__26 <RollbackToSavePointAsync>d__;
			<RollbackToSavePointAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RollbackToSavePointAsync>d__.<>4__this = this;
			<RollbackToSavePointAsync>d__.<>1__state = -1;
			<RollbackToSavePointAsync>d__.<>t__builder.Start<RollbackManager.<RollbackToSavePointAsync>d__26>(ref <RollbackToSavePointAsync>d__);
			return <RollbackToSavePointAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FB9B RID: 195483 RVA: 0x00B0E034 File Offset: 0x00B0C234
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

		// Token: 0x0602FB9C RID: 195484 RVA: 0x00B0E0C8 File Offset: 0x00B0C2C8
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

		// Token: 0x0602FB9D RID: 195485 RVA: 0x00B0E113 File Offset: 0x00B0C313
		public void TickYield()
		{
			if (this.CurrentRestoreJob != null)
			{
				this.AdvanceRestoreJob();
			}
		}

		// Token: 0x0602FB9E RID: 195486 RVA: 0x00B0E124 File Offset: 0x00B0C324
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

		// Token: 0x0602FB9F RID: 195487 RVA: 0x00B0E15C File Offset: 0x00B0C35C
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

		// Token: 0x0602FBA0 RID: 195488 RVA: 0x00B0E1DC File Offset: 0x00B0C3DC
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

		// Token: 0x0602FBA1 RID: 195489 RVA: 0x00B0E240 File Offset: 0x00B0C440
		private UniTask RestoreSavePointInternalAsync()
		{
			RollbackManager.<RestoreSavePointInternalAsync>d__33 <RestoreSavePointInternalAsync>d__;
			<RestoreSavePointInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RestoreSavePointInternalAsync>d__.<>4__this = this;
			<RestoreSavePointInternalAsync>d__.<>1__state = -1;
			<RestoreSavePointInternalAsync>d__.<>t__builder.Start<RollbackManager.<RestoreSavePointInternalAsync>d__33>(ref <RestoreSavePointInternalAsync>d__);
			return <RestoreSavePointInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBA2 RID: 195490 RVA: 0x00B0E284 File Offset: 0x00B0C484
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

		// Token: 0x0602FBA3 RID: 195491 RVA: 0x00B0E2F4 File Offset: 0x00B0C4F4
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

		// Token: 0x0602FBA4 RID: 195492 RVA: 0x00B0E364 File Offset: 0x00B0C564
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

		// Token: 0x0602FBA5 RID: 195493 RVA: 0x00B0E3D6 File Offset: 0x00B0C5D6
		private int GetMaxRollbackCount()
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			if (setting == null)
			{
				return 3;
			}
			return setting.MaxRollbackCount;
		}

		// Token: 0x04019C13 RID: 105491
		private const int DEFAULT_MAX_ROLLBACK_COUNT = 3;

		// Token: 0x04019C14 RID: 105492
		private const int DEFAULT_RESTORE_BATCH_SIZE = 16;

		// Token: 0x04019C15 RID: 105493
		private readonly List<WuWaGoRollbackSnapshot> Stack = new List<WuWaGoRollbackSnapshot>();

		// Token: 0x04019C16 RID: 105494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<IRollbackCapture> SavePointSnapshot;

		// Token: 0x04019C17 RID: 105495
		private bool HasUnrolledDrops;

		// Token: 0x04019C18 RID: 105496
		private bool LastEmittedAvailable;

		// Token: 0x04019C19 RID: 105497
		private bool IsAcceptingInput;

		// Token: 0x04019C1A RID: 105498
		[Nullable(2)]
		private RollbackManager.RestoreJob CurrentRestoreJob;

		// Token: 0x04019C1B RID: 105499
		private readonly WuWaGoGameModeBase GameMode;

		// Token: 0x04019C1C RID: 105500
		private readonly WuWaGoGameData GameData;

		// Token: 0x0200A9A7 RID: 43431
		[Nullable(0)]
		[RequiredMember]
		private class RestoreJob
		{
			// Token: 0x0604D749 RID: 317257 RVA: 0x01461D52 File Offset: 0x0145FF52
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public RestoreJob()
			{
			}

			// Token: 0x04033A1B RID: 211483
			[RequiredMember]
			public IReadOnlyList<IRollbackCapture> Captures;

			// Token: 0x04033A1C RID: 211484
			public int Index;

			// Token: 0x04033A1D RID: 211485
			[RequiredMember]
			public Action OnDone;
		}
	}
}
