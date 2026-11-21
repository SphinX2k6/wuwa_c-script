using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200570C RID: 22284
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class DangoBrawlModel : ModelBase
	{
		// Token: 0x06036D9F RID: 224671 RVA: 0x00F4BA84 File Offset: 0x00F49C84
		public void SetPlayRate()
		{
			this.PlayRateIndex++;
			if (this.PlayRateIndex >= DangoBrawlConst.DangoBrawlPlayRateList.Count)
			{
				this.PlayRateIndex = 0;
			}
			float playRate = this.GetPlayRate();
			AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_timescale", (float)((playRate == 1f) ? 1 : 2), null);
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, playRate);
		}

		// Token: 0x06036DA0 RID: 224672 RVA: 0x00F4BAEF File Offset: 0x00F49CEF
		public float GetPlayRate()
		{
			return DangoBrawlConst.DangoBrawlPlayRateList[this.PlayRateIndex];
		}

		// Token: 0x06036DA1 RID: 224673 RVA: 0x00F4BB04 File Offset: 0x00F49D04
		public void ApplyPlayRate()
		{
			float playRate = this.GetPlayRate();
			AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_timescale", (float)((playRate == 1f) ? 1 : 2), null);
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, playRate);
		}

		// Token: 0x06036DA2 RID: 224674 RVA: 0x00F4BB48 File Offset: 0x00F49D48
		public void ResetPlayRate()
		{
			AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_timescale", 1f, null);
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, 1f);
		}

		// Token: 0x06036DA3 RID: 224675 RVA: 0x00F4BB84 File Offset: 0x00F49D84
		[NullableContext(1)]
		public void CreateViewData(ActivityDangoBrawlData data)
		{
			this.CleanViewData();
			this.RollbackController = new DangoBrawlRollbackController(data);
			this.TouchController = new DangoBrawlTouchController(data);
			this.DataController = new DangoBrawlDataController(data);
			this.OperationDispatcher = new DangoBrawlOperationDispatcher();
			this.ViewRegistry = new DangoBrawlItemViewRegistry();
			this.RollbackController.Start();
			this.TouchController.Start();
			this.DataController.Start();
			this.OperationDispatcher.Start();
			this.ViewRegistry.Start();
		}

		// Token: 0x06036DA4 RID: 224676 RVA: 0x00F4BC08 File Offset: 0x00F49E08
		public void CleanViewData()
		{
			DangoBrawlRollbackController rollbackController = this.RollbackController;
			if (rollbackController != null)
			{
				rollbackController.Stop();
			}
			DangoBrawlTouchController touchController = this.TouchController;
			if (touchController != null)
			{
				touchController.Stop();
			}
			DangoBrawlDataController dataController = this.DataController;
			if (dataController != null)
			{
				dataController.Stop();
			}
			DangoBrawlOperationDispatcher operationDispatcher = this.OperationDispatcher;
			if (operationDispatcher != null)
			{
				operationDispatcher.Stop();
			}
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.Stop();
			}
			this.TouchController = null;
			this.DataController = null;
			this.OperationDispatcher = null;
			this.ViewRegistry = null;
			this.RollbackController = null;
		}

		// Token: 0x06036DA5 RID: 224677 RVA: 0x00F4BC8D File Offset: 0x00F49E8D
		public DangoBrawlTouchController GetTouchController()
		{
			return this.TouchController;
		}

		// Token: 0x06036DA6 RID: 224678 RVA: 0x00F4BC95 File Offset: 0x00F49E95
		public DangoBrawlDataController GetDataController()
		{
			return this.DataController;
		}

		// Token: 0x06036DA7 RID: 224679 RVA: 0x00F4BC9D File Offset: 0x00F49E9D
		public DangoBrawlOperationDispatcher GetOperationDispatcher()
		{
			return this.OperationDispatcher;
		}

		// Token: 0x06036DA8 RID: 224680 RVA: 0x00F4BCA5 File Offset: 0x00F49EA5
		public DangoBrawlItemViewRegistry GetViewRegistry()
		{
			return this.ViewRegistry;
		}

		// Token: 0x06036DA9 RID: 224681 RVA: 0x00F4BCAD File Offset: 0x00F49EAD
		public DangoBrawlRollbackController GetRollbackController()
		{
			return this.RollbackController;
		}

		// Token: 0x06036DAA RID: 224682 RVA: 0x00F4BCB5 File Offset: 0x00F49EB5
		public void InitBattleManager()
		{
			this.DestroyBattleManager();
			this.BattleManager = new DangoBrawlBattleManager();
			this.BattleManager.Init();
		}

		// Token: 0x06036DAB RID: 224683 RVA: 0x00F4BCD3 File Offset: 0x00F49ED3
		public void DestroyBattleManager()
		{
			DangoBrawlBattleManager battleManager = this.BattleManager;
			if (battleManager != null)
			{
				battleManager.Destroy();
			}
			this.BattleManager = null;
		}

		// Token: 0x06036DAC RID: 224684 RVA: 0x00F4BCF0 File Offset: 0x00F49EF0
		public DangoBrawlBattleManager GetBattleManager(bool needCheck = true)
		{
			if (this.BattleManager == null && needCheck)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[GetBattleManager] : BattleManager为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return this.BattleManager;
		}

		// Token: 0x170069ED RID: 27117
		// (get) Token: 0x06036DAD RID: 224685 RVA: 0x00F4BD2F File Offset: 0x00F49F2F
		[Nullable(1)]
		public static DangoBrawlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return DangoBrawlModel._Instance;
			}
		}

		// Token: 0x06036DAE RID: 224686 RVA: 0x00F4BD36 File Offset: 0x00F49F36
		[NullableContext(1)]
		public static DangoBrawlModel GetOrCreateInstance()
		{
			if (DangoBrawlModel._Instance == null)
			{
				DangoBrawlModel.CreateInstance();
			}
			return DangoBrawlModel._Instance;
		}

		// Token: 0x06036DAF RID: 224687 RVA: 0x00F4BD4A File Offset: 0x00F49F4A
		public static bool CreateInstance()
		{
			if (DangoBrawlModel._Instance != null)
			{
				return true;
			}
			DangoBrawlModel._Instance = new DangoBrawlModel();
			return true;
		}

		// Token: 0x06036DB0 RID: 224688 RVA: 0x00F4BD60 File Offset: 0x00F49F60
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036DB1 RID: 224689 RVA: 0x00F4BD62 File Offset: 0x00F49F62
		public static void ResetStaticDefaultValue()
		{
			DangoBrawlModel._Instance = null;
		}

		// Token: 0x06036DB2 RID: 224690 RVA: 0x00F4BD6A File Offset: 0x00F49F6A
		static DangoBrawlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DangoBrawlModel.CreateStaticDefaultValue), new Action(DangoBrawlModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D0EE RID: 119022
		private DangoBrawlRollbackController RollbackController;

		// Token: 0x0401D0EF RID: 119023
		private DangoBrawlTouchController TouchController;

		// Token: 0x0401D0F0 RID: 119024
		private DangoBrawlDataController DataController;

		// Token: 0x0401D0F1 RID: 119025
		private DangoBrawlOperationDispatcher OperationDispatcher;

		// Token: 0x0401D0F2 RID: 119026
		private DangoBrawlItemViewRegistry ViewRegistry;

		// Token: 0x0401D0F3 RID: 119027
		protected DangoBrawlBattleManager BattleManager;

		// Token: 0x0401D0F4 RID: 119028
		private int PlayRateIndex;

		// Token: 0x0401D0F5 RID: 119029
		private static DangoBrawlModel _Instance;
	}
}
