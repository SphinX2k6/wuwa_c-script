using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace
{
	// Token: 0x02005BBD RID: 23485
	[NullableContext(2)]
	[Nullable(0)]
	public class SeekTraceModel : ModelBase
	{
		// Token: 0x17006E00 RID: 28160
		// (get) Token: 0x06039B8E RID: 236430 RVA: 0x01036695 File Offset: 0x01034895
		[Nullable(1)]
		public static SeekTraceModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SeekTraceModel._Instance;
			}
		}

		// Token: 0x06039B8F RID: 236431 RVA: 0x0103669C File Offset: 0x0103489C
		[NullableContext(1)]
		public static SeekTraceModel GetOrCreateInstance()
		{
			if (SeekTraceModel._Instance == null)
			{
				SeekTraceModel.CreateInstance();
			}
			return SeekTraceModel._Instance;
		}

		// Token: 0x06039B90 RID: 236432 RVA: 0x010366B0 File Offset: 0x010348B0
		public static bool CreateInstance()
		{
			if (SeekTraceModel._Instance != null)
			{
				return true;
			}
			SeekTraceModel._Instance = new SeekTraceModel();
			return true;
		}

		// Token: 0x06039B91 RID: 236433 RVA: 0x010366C6 File Offset: 0x010348C6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039B92 RID: 236434 RVA: 0x010366C8 File Offset: 0x010348C8
		public static void ResetStaticDefaultValue()
		{
			SeekTraceModel._Instance = null;
		}

		// Token: 0x06039B93 RID: 236435 RVA: 0x010366D0 File Offset: 0x010348D0
		static SeekTraceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeekTraceModel.CreateStaticDefaultValue), new Action(SeekTraceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E7C2 RID: 124866
		public bool IsGameFinish;

		// Token: 0x0401E7C3 RID: 124867
		public bool GameFinishResult;

		// Token: 0x0401E7C4 RID: 124868
		public ITraceTracing Config;

		// Token: 0x0401E7C5 RID: 124869
		public int AddStep;

		// Token: 0x0401E7C6 RID: 124870
		public int PanelWidth;

		// Token: 0x0401E7C7 RID: 124871
		public int PanelHeight;

		// Token: 0x0401E7C8 RID: 124872
		public int ResetTimes;

		// Token: 0x0401E7C9 RID: 124873
		public bool RemainUiAfterCompletion;

		// Token: 0x0401E7CA RID: 124874
		public int CurrentInteractEntityId = -1;

		// Token: 0x0401E7CB RID: 124875
		public ETraceTracingImageType IconType = ETraceTracingImageType.Type1;

		// Token: 0x0401E7CC RID: 124876
		public Action<bool> OnSeekTraceFinish;

		// Token: 0x0401E7CD RID: 124877
		public int StepLimit;

		// Token: 0x0401E7CE RID: 124878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SeekTraceItemData> ItemDataList;

		// Token: 0x0401E7CF RID: 124879
		public List<bool> EnableGridList;

		// Token: 0x0401E7D0 RID: 124880
		public SeekTraceItemData SelectedItem;

		// Token: 0x0401E7D1 RID: 124881
		public int[] SelectedStartPosition;

		// Token: 0x0401E7D2 RID: 124882
		public HashSet<int> SelectedStartFilledIndexSet;

		// Token: 0x0401E7D3 RID: 124883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SeekTraceItemData> IndexToItemMap;

		// Token: 0x0401E7D4 RID: 124884
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<int, HashSet<SeekTraceItemData>> PreSelectedIndexToItemsMap;

		// Token: 0x0401E7D5 RID: 124885
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<SeekTraceItemData, HashSet<int>> ItemToPreSelectedIndexSetMap;

		// Token: 0x0401E7D6 RID: 124886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SeekTraceItemData> MainItemMap;

		// Token: 0x0401E7D7 RID: 124887
		private static SeekTraceModel _Instance;
	}
}
