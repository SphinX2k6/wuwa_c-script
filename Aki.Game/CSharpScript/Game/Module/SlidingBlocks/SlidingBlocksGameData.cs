using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B2B RID: 15147
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksGameData
	{
		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06026EF9 RID: 159481 RVA: 0x00AE5950 File Offset: 0x00AE3B50
		// (set) Token: 0x06026EFA RID: 159482 RVA: 0x00AE5958 File Offset: 0x00AE3B58
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

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x06026EFB RID: 159483 RVA: 0x00AE5961 File Offset: 0x00AE3B61
		public double GridMaxX
		{
			get
			{
				return this.GridSize.X - 0.5;
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x06026EFC RID: 159484 RVA: 0x00AE5978 File Offset: 0x00AE3B78
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

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x06026EFD RID: 159485 RVA: 0x00AE59A2 File Offset: 0x00AE3BA2
		public double GridMaxY
		{
			get
			{
				return this.GridSize.Y - 0.5;
			}
		}

		// Token: 0x06026EFE RID: 159486 RVA: 0x00AE59B9 File Offset: 0x00AE3BB9
		public float SingleCellMoveTime()
		{
			return (float)TimeUtil.Instance.InverseMillisecond / this.FallSpeed;
		}

		// Token: 0x06026EFF RID: 159487 RVA: 0x00AE59D0 File Offset: 0x00AE3BD0
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

		// Token: 0x06026F00 RID: 159488 RVA: 0x00AE5C5C File Offset: 0x00AE3E5C
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

		// Token: 0x06026F01 RID: 159489 RVA: 0x00AE5D74 File Offset: 0x00AE3F74
		public bool AddMinoData(double x, double y, Mino minoData, SlidingBlocksDefine.EAddMinoReason reason)
		{
			bool flag = this.AddColumnData(x, y, minoData);
			bool flag2 = this.AddRowData(x, y, minoData);
			return flag && flag2;
		}

		// Token: 0x06026F02 RID: 159490 RVA: 0x00AE5D98 File Offset: 0x00AE3F98
		public bool RemoveMinoData(double x, double y, SlidingBlocksDefine.ERemoveMinoReason reason)
		{
			bool flag = this.RemoveColumnData(x, y);
			bool flag2 = this.RemoveRowData(x, y);
			return flag && flag2;
		}

		// Token: 0x06026F03 RID: 159491 RVA: 0x00AE5DBC File Offset: 0x00AE3FBC
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

		// Token: 0x06026F04 RID: 159492 RVA: 0x00AE5E2C File Offset: 0x00AE402C
		private bool RemoveColumnData(double x, double y)
		{
			TetrisGridColumn tetrisGridColumn;
			return this.GridColumns.TryGetValue(x, out tetrisGridColumn) && tetrisGridColumn.RemoveData(y);
		}

		// Token: 0x06026F05 RID: 159493 RVA: 0x00AE5E54 File Offset: 0x00AE4054
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

		// Token: 0x06026F06 RID: 159494 RVA: 0x00AE5ED0 File Offset: 0x00AE40D0
		private bool RemoveRowData(double x, double y)
		{
			TetrisGridRow tetrisGridRow;
			return this.GridRows.TryGetValue(y, out tetrisGridRow) && tetrisGridRow.RemoveData(x);
		}

		// Token: 0x06026F07 RID: 159495 RVA: 0x00AE5EF6 File Offset: 0x00AE40F6
		public void RemoveTetromino(Tetromino tetromino)
		{
			this.WaitRemoveTetrominoList.Add(tetromino);
		}

		// Token: 0x06026F08 RID: 159496 RVA: 0x00AE5F04 File Offset: 0x00AE4104
		public void SetServerData(AvoidBlockRoundInfoNotify notify)
		{
			int[] array = new int[notify.RewardId.Count];
			notify.RewardId.CopyTo(array, 0);
			this.ServerData.Init(notify.InstId, notify.HistoryScore, array);
			string rewardTitleTextKey = this.ServerData.RewardTitleTextKey;
			if (rewardTitleTextKey == null || StringUtils.IsBlank(rewardTitleTextKey))
			{
				return;
			}
			this.Targets = new List<ITargetDescribeAndScore>();
			string[] array2 = rewardTitleTextKey.Split(';', StringSplitOptions.None);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(',', StringSplitOptions.None);
				int num = int.Parse(array3[1]);
				AvoidBlockReward? config = ConfigAvoidBlockRewardByRewardId.GetConfig(num, true);
				if (config != null)
				{
					TargetDescribeAndScore item = new TargetDescribeAndScore
					{
						DescribeTextKey = array3[0],
						RewardId = num,
						Score = config.Value.TargetScore
					};
					this.Targets.Add(item);
				}
			}
		}

		// Token: 0x06026F09 RID: 159497 RVA: 0x00AE5FEC File Offset: 0x00AE41EC
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

		// Token: 0x04015443 RID: 87107
		[Nullable(2)]
		public GeneralLogicTreeContext Context;

		// Token: 0x04015444 RID: 87108
		public SlidingBlocksDefine.EGameEndReason GameEndReason;

		// Token: 0x04015445 RID: 87109
		public SlidingBlocksGameServerData ServerData = new SlidingBlocksGameServerData();

		// Token: 0x04015446 RID: 87110
		public SlidingBlocksGameAudioData AudioData = new SlidingBlocksGameAudioData();

		// Token: 0x04015447 RID: 87111
		[Nullable(2)]
		public global::Transform OriginTransform;

		// Token: 0x04015448 RID: 87112
		public ETetrisPlayMode PlayMode;

		// Token: 0x04015449 RID: 87113
		public ETetrisDirection Direction;

		// Token: 0x0401544A RID: 87114
		public readonly List<ITetrominoConfig> AvailableTetrominoConfigs = new List<ITetrominoConfig>();

		// Token: 0x0401544B RID: 87115
		public int SequenceEntityPbDataId;

		// Token: 0x0401544C RID: 87116
		public string SequenceEntityInitState;

		// Token: 0x0401544D RID: 87117
		public double Time;

		// Token: 0x0401544E RID: 87118
		public float FallSpeed;

		// Token: 0x0401544F RID: 87119
		public float PrepareTime;

		// Token: 0x04015450 RID: 87120
		public float InitPrepareTime;

		// Token: 0x04015451 RID: 87121
		public double Score;

		// Token: 0x04015452 RID: 87122
		public int SpeedLevel = 1;

		// Token: 0x04015453 RID: 87123
		public double SpeedUpTime;

		// Token: 0x04015454 RID: 87124
		public readonly Vector2D GridSize = Vector2D.Create();

		// Token: 0x04015455 RID: 87125
		public readonly Vector2D PlayerCoord = Vector2D.Create();

		// Token: 0x04015456 RID: 87126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<ITetrisSingleIndexGrid> PresetBlocks;

		// Token: 0x04015457 RID: 87127
		public readonly Dictionary<double, TetrisGridColumn> GridColumns = new Dictionary<double, TetrisGridColumn>();

		// Token: 0x04015458 RID: 87128
		public readonly Dictionary<double, TetrisGridRow> GridRows = new Dictionary<double, TetrisGridRow>();

		// Token: 0x04015459 RID: 87129
		public readonly List<Tetromino> AllTetrominoList = new List<Tetromino>();

		// Token: 0x0401545A RID: 87130
		public readonly List<Tetromino> WaitRemoveTetrominoList = new List<Tetromino>();

		// Token: 0x0401545B RID: 87131
		public readonly List<Mino> TickMinos = new List<Mino>();

		// Token: 0x0401545C RID: 87132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITetrominoConfig> CurSpawnTetrominoList;

		// Token: 0x0401545D RID: 87133
		public int CurSpawnTetrominoListIndex;

		// Token: 0x0401545E RID: 87134
		[Nullable(2)]
		private Tetromino CurTetrominoInternal;

		// Token: 0x0401545F RID: 87135
		public double NextTetrominoSpawnCd;

		// Token: 0x04015460 RID: 87136
		public bool IsProcessLineClear;

		// Token: 0x04015461 RID: 87137
		public bool MainLineSequenceStart;

		// Token: 0x04015462 RID: 87138
		public bool MainLineGameCompleteTriggered;

		// Token: 0x04015463 RID: 87139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITargetDescribeAndScore> Targets;

		// Token: 0x04015464 RID: 87140
		public int AreaLoopEffectHandle;

		// Token: 0x04015465 RID: 87141
		public int AreaLoop2EffectHandle;

		// Token: 0x04015466 RID: 87142
		public int CharacterOutlineEffectHandle;

		// Token: 0x04015467 RID: 87143
		[Nullable(2)]
		public ItemMaterialControllerActorData CubeDestroyEffect;

		// Token: 0x04015468 RID: 87144
		public readonly double GridMinX = 0.5;
	}
}
