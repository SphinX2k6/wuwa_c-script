using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067BC RID: 26556
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class DangoBrawlModel : ModelBase
	{
		// Token: 0x06042249 RID: 270921 RVA: 0x0100A6A0 File Offset: 0x010088A0
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

		// Token: 0x0604224A RID: 270922 RVA: 0x0100A70B File Offset: 0x0100890B
		public float GetPlayRate()
		{
			return DangoBrawlConst.DangoBrawlPlayRateList[this.PlayRateIndex];
		}

		// Token: 0x0604224B RID: 270923 RVA: 0x0100A720 File Offset: 0x01008920
		public void ApplyPlayRate()
		{
			float playRate = this.GetPlayRate();
			AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_timescale", (float)((playRate == 1f) ? 1 : 2), null);
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, playRate);
		}

		// Token: 0x0604224C RID: 270924 RVA: 0x0100A764 File Offset: 0x01008964
		public void ResetPlayRate()
		{
			AudioSystem.Instance.SetRtpcValue("sys_game_3_7_tuanzi_timescale", 1f, null);
			UGameplayStatics.SetGlobalTimeDilation(GlobalData.World, 1f);
		}

		// Token: 0x0604224D RID: 270925 RVA: 0x0100A7A0 File Offset: 0x010089A0
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

		// Token: 0x0604224E RID: 270926 RVA: 0x0100A824 File Offset: 0x01008A24
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

		// Token: 0x0604224F RID: 270927 RVA: 0x0100A8A9 File Offset: 0x01008AA9
		public DangoBrawlTouchController GetTouchController()
		{
			return this.TouchController;
		}

		// Token: 0x06042250 RID: 270928 RVA: 0x0100A8B1 File Offset: 0x01008AB1
		public DangoBrawlDataController GetDataController()
		{
			return this.DataController;
		}

		// Token: 0x06042251 RID: 270929 RVA: 0x0100A8B9 File Offset: 0x01008AB9
		public DangoBrawlOperationDispatcher GetOperationDispatcher()
		{
			return this.OperationDispatcher;
		}

		// Token: 0x06042252 RID: 270930 RVA: 0x0100A8C1 File Offset: 0x01008AC1
		public DangoBrawlItemViewRegistry GetViewRegistry()
		{
			return this.ViewRegistry;
		}

		// Token: 0x06042253 RID: 270931 RVA: 0x0100A8C9 File Offset: 0x01008AC9
		public DangoBrawlRollbackController GetRollbackController()
		{
			return this.RollbackController;
		}

		// Token: 0x06042254 RID: 270932 RVA: 0x0100A8D1 File Offset: 0x01008AD1
		public void InitBattleManager()
		{
			this.DestroyBattleManager();
			this.BattleManager = new DangoBrawlBattleManager();
			this.BattleManager.Init();
		}

		// Token: 0x06042255 RID: 270933 RVA: 0x0100A8EF File Offset: 0x01008AEF
		public void DestroyBattleManager()
		{
			DangoBrawlBattleManager battleManager = this.BattleManager;
			if (battleManager != null)
			{
				battleManager.Destroy();
			}
			this.BattleManager = null;
		}

		// Token: 0x06042256 RID: 270934 RVA: 0x0100A90C File Offset: 0x01008B0C
		public DangoBrawlBattleManager GetBattleManager(bool needCheck = true)
		{
			if (this.BattleManager == null && needCheck)
			{
				Log.Instance.Error(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[GetBattleManager] : BattleManager为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return this.BattleManager;
		}

		// Token: 0x170096AC RID: 38572
		// (get) Token: 0x06042257 RID: 270935 RVA: 0x0100A94B File Offset: 0x01008B4B
		[Nullable(1)]
		public static DangoBrawlModel Instance
		{
			[NullableContext(1)]
			get
			{
				return DangoBrawlModel._Instance;
			}
		}

		// Token: 0x06042258 RID: 270936 RVA: 0x0100A952 File Offset: 0x01008B52
		[NullableContext(1)]
		public static DangoBrawlModel GetOrCreateInstance()
		{
			if (DangoBrawlModel._Instance == null)
			{
				DangoBrawlModel.CreateInstance();
			}
			return DangoBrawlModel._Instance;
		}

		// Token: 0x06042259 RID: 270937 RVA: 0x0100A966 File Offset: 0x01008B66
		public static bool CreateInstance()
		{
			if (DangoBrawlModel._Instance != null)
			{
				return true;
			}
			DangoBrawlModel._Instance = new DangoBrawlModel();
			return true;
		}

		// Token: 0x0604225A RID: 270938 RVA: 0x0100A97C File Offset: 0x01008B7C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604225B RID: 270939 RVA: 0x0100A97E File Offset: 0x01008B7E
		public static void ResetStaticDefaultValue()
		{
			DangoBrawlModel._Instance = null;
		}

		// Token: 0x0604225C RID: 270940 RVA: 0x0100A986 File Offset: 0x01008B86
		static DangoBrawlModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DangoBrawlModel.CreateStaticDefaultValue), new Action(DangoBrawlModel.ResetStaticDefaultValue));
		}

		// Token: 0x04022891 RID: 141457
		private DangoBrawlRollbackController RollbackController;

		// Token: 0x04022892 RID: 141458
		private DangoBrawlTouchController TouchController;

		// Token: 0x04022893 RID: 141459
		private DangoBrawlDataController DataController;

		// Token: 0x04022894 RID: 141460
		private DangoBrawlOperationDispatcher OperationDispatcher;

		// Token: 0x04022895 RID: 141461
		private DangoBrawlItemViewRegistry ViewRegistry;

		// Token: 0x04022896 RID: 141462
		protected DangoBrawlBattleManager BattleManager;

		// Token: 0x04022897 RID: 141463
		private int PlayRateIndex;

		// Token: 0x04022898 RID: 141464
		private static DangoBrawlModel _Instance;
	}
}
