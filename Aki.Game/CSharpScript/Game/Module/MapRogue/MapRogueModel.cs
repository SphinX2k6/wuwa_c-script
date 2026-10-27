using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B0 RID: 21936
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MapRogueModel : ModelBase
	{
		// Token: 0x06037EB5 RID: 229045 RVA: 0x00D3FD50 File Offset: 0x00D3DF50
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

		// Token: 0x06037EB6 RID: 229046 RVA: 0x00D3FDA0 File Offset: 0x00D3DFA0
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

		// Token: 0x06037EB7 RID: 229047 RVA: 0x00D3FDC8 File Offset: 0x00D3DFC8
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

		// Token: 0x06037EB8 RID: 229048 RVA: 0x00D3FE3C File Offset: 0x00D3E03C
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

		// Token: 0x06037EB9 RID: 229049 RVA: 0x00D3FF20 File Offset: 0x00D3E120
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

		// Token: 0x06037EBA RID: 229050 RVA: 0x00D40088 File Offset: 0x00D3E288
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

		// Token: 0x06037EBB RID: 229051 RVA: 0x00D4016C File Offset: 0x00D3E36C
		public void UpdateOpData(RogueResOpData data)
		{
			MapRogueOp mapRogueOp;
			if (!this.GameOpMap.TryGetValue(data.IncId, out mapRogueOp))
			{
				return;
			}
			mapRogueOp.Update(data, this.GameInfo);
		}

		// Token: 0x06037EBC RID: 229052 RVA: 0x00D4019C File Offset: 0x00D3E39C
		private int SortOpData(MapRogueOp opA, MapRogueOp opB)
		{
			return opB.Priority - opA.Priority;
		}

		// Token: 0x06037EBD RID: 229053 RVA: 0x00D401AC File Offset: 0x00D3E3AC
		[NullableContext(2)]
		public MapRogueOp GetOpData(int incId)
		{
			MapRogueOp result;
			this.GameOpMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x06037EBE RID: 229054 RVA: 0x00D401C9 File Offset: 0x00D3E3C9
		public List<MapRogueOp> GetAllOpData()
		{
			return this.GameOpList;
		}

		// Token: 0x06037EBF RID: 229055 RVA: 0x00D401D4 File Offset: 0x00D3E3D4
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

		// Token: 0x06037EC0 RID: 229056 RVA: 0x00D40238 File Offset: 0x00D3E438
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

		// Token: 0x06037EC1 RID: 229057 RVA: 0x00D40270 File Offset: 0x00D3E470
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

		// Token: 0x06037EC2 RID: 229058 RVA: 0x00D402D0 File Offset: 0x00D3E4D0
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

		// Token: 0x06037EC3 RID: 229059 RVA: 0x00D40334 File Offset: 0x00D3E534
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

		// Token: 0x06037EC4 RID: 229060 RVA: 0x00D403C0 File Offset: 0x00D3E5C0
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

		// Token: 0x06037EC5 RID: 229061 RVA: 0x00D4044E File Offset: 0x00D3E64E
		[NullableContext(2)]
		public IRogueGetListItemData ShiftGetItemData()
		{
			if (this.GameInfo == null)
			{
				return null;
			}
			return this.GameInfo.ShiftGetItemData();
		}

		// Token: 0x06037EC6 RID: 229062 RVA: 0x00D40465 File Offset: 0x00D3E665
		public int GetRogueCurrencyItemId()
		{
			return this.CurrencyItemId;
		}

		// Token: 0x06037EC7 RID: 229063 RVA: 0x00D4046D File Offset: 0x00D3E66D
		public int GetRogueRoleLevel()
		{
			return this.RoleLevel;
		}

		// Token: 0x06037EC8 RID: 229064 RVA: 0x00D40475 File Offset: 0x00D3E675
		public void SetRoleLevel(int level)
		{
			this.RoleLevel = level;
		}

		// Token: 0x06037EC9 RID: 229065 RVA: 0x00D4047E File Offset: 0x00D3E67E
		public int GetRogueRoleMaxStar()
		{
			return this.RoleMaxStar;
		}

		// Token: 0x06037ECA RID: 229066 RVA: 0x00D40488 File Offset: 0x00D3E688
		public int GetExploredGridCount()
		{
			int num = 0;
			foreach (MapGridData mapGridData in this.GameInfo.MapGrids)
			{
				num += ((mapGridData.IsExplore > false) ? 1 : 0);
			}
			return num;
		}

		// Token: 0x06037ECB RID: 229067 RVA: 0x00D404E8 File Offset: 0x00D3E6E8
		public bool GetDebugMode()
		{
			return false;
		}

		// Token: 0x06037ECC RID: 229068 RVA: 0x00D404EB File Offset: 0x00D3E6EB
		public void SetDebugMode(bool bOn)
		{
			this.DebugMode = bOn;
		}

		// Token: 0x170086BE RID: 34494
		// (get) Token: 0x06037ECD RID: 229069 RVA: 0x00D404F4 File Offset: 0x00D3E6F4
		public static MapRogueModel Instance
		{
			get
			{
				return MapRogueModel._Instance;
			}
		}

		// Token: 0x06037ECE RID: 229070 RVA: 0x00D404FB File Offset: 0x00D3E6FB
		public static MapRogueModel GetOrCreateInstance()
		{
			if (MapRogueModel._Instance == null)
			{
				MapRogueModel.CreateInstance();
			}
			return MapRogueModel._Instance;
		}

		// Token: 0x06037ECF RID: 229071 RVA: 0x00D4050F File Offset: 0x00D3E70F
		public static bool CreateInstance()
		{
			if (MapRogueModel._Instance != null)
			{
				return true;
			}
			MapRogueModel._Instance = new MapRogueModel();
			return true;
		}

		// Token: 0x06037ED0 RID: 229072 RVA: 0x00D40525 File Offset: 0x00D3E725
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037ED1 RID: 229073 RVA: 0x00D40527 File Offset: 0x00D3E727
		public static void ResetStaticDefaultValue()
		{
			MapRogueModel._Instance = null;
		}

		// Token: 0x06037ED2 RID: 229074 RVA: 0x00D4052F File Offset: 0x00D3E72F
		static MapRogueModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapRogueModel.CreateStaticDefaultValue), new Action(MapRogueModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401D604 RID: 120324
		[Nullable(2)]
		public MapRogueGameInfo GameInfo;

		// Token: 0x0401D605 RID: 120325
		protected List<MapRogueOp> GameOpList = new List<MapRogueOp>();

		// Token: 0x0401D606 RID: 120326
		protected Dictionary<int, MapRogueOp> GameOpMap = new Dictionary<int, MapRogueOp>();

		// Token: 0x0401D607 RID: 120327
		private int CurrencyItemId;

		// Token: 0x0401D608 RID: 120328
		private int RoleLevel;

		// Token: 0x0401D609 RID: 120329
		private int RoleMaxStar;

		// Token: 0x0401D60A RID: 120330
		private bool DebugMode;

		// Token: 0x0401D60B RID: 120331
		[Nullable(2)]
		private static MapRogueModel _Instance;
	}
}
