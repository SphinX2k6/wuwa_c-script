using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02006A60 RID: 27232
	[NullableContext(2)]
	[Nullable(0)]
	public class SeekTraceModel : ModelBase
	{
		// Token: 0x1700991B RID: 39195
		// (get) Token: 0x06043B40 RID: 277312 RVA: 0x01091E61 File Offset: 0x01090061
		[Nullable(1)]
		public static SeekTraceModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SeekTraceModel._Instance;
			}
		}

		// Token: 0x06043B41 RID: 277313 RVA: 0x01091E68 File Offset: 0x01090068
		[NullableContext(1)]
		public static SeekTraceModel GetOrCreateInstance()
		{
			if (SeekTraceModel._Instance == null)
			{
				SeekTraceModel.CreateInstance();
			}
			return SeekTraceModel._Instance;
		}

		// Token: 0x06043B42 RID: 277314 RVA: 0x01091E7C File Offset: 0x0109007C
		public static bool CreateInstance()
		{
			if (SeekTraceModel._Instance != null)
			{
				return true;
			}
			SeekTraceModel._Instance = new SeekTraceModel();
			return true;
		}

		// Token: 0x06043B43 RID: 277315 RVA: 0x01091E92 File Offset: 0x01090092
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043B44 RID: 277316 RVA: 0x01091E94 File Offset: 0x01090094
		public static void ResetStaticDefaultValue()
		{
			SeekTraceModel._Instance = null;
		}

		// Token: 0x06043B45 RID: 277317 RVA: 0x01091E9C File Offset: 0x0109009C
		static SeekTraceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeekTraceModel.CreateStaticDefaultValue), new Action(SeekTraceModel.ResetStaticDefaultValue));
		}

		// Token: 0x040235D0 RID: 144848
		public bool IsGameFinish;

		// Token: 0x040235D1 RID: 144849
		public bool GameFinishResult;

		// Token: 0x040235D2 RID: 144850
		public ITraceTracing Config;

		// Token: 0x040235D3 RID: 144851
		public int AddStep;

		// Token: 0x040235D4 RID: 144852
		public int PanelWidth;

		// Token: 0x040235D5 RID: 144853
		public int PanelHeight;

		// Token: 0x040235D6 RID: 144854
		public int ResetTimes;

		// Token: 0x040235D7 RID: 144855
		public bool RemainUiAfterCompletion;

		// Token: 0x040235D8 RID: 144856
		public int CurrentInteractEntityId = -1;

		// Token: 0x040235D9 RID: 144857
		public ETraceTracingImageType IconType = ETraceTracingImageType.Type1;

		// Token: 0x040235DA RID: 144858
		public Action<bool> OnSeekTraceFinish;

		// Token: 0x040235DB RID: 144859
		public int StepLimit;

		// Token: 0x040235DC RID: 144860
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SeekTraceItemData> ItemDataList;

		// Token: 0x040235DD RID: 144861
		public List<bool> EnableGridList;

		// Token: 0x040235DE RID: 144862
		public SeekTraceItemData SelectedItem;

		// Token: 0x040235DF RID: 144863
		public int[] SelectedStartPosition;

		// Token: 0x040235E0 RID: 144864
		public HashSet<int> SelectedStartFilledIndexSet;

		// Token: 0x040235E1 RID: 144865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SeekTraceItemData> IndexToItemMap;

		// Token: 0x040235E2 RID: 144866
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<int, HashSet<SeekTraceItemData>> PreSelectedIndexToItemsMap;

		// Token: 0x040235E3 RID: 144867
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<SeekTraceItemData, HashSet<int>> ItemToPreSelectedIndexSetMap;

		// Token: 0x040235E4 RID: 144868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SeekTraceItemData> MainItemMap;

		// Token: 0x040235E5 RID: 144869
		private static SeekTraceModel _Instance;
	}
}
