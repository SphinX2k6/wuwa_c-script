using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.LevelRangeDebug
{
	// Token: 0x02004569 RID: 17769
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelRangeDebugDrawModel : ModelBase
	{
		// Token: 0x17007586 RID: 30086
		// (get) Token: 0x0602DE49 RID: 187977 RVA: 0x00A8D9E9 File Offset: 0x00A8BBE9
		public static LevelRangeDebugDrawModel Instance
		{
			get
			{
				return LevelRangeDebugDrawModel._Instance;
			}
		}

		// Token: 0x0602DE4A RID: 187978 RVA: 0x00A8D9F0 File Offset: 0x00A8BBF0
		public static LevelRangeDebugDrawModel GetOrCreateInstance()
		{
			if (LevelRangeDebugDrawModel._Instance == null)
			{
				LevelRangeDebugDrawModel.CreateInstance();
			}
			return LevelRangeDebugDrawModel._Instance;
		}

		// Token: 0x0602DE4B RID: 187979 RVA: 0x00A8DA04 File Offset: 0x00A8BC04
		public static bool CreateInstance()
		{
			if (LevelRangeDebugDrawModel._Instance != null)
			{
				return true;
			}
			LevelRangeDebugDrawModel._Instance = new LevelRangeDebugDrawModel();
			return true;
		}

		// Token: 0x0602DE4C RID: 187980 RVA: 0x00A8DA1A File Offset: 0x00A8BC1A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DE4D RID: 187981 RVA: 0x00A8DA1C File Offset: 0x00A8BC1C
		public static void ResetStaticDefaultValue()
		{
			LevelRangeDebugDrawModel._Instance = null;
		}

		// Token: 0x0602DE4E RID: 187982 RVA: 0x00A8DA24 File Offset: 0x00A8BC24
		static LevelRangeDebugDrawModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelRangeDebugDrawModel.CreateStaticDefaultValue), new Action(LevelRangeDebugDrawModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018829 RID: 100393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<ELevelRangeType, LevelRangeDrawData> DrawDataMap;

		// Token: 0x0401882A RID: 100394
		public EDebugDrawMode DrawMode;

		// Token: 0x0401882B RID: 100395
		public float DrawRemainTime;

		// Token: 0x0401882C RID: 100396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, LevelRangeTreeReferenceData> QuestReferenceDataMap;

		// Token: 0x0401882D RID: 100397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, LevelRangeTreeReferenceData> LevelPlayReferenceDataMap;

		// Token: 0x0401882E RID: 100398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Queue<LevelRangeDrawVolumeCache> DrawVolumeCache;

		// Token: 0x0401882F RID: 100399
		[Nullable(2)]
		private static LevelRangeDebugDrawModel _Instance;
	}
}
