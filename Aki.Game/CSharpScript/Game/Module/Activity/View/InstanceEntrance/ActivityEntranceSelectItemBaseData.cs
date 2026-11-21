using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF2 RID: 20210
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEntranceSelectItemBaseData
	{
		// Token: 0x06032CCA RID: 208074 RVA: 0x00E436AB File Offset: 0x00E418AB
		public bool GetSelectState()
		{
			return this.SelectState;
		}

		// Token: 0x06032CCB RID: 208075 RVA: 0x00E436B3 File Offset: 0x00E418B3
		public void SetSelectState(bool selectState)
		{
			this.SelectState = selectState;
		}

		// Token: 0x06032CCC RID: 208076 RVA: 0x00E436BC File Offset: 0x00E418BC
		public int GetUiLogicIndex()
		{
			return this.UiLogicIndex;
		}

		// Token: 0x06032CCD RID: 208077 RVA: 0x00E436C4 File Offset: 0x00E418C4
		[NullableContext(1)]
		public ActivityEntranceSelectItemSubData[] GetSubDataList()
		{
			return this.SubDataList;
		}

		// Token: 0x06032CCE RID: 208078 RVA: 0x00E436CC File Offset: 0x00E418CC
		public int GetDataIndex()
		{
			return this.DataIndex;
		}

		// Token: 0x06032CCF RID: 208079 RVA: 0x00E436D4 File Offset: 0x00E418D4
		[NullableContext(1)]
		public string GetName()
		{
			if (this.GetNameFunc == null)
			{
				return string.Empty;
			}
			return this.GetNameFunc(this.DataIndex);
		}

		// Token: 0x06032CD0 RID: 208080 RVA: 0x00E436F5 File Offset: 0x00E418F5
		[NullableContext(1)]
		public string GetDesc()
		{
			if (this.GetDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetDescFunc(this.DataIndex);
		}

		// Token: 0x06032CD1 RID: 208081 RVA: 0x00E43716 File Offset: 0x00E41916
		public bool GetLockState()
		{
			return this.GetLockStateFunc != null && this.GetLockStateFunc(this.DataIndex);
		}

		// Token: 0x06032CD2 RID: 208082 RVA: 0x00E43733 File Offset: 0x00E41933
		public int GetInstanceDungeonId()
		{
			if (this.GetInstanceDungeonIdFunc == null)
			{
				return 0;
			}
			return this.GetInstanceDungeonIdFunc(this.DataIndex);
		}

		// Token: 0x06032CD3 RID: 208083 RVA: 0x00E43750 File Offset: 0x00E41950
		[NullableContext(1)]
		public string GetUnlockDesc()
		{
			if (this.GetUnlockDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetUnlockDescFunc(this.DataIndex);
		}

		// Token: 0x06032CD4 RID: 208084 RVA: 0x00E43771 File Offset: 0x00E41971
		public int GetRecommendLevel()
		{
			if (this.GetRecommendLevelFunc == null)
			{
				return 0;
			}
			return this.GetRecommendLevelFunc(this.DataIndex);
		}

		// Token: 0x06032CD5 RID: 208085 RVA: 0x00E4378E File Offset: 0x00E4198E
		public bool GetFinishState()
		{
			return this.GetFinishStateFunc != null && this.GetFinishStateFunc(this.DataIndex);
		}

		// Token: 0x06032CD6 RID: 208086 RVA: 0x00E437AB File Offset: 0x00E419AB
		public bool GetRedDotState()
		{
			return this.GetRedDotStateFunc != null && this.GetRedDotStateFunc(this.DataIndex);
		}

		// Token: 0x06032CD7 RID: 208087 RVA: 0x00E437C8 File Offset: 0x00E419C8
		public Action<int> GetClickCallBack()
		{
			return this.ClickCallBack;
		}

		// Token: 0x06032CD8 RID: 208088 RVA: 0x00E437D0 File Offset: 0x00E419D0
		[NullableContext(1)]
		public string GetSubTitle()
		{
			if (this.GetSubTitleFunc == null)
			{
				return string.Empty;
			}
			return this.GetSubTitleFunc(this.DataIndex);
		}

		// Token: 0x06032CD9 RID: 208089 RVA: 0x00E437F1 File Offset: 0x00E419F1
		public int GetDefaultDifficultIndex()
		{
			if (this.GetDefaultDifficultIndexFunc == null)
			{
				return 0;
			}
			return this.GetDefaultDifficultIndexFunc(this.DataIndex);
		}

		// Token: 0x06032CDA RID: 208090 RVA: 0x00E4380E File Offset: 0x00E41A0E
		[NullableContext(1)]
		public string GetBgPath()
		{
			if (this.GetBgPathFunc == null)
			{
				return string.Empty;
			}
			return this.GetBgPathFunc(this.DataIndex);
		}

		// Token: 0x06032CDB RID: 208091 RVA: 0x00E43830 File Offset: 0x00E41A30
		[return: Nullable(1)]
		public static ActivityEntranceSelectItemBaseData Create(int dataIndex, int uiLogicIndex, [Nullable(new byte[]
		{
			2,
			1
		})] ActivityEntranceSelectItemSubData[] subData, [Nullable(new byte[]
		{
			2,
			1
		})] Func<int, string> getNameFunc, [Nullable(new byte[]
		{
			2,
			1
		})] Func<int, string> getDescFunc, [Nullable(new byte[]
		{
			2,
			1
		})] Func<int, string> getSubTitleFunc, Func<int, bool> getLockStateFunc, Func<int, int> getInstanceDungeonIdFunc, [Nullable(new byte[]
		{
			2,
			1
		})] Func<int, string> getUnlockDescFunc, Func<int, bool> getFinishStateFunc, Func<int, int> getRecommendLevelFunc, Func<int, int> getDefaultDifficultIndex, [Nullable(new byte[]
		{
			2,
			1
		})] Func<int, string> getBgPathFunc, Action<int> clickCallBack, Func<int, bool> getRedDotStateFunc)
		{
			return new ActivityEntranceSelectItemBaseData
			{
				SelectState = false,
				DataIndex = dataIndex,
				UiLogicIndex = uiLogicIndex,
				GetNameFunc = getNameFunc,
				GetDescFunc = getDescFunc,
				GetSubTitleFunc = getSubTitleFunc,
				GetLockStateFunc = getLockStateFunc,
				GetInstanceDungeonIdFunc = getInstanceDungeonIdFunc,
				GetUnlockDescFunc = getUnlockDescFunc,
				GetFinishStateFunc = getFinishStateFunc,
				GetRedDotStateFunc = getRedDotStateFunc,
				GetDefaultDifficultIndexFunc = getDefaultDifficultIndex,
				GetRecommendLevelFunc = getRecommendLevelFunc,
				GetBgPathFunc = getBgPathFunc,
				ClickCallBack = clickCallBack,
				SubDataList = (subData ?? Array.Empty<ActivityEntranceSelectItemSubData>())
			};
		}

		// Token: 0x0401AF7D RID: 110461
		private bool SelectState;

		// Token: 0x0401AF7E RID: 110462
		private int DataIndex;

		// Token: 0x0401AF7F RID: 110463
		private int UiLogicIndex;

		// Token: 0x0401AF80 RID: 110464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetNameFunc;

		// Token: 0x0401AF81 RID: 110465
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetDescFunc;

		// Token: 0x0401AF82 RID: 110466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetSubTitleFunc;

		// Token: 0x0401AF83 RID: 110467
		private Func<int, bool> GetLockStateFunc;

		// Token: 0x0401AF84 RID: 110468
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetUnlockDescFunc;

		// Token: 0x0401AF85 RID: 110469
		private Func<int, int> GetInstanceDungeonIdFunc;

		// Token: 0x0401AF86 RID: 110470
		private Func<int, bool> GetFinishStateFunc;

		// Token: 0x0401AF87 RID: 110471
		private Func<int, int> GetRecommendLevelFunc;

		// Token: 0x0401AF88 RID: 110472
		private Func<int, bool> GetRedDotStateFunc;

		// Token: 0x0401AF89 RID: 110473
		private Func<int, int> GetDefaultDifficultIndexFunc;

		// Token: 0x0401AF8A RID: 110474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetBgPathFunc;

		// Token: 0x0401AF8B RID: 110475
		private Action<int> ClickCallBack;

		// Token: 0x0401AF8C RID: 110476
		[Nullable(1)]
		private ActivityEntranceSelectItemSubData[] SubDataList = Array.Empty<ActivityEntranceSelectItemSubData>();
	}
}
