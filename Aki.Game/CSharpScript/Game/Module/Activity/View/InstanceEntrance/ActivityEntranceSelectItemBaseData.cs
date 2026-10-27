using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F0B RID: 24331
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEntranceSelectItemBaseData
	{
		// Token: 0x0603DD2F RID: 253231 RVA: 0x00EF19A3 File Offset: 0x00EEFBA3
		public bool GetSelectState()
		{
			return this.SelectState;
		}

		// Token: 0x0603DD30 RID: 253232 RVA: 0x00EF19AB File Offset: 0x00EEFBAB
		public void SetSelectState(bool selectState)
		{
			this.SelectState = selectState;
		}

		// Token: 0x0603DD31 RID: 253233 RVA: 0x00EF19B4 File Offset: 0x00EEFBB4
		public int GetUiLogicIndex()
		{
			return this.UiLogicIndex;
		}

		// Token: 0x0603DD32 RID: 253234 RVA: 0x00EF19BC File Offset: 0x00EEFBBC
		[NullableContext(1)]
		public ActivityEntranceSelectItemSubData[] GetSubDataList()
		{
			return this.SubDataList;
		}

		// Token: 0x0603DD33 RID: 253235 RVA: 0x00EF19C4 File Offset: 0x00EEFBC4
		public int GetDataIndex()
		{
			return this.DataIndex;
		}

		// Token: 0x0603DD34 RID: 253236 RVA: 0x00EF19CC File Offset: 0x00EEFBCC
		[NullableContext(1)]
		public string GetName()
		{
			if (this.GetNameFunc == null)
			{
				return string.Empty;
			}
			return this.GetNameFunc(this.DataIndex);
		}

		// Token: 0x0603DD35 RID: 253237 RVA: 0x00EF19ED File Offset: 0x00EEFBED
		[NullableContext(1)]
		public string GetDesc()
		{
			if (this.GetDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetDescFunc(this.DataIndex);
		}

		// Token: 0x0603DD36 RID: 253238 RVA: 0x00EF1A0E File Offset: 0x00EEFC0E
		public bool GetLockState()
		{
			return this.GetLockStateFunc != null && this.GetLockStateFunc(this.DataIndex);
		}

		// Token: 0x0603DD37 RID: 253239 RVA: 0x00EF1A2B File Offset: 0x00EEFC2B
		public int GetInstanceDungeonId()
		{
			if (this.GetInstanceDungeonIdFunc == null)
			{
				return 0;
			}
			return this.GetInstanceDungeonIdFunc(this.DataIndex);
		}

		// Token: 0x0603DD38 RID: 253240 RVA: 0x00EF1A48 File Offset: 0x00EEFC48
		[NullableContext(1)]
		public string GetUnlockDesc()
		{
			if (this.GetUnlockDescFunc == null)
			{
				return string.Empty;
			}
			return this.GetUnlockDescFunc(this.DataIndex);
		}

		// Token: 0x0603DD39 RID: 253241 RVA: 0x00EF1A69 File Offset: 0x00EEFC69
		public int GetRecommendLevel()
		{
			if (this.GetRecommendLevelFunc == null)
			{
				return 0;
			}
			return this.GetRecommendLevelFunc(this.DataIndex);
		}

		// Token: 0x0603DD3A RID: 253242 RVA: 0x00EF1A86 File Offset: 0x00EEFC86
		public bool GetFinishState()
		{
			return this.GetFinishStateFunc != null && this.GetFinishStateFunc(this.DataIndex);
		}

		// Token: 0x0603DD3B RID: 253243 RVA: 0x00EF1AA3 File Offset: 0x00EEFCA3
		public bool GetRedDotState()
		{
			return this.GetRedDotStateFunc != null && this.GetRedDotStateFunc(this.DataIndex);
		}

		// Token: 0x0603DD3C RID: 253244 RVA: 0x00EF1AC0 File Offset: 0x00EEFCC0
		public Action<int> GetClickCallBack()
		{
			return this.ClickCallBack;
		}

		// Token: 0x0603DD3D RID: 253245 RVA: 0x00EF1AC8 File Offset: 0x00EEFCC8
		[NullableContext(1)]
		public string GetSubTitle()
		{
			if (this.GetSubTitleFunc == null)
			{
				return string.Empty;
			}
			return this.GetSubTitleFunc(this.DataIndex);
		}

		// Token: 0x0603DD3E RID: 253246 RVA: 0x00EF1AE9 File Offset: 0x00EEFCE9
		public int GetDefaultDifficultIndex()
		{
			if (this.GetDefaultDifficultIndexFunc == null)
			{
				return 0;
			}
			return this.GetDefaultDifficultIndexFunc(this.DataIndex);
		}

		// Token: 0x0603DD3F RID: 253247 RVA: 0x00EF1B06 File Offset: 0x00EEFD06
		[NullableContext(1)]
		public string GetBgPath()
		{
			if (this.GetBgPathFunc == null)
			{
				return string.Empty;
			}
			return this.GetBgPathFunc(this.DataIndex);
		}

		// Token: 0x0603DD40 RID: 253248 RVA: 0x00EF1B28 File Offset: 0x00EEFD28
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

		// Token: 0x040204AB RID: 132267
		private bool SelectState;

		// Token: 0x040204AC RID: 132268
		private int DataIndex;

		// Token: 0x040204AD RID: 132269
		private int UiLogicIndex;

		// Token: 0x040204AE RID: 132270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetNameFunc;

		// Token: 0x040204AF RID: 132271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetDescFunc;

		// Token: 0x040204B0 RID: 132272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetSubTitleFunc;

		// Token: 0x040204B1 RID: 132273
		private Func<int, bool> GetLockStateFunc;

		// Token: 0x040204B2 RID: 132274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetUnlockDescFunc;

		// Token: 0x040204B3 RID: 132275
		private Func<int, int> GetInstanceDungeonIdFunc;

		// Token: 0x040204B4 RID: 132276
		private Func<int, bool> GetFinishStateFunc;

		// Token: 0x040204B5 RID: 132277
		private Func<int, int> GetRecommendLevelFunc;

		// Token: 0x040204B6 RID: 132278
		private Func<int, bool> GetRedDotStateFunc;

		// Token: 0x040204B7 RID: 132279
		private Func<int, int> GetDefaultDifficultIndexFunc;

		// Token: 0x040204B8 RID: 132280
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<int, string> GetBgPathFunc;

		// Token: 0x040204B9 RID: 132281
		private Action<int> ClickCallBack;

		// Token: 0x040204BA RID: 132282
		[Nullable(1)]
		private ActivityEntranceSelectItemSubData[] SubDataList = Array.Empty<ActivityEntranceSelectItemSubData>();
	}
}
