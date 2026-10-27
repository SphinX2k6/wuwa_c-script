using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B81 RID: 19329
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksGameData
	{
		// Token: 0x17007C3F RID: 31807
		// (get) Token: 0x06032168 RID: 205160 RVA: 0x00BA17C0 File Offset: 0x00B9F9C0
		// (set) Token: 0x06032169 RID: 205161 RVA: 0x00BA17C8 File Offset: 0x00B9F9C8
		[Nullable(2)]
		public Tetromino CurTetromino
		{
			[NullableContext(2)]
			get
			{
				return this.CurTetrominoInternal;
			}
			[NullableContext(2)]
			set
			{
				this.CurTetrominoInternal = value;
			}
		}

		// Token: 0x17007C40 RID: 31808
		// (get) Token: 0x0603216A RID: 205162 RVA: 0x00BA17D1 File Offset: 0x00B9F9D1
		public double GridMaxX
		{
			get
			{
				return this.GridSize.X - 0.5;
			}
		}

		// Token: 0x17007C41 RID: 31809
		// (get) Token: 0x0603216B RID: 205163 RVA: 0x00BA17E8 File Offset: 0x00B9F9E8
		public double GridMinY
		{
			get
			{
				if (this.PlayMode != ETetrisPlayMode.MainLine)
				{
					return (double)SlidingBlocksGlobal.Setting.PrepareAreaMinY + 0.5;
				}
				return 0.5;
			}
		}

		// Token: 0x17007C42 RID: 31810
		// (get) Token: 0x0603216C RID: 205164 RVA: 0x00BA1812 File Offset: 0x00B9FA12
		public double GridMaxY
		{
			get
			{
				return this.GridSize.Y - 0.5;
			}
		}

		// Token: 0x0603216D RID: 205165 RVA: 0x00BA1829 File Offset: 0x00B9FA29
		public float SingleCellMoveTime()
		{
			return (float)TimeUtil.Instance.InverseMillisecond / this.FallSpeed;
		}

		// Token: 0x0603216E RID: 205166 RVA: 0x00BA1840 File Offset: 0x00B9FA40
		public void Init(IFinishTetris config, global::Transform originTransform, Bp_Tetris_C setting, GeneralLogicTreeContext context)
		{
			this.OriginTransform = originTransform;
			this.PlayMode = config.PlayMode.Type;
			this.Score = 0.0;
			Vector2D gridSize = this.GridSize;
			ITetrisIndexedBoard presetBlocks = config.PresetBlocks;
			double inX = Math.Floor((double)((presetBlocks != null) ? presetBlocks.BoardSize.X : setting.DefaultBoardSize.X));
			ITetrisIndexedBoard presetBlocks2 = config.PresetBlocks;
			gridSize.Set(inX, Math.Floor((double)((presetBlocks2 != null) ? presetBlocks2.BoardSize.Y : setting.DefaultBoardSize.Y)));
			switch (config.PlayMode.Type)
			{
			case ETetrisPlayMode.Normal:
			{
				ITetrisPlayModeNormal tetrisPlayModeNormal = config.PlayMode as ITetrisPlayModeNormal;
				this.Time = (double)((tetrisPlayModeNormal != null) ? tetrisPlayModeNormal.Time : 0);
				break;
			}
			case ETetrisPlayMode.Endless:
			{
				ITetrisPlayModeEndless tetrisPlayModeEndless = config.PlayMode as ITetrisPlayModeEndless;
				this.SpeedLevel = ((tetrisPlayModeEndless != null) ? tetrisPlayModeEndless.SpeedLevel : null).GetValueOrDefault(1);
				this.SpeedUpTime = 0.0;
				break;
			}
			case ETetrisPlayMode.MainLine:
			{
				ITetrisPlayModeMainLine tetrisPlayModeMainLine = config.PlayMode as ITetrisPlayModeMainLine;
				this.SequenceEntityPbDataId = tetrisPlayModeMainLine.EntityId;
				this.SequenceEntityInitState = tetrisPlayModeMainLine.EntityState;
				if (tetrisPlayModeMainLine.FieldHeight != null)
				{
					this.GridSize.Y = (double)tetrisPlayModeMainLine.FieldHeight.Value;
				}
				break;
			}
			}
			this.PresetBlocks = null;
			if (config.PresetBlocks != null)
			{
				this.PresetBlocks = config.PresetBlocks.IndexedGrids;
			}
			this.CurSpawnTetrominoList = null;
			this.AllTetrominoList.Clear();
			this.WaitRemoveTetrominoList.Clear();
			this.Direction = config.Direction;
			this.FallSpeed = config.FallSpeed.GetValueOrDefault(1f);
			this.InitPrepareTime = (config.PrepareTime ?? setting.CubeControlTime);
			this.PrepareTime = this.InitPrepareTime;
			this.Context = context;
			this.AreaLoopEffectHandle = 0;
			this.AreaLoop2EffectHandle = 0;
			this.AvailableTetrominoConfigs.Clear();
			List<string> availableCombineBlocks = config.AvailableCombineBlocks;
			if (availableCombineBlocks != null && availableCombineBlocks.Count > 0)
			{
				foreach (string shapeName in config.AvailableCombineBlocks)
				{
					ITetrominoConfig tetrominoConfigByShapeName = SlidingBlocksUtil.GetTetrominoConfigByShapeName(shapeName);
					if (tetrominoConfigByShapeName != null)
					{
						this.AvailableTetrominoConfigs.Add(tetrominoConfigByShapeName);
					}
				}
			}
			this.AudioData.Init();
		}

		// Token: 0x0603216F RID: 205167 RVA: 0x00BA1ACC File Offset: 0x00B9FCCC
		public void Reset()
		{
			this.ServerData.Reset();
			this.AudioData.Reset();
			this.TickMinos.Clear();
			foreach (KeyValuePair<double, TetrisGridColumn> keyValuePair in this.GridColumns)
			{
				keyValuePair.Value.Clear();
			}
			this.GridColumns.Clear();
			foreach (KeyValuePair<double, TetrisGridRow> keyValuePair2 in this.GridRows)
			{
				keyValuePair2.Value.Clear();
			}
			this.GridRows.Clear();
			this.NextTetrominoSpawnCd = 0.0;
			this.CurTetrominoInternal = null;
			this.MainLineGameCompleteTriggered = false;
			this.MainLineSequenceStart = false;
			this.CurSpawnTetrominoList = null;
			this.CharacterOutlineEffectHandle = 0;
			this.GameEndReason = SlidingBlocksDefine.EGameEndReason.None;
			this.CubeDestroyEffect = null;
		}

		// Token: 0x06032170 RID: 205168 RVA: 0x00BA1BE4 File Offset: 0x00B9FDE4
		public bool AddMinoData(double x, double y, Mino minoData, SlidingBlocksDefine.EAddMinoReason reason)
		{
			bool flag = this.AddColumnData(x, y, minoData);
			bool flag2 = this.AddRowData(x, y, minoData);
			return flag && flag2;
		}

		// Token: 0x06032171 RID: 205169 RVA: 0x00BA1C08 File Offset: 0x00B9FE08
		public bool RemoveMinoData(double x, double y, SlidingBlocksDefine.ERemoveMinoReason reason)
		{
			bool flag = this.RemoveColumnData(x, y);
			bool flag2 = this.RemoveRowData(x, y);
			return flag && flag2;
		}

		// Token: 0x06032172 RID: 205170 RVA: 0x00BA1C2C File Offset: 0x00B9FE2C
		private bool AddColumnData(double x, double y, Mino minoData)
		{
			if (x < 0.0 || x >= this.GridSize.X || y < 0.0 || y >= this.GridSize.Y)
			{
				return false;
			}
			TetrisGridColumn tetrisGridColumn;
			if (!this.GridColumns.TryGetValue(x, out tetrisGridColumn))
			{
				tetrisGridColumn = new TetrisGridColumn(this, x);
				this.GridColumns[x] = tetrisGridColumn;
			}
			return tetrisGridColumn.AddData(y, minoData);
		}

		// Token: 0x06032173 RID: 205171 RVA: 0x00BA1C9C File Offset: 0x00B9FE9C
		private bool RemoveColumnData(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			return this.GridColumns.TryGetValue(x, out tetrisGridColumn) && tetrisGridColumn.RemoveData(y);
		}

		// Token: 0x06032174 RID: 205172 RVA: 0x00BA1CC4 File Offset: 0x00B9FEC4
		private bool AddRowData(double x, double y, Mino minoData)
		{
			if (x < 0.0 || x >= this.GridSize.X || y < 0.0 || y >= this.GridSize.Y)
			{
				return false;
			}
			TetrisGridRow tetrisGridRow;
			if (!this.GridRows.TryGetValue(y, out tetrisGridRow))
			{
				tetrisGridRow = new TetrisGridRow(this, y, this.GridSize.X);
				this.GridRows[y] = tetrisGridRow;
			}
			return tetrisGridRow.AddData(x, minoData);
		}

		// Token: 0x06032175 RID: 205173 RVA: 0x00BA1D40 File Offset: 0x00B9FF40
		private bool RemoveRowData(double x, double y)
		{
			TetrisGridRow tetrisGridRow;
			return this.GridRows.TryGetValue(y, out tetrisGridRow) && tetrisGridRow.RemoveData(x);
		}

		// Token: 0x06032176 RID: 205174 RVA: 0x00BA1D66 File Offset: 0x00B9FF66
		public void RemoveTetromino(Tetromino tetromino)
		{
			this.WaitRemoveTetrominoList.Add(tetromino);
		}

		// Token: 0x06032177 RID: 205175 RVA: 0x00BA1D74 File Offset: 0x00B9FF74
		public void SetServerData(AvoidBlockRoundInfoNotify notify)
		{
			this.ServerData.Init(notify.InstId, notify.HistoryScore, notify.RewardId.ToArray<int>());
			string rewardTitleTextKey = this.ServerData.RewardTitleTextKey;
			if (rewardTitleTextKey == null || StringUtils.IsBlank(rewardTitleTextKey))
			{
				return;
			}
			this.Targets = new List<ITargetDescribeAndScore>();
			string[] array = rewardTitleTextKey.Split(';', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(',', StringSplitOptions.None);
				int num = int.Parse(array2[1]);
				AvoidBlockReward? config = ConfigAvoidBlockRewardByRewardId.GetConfig(num, true);
				if (config != null)
				{
					TargetDescribeAndScore item = new TargetDescribeAndScore
					{
						DescribeTextKey = array2[0],
						RewardId = num,
						Score = config.Value.TargetScore
					};
					this.Targets.Add(item);
				}
			}
		}

		// Token: 0x06032178 RID: 205176 RVA: 0x00BA1E44 File Offset: 0x00BA0044
		public void SetSettlementData(AvoidBlockSettlementNotify notify)
		{
			if (this.ServerData == null)
			{
				return;
			}
			this.ServerData.IsWin = notify.Win;
			this.ServerData.HistoryScore = notify.HistoryScore;
			this.ServerData.RewardList.Clear();
			foreach (KeyValuePair<int, int> keyValuePair in notify.RewardItemMap)
			{
				this.ServerData.RewardList.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			}
		}

		// Token: 0x0401AAEF RID: 109295
		[Nullable(2)]
		public GeneralLogicTreeContext Context;

		// Token: 0x0401AAF0 RID: 109296
		public SlidingBlocksDefine.EGameEndReason GameEndReason;

		// Token: 0x0401AAF1 RID: 109297
		public SlidingBlocksGameServerData ServerData = new SlidingBlocksGameServerData();

		// Token: 0x0401AAF2 RID: 109298
		public SlidingBlocksGameAudioData AudioData = new SlidingBlocksGameAudioData();

		// Token: 0x0401AAF3 RID: 109299
		[Nullable(2)]
		public global::Transform OriginTransform;

		// Token: 0x0401AAF4 RID: 109300
		public ETetrisPlayMode PlayMode;

		// Token: 0x0401AAF5 RID: 109301
		public ETetrisDirection Direction;

		// Token: 0x0401AAF6 RID: 109302
		public readonly List<ITetrominoConfig> AvailableTetrominoConfigs = new List<ITetrominoConfig>();

		// Token: 0x0401AAF7 RID: 109303
		public int SequenceEntityPbDataId;

		// Token: 0x0401AAF8 RID: 109304
		public string SequenceEntityInitState;

		// Token: 0x0401AAF9 RID: 109305
		public double Time;

		// Token: 0x0401AAFA RID: 109306
		public float FallSpeed;

		// Token: 0x0401AAFB RID: 109307
		public float PrepareTime;

		// Token: 0x0401AAFC RID: 109308
		public float InitPrepareTime;

		// Token: 0x0401AAFD RID: 109309
		public double Score;

		// Token: 0x0401AAFE RID: 109310
		public int SpeedLevel = 1;

		// Token: 0x0401AAFF RID: 109311
		public double SpeedUpTime;

		// Token: 0x0401AB00 RID: 109312
		public readonly Vector2D GridSize = Vector2D.Create();

		// Token: 0x0401AB01 RID: 109313
		public readonly Vector2D PlayerCoord = Vector2D.Create();

		// Token: 0x0401AB02 RID: 109314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<ITetrisSingleIndexGrid> PresetBlocks;

		// Token: 0x0401AB03 RID: 109315
		public readonly Dictionary<double, TetrisGridColumn> GridColumns = new Dictionary<double, TetrisGridColumn>();

		// Token: 0x0401AB04 RID: 109316
		public readonly Dictionary<double, TetrisGridRow> GridRows = new Dictionary<double, TetrisGridRow>();

		// Token: 0x0401AB05 RID: 109317
		public readonly List<Tetromino> AllTetrominoList = new List<Tetromino>();

		// Token: 0x0401AB06 RID: 109318
		public readonly List<Tetromino> WaitRemoveTetrominoList = new List<Tetromino>();

		// Token: 0x0401AB07 RID: 109319
		public readonly List<Mino> TickMinos = new List<Mino>();

		// Token: 0x0401AB08 RID: 109320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITetrominoConfig> CurSpawnTetrominoList;

		// Token: 0x0401AB09 RID: 109321
		public int CurSpawnTetrominoListIndex;

		// Token: 0x0401AB0A RID: 109322
		[Nullable(2)]
		private Tetromino CurTetrominoInternal;

		// Token: 0x0401AB0B RID: 109323
		public double NextTetrominoSpawnCd;

		// Token: 0x0401AB0C RID: 109324
		public bool IsProcessLineClear;

		// Token: 0x0401AB0D RID: 109325
		public bool MainLineSequenceStart;

		// Token: 0x0401AB0E RID: 109326
		public bool MainLineGameCompleteTriggered;

		// Token: 0x0401AB0F RID: 109327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITargetDescribeAndScore> Targets;

		// Token: 0x0401AB10 RID: 109328
		public int AreaLoopEffectHandle;

		// Token: 0x0401AB11 RID: 109329
		public int AreaLoop2EffectHandle;

		// Token: 0x0401AB12 RID: 109330
		public int CharacterOutlineEffectHandle;

		// Token: 0x0401AB13 RID: 109331
		[Nullable(2)]
		public ItemMaterialControllerActorData CubeDestroyEffect;

		// Token: 0x0401AB14 RID: 109332
		public readonly double GridMinX = 0.5;
	}
}
