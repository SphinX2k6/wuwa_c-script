using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SubLevelLoading
{
	// Token: 0x02003B20 RID: 15136
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class SubLevelLoadingModel : ModelBase
	{
		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x06026E65 RID: 159333 RVA: 0x00AE320D File Offset: 0x00AE140D
		// (set) Token: 0x06026E66 RID: 159334 RVA: 0x00AE3215 File Offset: 0x00AE1415
		public EScreenEffectType ScreenEffect
		{
			get
			{
				return this.ScreenEffectInternal;
			}
			set
			{
				this.ScreenEffectInternal = value;
			}
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06026E68 RID: 159336 RVA: 0x00AE3227 File Offset: 0x00AE1427
		// (set) Token: 0x06026E67 RID: 159335 RVA: 0x00AE321E File Offset: 0x00AE141E
		public GameModePromise LoadSubLevelPromise
		{
			get
			{
				return this.LoadSubLevelPromiseInternal;
			}
			set
			{
				this.LoadSubLevelPromiseInternal = value;
			}
		}

		// Token: 0x06026E69 RID: 159337 RVA: 0x00AE322F File Offset: 0x00AE142F
		protected override bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x06026E6A RID: 159338 RVA: 0x00AE3232 File Offset: 0x00AE1432
		protected override bool OnClear()
		{
			this.ScreenEffectInternal = EScreenEffectType.ScreenEffectNone;
			LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
			this.LoadSubLevelPromiseInternal = null;
			return true;
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06026E6B RID: 159339 RVA: 0x00AE3253 File Offset: 0x00AE1453
		[Nullable(1)]
		public static SubLevelLoadingModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SubLevelLoadingModel._Instance;
			}
		}

		// Token: 0x06026E6C RID: 159340 RVA: 0x00AE325A File Offset: 0x00AE145A
		[NullableContext(1)]
		public static SubLevelLoadingModel GetOrCreateInstance()
		{
			if (SubLevelLoadingModel._Instance == null)
			{
				SubLevelLoadingModel.CreateInstance();
			}
			return SubLevelLoadingModel._Instance;
		}

		// Token: 0x06026E6D RID: 159341 RVA: 0x00AE326E File Offset: 0x00AE146E
		public static bool CreateInstance()
		{
			if (SubLevelLoadingModel._Instance != null)
			{
				return true;
			}
			SubLevelLoadingModel._Instance = new SubLevelLoadingModel();
			return true;
		}

		// Token: 0x06026E6E RID: 159342 RVA: 0x00AE3284 File Offset: 0x00AE1484
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026E6F RID: 159343 RVA: 0x00AE3286 File Offset: 0x00AE1486
		public static void ResetStaticDefaultValue()
		{
			SubLevelLoadingModel._Instance = null;
		}

		// Token: 0x06026E70 RID: 159344 RVA: 0x00AE328E File Offset: 0x00AE148E
		static SubLevelLoadingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SubLevelLoadingModel.CreateStaticDefaultValue), new Action(SubLevelLoadingModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015414 RID: 87060
		private EScreenEffectType ScreenEffectInternal;

		// Token: 0x04015415 RID: 87061
		private GameModePromise LoadSubLevelPromiseInternal;

		// Token: 0x04015416 RID: 87062
		private static SubLevelLoadingModel _Instance;
	}
}
