using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004586 RID: 17798
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MapRogueModel : ModelBase
	{
		// Token: 0x0602CDB3 RID: 183731 RVA: 0x00C8DA98 File Offset: 0x00C8BC98
		public void RefreshGameInfo(IGameInfoInitData gameInfo)
		{
			if (this.GameInfo == null)
			{
				this.GameInfo = new MapRogueGameInfo();
			}
			this.GameInfo.Refresh(gameInfo);
			this.CurrencyItemId = gameInfo.CurrencyItemId;
			this.RoleLevel = gameInfo.RoleLevel;
			this.RoleMaxStar = gameInfo.RoleMaxStar;
		}

		// Token: 0x0602CDB4 RID: 183732 RVA: 0x00C8DAE8 File Offset: 0x00C8BCE8
		public void ResetGameInfo()
		{
			MapRogueGameInfo gameInfo = this.GameInfo;
			if (gameInfo != null)
			{
				gameInfo.Clear();
			}
			this.GameInfo = null;
			this.GameOpList.Clear();
		}

		// Token: 0x0602CDB5 RID: 183733 RVA: 0x00C8DB10 File Offset: 0x00C8BD10
		public void GenerateOpList(IList<RogueResOpData> dataList)
		{
			this.GameOpList.Clear();
			foreach (RogueResOpData data in dataList)
			{
				this.AddOpData(data, false);
			}
			this.GameOpList.Sort(new Comparison<MapRogueOp>(this.SortOpData));
			this.PrintAllOpList();
		}

		// Token: 0x0602CDB6 RID: 183734 RVA: 0x00C8DB84 File Offset: 0x00C8BD84
		public unsafe void PrintAllOpList()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RogueBattle;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[MapRogue] 指令队列打印开始";
			string item = "InBattle";
			MapRogueGameInfo gameInfo = this.GameInfo;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (gameInfo != null) ? new bool?(gameInfo.InBattle) : null);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			for (int i = 0; i < this.GameOpList.Count; i++)
			{
				MapRogueOp mapRogueOp = this.GameOpList[i];
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RogueBattle;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[MapRogue] 指令";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", mapRogueOp.ToString());
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602CDB7 RID: 183735 RVA: 0x00C8DC68 File Offset: 0x00C8BE68
		public unsafe void AddOpData(RogueResOpData data, bool emitSort = true)
		{
			MapRogueOp mapRogueOp = null;
			switch (data.RogueResOpType)
			{
			case RogueResOpType.Move:
			{
				MapRogueGameInfo gameInfo = this.GameInfo;
				mapRogueOp = new MapRogueOpMove((gameInfo != null) ? gameInfo.PlayerGridIndex : 0);
				break;
			}
			case RogueResOpType.GridEvent:
				mapRogueOp = new MapRogueOpGridEvent();
				break;
			case RogueResOpType.SelectView:
				mapRogueOp = new MapRogueOpSelectView();
				break;
			case RogueResOpType.ShowView:
				mapRogueOp = new MapRogueOpShowView();
				break;
			case RogueResOpType.RogueGotoLevelPlay:
				mapRogueOp = new MapRogueOpGotoLevelPlay();
				break;
			case RogueResOpType.RollBuffBondLinkId:
				mapRogueOp = new MapRogueOpRoleBuffBondLinkId();
				break;
			case RogueResOpType.FallbackView:
				mapRogueOp = new MapRogueOpFallback();
				break;
			case RogueResOpType.LightBlockByLocationEffect:
				mapRogueOp = new MapRogueOpGridFocus();
				break;
			case RogueResOpType.MapTeleportByLocationEffect:
				mapRogueOp = new MapRogueOpTeleport();
				break;
			case RogueResOpType.ChangeEventByPos:
				mapRogueOp = new MapRogueOpChangeEvent();
				break;
			}
			if (mapRogueOp != null)
			{
				mapRogueOp.Update(data, this.GameInfo);
				this.GameOpList.Add(mapRogueOp);
				this.GameOpMap[data.IncId] = mapRogueOp;
				if (emitSort)
				{
					this.GameOpList.Sort(new Comparison<MapRogueOp>(this.SortOpData));
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[MapRogue] 新增指令";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", this.GameOpList.Count - 1);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", mapRogueOp.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x0602CDB8 RID: 183736 RVA: 0x00C8DDD0 File Offset: 0x00C8BFD0
		public unsafe void RemoveOpData(int incId)
		{
			if (this.GameInfo == null)
			{
				return;
			}
			MapRogueOp mapRogueOp;
			if (!this.GameOpMap.TryGetValue(incId, out mapRogueOp))
			{
				return;
			}
			mapRogueOp.Delete(this.GameInfo);
			int num = this.GameOpList.FindIndex((MapRogueOp op) => op.IncId == incId);
			if (num != -1)
			{
				this.GameOpList.RemoveAt(num);
			}
			this.GameOpMap.Remove(incId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RogueBattle;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[MapRogue] 删除指令";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Index", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IncId", incId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602CDB9 RID: 183737 RVA: 0x00C8DEB4 File Offset: 0x00C8C0B4
		public void UpdateOpData(RogueResOpData data)
		{
			MapRogueOp mapRogueOp;
			if (!this.GameOpMap.TryGetValue(data.IncId, out mapRogueOp))
			{
				return;
			}
			mapRogueOp.Update(data, this.GameInfo);
		}

		// Token: 0x0602CDBA RID: 183738 RVA: 0x00C8DEE4 File Offset: 0x00C8C0E4
		private int SortOpData(MapRogueOp opA, MapRogueOp opB)
		{
			return opB.Priority - opA.Priority;
		}

		// Token: 0x0602CDBB RID: 183739 RVA: 0x00C8DEF4 File Offset: 0x00C8C0F4
		[NullableContext(2)]
		public MapRogueOp GetOpData(int incId)
		{
			MapRogueOp result;
			this.GameOpMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x0602CDBC RID: 183740 RVA: 0x00C8DF11 File Offset: 0x00C8C111
		public List<MapRogueOp> GetAllOpData()
		{
			return this.GameOpList;
		}

		// Token: 0x0602CDBD RID: 183741 RVA: 0x00C8DF1C File Offset: 0x00C8C11C
		public List<MapRogueOp> GetOpDataByType(RogueResOpType type)
		{
			List<MapRogueOp> list = new List<MapRogueOp>();
			foreach (MapRogueOp mapRogueOp in this.GameOpList)
			{
				if (mapRogueOp.Type == type)
				{
					list.Add(mapRogueOp);
				}
			}
			return list;
		}

		// Token: 0x0602CDBE RID: 183742 RVA: 0x00C8DF80 File Offset: 0x00C8C180
		[NullableContext(2)]
		public void ExecuteOpData(int incId, Action<bool> callback = null)
		{
			if (this.GameInfo == null)
			{
				return;
			}
			MapRogueOp mapRogueOp;
			if (this.GameOpMap.TryGetValue(incId, out mapRogueOp) && mapRogueOp != null)
			{
				mapRogueOp.Execute(this.GameInfo, callback);
			}
		}

		// Token: 0x0602CDBF RID: 183743 RVA: 0x00C8DFB8 File Offset: 0x00C8C1B8
		public void ExecuteOpDataList()
		{
			if (this.GameInfo == null)
			{
				return;
			}
			if (this.GameOpList.Count > 0)
			{
				MapRogueOp mapRogueOp = this.GameOpList[this.GameOpList.Count - 1];
				this.GameInfo.GameStage = EMapRogueGameStage.Wait;
				mapRogueOp.StartExecute(this.GameInfo);
				return;
			}
			this.GameInfo.GameStage = EMapRogueGameStage.Norm;
		}

		// Token: 0x0602CDC0 RID: 183744 RVA: 0x00C8E018 File Offset: 0x00C8C218
		public List<MapGridData> CreateMapGridDataList(IList<RogueResGridData> dataList, int randomSeed)
		{
			SeedRandomUtil seedRandomUtil = new SeedRandomUtil();
			seedRandomUtil.SetSeed((long)randomSeed);
			List<MapGridData> list = new List<MapGridData>();
			for (int i = 0; i < dataList.Count; i++)
			{
				RogueResGridData data = dataList[i];
				MapGridData mapGridData = new MapGridData();
				mapGridData.RefreshByServer(data);
				mapGridData.GridIndex = i;
				this.SetGridType(mapGridData, seedRandomUtil);
				list.Add(mapGridData);
			}
			return list;
		}

		// Token: 0x0602CDC1 RID: 183745 RVA: 0x00C8E07C File Offset: 0x00C8C27C
		public void RefreshMapGridData(int index, RogueResGridData data)
		{
			if (index >= this.GameInfo.MapGrids.Count)
			{
				return;
			}
			MapGridData mapGridData = this.GameInfo.MapGrids[index];
			if (mapGridData == null)
			{
				return;
			}
			int gridTypeId = mapGridData.GridTypeId;
			bool isExplore = mapGridData.IsExplore;
			mapGridData.RefreshByServer(data);
			if (gridTypeId != mapGridData.GridTypeId)
			{
				SeedRandomUtil seedRandomUtil = new SeedRandomUtil();
				seedRandomUtil.SetSeed((long)this.GameInfo.RandomSeed);
				this.SetGridType(mapGridData, seedRandomUtil);
			}
			this.GameInfo.RefreshGrid(index, isExplore != mapGridData.IsExplore);
		}

		// Token: 0x0602CDC2 RID: 183746 RVA: 0x00C8E108 File Offset: 0x00C8C308
		private void SetGridType(MapGridData gridData, SeedRandomUtil seedRandomUtil)
		{
			RogueResGridMapType? gridMapTypeConfigById = MapRogueConfig.Instance.GetGridMapTypeConfigById(gridData.GridTypeId);
			if (gridMapTypeConfigById == null)
			{
				return;
			}
			List<int> weights = new List<int>(gridMapTypeConfigById.Value.GroundPath().Values);
			gridData.GroundPathIndex = seedRandomUtil.WeightedRandom(weights);
			Dictionary<string, int> dictionary = gridMapTypeConfigById.Value.DecorationPath();
			if (dictionary != null && dictionary.Count > 0)
			{
				List<int> weights2 = new List<int>(dictionary.Values);
				gridData.ExtraPathIndex = seedRandomUtil.WeightedRandom(weights2);
				return;
			}
			gridData.ExtraPathIndex = -1;
		}

		// Token: 0x0602CDC3 RID: 183747 RVA: 0x00C8E196 File Offset: 0x00C8C396
		[NullableContext(2)]
		public IRogueGetListItemData ShiftGetItemData()
		{
			if (this.GameInfo == null)
			{
				return null;
			}
			return this.GameInfo.ShiftGetItemData();
		}

		// Token: 0x0602CDC4 RID: 183748 RVA: 0x00C8E1AD File Offset: 0x00C8C3AD
		public int GetRogueCurrencyItemId()
		{
			return this.CurrencyItemId;
		}

		// Token: 0x0602CDC5 RID: 183749 RVA: 0x00C8E1B5 File Offset: 0x00C8C3B5
		public int GetRogueRoleLevel()
		{
			return this.RoleLevel;
		}

		// Token: 0x0602CDC6 RID: 183750 RVA: 0x00C8E1BD File Offset: 0x00C8C3BD
		public void SetRoleLevel(int level)
		{
			this.RoleLevel = level;
		}

		// Token: 0x0602CDC7 RID: 183751 RVA: 0x00C8E1C6 File Offset: 0x00C8C3C6
		public int GetRogueRoleMaxStar()
		{
			return this.RoleMaxStar;
		}

		// Token: 0x0602CDC8 RID: 183752 RVA: 0x00C8E1D0 File Offset: 0x00C8C3D0
		public int GetExploredGridCount()
		{
			int num = 0;
			foreach (MapGridData mapGridData in this.GameInfo.MapGrids)
			{
				num += ((mapGridData.IsExplore > false) ? 1 : 0);
			}
			return num;
		}

		// Token: 0x0602CDC9 RID: 183753 RVA: 0x00C8E230 File Offset: 0x00C8C430
		public bool GetDebugMode()
		{
			return false;
		}

		// Token: 0x0602CDCA RID: 183754 RVA: 0x00C8E233 File Offset: 0x00C8C433
		public void SetDebugMode(bool bOn)
		{
			this.DebugMode = bOn;
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x0602CDCB RID: 183755 RVA: 0x00C8E23C File Offset: 0x00C8C43C
		public static MapRogueModel Instance
		{
			get
			{
				return MapRogueModel._Instance;
			}
		}

		// Token: 0x0602CDCC RID: 183756 RVA: 0x00C8E243 File Offset: 0x00C8C443
		public static MapRogueModel GetOrCreateInstance()
		{
			if (MapRogueModel._Instance == null)
			{
				MapRogueModel.CreateInstance();
			}
			return MapRogueModel._Instance;
		}

		// Token: 0x0602CDCD RID: 183757 RVA: 0x00C8E257 File Offset: 0x00C8C457
		public static bool CreateInstance()
		{
			if (MapRogueModel._Instance != null)
			{
				return true;
			}
			MapRogueModel._Instance = new MapRogueModel();
			return true;
		}

		// Token: 0x0602CDCE RID: 183758 RVA: 0x00C8E26D File Offset: 0x00C8C46D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602CDCF RID: 183759 RVA: 0x00C8E26F File Offset: 0x00C8C46F
		public static void ResetStaticDefaultValue()
		{
			MapRogueModel._Instance = null;
		}

		// Token: 0x0602CDD0 RID: 183760 RVA: 0x00C8E277 File Offset: 0x00C8C477
		static MapRogueModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueModel.CreateStaticDefaultValue), new Action(MapRogueModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401808F RID: 98447
		[Nullable(2)]
		public MapRogueGameInfo GameInfo;

		// Token: 0x04018090 RID: 98448
		protected List<MapRogueOp> GameOpList = new List<MapRogueOp>();

		// Token: 0x04018091 RID: 98449
		protected Dictionary<int, MapRogueOp> GameOpMap = new Dictionary<int, MapRogueOp>();

		// Token: 0x04018092 RID: 98450
		private int CurrencyItemId;

		// Token: 0x04018093 RID: 98451
		private int RoleLevel;

		// Token: 0x04018094 RID: 98452
		private int RoleMaxStar;

		// Token: 0x04018095 RID: 98453
		private bool DebugMode;

		// Token: 0x04018096 RID: 98454
		[Nullable(2)]
		private static MapRogueModel _Instance;
	}
}
