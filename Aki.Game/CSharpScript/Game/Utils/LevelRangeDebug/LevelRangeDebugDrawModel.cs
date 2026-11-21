using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.LevelRangeDebug
{
	// Token: 0x02003491 RID: 13457
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelRangeDebugDrawModel : ModelBase
	{
		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x0602252B RID: 140587 RVA: 0x009B9101 File Offset: 0x009B7301
		public static LevelRangeDebugDrawModel Instance
		{
			get
			{
				return LevelRangeDebugDrawModel._Instance;
			}
		}

		// Token: 0x0602252C RID: 140588 RVA: 0x009B9108 File Offset: 0x009B7308
		public static LevelRangeDebugDrawModel GetOrCreateInstance()
		{
			if (LevelRangeDebugDrawModel._Instance == null)
			{
				LevelRangeDebugDrawModel.CreateInstance();
			}
			return LevelRangeDebugDrawModel._Instance;
		}

		// Token: 0x0602252D RID: 140589 RVA: 0x009B911C File Offset: 0x009B731C
		public static bool CreateInstance()
		{
			if (LevelRangeDebugDrawModel._Instance != null)
			{
				return true;
			}
			LevelRangeDebugDrawModel._Instance = new LevelRangeDebugDrawModel();
			return true;
		}

		// Token: 0x0602252E RID: 140590 RVA: 0x009B9132 File Offset: 0x009B7332
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602252F RID: 140591 RVA: 0x009B9134 File Offset: 0x009B7334
		public static void ResetStaticDefaultValue()
		{
			LevelRangeDebugDrawModel._Instance = null;
		}

		// Token: 0x06022530 RID: 140592 RVA: 0x009B913C File Offset: 0x009B733C
		static LevelRangeDebugDrawModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelRangeDebugDrawModel.CreateStaticDefaultValue), new Action(LevelRangeDebugDrawModel.ResetStaticDefaultValue));
		}

		// Token: 0x04012E63 RID: 77411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<ELevelRangeType, LevelRangeDrawData> DrawDataMap;

		// Token: 0x04012E64 RID: 77412
		public EDebugDrawMode DrawMode;

		// Token: 0x04012E65 RID: 77413
		public float DrawRemainTime;

		// Token: 0x04012E66 RID: 77414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, LevelRangeTreeReferenceData> QuestReferenceDataMap;

		// Token: 0x04012E67 RID: 77415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, LevelRangeTreeReferenceData> LevelPlayReferenceDataMap;

		// Token: 0x04012E68 RID: 77416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Queue<LevelRangeDrawVolumeCache> DrawVolumeCache;

		// Token: 0x04012E69 RID: 77417
		[Nullable(2)]
		private static LevelRangeDebugDrawModel _Instance;
	}
}
