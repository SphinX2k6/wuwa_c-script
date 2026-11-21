using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using Aki.Game.Module.Activity.ActivityContent.Tetris.View;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB2 RID: 12210
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisPlayController
	{
		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0601CF3F RID: 118591 RVA: 0x008D68DB File Offset: 0x008D4ADB
		public bool HasPendingFirstTimeRewards
		{
			get
			{
				return this.PendingFirstTimeRewards.Count != 0;
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0601CF40 RID: 118592 RVA: 0x008D68EB File Offset: 0x008D4AEB
		// (set) Token: 0x0601CF41 RID: 118593 RVA: 0x008D68F3 File Offset: 0x008D4AF3
		public bool IsAnimating
		{
			get
			{
				return this.IsAnimatingInternal;
			}
			private set
			{
				if (this.IsAnimatingInternal == value)
				{
					return;
				}
				this.IsAnimatingInternal = value;
				Action<bool> onAnimatingChanged = this.OnAnimatingChanged;
				if (onAnimatingChanged == null)
				{
					return;
				}
				onAnimatingChanged(value);
			}
		}

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0601CF42 RID: 118594 RVA: 0x008D6917 File Offset: 0x008D4B17
		// (set) Token: 0x0601CF43 RID: 118595 RVA: 0x008D691F File Offset: 0x008D4B1F
		internal bool IsSettlingScore
		{
			get
			{
				return this.IsSettlingScoreInternal;
			}
			private set
			{
				if (this.IsSettlingScoreInternal == value)
				{
					return;
				}
				this.IsSettlingScoreInternal = value;
				Action onScoreSettlementChanged = this.OnScoreSettlementChanged;
				if (onScoreSettlementChanged == null)
				{
					return;
				}
				onScoreSettlementChanged();
			}
		}

		// Token: 0x0601CF44 RID: 118596 RVA: 0x008D6942 File Offset: 0x008D4B42
		public float GetRandomFloat()
		{
			return this.RandomNumberGenerator.NextSingle();
		}

		// Token: 0x0601CF45 RID: 118597 RVA: 0x008D694F File Offset: 0x008D4B4F
		private bool IsTriggered(int probability)
		{
			return probability > 0 && this.RandomNumberGenerator.Next(10000) < probability;
		}

		// Token: 0x0601CF46 RID: 118598 RVA: 0x008D696C File Offset: 0x008D4B6C
		private int GetRandomIntInRange(IntRange? range)
		{
			if (range == null)
			{
				return 0;
			}
			return this.RandomNumberGenerator.Next(range.Value.Min, range.Value.Max + 1);
		}

		// Token: 0x0601CF47 RID: 118599 RVA: 0x008D69B0 File Offset: 0x008D4BB0
		private int[] GetRandomIndices(int startIndex, int arrayLength, int indicesCount)
		{
			if (arrayLength <= 0)
			{
				throw new ArgumentOutOfRangeException("arrayLength", arrayLength, "数组长度必须大于0");
			}
			if (indicesCount <= 0)
			{
				throw new ArgumentOutOfRangeException("indicesCount", indicesCount, "下标数量必须大于0");
			}
			if (indicesCount > arrayLength)
			{
				throw new ArgumentException("下标数量必须小于等于数组长度", "indicesCount");
			}
			int[] array = new int[arrayLength];
			for (int i = 0; i < arrayLength; i++)
			{
				array[i] = startIndex + i;
			}
			this.RandomNumberGenerator.Shuffle<int>(array);
			return RuntimeHelpers.GetSubArray<int>(array, Range.EndAt(indicesCount));
		}

		// Token: 0x0601CF48 RID: 118600 RVA: 0x008D6A3C File Offset: 0x008D4C3C
		public void InitLevel(int id)
		{
			this.LevelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			this.ResetTraceId();
			this.PlaceCount = 0;
			this.FirstRefillHandShapesSerialized = "";
			this.CurrentRoundRefillHandShapesSerialized = "";
			this.CurrentStageIndex = 1;
			this.CurrentRoundIndex = 1;
			this.RotateCount1 = 0;
			this.RotateCount2 = 0;
			this.RotateCount3 = 0;
			this.RotateCount4 = 0;
			this.ExplosionCount = 0;
			this.CurrentRoundRotateCount1 = 0;
			this.CurrentRoundRotateCount2 = 0;
			this.CurrentRoundRotateCount3 = 0;
			this.CurrentRoundRotateCount4 = 0;
			this.CurrentRoundExplosionCount = 0;
			this.InitLevelConfig(id);
			this.InitBoard(id);
			this.InitGenerateShape();
			this.SendStartLogData();
		}

		// Token: 0x0601CF49 RID: 118601 RVA: 0x008D6AED File Offset: 0x008D4CED
		public void SetUseDialogWinOnly(bool value)
		{
			this.UseDialogWinOnly = value;
		}

		// Token: 0x0601CF4A RID: 118602 RVA: 0x008D6AF8 File Offset: 0x008D4CF8
		public void ResetLevel(int id)
		{
			this.LevelStartTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			this.ResetTraceId();
			this.PlaceCount = 0;
			this.FirstRefillHandShapesSerialized = "";
			this.CurrentRoundRefillHandShapesSerialized = "";
			this.CurrentStageIndex = 1;
			this.CurrentRoundIndex = 1;
			this.RotateCount1 = 0;
			this.RotateCount2 = 0;
			this.RotateCount3 = 0;
			this.RotateCount4 = 0;
			this.ExplosionCount = 0;
			this.CurrentRoundRotateCount1 = 0;
			this.CurrentRoundRotateCount2 = 0;
			this.CurrentRoundRotateCount3 = 0;
			this.CurrentRoundRotateCount4 = 0;
			this.CurrentRoundExplosionCount = 0;
			this.GridModel.Reset();
			this.ScoreModel.Reset();
			this.GemModel.Reset();
			this.HandShapes = new List<BlockInstance>();
			this.IsGameOver = false;
			this.IsAnimating = false;
			this.IsSettlingScore = false;
			this.TakeBackCount = 0;
			this.TakeBackSnapshot = null;
			this.InitBoard(id);
			this.SendStartLogData();
		}

		// Token: 0x0601CF4B RID: 118603 RVA: 0x008D6BEC File Offset: 0x008D4DEC
		public void ClearCallback()
		{
			this.OnAnimatingChanged = null;
			this.OnScoreSettlementChanged = null;
			this.OnDataUpdate = null;
			this.OnCombo = null;
			this.OnRefillHandShapes = null;
			this.OnHandShapesCleared = null;
			this.OnBeforeOpenPopup = null;
			this.OnPlaceAnimation = null;
			this.OnRemoveAnimation = null;
			this.OnCleanAnimation = null;
			this.OnLoseBoardAnimation = null;
		}

		// Token: 0x0601CF4C RID: 118604 RVA: 0x008D6C46 File Offset: 0x008D4E46
		private void InitLevelConfig(int id)
		{
			this.CurrentLevelConfig = new Tetris?(ActivityTetrisConfig.Instance.GetLevelConfig(id));
		}

		// Token: 0x0601CF4D RID: 118605 RVA: 0x008D6C5E File Offset: 0x008D4E5E
		public Tetris? GetCurrentConfig()
		{
			return this.CurrentLevelConfig;
		}

		// Token: 0x0601CF4E RID: 118606 RVA: 0x008D6C66 File Offset: 0x008D4E66
		public EGameMode GetGameMode()
		{
			return TetrisUtils.CheckLevelMode(this.CurrentLevelConfig.Value);
		}

		// Token: 0x0601CF4F RID: 118607 RVA: 0x008D6C78 File Offset: 0x008D4E78
		public Dictionary<int, int> GetCurrentTarget()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			IntIntMap value = this.CurrentLevelConfig.Value.TargetResults((int)this.CurrentDifficulty).Value;
			int mapIntIntLength = value.MapIntIntLength;
			for (int i = 0; i < mapIntIntLength; i++)
			{
				DicIntInt value2 = value.MapIntInt(i).Value;
				dictionary[value2.Key] = value2.Value;
			}
			return dictionary;
		}

		// Token: 0x0601CF50 RID: 118608 RVA: 0x008D6CF0 File Offset: 0x008D4EF0
		public Dictionary<int, int> GetCurrentTargetRecord()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in this.GetCurrentTarget())
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
			return dictionary;
		}

		// Token: 0x0601CF51 RID: 118609 RVA: 0x008D6D58 File Offset: 0x008D4F58
		public bool IsAllTargetsCompleted(bool shouldConsiderRecord)
		{
			foreach (KeyValuePair<int, int> keyValuePair in this.GetCurrentTarget())
			{
				if (keyValuePair.Key == 0)
				{
					int num = this.GetCurrentScore();
					if (shouldConsiderRecord)
					{
						long? highestScore = this.GetHighestScore();
						if (highestScore != null)
						{
							long valueOrDefault = highestScore.GetValueOrDefault();
							num = Math.Max(num, (int)valueOrDefault);
						}
					}
					if (num < keyValuePair.Value)
					{
						return false;
					}
				}
				else
				{
					int num2 = this.GemModel.GetGem((EGemType)keyValuePair.Key);
					if (shouldConsiderRecord)
					{
						ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
						int? num3 = (tetrisData != null) ? tetrisData.GetChallengeRecord(this.CurrentLevelConfig.Value.Id, keyValuePair.Key) : null;
						if (num3 != null)
						{
							int valueOrDefault2 = num3.GetValueOrDefault();
							num2 = Math.Max(num2, valueOrDefault2);
						}
					}
					if (num2 < keyValuePair.Value)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0601CF52 RID: 118610 RVA: 0x008D6E78 File Offset: 0x008D5078
		public bool IsActivityLevel()
		{
			return this.CurrentLevelConfig == null || this.CurrentLevelConfig.GetValueOrDefault().ActivityId != 0;
		}

		// Token: 0x0601CF53 RID: 118611 RVA: 0x008D6EA8 File Offset: 0x008D50A8
		public void OnPlayerDropShape(int handIndex, int targetR, int targetC)
		{
			if (this.IsGameOver)
			{
				return;
			}
			if (this.IsAnimating)
			{
				return;
			}
			BlockInstance blockInstance = this.HandShapes[handIndex];
			if (blockInstance == null)
			{
				return;
			}
			if (!this.PlaceShape(blockInstance, targetR, targetC))
			{
				return;
			}
			this.PlaceCount++;
			this.IsAnimating = true;
			this.HandShapes[handIndex] = null;
			this.ProcessElimination(new Action(this.OnEliminationComplete));
			int boundRectWidth = blockInstance.BoundRectWidth;
			int boundRectHeight = blockInstance.BoundRectHeight;
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			ValueTuple<int, int>[] offsets = blockInstance.Offsets;
			for (int i = 0; i < offsets.Length; i++)
			{
				ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(offsets[i], boundRectWidth, boundRectHeight, blockInstance.Rotation);
				list.Add(new ValueTuple<int, int>(targetR + rotatedOffset.Item1, targetC + rotatedOffset.Item2));
			}
			TetrisPlayController.Delegate_OnPlaceAnimation onPlaceAnimation = this.OnPlaceAnimation;
			if (onPlaceAnimation == null)
			{
				return;
			}
			onPlaceAnimation(list, null);
		}

		// Token: 0x0601CF54 RID: 118612 RVA: 0x008D6F90 File Offset: 0x008D5190
		[NullableContext(2)]
		private void ProcessElimination(Action onComplete = null)
		{
			this.IsSettlingScore = true;
			this.ProcessClearInfo(this.CheckAndClear(), delegate
			{
				if (this.IsBoardEmpty() && this.OnCleanAnimation != null)
				{
					this.OnCleanAnimation(false, onComplete);
					return;
				}
				Action onComplete2 = onComplete;
				if (onComplete2 == null)
				{
					return;
				}
				onComplete2();
			});
		}

		// Token: 0x0601CF55 RID: 118613 RVA: 0x008D6FD0 File Offset: 0x008D51D0
		[NullableContext(2)]
		private void ProcessClearInfo(TetrisClearInfo clearInfo, Action onEliminationComplete = null)
		{
			TetrisPlayController.<>c__DisplayClass74_0 CS$<>8__locals1 = new TetrisPlayController.<>c__DisplayClass74_0();
			CS$<>8__locals1.onEliminationComplete = onEliminationComplete;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clearInfo = clearInfo;
			int num = this.Calculate(CS$<>8__locals1.clearInfo);
			if (num != 0)
			{
				this.EmitScoreChanged();
			}
			foreach (KeyValuePair<EGemType, int> keyValuePair in CS$<>8__locals1.clearInfo.CollectedGems)
			{
				this.GemModel.AddGem(keyValuePair.Key, keyValuePair.Value);
			}
			this.CurrentRoundExplosionCount += CS$<>8__locals1.clearInfo.BombCount;
			bool hasTriggeredBombs = CS$<>8__locals1.clearInfo.HasTriggeredBombs;
			if (!hasTriggeredBombs)
			{
				this.UpdateHandShapes();
			}
			this.NotifyUi(false, false);
			if (!hasTriggeredBombs)
			{
				this.IsSettlingScore = false;
			}
			if (CS$<>8__locals1.clearInfo.ClearedPositions.Length != 0 || CS$<>8__locals1.clearInfo.IsBombExplosion)
			{
				Action<ComboData> onCombo = this.OnCombo;
				if (onCombo != null)
				{
					onCombo(new ComboData
					{
						ClearInfo = CS$<>8__locals1.clearInfo,
						ComboCount = this.ScoreModel.GetComboCount(),
						Score = num,
						GameMode = this.GetGameMode()
					});
				}
			}
			if (!CS$<>8__locals1.clearInfo.HasRemoveAnimation)
			{
				if (hasTriggeredBombs)
				{
					this.ProcessClearInfo(this.DetonateBombs(CS$<>8__locals1.clearInfo), CS$<>8__locals1.onEliminationComplete);
					return;
				}
				Action onEliminationComplete2 = CS$<>8__locals1.onEliminationComplete;
				if (onEliminationComplete2 == null)
				{
					return;
				}
				onEliminationComplete2();
				return;
			}
			else if (this.OnRemoveAnimation != null)
			{
				if (hasTriggeredBombs)
				{
					CS$<>8__locals1.isCurrentAnimationCompleted = false;
					CS$<>8__locals1.isNextEliminationCompleted = false;
					CS$<>8__locals1.isNextEliminationStarted = false;
					CS$<>8__locals1.isChainCompleted = false;
					this.OnRemoveAnimation(CS$<>8__locals1.clearInfo, new Action(CS$<>8__locals1.<ProcessClearInfo>g__onNext|1), new Action(CS$<>8__locals1.<ProcessClearInfo>g__onCurrentAnimationComplete|2));
					return;
				}
				this.OnRemoveAnimation(CS$<>8__locals1.clearInfo, null, CS$<>8__locals1.onEliminationComplete);
				return;
			}
			else
			{
				if (hasTriggeredBombs)
				{
					this.ProcessClearInfo(this.DetonateBombs(CS$<>8__locals1.clearInfo), CS$<>8__locals1.onEliminationComplete);
					return;
				}
				Action onEliminationComplete3 = CS$<>8__locals1.onEliminationComplete;
				if (onEliminationComplete3 == null)
				{
					return;
				}
				onEliminationComplete3();
				return;
			}
		}

		// Token: 0x0601CF56 RID: 118614 RVA: 0x008D71DC File Offset: 0x008D53DC
		private void OnEliminationComplete()
		{
			this.UpdateGameState();
			this.CurrentRoundIndex++;
			if (!this.IsGameOver)
			{
				this.IsAnimating = false;
			}
		}

		// Token: 0x0601CF57 RID: 118615 RVA: 0x008D7201 File Offset: 0x008D5401
		public void UpdateGameState()
		{
			if (this.CheckWinCondition())
			{
				this.IsGameOver = true;
				this.OnGameWin();
				this.SendResultLogData(1);
				return;
			}
			if (this.CheckLossCondition())
			{
				this.IsGameOver = true;
				this.OnNoMovesAvailable();
			}
		}

		// Token: 0x0601CF58 RID: 118616 RVA: 0x008D7238 File Offset: 0x008D5438
		private void UpdateHandShapes()
		{
			bool flag = true;
			using (List<BlockInstance>.Enumerator enumerator = this.HandShapes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != null)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				this.CurrentStageIndex++;
				this.RotateCount1 += this.CurrentRoundRotateCount1;
				this.RotateCount2 += this.CurrentRoundRotateCount2;
				this.RotateCount3 += this.CurrentRoundRotateCount3;
				this.RotateCount4 += this.CurrentRoundRotateCount4;
				this.ExplosionCount += this.CurrentRoundExplosionCount;
				this.RefillHandShapes();
				this.CurrentRoundRotateCount1 = 0;
				this.CurrentRoundRotateCount2 = 0;
				this.CurrentRoundRotateCount3 = 0;
				this.CurrentRoundRotateCount4 = 0;
				this.CurrentRoundExplosionCount = 0;
			}
		}

		// Token: 0x0601CF59 RID: 118617 RVA: 0x008D7330 File Offset: 0x008D5530
		public void RefillHandShapes()
		{
			this.HandShapes = this.GenerateBlocks(this.CurrentLevelConfig.Value.BlockNum);
			string text = this.SerializeHandShapes(this.HandShapes);
			if (this.FirstRefillHandShapesSerialized == "")
			{
				this.FirstRefillHandShapesSerialized = text;
			}
			this.CurrentRoundRefillHandShapesSerialized = text;
			this.SaveTakeBackSnapshot();
			this.SendRoundLogData();
			Action onRefillHandShapes = this.OnRefillHandShapes;
			if (onRefillHandShapes == null)
			{
				return;
			}
			onRefillHandShapes();
		}

		// Token: 0x0601CF5A RID: 118618 RVA: 0x008D73A8 File Offset: 0x008D55A8
		private void SaveTakeBackSnapshot()
		{
			this.TakeBackSnapshot = new TetrisGameSnapshot
			{
				BoardCells = this.GridModel.CloneCells(),
				HandShapes = this.CloneHandShapes(),
				ScoreSnapshot = this.ScoreModel.CreateSnapshot(),
				GemSnapshot = this.GemModel.CreateSnapshot(),
				CurrentRoundIndex = this.CurrentRoundIndex,
				CurrentStageIndex = this.CurrentStageIndex,
				PlaceCount = this.PlaceCount
			};
		}

		// Token: 0x0601CF5B RID: 118619 RVA: 0x008D7424 File Offset: 0x008D5624
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		private List<BlockInstance> CloneHandShapes()
		{
			List<BlockInstance> list = new List<BlockInstance>();
			foreach (BlockInstance blockInstance in this.HandShapes)
			{
				if (blockInstance == null)
				{
					list.Add(null);
				}
				else
				{
					List<BlockInstance> list2 = list;
					BlockInstance blockInstance2 = blockInstance.<Clone>$();
					blockInstance2.Offsets = blockInstance.Offsets.ToArray<ValueTuple<int, int>>();
					list2.Add(blockInstance2);
				}
			}
			return list;
		}

		// Token: 0x0601CF5C RID: 118620 RVA: 0x008D74A0 File Offset: 0x008D56A0
		private bool CheckWinCondition()
		{
			if (this.CurrentLevelConfig == null)
			{
				return false;
			}
			if (this.UseDialogWinOnly)
			{
				return false;
			}
			switch (this.GetGameMode())
			{
			case EGameMode.Score:
				return this.GetCurrentScore() >= this.GetCurrentTarget()[0];
			case EGameMode.GemCollection:
				foreach (KeyValuePair<int, int> keyValuePair in this.GetCurrentTarget())
				{
					if (this.GemModel.GetGem((EGemType)keyValuePair.Key) < keyValuePair.Value)
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x0601CF5D RID: 118621 RVA: 0x008D7560 File Offset: 0x008D5760
		private bool CheckLossCondition()
		{
			foreach (BlockInstance blockInstance in this.HandShapes)
			{
				if (!(blockInstance == null))
				{
					for (int i = 0; i < 8; i++)
					{
						for (int j = 0; j < 8; j++)
						{
							if (this.CanPlaceShape(blockInstance, i, j, this.IsRotationEnabled()))
							{
								return false;
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0601CF5E RID: 118622 RVA: 0x008D75E8 File Offset: 0x008D57E8
		public void NotifyUi(bool isInit = false, bool isTakeBack = false)
		{
			Action<bool, bool> onDataUpdate = this.OnDataUpdate;
			if (onDataUpdate == null)
			{
				return;
			}
			onDataUpdate(isInit, isTakeBack);
		}

		// Token: 0x0601CF5F RID: 118623 RVA: 0x008D75FC File Offset: 0x008D57FC
		public TetrisBoardData GetGridModel()
		{
			return this.GridModel;
		}

		// Token: 0x0601CF60 RID: 118624 RVA: 0x008D7604 File Offset: 0x008D5804
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public List<BlockInstance> GetHandShapes()
		{
			return this.HandShapes;
		}

		// Token: 0x0601CF61 RID: 118625 RVA: 0x008D760C File Offset: 0x008D580C
		private void OnNoMovesAvailable()
		{
			UiLayer.Instance.SetShowMaskLayer("TetrisNoMovesAvailable", true);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiLayer.Instance.SetShowMaskLayer("TetrisNoMovesAvailable", false);
				if (this.CanTakeBack())
				{
					this.ShowTakeBackConfirmBox();
					return;
				}
				this.OnGameLose();
			}, 500f, null, null, true, 1f);
		}

		// Token: 0x0601CF62 RID: 118626 RVA: 0x008D7644 File Offset: 0x008D5844
		private void OnGameLose()
		{
			this.SetEmptyCellsColorIdFixed();
			Action onHandShapesCleared = this.OnHandShapesCleared;
			if (onHandShapesCleared != null)
			{
				onHandShapesCleared();
			}
			if (this.OnLoseBoardAnimation != null)
			{
				this.IsAnimating = true;
				this.OnLoseBoardAnimation(delegate
				{
					this.IsAnimating = false;
					this.DoGameLose();
				});
				return;
			}
			this.DoGameLose();
		}

		// Token: 0x0601CF63 RID: 118627 RVA: 0x008D7698 File Offset: 0x008D5898
		private void DoGameLose()
		{
			this.LoseCount++;
			if (this.GetGameMode() == EGameMode.Infinite)
			{
				this.SendInfiniteFinishRequest(new Action(this.OpenEndlessLevelLoseView));
				return;
			}
			Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
			if (onBeforeOpenPopup != null)
			{
				onBeforeOpenPopup();
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsLoseView, null, null);
		}

		// Token: 0x0601CF64 RID: 118628 RVA: 0x008D76F4 File Offset: 0x008D58F4
		private void SetEmptyCellsColorIdFixed()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					TetrisCellData tetrisCellData = this.GridModel.Cells[i, j];
					tetrisCellData.Reset();
					tetrisCellData.ColorId = 7;
				}
			}
		}

		// Token: 0x0601CF65 RID: 118629 RVA: 0x008D7738 File Offset: 0x008D5938
		private void OpenEndlessLevelLoseView()
		{
			Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
			if (onBeforeOpenPopup != null)
			{
				onBeforeOpenPopup();
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessEndView, new EndLessEndOpenParam
			{
				Score = this.ScoreModel.GetScore(),
				IsAutoClose = !this.IsActivityLevel()
			}, null);
		}

		// Token: 0x0601CF66 RID: 118630 RVA: 0x008D778B File Offset: 0x008D598B
		public void OnLoseReset()
		{
			if (!this.TryChangeLevelDifficulty())
			{
				this.DoResetTetris();
			}
		}

		// Token: 0x0601CF67 RID: 118631 RVA: 0x008D779B File Offset: 0x008D599B
		public void OnGameWin()
		{
			this.DoGameWin(this.GenRequestMsg());
		}

		// Token: 0x0601CF68 RID: 118632 RVA: 0x008D77A9 File Offset: 0x008D59A9
		public void OnGameWinQuickComplete()
		{
			this.DoGameWin(this.GenRequestMsgWithTargetResult());
		}

		// Token: 0x0601CF69 RID: 118633 RVA: 0x008D77B8 File Offset: 0x008D59B8
		[NullableContext(2)]
		private void DoGameWin(TetrisUpdateRequest requestMsg)
		{
			TetrisPlayController.<>c__DisplayClass94_0 CS$<>8__locals1 = new TetrisPlayController.<>c__DisplayClass94_0();
			CS$<>8__locals1.levelId = this.CurrentLevelConfig.Value.Id;
			CS$<>8__locals1.isHardLevel = TetrisUtils.IsHardLevel(this.CurrentLevelConfig.Value);
			CS$<>8__locals1.isEggLevel = TetrisUtils.IsEggLevel(this.CurrentLevelConfig.Value);
			TetrisPlayController.<>c__DisplayClass94_0 CS$<>8__locals2 = CS$<>8__locals1;
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			CS$<>8__locals2.isAlreadyComplete = ((tetrisData != null) ? new bool?(tetrisData.CheckChallengeComplete(CS$<>8__locals1.levelId)) : null);
			CS$<>8__locals1.msgToSend = (CS$<>8__locals1.isAlreadyComplete.GetValueOrDefault() ? null : requestMsg);
			Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
			if (onBeforeOpenPopup != null)
			{
				onBeforeOpenPopup();
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsWinView, new Action(CS$<>8__locals1.<DoGameWin>g__onWinCallback|0), null);
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x008D7884 File Offset: 0x008D5A84
		private bool CanTakeBack()
		{
			if (this.CurrentLevelConfig == null)
			{
				return false;
			}
			int takeBackCnt = this.CurrentLevelConfig.Value.TakeBackCnt;
			return this.TakeBackCount < takeBackCnt && !(this.TakeBackSnapshot == null);
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x008D78D0 File Offset: 0x008D5AD0
		private void ShowTakeBackConfirmBox()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TetrisTakeBackConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<ShowTakeBackConfirmBox>g__cancelCallback|96_0));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<ShowTakeBackConfirmBox>g__confirmCallback|96_1));
			Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
			if (onBeforeOpenPopup != null)
			{
				onBeforeOpenPopup();
			}
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0601CF6C RID: 118636 RVA: 0x008D7938 File Offset: 0x008D5B38
		public void DoTakeBack()
		{
			if (this.TakeBackSnapshot == null)
			{
				return;
			}
			this.TakeBackCount++;
			int currentScore = this.GetCurrentScore();
			this.GridModel.RestoreFromSnapshot(this.TakeBackSnapshot.BoardCells);
			this.RestoreHandShapesFromSnapshot(this.TakeBackSnapshot.HandShapes);
			TetrisScoreData scoreModel = this.ScoreModel;
			TetrisScoreSnapshot scoreSnapshot = this.TakeBackSnapshot.ScoreSnapshot;
			scoreModel.RestoreFromSnapshot(scoreSnapshot);
			TetrisGemData gemModel = this.GemModel;
			TetrisGemSnapshot gemSnapshot = this.TakeBackSnapshot.GemSnapshot;
			gemModel.RestoreFromSnapshot(gemSnapshot);
			this.CurrentRoundIndex = this.TakeBackSnapshot.CurrentRoundIndex;
			this.CurrentStageIndex = this.TakeBackSnapshot.CurrentStageIndex;
			this.PlaceCount = this.TakeBackSnapshot.PlaceCount;
			this.CurrentRoundRotateCount1 = 0;
			this.CurrentRoundRotateCount2 = 0;
			this.CurrentRoundRotateCount3 = 0;
			this.CurrentRoundRotateCount4 = 0;
			this.CurrentRoundExplosionCount = 0;
			this.IsGameOver = false;
			this.IsAnimating = false;
			if (currentScore != this.GetCurrentScore())
			{
				this.EmitScoreChanged();
			}
			this.NotifyUi(false, true);
		}

		// Token: 0x0601CF6D RID: 118637 RVA: 0x008D7A3C File Offset: 0x008D5C3C
		private void RestoreHandShapesFromSnapshot([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> snapshotShapes)
		{
			this.HandShapes.Clear();
			foreach (BlockInstance blockInstance in snapshotShapes)
			{
				if (blockInstance == null)
				{
					this.HandShapes.Add(null);
				}
				else
				{
					List<BlockInstance> handShapes = this.HandShapes;
					BlockInstance blockInstance2 = blockInstance.<Clone>$();
					blockInstance2.Offsets = blockInstance.Offsets.ToArray<ValueTuple<int, int>>();
					handShapes.Add(blockInstance2);
				}
			}
		}

		// Token: 0x0601CF6E RID: 118638 RVA: 0x008D7AC4 File Offset: 0x008D5CC4
		public int GetRemainingTakeBackCount()
		{
			if (this.CurrentLevelConfig == null)
			{
				return 0;
			}
			return Math.Max(0, this.CurrentLevelConfig.Value.TakeBackCnt - this.TakeBackCount);
		}

		// Token: 0x0601CF6F RID: 118639 RVA: 0x008D7B00 File Offset: 0x008D5D00
		public void DoResetTetris()
		{
			Action onHandShapesCleared = this.OnHandShapesCleared;
			if (onHandShapesCleared != null)
			{
				onHandShapesCleared();
			}
			if (this.OnCleanAnimation != null)
			{
				this.IsAnimating = true;
				this.OnCleanAnimation(true, delegate
				{
					this.IsAnimating = false;
					this.ExecuteReset();
				});
				return;
			}
			this.ExecuteReset();
		}

		// Token: 0x0601CF70 RID: 118640 RVA: 0x008D7B4C File Offset: 0x008D5D4C
		private void ExecuteReset()
		{
			this.SendResultLogData(3);
			this.ResetLevel(this.CurrentLevelConfig.Value.Id);
			this.RefillHandShapes();
			this.NotifyUi(true, false);
		}

		// Token: 0x0601CF71 RID: 118641 RVA: 0x008D7B88 File Offset: 0x008D5D88
		private bool TryChangeLevelDifficulty()
		{
			TetrisPlayController.<>c__DisplayClass102_0 CS$<>8__locals1 = new TetrisPlayController.<>c__DisplayClass102_0();
			CS$<>8__locals1.<>4__this = this;
			bool flag = false;
			CS$<>8__locals1.targetDifficulty = 0;
			for (int i = (int)this.CurrentDifficulty; i < this.CurrentLevelConfig.Value.ReduceDiffCntLength; i++)
			{
				int num = this.CurrentLevelConfig.Value.ReduceDiffCnt(i);
				if (this.LoseCount >= num)
				{
					CS$<>8__locals1.targetDifficulty = i + 1;
					flag = true;
				}
			}
			if (flag)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TetrisDifficultyChangeConfirm);
				confirmBoxDataNew.FunctionMap.Add(1, new Action(CS$<>8__locals1.<TryChangeLevelDifficulty>g__cancelCallback|0));
				confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<TryChangeLevelDifficulty>g__confirmCallback|1));
				Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
				if (onBeforeOpenPopup != null)
				{
					onBeforeOpenPopup();
				}
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
			return flag;
		}

		// Token: 0x0601CF72 RID: 118642 RVA: 0x008D7C5C File Offset: 0x008D5E5C
		private TetrisUpdateRequest GenRequestMsg()
		{
			TetrisUpdateRequest tetrisUpdateRequest = TetrisUpdateRequest.Create();
			tetrisUpdateRequest.ActivityId = ActivityTetrisController.Instance.ActivityId;
			tetrisUpdateRequest.TetrisLevelInfo = new TetrisLevelInfo
			{
				Id = this.CurrentLevelConfig.Value.Id,
				State = TetrisState.TetrisUnlocked,
				DifficultyIdx = (int)this.CurrentDifficulty
			};
			tetrisUpdateRequest.TetrisLevelInfo.Results.MergeFrom(this.GenResult());
			return tetrisUpdateRequest;
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x008D7CCC File Offset: 0x008D5ECC
		private TetrisUpdateRequest GenRequestMsgWithTargetResult()
		{
			TetrisUpdateRequest tetrisUpdateRequest = TetrisUpdateRequest.Create();
			tetrisUpdateRequest.ActivityId = ActivityTetrisController.Instance.ActivityId;
			tetrisUpdateRequest.TetrisLevelInfo = new TetrisLevelInfo
			{
				Id = this.CurrentLevelConfig.Value.Id,
				State = TetrisState.TetrisUnlocked,
				DifficultyIdx = (int)this.CurrentDifficulty
			};
			tetrisUpdateRequest.TetrisLevelInfo.Results.MergeFrom(this.GetCurrentTargetRecord());
			return tetrisUpdateRequest;
		}

		// Token: 0x0601CF74 RID: 118644 RVA: 0x008D7D3C File Offset: 0x008D5F3C
		private TetrisFinishRequest GenInfiniteRequestMsg()
		{
			TetrisFinishRequest tetrisFinishRequest = TetrisFinishRequest.Create();
			tetrisFinishRequest.HostPlayerId = CreatureModel.Instance.GetWorldOwner();
			tetrisFinishRequest.EntityId = TetrisController.Instance.GetEntityId();
			int? num = this.GetCurrentTarget().ContainsKey(0) ? new int?(this.GetCurrentTarget()[0]) : null;
			tetrisFinishRequest.Score = ((num != null) ? Math.Min(this.ScoreModel.GetScore(), num.Value) : this.ScoreModel.GetScore());
			return tetrisFinishRequest;
		}

		// Token: 0x0601CF75 RID: 118645 RVA: 0x008D7DCC File Offset: 0x008D5FCC
		[return: Nullable(new byte[]
		{
			0,
			2,
			1
		})]
		private ValueTuple<TetrisUpdateRequest, Dictionary<int, int>> GenActivityInfiniteRequestMsg()
		{
			int id = this.CurrentLevelConfig.Value.Id;
			Dictionary<int, int> dictionary = this.GenActivityInfiniteResult(id);
			if (dictionary.Count == 0)
			{
				return new ValueTuple<TetrisUpdateRequest, Dictionary<int, int>>(null, dictionary);
			}
			TetrisUpdateRequest tetrisUpdateRequest = TetrisUpdateRequest.Create();
			tetrisUpdateRequest.ActivityId = ActivityTetrisController.Instance.ActivityId;
			tetrisUpdateRequest.TetrisLevelInfo = new TetrisLevelInfo
			{
				Id = id,
				State = TetrisState.TetrisUnlocked,
				DifficultyIdx = (int)this.CurrentDifficulty
			};
			tetrisUpdateRequest.TetrisLevelInfo.Results.MergeFrom(dictionary);
			return new ValueTuple<TetrisUpdateRequest, Dictionary<int, int>>(tetrisUpdateRequest, dictionary);
		}

		// Token: 0x0601CF76 RID: 118646 RVA: 0x008D7E58 File Offset: 0x008D6058
		private Dictionary<int, int> GenResult()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in this.GetCurrentTarget())
			{
				int val = (keyValuePair.Key == 0) ? this.ScoreModel.GetScore() : this.GemModel.GetGem((EGemType)keyValuePair.Key);
				dictionary[keyValuePair.Key] = Math.Min(val, keyValuePair.Value);
			}
			return dictionary;
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x008D7EF0 File Offset: 0x008D60F0
		private Dictionary<int, int> GenActivityInfiniteResult(int challengeId)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int num in this.GetCurrentTarget().Keys)
			{
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				int? num2 = (tetrisData != null) ? tetrisData.GetChallengeRecord(challengeId, num) : null;
				int num3 = (num == 0) ? this.ScoreModel.GetScore() : this.GemModel.GetGem((EGemType)num);
				int? num4 = num2;
				int num5 = num3;
				if (num4.GetValueOrDefault() < num5 & num4 != null)
				{
					dictionary[num] = num3;
				}
			}
			return dictionary;
		}

		// Token: 0x0601CF78 RID: 118648 RVA: 0x008D7FA8 File Offset: 0x008D61A8
		[NullableContext(2)]
		public void SendInfiniteFinishRequest(Action callback = null)
		{
			if (this.CurrentLevelConfig.Value.ActivityId == 0)
			{
				TetrisController.Instance.SendCompleteRequest(this.GenInfiniteRequestMsg(), callback);
				return;
			}
			ValueTuple<TetrisUpdateRequest, Dictionary<int, int>> valueTuple = this.GenActivityInfiniteRequestMsg();
			TetrisUpdateRequest item = valueTuple.Item1;
			Dictionary<int, int> results = valueTuple.Item2;
			if (item != null)
			{
				ActivityTetrisController.Instance.SendCompleteRequest(item, delegate(List<RewardItemData> rewards)
				{
					ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
					if (tetrisData != null)
					{
						int id = this.GetCurrentConfig().Value.Id;
						bool flag = tetrisData.UpdateLocalChallengeRecords(id, results);
						bool flag2 = this.IsAllTargetsCompleted(true);
						bool flag3 = false;
						if (flag2)
						{
							flag3 = tetrisData.UpdateChallengeState(id, TetrisState.TetrisFinished);
						}
						if (this.PendingFirstTimeRewards.Count == 0 && rewards.Count > 0)
						{
							this.PendingFirstTimeRewards = rewards;
						}
						if (flag && !flag3)
						{
							EventSystem.Instance.Emit<int>(EEventName.OnTetrisChallengeStateUpdate, id);
						}
						Action callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3();
					}
				});
				return;
			}
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}

		// Token: 0x0601CF79 RID: 118649 RVA: 0x008D803C File Offset: 0x008D623C
		public void QuitEndlessLevel()
		{
			Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
			if (onBeforeOpenPopup != null)
			{
				onBeforeOpenPopup();
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessEndView, new EndLessEndOpenParam
			{
				Score = this.ScoreModel.GetScore(),
				IsQuit = true,
				IsAutoClose = !this.IsActivityLevel(),
				Rewards = this.PendingFirstTimeRewards
			}, null);
		}

		// Token: 0x0601CF7A RID: 118650 RVA: 0x008D80A4 File Offset: 0x008D62A4
		[NullableContext(2)]
		public void TryShowPendingFirstTimeRewards(Action callback = null)
		{
			List<RewardItemData> pendingFirstTimeRewards = this.PendingFirstTimeRewards;
			if (pendingFirstTimeRewards != null && pendingFirstTimeRewards.Count != 0)
			{
				Action onBeforeOpenPopup = this.OnBeforeOpenPopup;
				if (onBeforeOpenPopup != null)
				{
					onBeforeOpenPopup();
				}
				ItemRewardController.Instance.OpenCommonRewardView(1009, this.PendingFirstTimeRewards, callback);
				return;
			}
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x0601CF7B RID: 118651 RVA: 0x008D80F4 File Offset: 0x008D62F4
		private void InitGenerateShape()
		{
			this.AllShapes = ActivityTetrisConfig.GetAllShape();
		}

		// Token: 0x0601CF7C RID: 118652 RVA: 0x008D8104 File Offset: 0x008D6304
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public List<BlockInstance> GenerateBlocks(int count)
		{
			List<BlockInstance> list = new List<BlockInstance>();
			bool[,] boardOccupancy = this.GetBoardOccupancy();
			IReadOnlyList<TetrisPreset> presetConfigList = ActivityTetrisConfig.Instance.GetPresetConfigList(this.CurrentLevelConfig.Value.Id, this.CurrentRoundIndex);
			List<int> list2 = new List<int>();
			for (int i = 0; i < count; i++)
			{
				ShapeConfig shapeConfig;
				if (presetConfigList != null && i < presetConfigList.Count)
				{
					shapeConfig = ActivityTetrisConfig.GetTetrisShape(presetConfigList[i].ShapeId);
				}
				else
				{
					List<ShapeConfig> placeableShapes = this.GetPlaceableShapes(boardOccupancy);
					if (placeableShapes.Count == 0)
					{
						shapeConfig = this.GetRandomShapeFromList(this.AllShapes);
					}
					else
					{
						List<ShapeConfig> list3 = new List<ShapeConfig>();
						foreach (ShapeConfig shapeConfig2 in placeableShapes)
						{
							if (!list2.Contains(shapeConfig2.Id))
							{
								list3.Add(shapeConfig2);
							}
						}
						shapeConfig = this.GetRandomShapeFromList((list3.Count > 0) ? list3 : placeableShapes);
					}
				}
				if (shapeConfig.Id != 0)
				{
					list2.Add(shapeConfig.Id);
					BlockInstance item = TetrisUtils.Instance.CreateInstance(shapeConfig);
					this.OccupyVirtualGrid(boardOccupancy, shapeConfig);
					list.Add(item);
				}
			}
			this.ApplyGemsAndColors(list, presetConfigList);
			this.ApplyRotations(list, (presetConfigList != null) ? presetConfigList.Count : 0);
			this.ApplyBombs(list);
			return list;
		}

		// Token: 0x0601CF7D RID: 118653 RVA: 0x008D8278 File Offset: 0x008D6478
		private List<ShapeConfig> GetPlaceableShapes(bool[,] virtualGrid)
		{
			List<ShapeConfig> list = new List<ShapeConfig>();
			int length = virtualGrid.GetLength(0);
			int length2 = virtualGrid.GetLength(1);
			foreach (ShapeConfig shapeConfig in this.AllShapes)
			{
				if (this.CheckShapeCanFitAnywhere(virtualGrid, shapeConfig, length, length2))
				{
					list.Add(shapeConfig);
				}
			}
			return list;
		}

		// Token: 0x0601CF7E RID: 118654 RVA: 0x008D82F4 File Offset: 0x008D64F4
		private bool CheckShapeCanFitAnywhere(bool[,] grid, ShapeConfig shape, int rows, int cols)
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (!this.IsRotationEnabled())
					{
						if (TetrisPlayController.TryPlaceOnVirtual(grid, shape.Matrix, i, j, ETetrisRotation.Origin, true))
						{
							return true;
						}
					}
					else
					{
						bool flag = false;
						foreach (ETetrisRotation rotation in shape.DistinctRotations)
						{
							if (flag)
							{
								break;
							}
							flag = (flag || TetrisPlayController.TryPlaceOnVirtual(grid, shape.Matrix, i, j, rotation, true));
						}
						if (flag)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0601CF7F RID: 118655 RVA: 0x008D8378 File Offset: 0x008D6578
		private static bool TryPlaceOnVirtual(bool[,] grid, byte[,] matrix, int startR, int startC, ETetrisRotation rotation, bool isDryRun)
		{
			int length;
			int length2;
			switch (rotation)
			{
			case ETetrisRotation.Origin:
			case ETetrisRotation.Clockwise180:
				length = matrix.GetLength(0);
				length2 = matrix.GetLength(1);
				break;
			case ETetrisRotation.Clockwise90:
			case ETetrisRotation.Clockwise270:
				length = matrix.GetLength(1);
				length2 = matrix.GetLength(0);
				break;
			default:
				throw new ArgumentOutOfRangeException("rotation", rotation, null);
			}
			if (length == 0 || length2 == 0)
			{
				return true;
			}
			int length3 = grid.GetLength(0);
			int length4 = grid.GetLength(1);
			if (startR + length > length3 || startC + length2 > length4)
			{
				return false;
			}
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (TetrisPlayController.GetMatrixCell(matrix, length2, length, i, j, rotation) == 1 && grid[startR + i, startC + j])
					{
						return false;
					}
				}
			}
			if (!isDryRun)
			{
				for (int k = 0; k < length; k++)
				{
					for (int l = 0; l < length2; l++)
					{
						if (TetrisPlayController.GetMatrixCell(matrix, length2, length, k, l, rotation) == 1)
						{
							grid[startR + k, startC + l] = true;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0601CF80 RID: 118656 RVA: 0x008D8484 File Offset: 0x008D6684
		private static byte GetMatrixCell(byte[,] matrix, int shapeW, int shapeH, int r, int c, ETetrisRotation rotation)
		{
			byte result;
			switch (rotation)
			{
			case ETetrisRotation.Origin:
				result = matrix[r, c];
				break;
			case ETetrisRotation.Clockwise90:
				result = matrix[shapeW - 1 - c, r];
				break;
			case ETetrisRotation.Clockwise180:
				result = matrix[shapeH - 1 - r, shapeW - 1 - c];
				break;
			case ETetrisRotation.Clockwise270:
				result = matrix[c, shapeH - 1 - r];
				break;
			default:
				throw new ArgumentOutOfRangeException("rotation", rotation, null);
			}
			return result;
		}

		// Token: 0x0601CF81 RID: 118657 RVA: 0x008D8500 File Offset: 0x008D6700
		private void OccupyVirtualGrid(bool[,] grid, ShapeConfig config)
		{
			int length = grid.GetLength(0);
			int length2 = grid.GetLength(1);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (TetrisPlayController.TryPlaceOnVirtual(grid, config.Matrix, i, j, ETetrisRotation.Origin, false))
					{
						return;
					}
					if (this.IsRotationEnabled())
					{
						foreach (ETetrisRotation rotation in RuntimeHelpers.GetSubArray<ETetrisRotation>(config.DistinctRotations, Range.StartAt(1)))
						{
							if (TetrisPlayController.TryPlaceOnVirtual(grid, config.Matrix, i, j, rotation, false))
							{
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0601CF82 RID: 118658 RVA: 0x008D8598 File Offset: 0x008D6798
		private ShapeConfig GetRandomShapeFromList(List<ShapeConfig> list)
		{
			if (list.Count == 0)
			{
				return this.AllShapes[0];
			}
			int num = 0;
			foreach (ShapeConfig shapeConfig in list)
			{
				num += shapeConfig.Weight;
			}
			if (num <= 0)
			{
				return list[this.RandomNumberGenerator.Next(list.Count)];
			}
			double num2 = this.RandomNumberGenerator.NextDouble() * (double)num;
			foreach (ShapeConfig shapeConfig2 in list)
			{
				num2 -= (double)shapeConfig2.Weight;
				if (num2 < 0.0)
				{
					return shapeConfig2;
				}
			}
			return list[list.Count - 1];
		}

		// Token: 0x0601CF83 RID: 118659 RVA: 0x008D8690 File Offset: 0x008D6890
		[NullableContext(2)]
		private void ApplyGemsAndColors([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> blocks, IReadOnlyList<TetrisPreset> presetConfigList)
		{
			int num = Math.Min((presetConfigList != null) ? presetConfigList.Count : 0, blocks.Count);
			if (this.GetGameMode() != EGameMode.GemCollection)
			{
				for (int i = 0; i < blocks.Count; i++)
				{
					BlockInstance blockInstance = blocks[i];
					blockInstance.ColorId = ((i < num) ? presetConfigList[i].Color : this.RandomNumberGenerator.Next(1, 7));
					blockInstance.GemType = EGemType.None;
				}
				return;
			}
			List<EGemType> list = this.CalcRestGems();
			if (list == null || list.Count <= 0)
			{
				return;
			}
			int num2 = blocks.Count - num;
			int[] array = (num2 > 0) ? this.GetRandomIndices(num, num2, this.RandomNumberGenerator.Next(1, Math.Min(list.Count, num2) + 1)) : Array.Empty<int>();
			for (int j = 0; j < blocks.Count; j++)
			{
				BlockInstance blockInstance2 = blocks[j];
				if (j < num)
				{
					TetrisPreset tetrisPreset = presetConfigList[j];
					EGemType gem = (EGemType)tetrisPreset.Gem;
					blockInstance2.GemType = gem;
					blockInstance2.ColorId = tetrisPreset.Color;
					blockInstance2.GemFill = ((gem == EGemType.None) ? EGemFillType.None : this.GetGemFillType(gem));
					if (blockInstance2.GemFill == EGemFillType.Single)
					{
						int gemOffSet = this.RandomNumberGenerator.Next(blockInstance2.Offsets.Length);
						blockInstance2.GemOffSet = gemOffSet;
					}
				}
				else if (Array.IndexOf<int>(array, j) >= 0)
				{
					EGemType nextGemType = this.GetNextGemType(list);
					blockInstance2.GemType = nextGemType;
					blockInstance2.ColorId = (int)nextGemType;
					blockInstance2.GemFill = this.GetGemFillType(nextGemType);
					if (blockInstance2.GemFill == EGemFillType.Single)
					{
						int gemOffSet2 = this.RandomNumberGenerator.Next(blockInstance2.Offsets.Length);
						blockInstance2.GemOffSet = gemOffSet2;
					}
				}
				else
				{
					blockInstance2.ColorId = this.RandomNumberGenerator.Next(1, 7);
					blockInstance2.GemType = EGemType.None;
				}
			}
		}

		// Token: 0x0601CF84 RID: 118660 RVA: 0x008D8870 File Offset: 0x008D6A70
		private EGemType GetNextGemType(List<EGemType> neededGems)
		{
			this.GemModel.CurrentGemBag = this.GemModel.CurrentGemBag.FindAll(new Predicate<EGemType>(neededGems.Contains));
			if (this.GemModel.CurrentGemBag.Count == 0)
			{
				EGemType[] array = neededGems.ToArray();
				this.RandomNumberGenerator.Shuffle<EGemType>(array);
				this.GemModel.CurrentGemBag = array.ToList<EGemType>();
			}
			List<EGemType> currentGemBag = this.GemModel.CurrentGemBag;
			EGemType result = currentGemBag[currentGemBag.Count - 1];
			this.GemModel.CurrentGemBag.RemoveAt(this.GemModel.CurrentGemBag.Count - 1);
			return result;
		}

		// Token: 0x0601CF85 RID: 118661 RVA: 0x008D8918 File Offset: 0x008D6B18
		private EGemFillType GetGemFillType(EGemType gemType)
		{
			int num = this.GemModel.GetSpawnCount(gemType);
			num++;
			this.GemModel.SetSpawnCount(gemType, num);
			if (num % 5 == 0)
			{
				return EGemFillType.Full;
			}
			return EGemFillType.Single;
		}

		// Token: 0x0601CF86 RID: 118662 RVA: 0x008D894C File Offset: 0x008D6B4C
		[NullableContext(2)]
		private List<EGemType> CalcRestGems()
		{
			Dictionary<int, int> currentTarget = this.GetCurrentTarget();
			if (currentTarget.Count == 0)
			{
				return null;
			}
			List<EGemType> list = new List<EGemType>();
			foreach (KeyValuePair<int, int> keyValuePair in currentTarget)
			{
				if (keyValuePair.Value - this.GemModel.GetGem((EGemType)keyValuePair.Key) > 0)
				{
					list.Add((EGemType)keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x0601CF87 RID: 118663 RVA: 0x008D89D8 File Offset: 0x008D6BD8
		private void ApplyRotations([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> blocks, int configBlockCount)
		{
			if (this.IsRotationEnabled())
			{
				int num = blocks.Count - configBlockCount;
				if (num > 0)
				{
					TetrisRotationConfig? rotationConfig = this.CurrentLevelConfig.Value.RotationConfig;
					if (rotationConfig != null)
					{
						TetrisRotationConfig valueOrDefault = rotationConfig.GetValueOrDefault();
						if (valueOrDefault.ObjectCount != null && valueOrDefault.RotationCount != null && this.IsTriggered(rotationConfig.Value.Probability))
						{
							int indicesCount = Math.Min(this.GetRandomIntInRange(rotationConfig.Value.ObjectCount), num);
							foreach (int index in this.GetRandomIndices(configBlockCount, num, indicesCount))
							{
								int randomIntInRange = this.GetRandomIntInRange(rotationConfig.Value.RotationCount);
								BlockInstance blockInstance = blocks[index];
								ETetrisRotation rotation;
								switch (randomIntInRange)
								{
								case 1:
									rotation = ETetrisRotation.Clockwise90;
									break;
								case 2:
									rotation = ETetrisRotation.Clockwise180;
									break;
								case 3:
									rotation = ETetrisRotation.Clockwise270;
									break;
								default:
									rotation = ETetrisRotation.Origin;
									break;
								}
								blockInstance.Rotation = rotation;
							}
						}
					}
				}
			}
		}

		// Token: 0x0601CF88 RID: 118664 RVA: 0x008D8B04 File Offset: 0x008D6D04
		private void ApplyBombs([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> blocks)
		{
			TetrisBombConfig? bombConfig = this.CurrentLevelConfig.Value.BombConfig;
			if (bombConfig != null)
			{
				TetrisBombConfig valueOrDefault = bombConfig.GetValueOrDefault();
				foreach (BlockInstance blockInstance in blocks)
				{
					EGemType? egemType = (blockInstance != null) ? new EGemType?(blockInstance.GemType) : null;
					if (egemType == null)
					{
						goto IL_79;
					}
					EGemType valueOrDefault2 = egemType.GetValueOrDefault();
					if (valueOrDefault2 - EGemType.Orange > 5)
					{
						goto IL_79;
					}
					bool flag = true;
					IL_7C:
					if (flag && blockInstance.GemFill != EGemFillType.None)
					{
						continue;
					}
					if (!this.IsTriggered(valueOrDefault.BombProbability))
					{
						blockInstance.BombType = EBombType.None;
						blockInstance.BombFillType = EBombFillType.None;
						blockInstance.BombOffsetIndex = 0;
						continue;
					}
					blockInstance.BombType = (this.IsTriggered(valueOrDefault.SuperBombProbability) ? EBombType.SuperBomb : EBombType.Bomb);
					if (this.IsTriggered(valueOrDefault.AllBombProbability))
					{
						blockInstance.BombFillType = EBombFillType.All;
						blockInstance.GemType = EGemType.None;
						blockInstance.GemFill = EGemFillType.None;
						blockInstance.GemOffSet = 0;
						continue;
					}
					blockInstance.BombFillType = EBombFillType.Single;
					switch (blockInstance.GemFill)
					{
					case EGemFillType.None:
						blockInstance.BombOffsetIndex = this.RandomNumberGenerator.Next(blockInstance.Offsets.Length);
						continue;
					case EGemFillType.Single:
					{
						int num = blockInstance.Offsets.Length;
						if (num > 1)
						{
							int[] array = new int[blockInstance.Offsets.Length - 1];
							for (int i = 0; i < array.Length; i++)
							{
								array[i] = ((i < blockInstance.GemOffSet) ? i : (i + 1));
							}
							this.RandomNumberGenerator.Shuffle<int>(array);
							blockInstance.BombOffsetIndex = array[0];
							continue;
						}
						if (num == 1)
						{
							blockInstance.BombOffsetIndex = 0;
							blockInstance.GemType = EGemType.None;
							blockInstance.GemFill = EGemFillType.None;
							continue;
						}
						continue;
					}
					case EGemFillType.Full:
						blockInstance.BombOffsetIndex = this.RandomNumberGenerator.Next(blockInstance.Offsets.Length);
						continue;
					default:
						blockInstance.GemType = EGemType.None;
						blockInstance.GemFill = EGemFillType.None;
						blockInstance.GemOffSet = 0;
						continue;
					}
					IL_79:
					flag = false;
					goto IL_7C;
				}
			}
		}

		// Token: 0x0601CF89 RID: 118665 RVA: 0x008D8D5C File Offset: 0x008D6F5C
		public Dictionary<EGemType, int> GetCurrentGems()
		{
			return this.GemModel.GetCurrentGem();
		}

		// Token: 0x0601CF8A RID: 118666 RVA: 0x008D8D69 File Offset: 0x008D6F69
		public int GetCurrentGem(int gemId)
		{
			return this.GemModel.GetCurrentGem().GetValueOrDefault((EGemType)gemId, 0);
		}

		// Token: 0x0601CF8B RID: 118667 RVA: 0x008D8D7D File Offset: 0x008D6F7D
		public int GetCurrentScore()
		{
			return this.ScoreModel.GetScore();
		}

		// Token: 0x0601CF8C RID: 118668 RVA: 0x008D8D8C File Offset: 0x008D6F8C
		private void EmitScoreChanged()
		{
			int? num = (this.CurrentLevelConfig != null) ? new int?(this.CurrentLevelConfig.GetValueOrDefault().Id) : null;
			if (num != null)
			{
				int valueOrDefault = num.GetValueOrDefault();
				EventSystem.Instance.Emit<int, int>(EEventName.OnTetrisScoreChanged, valueOrDefault, this.GetCurrentScore());
			}
		}

		// Token: 0x0601CF8D RID: 118669 RVA: 0x008D8DEE File Offset: 0x008D6FEE
		public void SetComboCount(int count)
		{
			this.ScoreModel.SetComboCount(count, this.CurrentRoundIndex);
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x008D8E02 File Offset: 0x008D7002
		public TetrisScoreData GetScoreModel()
		{
			return this.ScoreModel;
		}

		// Token: 0x0601CF8F RID: 118671 RVA: 0x008D8E0A File Offset: 0x008D700A
		public int Calculate(TetrisClearInfo clearInfo)
		{
			return this.ScoreModel.Calculate(clearInfo, this.CurrentRoundIndex);
		}

		// Token: 0x0601CF90 RID: 118672 RVA: 0x008D8E20 File Offset: 0x008D7020
		public long? GetHighestScore()
		{
			if (!this.IsActivityLevel())
			{
				return new long?(TetrisController.Instance.GetHighestScore());
			}
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			int? num = (tetrisData != null) ? tetrisData.GetChallengeRecord(this.CurrentLevelConfig.Value.Id, 0) : null;
			if (num == null)
			{
				return null;
			}
			return new long?((long)num.GetValueOrDefault());
		}

		// Token: 0x0601CF91 RID: 118673 RVA: 0x008D8E98 File Offset: 0x008D7098
		public bool IsRotationEnabled()
		{
			return this.CurrentLevelConfig != null && this.CurrentLevelConfig.GetValueOrDefault().EnableRotation;
		}

		// Token: 0x0601CF92 RID: 118674 RVA: 0x008D8EC4 File Offset: 0x008D70C4
		public void RecordRotation(int index)
		{
			switch (index)
			{
			case 0:
				this.CurrentRoundRotateCount1++;
				return;
			case 1:
				this.CurrentRoundRotateCount2++;
				return;
			case 2:
				this.CurrentRoundRotateCount3++;
				return;
			case 3:
				this.CurrentRoundRotateCount4++;
				return;
			default:
				return;
			}
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x008D8F24 File Offset: 0x008D7124
		private void InitBoard(int id)
		{
			TetrisBoardItemConfig[,] tetrisMap = ActivityTetrisConfig.Instance.GetTetrisMap(id);
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.GridModel.Cells[i, j] = TetrisPlayController.ParseSingleCell(tetrisMap[i, j]);
				}
			}
		}

		// Token: 0x0601CF94 RID: 118676 RVA: 0x008D8F74 File Offset: 0x008D7174
		private static TetrisCellData ParseSingleCell(in TetrisBoardItemConfig itemData)
		{
			TetrisCellData tetrisCellData = new TetrisCellData();
			TetrisBoardItemConfig tetrisBoardItemConfig = itemData;
			if (tetrisBoardItemConfig.Block)
			{
				tetrisCellData.Type = ECellType.Fixed;
				tetrisCellData.ColorId = 7;
			}
			else
			{
				tetrisBoardItemConfig = itemData;
				if (tetrisBoardItemConfig.Color == 0)
				{
					tetrisCellData.Type = ECellType.Empty;
				}
				else
				{
					tetrisCellData.Type = ECellType.Normal;
					TetrisCellData tetrisCellData2 = tetrisCellData;
					tetrisBoardItemConfig = itemData;
					tetrisCellData2.ColorId = tetrisBoardItemConfig.Color;
					TetrisCellData tetrisCellData3 = tetrisCellData;
					tetrisBoardItemConfig = itemData;
					tetrisCellData3.SealState = (ESealState)tetrisBoardItemConfig.Seal;
					tetrisBoardItemConfig = itemData;
					switch (tetrisBoardItemConfig.Gem)
					{
					case 1:
						tetrisCellData.GemType = EGemType.Orange;
						break;
					case 2:
						tetrisCellData.GemType = EGemType.Blue;
						break;
					case 3:
						tetrisCellData.GemType = EGemType.Green;
						break;
					case 4:
						tetrisCellData.GemType = EGemType.Purple;
						break;
					case 5:
						tetrisCellData.GemType = EGemType.Yellow;
						break;
					case 6:
						tetrisCellData.GemType = EGemType.Red;
						break;
					case 8:
						tetrisCellData.BombType = EBombType.Bomb;
						break;
					case 9:
						tetrisCellData.BombType = EBombType.SuperBomb;
						break;
					}
				}
			}
			return tetrisCellData;
		}

		// Token: 0x0601CF95 RID: 118677 RVA: 0x008D907C File Offset: 0x008D727C
		[NullableContext(2)]
		public bool CanPlaceShape(BlockInstance block, int targetR, int targetC, bool checkAllRotations)
		{
			if (block == null)
			{
				return false;
			}
			int boundRectWidth = block.BoundRectWidth;
			int boundRectHeight = block.BoundRectHeight;
			ValueTuple<int, int>[] offsets = block.Offsets;
			if (!checkAllRotations)
			{
				return this.CanPlaceShapeInternal(targetR, targetC, offsets, boundRectWidth, boundRectHeight, block.Rotation);
			}
			bool flag = false;
			foreach (ETetrisRotation rotation in block.DistinctRotations)
			{
				if (flag)
				{
					break;
				}
				flag = (flag || this.CanPlaceShapeInternal(targetR, targetC, offsets, boundRectWidth, boundRectHeight, rotation));
			}
			return flag;
		}

		// Token: 0x0601CF96 RID: 118678 RVA: 0x008D90F8 File Offset: 0x008D72F8
		private bool CanPlaceShapeInternal(int targetR, int targetC, [TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] ValueTuple<int, int>[] shapeOffsets, int boundRectWidth, int boundRectHeight, ETetrisRotation rotation)
		{
			for (int i = 0; i < shapeOffsets.Length; i++)
			{
				ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(shapeOffsets[i], boundRectWidth, boundRectHeight, rotation);
				int num = targetR + rotatedOffset.Item1;
				int num2 = targetC + rotatedOffset.Item2;
				if (num < 0 || num >= 8 || num2 < 0 || num2 >= 8)
				{
					return false;
				}
				if (this.GridModel.Cells[num, num2].IsOccupied)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0601CF97 RID: 118679 RVA: 0x008D916C File Offset: 0x008D736C
		public bool PlaceShape(BlockInstance shape, int targetR, int targetC)
		{
			if (!this.CanPlaceShape(shape, targetR, targetC, false))
			{
				return false;
			}
			int boundRectWidth = shape.BoundRectWidth;
			int boundRectHeight = shape.BoundRectHeight;
			for (int i = 0; i < shape.Offsets.Length; i++)
			{
				ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(shape.Offsets[i], boundRectWidth, boundRectHeight, shape.Rotation);
				TetrisCellData tetrisCellData = this.GridModel.Cells[targetR + rotatedOffset.Item1, targetC + rotatedOffset.Item2];
				tetrisCellData.Type = ECellType.Normal;
				tetrisCellData.ColorId = shape.ColorId;
				tetrisCellData.SealState = ESealState.None;
				TetrisCellData tetrisCellData2 = tetrisCellData;
				ValueTuple<EGemType, EBombType> cellAttachmentTypes = shape.GetCellAttachmentTypes(i);
				tetrisCellData2.GemType = cellAttachmentTypes.Item1;
				tetrisCellData.BombType = cellAttachmentTypes.Item2;
			}
			return true;
		}

		// Token: 0x0601CF98 RID: 118680 RVA: 0x008D9228 File Offset: 0x008D7428
		private TetrisClearInfo CheckAndClear()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			Dictionary<EGemType, int> collectedGems = new Dictionary<EGemType, int>();
			List<ValueTuple<int, int, int>> list3 = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list4 = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list5 = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list6 = new List<ValueTuple<int, int, int>>();
			for (int i = 0; i < 8; i++)
			{
				bool flag = true;
				for (int j = 0; j < 8; j++)
				{
					if (!this.GridModel.Cells[i, j].IsOccupied)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					list.Add(i);
				}
			}
			for (int k = 0; k < 8; k++)
			{
				bool flag2 = true;
				for (int l = 0; l < 8; l++)
				{
					if (!this.GridModel.Cells[l, k].IsOccupied)
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					list2.Add(k);
				}
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int row in list)
			{
				for (int m = 0; m < 8; m++)
				{
					hashSet.Add(TetrisUtils.GenPosKey(row, m));
				}
			}
			foreach (int column in list2)
			{
				for (int n = 0; n < 8; n++)
				{
					hashSet.Add(TetrisUtils.GenPosKey(n, column));
				}
			}
			foreach (int key in hashSet)
			{
				ValueTuple<int, int> valueTuple = TetrisUtils.ParsePosKey(key);
				TetrisCellData tetrisCellData = this.GridModel.Cells[valueTuple.Item1, valueTuple.Item2];
				if (tetrisCellData.Type != ECellType.Fixed)
				{
					switch (tetrisCellData.SealState)
					{
					case ESealState.Layer1:
						TetrisPlayController.UnsealCell(valueTuple, tetrisCellData, list4);
						continue;
					case ESealState.Layer2:
						TetrisPlayController.SetCellSealLayer1(valueTuple, tetrisCellData, list4);
						continue;
					}
					TetrisPlayController.ClearCell(valueTuple, tetrisCellData, collectedGems, list3, list5, list6);
				}
			}
			return new TetrisClearInfo
			{
				ClearedRows = list.ToArray(),
				ClearedCols = list2.ToArray(),
				CollectedGems = collectedGems,
				ClearedPositions = list3.ToArray(),
				SealChangePositions = list4.ToArray(),
				Bombs = Array.Empty<ValueTuple<int, int, int>>(),
				SuperBombs = Array.Empty<ValueTuple<int, int, int>>(),
				TriggeredBombs = list5.ToArray(),
				TriggeredSuperBombs = list6.ToArray(),
				CumulateBombCount = 0,
				IsBoardAllCleared = (list5.Count + list6.Count == 0 && this.IsBoardEmpty())
			};
		}

		// Token: 0x0601CF99 RID: 118681 RVA: 0x008D9514 File Offset: 0x008D7714
		private TetrisClearInfo DetonateBombs(TetrisClearInfo previousClearInfo)
		{
			Dictionary<EGemType, int> collectedGems = new Dictionary<EGemType, int>();
			List<ValueTuple<int, int, int>> list = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list2 = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list3 = new List<ValueTuple<int, int, int>>();
			List<ValueTuple<int, int, int>> list4 = new List<ValueTuple<int, int, int>>();
			Array.Clear(this.BombCoverage, 0, this.BombCoverage.Length);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (ValueTuple<int, int, int> valueTuple in previousClearInfo.TriggeredBombs)
			{
				for (int j = Math.Max(valueTuple.Item1 - 1, 0); j <= Math.Min(valueTuple.Item1 + 1, 7); j++)
				{
					for (int k = Math.Max(valueTuple.Item2 - 1, 0); k <= Math.Min(valueTuple.Item2 + 1, 7); k++)
					{
						ref byte ptr = ref this.BombCoverage[j, k];
						ptr += 1;
						hashSet.Add(TetrisUtils.GenPosKey(j, k));
					}
				}
			}
			foreach (ValueTuple<int, int, int> valueTuple2 in previousClearInfo.TriggeredSuperBombs)
			{
				for (int l = Math.Max(valueTuple2.Item1 - 2, 0); l <= Math.Min(valueTuple2.Item1 + 2, 7); l++)
				{
					for (int m = Math.Max(valueTuple2.Item2 - 2, 0); m <= Math.Min(valueTuple2.Item2 + 2, 7); m++)
					{
						ref byte ptr2 = ref this.BombCoverage[l, m];
						ptr2 += 1;
						hashSet.Add(TetrisUtils.GenPosKey(l, m));
					}
				}
			}
			foreach (int key in hashSet)
			{
				ValueTuple<int, int> valueTuple3 = TetrisUtils.ParsePosKey(key);
				TetrisCellData tetrisCellData = this.GridModel.Cells[valueTuple3.Item1, valueTuple3.Item2];
				if (tetrisCellData.Type == ECellType.Normal)
				{
					switch (tetrisCellData.SealState)
					{
					case ESealState.Layer1:
					{
						byte b = this.BombCoverage[valueTuple3.Item1, valueTuple3.Item2];
						if (b >= 2)
						{
							TetrisPlayController.ClearCell(valueTuple3, tetrisCellData, collectedGems, list, list3, list4);
							continue;
						}
						if (b == 1)
						{
							TetrisPlayController.UnsealCell(valueTuple3, tetrisCellData, list2);
							continue;
						}
						continue;
					}
					case ESealState.Layer2:
					{
						byte b = this.BombCoverage[valueTuple3.Item1, valueTuple3.Item2];
						if (b >= 3)
						{
							TetrisPlayController.ClearCell(valueTuple3, tetrisCellData, collectedGems, list, list3, list4);
							continue;
						}
						if (b == 1)
						{
							TetrisPlayController.SetCellSealLayer1(valueTuple3, tetrisCellData, list2);
							continue;
						}
						if (b != 2)
						{
							continue;
						}
						TetrisPlayController.UnsealCell(valueTuple3, tetrisCellData, list2);
						continue;
					}
					}
					TetrisPlayController.ClearCell(valueTuple3, tetrisCellData, collectedGems, list, list3, list4);
				}
			}
			return new TetrisClearInfo
			{
				ClearedRows = Array.Empty<int>(),
				ClearedCols = Array.Empty<int>(),
				CollectedGems = collectedGems,
				ClearedPositions = list.ToArray(),
				SealChangePositions = list2.ToArray(),
				Bombs = previousClearInfo.TriggeredBombs,
				SuperBombs = previousClearInfo.TriggeredSuperBombs,
				TriggeredBombs = list3.ToArray(),
				TriggeredSuperBombs = list4.ToArray(),
				CumulateBombCount = previousClearInfo.CumulateBombCount + previousClearInfo.TriggeredBombCount,
				IsBoardAllCleared = (list3.Count + list4.Count == 0 && this.IsBoardEmpty())
			};
		}

		// Token: 0x0601CF9A RID: 118682 RVA: 0x008D98AC File Offset: 0x008D7AAC
		[NullableContext(0)]
		private static void SetCellSealLayer1([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] ValueTuple<int, int> position, [Nullable(1)] TetrisCellData cell, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> sealChangePositions)
		{
			sealChangePositions.Add(new ValueTuple<int, int, int>(position.Item1, position.Item2, cell.ColorId));
			cell.SealState = ESealState.Layer1;
		}

		// Token: 0x0601CF9B RID: 118683 RVA: 0x008D98D2 File Offset: 0x008D7AD2
		[NullableContext(0)]
		private static void UnsealCell([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] ValueTuple<int, int> position, [Nullable(1)] TetrisCellData cell, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> sealChangePositions)
		{
			sealChangePositions.Add(new ValueTuple<int, int, int>(position.Item1, position.Item2, cell.ColorId));
			cell.SealState = ESealState.None;
		}

		// Token: 0x0601CF9C RID: 118684 RVA: 0x008D98F8 File Offset: 0x008D7AF8
		private static void ClearCell([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(0)] ValueTuple<int, int> position, TetrisCellData cell, Dictionary<EGemType, int> collectedGems, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> clearedPositions, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> triggeredBombs, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> triggeredSuperBombs)
		{
			switch (cell.BombType)
			{
			case EBombType.Bomb:
				triggeredBombs.Add(new ValueTuple<int, int, int>(position.Item1, position.Item2, cell.ColorId));
				goto IL_93;
			case EBombType.SuperBomb:
				triggeredSuperBombs.Add(new ValueTuple<int, int, int>(position.Item1, position.Item2, cell.ColorId));
				goto IL_93;
			}
			EGemType gemType = cell.GemType;
			bool flag = gemType - EGemType.Orange <= 5;
			if (flag)
			{
				int num;
				collectedGems[cell.GemType] = (collectedGems.TryGetValue(cell.GemType, out num) ? (num + 1) : 1);
			}
			IL_93:
			clearedPositions.Add(new ValueTuple<int, int, int>(position.Item1, position.Item2, cell.ColorId));
			cell.Reset();
		}

		// Token: 0x0601CF9D RID: 118685 RVA: 0x008D99BC File Offset: 0x008D7BBC
		public bool IsBoardEmpty()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (this.GridModel.Cells[i, j].Type == ECellType.Normal)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0601CF9E RID: 118686 RVA: 0x008D99FE File Offset: 0x008D7BFE
		private bool[,] GetBoardOccupancy()
		{
			return this.GridModel.GetBoardOccupancy();
		}

		// Token: 0x0601CF9F RID: 118687 RVA: 0x008D9A0C File Offset: 0x008D7C0C
		[return: TupleElementNames(new string[]
		{
			"Rows",
			"Cols"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<List<int>, List<int>> GetClearableRowsAndColsIfPlace([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int>> positions)
		{
			Array boardOccupancy = this.GridModel.GetBoardOccupancy();
			bool[,] array = new bool[8, 8];
			Array.Copy(boardOccupancy, array, array.Length);
			foreach (ValueTuple<int, int> valueTuple in positions)
			{
				int item = valueTuple.Item1;
				if (item >= 0 && item < 8)
				{
					int item2 = valueTuple.Item2;
					if (item2 >= 0 && item2 < 8)
					{
						array[valueTuple.Item1, valueTuple.Item2] = true;
					}
				}
			}
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < 8; i++)
			{
				bool flag = true;
				for (int j = 0; j < 8; j++)
				{
					if (!array[i, j])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					list.Add(i);
				}
			}
			for (int k = 0; k < 8; k++)
			{
				bool flag2 = true;
				for (int l = 0; l < 8; l++)
				{
					if (!array[l, k])
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					list2.Add(k);
				}
			}
			return new ValueTuple<List<int>, List<int>>(list, list2);
		}

		// Token: 0x0601CFA0 RID: 118688 RVA: 0x008D9B44 File Offset: 0x008D7D44
		private List<string> SerializeBoardLines()
		{
			List<string> list = new List<string>();
			TetrisCellData[,] cells = this.GridModel.Cells;
			for (int i = 0; i < 8; i++)
			{
				string text = "";
				for (int j = 0; j < 8; j++)
				{
					text += (cells[i, j].IsOccupied ? "1" : "0");
				}
				list.Add(text);
			}
			return list;
		}

		// Token: 0x0601CFA1 RID: 118689 RVA: 0x008D9BB0 File Offset: 0x008D7DB0
		private int GetLevelCostTimeSeconds()
		{
			if (this.LevelStartTime <= 0L)
			{
				return 0;
			}
			return (int)Math.Round((double)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.LevelStartTime) / 1000.0);
		}

		// Token: 0x0601CFA2 RID: 118690 RVA: 0x008D9BF0 File Offset: 0x008D7DF0
		private void ResetTraceId()
		{
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<long>(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
			this.CurrentTraceId = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0601CFA3 RID: 118691 RVA: 0x008D9C4E File Offset: 0x008D7E4E
		private string GetTraceId()
		{
			if (this.CurrentTraceId.Length <= 0)
			{
				this.ResetTraceId();
			}
			return this.CurrentTraceId;
		}

		// Token: 0x0601CFA4 RID: 118692 RVA: 0x008D9C6C File Offset: 0x008D7E6C
		private string SerializeHandShapes([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> shapes)
		{
			List<string> list = new List<string>();
			foreach (BlockInstance blockInstance in shapes)
			{
				if (blockInstance != null)
				{
					list.Add(blockInstance.Config.Id.ToString());
				}
			}
			return string.Join(",", list);
		}

		// Token: 0x0601CFA5 RID: 118693 RVA: 0x008D9CE8 File Offset: 0x008D7EE8
		private string SerializeGemReward()
		{
			if (this.GetGameMode() != EGameMode.GemCollection)
			{
				return "-1";
			}
			Dictionary<EGemType, int> currentGem = this.GemModel.GetCurrentGem();
			List<string> list = new List<string>();
			foreach (KeyValuePair<EGemType, int> keyValuePair in currentGem)
			{
				if (keyValuePair.Value > 0)
				{
					List<string> list2 = list;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>((int)keyValuePair.Key);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
					list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			return string.Join(",", list);
		}

		// Token: 0x0601CFA6 RID: 118694 RVA: 0x008D9DA0 File Offset: 0x008D7FA0
		public void SendStartLogData()
		{
			TetrisStartLogEvent tetrisStartLogEvent = new TetrisStartLogEvent();
			Tetris? currentLevelConfig = this.CurrentLevelConfig;
			if (currentLevelConfig != null)
			{
				int id = currentLevelConfig.Value.Id;
				tetrisStartLogEvent.i_activity_id = ActivityTetrisController.Instance.ActivityId;
				tetrisStartLogEvent.i_inst_id = id;
				tetrisStartLogEvent.i_type = currentLevelConfig.Value.Mode;
				TetrisStartLogEvent tetrisStartLogEvent2 = tetrisStartLogEvent;
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				tetrisStartLogEvent2.i_first_pass = (((tetrisData != null && tetrisData.CheckChallengeComplete(id)) > false) ? 1 : 0);
				tetrisStartLogEvent.s_trace_id = this.GetTraceId();
			}
			LogReportController.Instance.LogReport(tetrisStartLogEvent);
		}

		// Token: 0x0601CFA7 RID: 118695 RVA: 0x008D9E38 File Offset: 0x008D8038
		public void SendResultLogData(int operation)
		{
			this.RotateCount1 += this.CurrentRoundRotateCount1;
			this.RotateCount2 += this.CurrentRoundRotateCount2;
			this.RotateCount3 += this.CurrentRoundRotateCount3;
			this.RotateCount4 += this.CurrentRoundRotateCount4;
			this.ExplosionCount += this.CurrentRoundExplosionCount;
			TetrisResultLogEvent tetrisResultLogEvent = new TetrisResultLogEvent();
			Tetris? currentLevelConfig = this.CurrentLevelConfig;
			if (currentLevelConfig != null)
			{
				int id = currentLevelConfig.Value.Id;
				List<string> list = this.SerializeBoardLines();
				tetrisResultLogEvent.i_activity_id = ActivityTetrisController.Instance.ActivityId;
				tetrisResultLogEvent.i_inst_id = id;
				tetrisResultLogEvent.i_type = currentLevelConfig.Value.Mode;
				TetrisResultLogEvent tetrisResultLogEvent2 = tetrisResultLogEvent;
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				tetrisResultLogEvent2.i_first_pass = (((tetrisData != null && tetrisData.CheckChallengeComplete(id)) > false) ? 1 : 0);
				tetrisResultLogEvent.s_trace_id = this.GetTraceId();
				tetrisResultLogEvent.i_if_back = ((this.TakeBackCount > 0) ? 1 : 0);
				tetrisResultLogEvent.i_inst_diff = (int)this.CurrentDifficulty;
				tetrisResultLogEvent.i_result = operation;
				tetrisResultLogEvent.i_display_mode = ((this.GetGameMode() == EGameMode.GemCollection) ? 2 : 1);
				tetrisResultLogEvent.i_get_score = this.ScoreModel.GetScore();
				tetrisResultLogEvent.i_combo_max = this.ScoreModel.GetMaxComboCount();
				tetrisResultLogEvent.o_reward_items_new = this.SerializeGemReward();
				tetrisResultLogEvent.i_round = this.CurrentStageIndex;
				tetrisResultLogEvent.i_count = this.PlaceCount;
				tetrisResultLogEvent.i_cost_time = this.GetLevelCostTimeSeconds();
				tetrisResultLogEvent.i_first_tab = this.FirstRefillHandShapesSerialized;
				tetrisResultLogEvent.i_second_tab = this.CurrentRoundRefillHandShapesSerialized;
				tetrisResultLogEvent.o_line_end1 = ((list.Count > 0) ? list[0] : "");
				tetrisResultLogEvent.o_line_end2 = ((list.Count > 1) ? list[1] : "");
				tetrisResultLogEvent.o_line_end3 = ((list.Count > 2) ? list[2] : "");
				tetrisResultLogEvent.o_line_end4 = ((list.Count > 3) ? list[3] : "");
				tetrisResultLogEvent.o_line_end5 = ((list.Count > 4) ? list[4] : "");
				tetrisResultLogEvent.o_line_end6 = ((list.Count > 5) ? list[5] : "");
				tetrisResultLogEvent.o_line_end7 = ((list.Count > 6) ? list[6] : "");
				tetrisResultLogEvent.o_line_end8 = ((list.Count > 7) ? list[7] : "");
				tetrisResultLogEvent.i_rotate_count1 = this.RotateCount1;
				tetrisResultLogEvent.i_rotate_count2 = this.RotateCount2;
				tetrisResultLogEvent.i_rotate_count3 = this.RotateCount3;
				tetrisResultLogEvent.i_rotate_count4 = this.RotateCount4;
				tetrisResultLogEvent.i_explosion_count = this.ExplosionCount;
			}
			LogReportController.Instance.LogReport(tetrisResultLogEvent);
		}

		// Token: 0x0601CFA8 RID: 118696 RVA: 0x008DA0FC File Offset: 0x008D82FC
		private void FillRoundLogBoardLines(TetrisRoundLogEvent logData, List<string> boardLines)
		{
			string text = "";
			logData.o_line_start1 = ((boardLines.Count > 0) ? boardLines[0] : text);
			logData.o_line_start2 = ((boardLines.Count > 1) ? boardLines[1] : text);
			logData.o_line_start3 = ((boardLines.Count > 2) ? boardLines[2] : text);
			logData.o_line_start4 = ((boardLines.Count > 3) ? boardLines[3] : text);
			logData.o_line_start5 = ((boardLines.Count > 4) ? boardLines[4] : text);
			logData.o_line_start6 = ((boardLines.Count > 5) ? boardLines[5] : text);
			logData.o_line_start7 = ((boardLines.Count > 6) ? boardLines[6] : text);
			logData.o_line_start8 = ((boardLines.Count > 7) ? boardLines[7] : text);
			logData.o_line_end1 = ((boardLines.Count > 0) ? boardLines[0] : text);
			logData.o_line_end2 = ((boardLines.Count > 1) ? boardLines[1] : text);
			logData.o_line_end3 = ((boardLines.Count > 2) ? boardLines[2] : text);
			logData.o_line_end4 = ((boardLines.Count > 3) ? boardLines[3] : text);
			logData.o_line_end5 = ((boardLines.Count > 4) ? boardLines[4] : text);
			logData.o_line_end6 = ((boardLines.Count > 5) ? boardLines[5] : text);
			logData.o_line_end7 = ((boardLines.Count > 6) ? boardLines[6] : text);
			logData.o_line_end8 = ((boardLines.Count > 7) ? boardLines[7] : text);
		}

		// Token: 0x0601CFA9 RID: 118697 RVA: 0x008DA2A0 File Offset: 0x008D84A0
		public void SendRoundLogData()
		{
			TetrisRoundLogEvent tetrisRoundLogEvent = new TetrisRoundLogEvent();
			Tetris? currentLevelConfig = this.CurrentLevelConfig;
			if (currentLevelConfig != null)
			{
				int id = currentLevelConfig.Value.Id;
				List<string> boardLines = this.SerializeBoardLines();
				tetrisRoundLogEvent.i_activity_id = ActivityTetrisController.Instance.ActivityId;
				tetrisRoundLogEvent.i_inst_id = id;
				tetrisRoundLogEvent.i_type = (int)this.GetGameMode();
				TetrisRoundLogEvent tetrisRoundLogEvent2 = tetrisRoundLogEvent;
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				tetrisRoundLogEvent2.i_first_pass = (((tetrisData != null && tetrisData.CheckChallengeComplete(id)) > false) ? 1 : 0);
				tetrisRoundLogEvent.s_trace_id = this.GetTraceId();
				tetrisRoundLogEvent.i_if_back = ((this.TakeBackCount > 0) ? 1 : 0);
				tetrisRoundLogEvent.i_inst_diff = (int)this.CurrentDifficulty;
				tetrisRoundLogEvent.i_round = this.CurrentStageIndex;
				tetrisRoundLogEvent.i_result = 0;
				tetrisRoundLogEvent.i_display_mode = ((this.GetGameMode() == EGameMode.GemCollection) ? 2 : 1);
				tetrisRoundLogEvent.i_get_score = this.ScoreModel.GetScore();
				tetrisRoundLogEvent.if_con_combo = ((this.ScoreModel.GetComboCount() > 0) ? 1 : 0);
				tetrisRoundLogEvent.i_combo_max = this.ScoreModel.GetComboCount();
				tetrisRoundLogEvent.o_reward_items_new = this.SerializeGemReward();
				tetrisRoundLogEvent.i_first_tab = this.CurrentRoundRefillHandShapesSerialized;
				tetrisRoundLogEvent.i_count = this.PlaceCount;
				tetrisRoundLogEvent.i_cost_time = this.GetLevelCostTimeSeconds();
				this.FillRoundLogBoardLines(tetrisRoundLogEvent, boardLines);
				tetrisRoundLogEvent.i_rotate_count1 = this.CurrentRoundRotateCount1;
				tetrisRoundLogEvent.i_rotate_count2 = this.CurrentRoundRotateCount2;
				tetrisRoundLogEvent.i_rotate_count3 = this.CurrentRoundRotateCount3;
				tetrisRoundLogEvent.i_rotate_count4 = this.CurrentRoundRotateCount4;
				tetrisRoundLogEvent.i_explosion_count = this.CurrentRoundExplosionCount;
			}
			LogReportController.Instance.LogReport(tetrisRoundLogEvent);
		}

		// Token: 0x0601CFAD RID: 118701 RVA: 0x008DA4E8 File Offset: 0x008D86E8
		[CompilerGenerated]
		private void <ShowTakeBackConfirmBox>g__cancelCallback|96_0()
		{
			Action onHandShapesCleared = this.OnHandShapesCleared;
			if (onHandShapesCleared != null)
			{
				onHandShapesCleared();
			}
			this.DoGameLose();
		}

		// Token: 0x0601CFAE RID: 118702 RVA: 0x008DA501 File Offset: 0x008D8701
		[CompilerGenerated]
		private void <ShowTakeBackConfirmBox>g__confirmCallback|96_1()
		{
			this.DoTakeBack();
		}

		// Token: 0x0400F431 RID: 62513
		private readonly TetrisBoardData GridModel = new TetrisBoardData();

		// Token: 0x0400F432 RID: 62514
		private readonly TetrisScoreData ScoreModel = new TetrisScoreData();

		// Token: 0x0400F433 RID: 62515
		private readonly TetrisGemData GemModel = new TetrisGemData();

		// Token: 0x0400F434 RID: 62516
		private List<ShapeConfig> AllShapes = new List<ShapeConfig>();

		// Token: 0x0400F435 RID: 62517
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<BlockInstance> HandShapes = new List<BlockInstance>();

		// Token: 0x0400F436 RID: 62518
		public Tetris? CurrentLevelConfig;

		// Token: 0x0400F437 RID: 62519
		public bool IsGameOver;

		// Token: 0x0400F438 RID: 62520
		public int CurrentRoundIndex;

		// Token: 0x0400F439 RID: 62521
		private int LoseCount;

		// Token: 0x0400F43A RID: 62522
		public ETetrisDifficulty CurrentDifficulty;

		// Token: 0x0400F43B RID: 62523
		private int TakeBackCount;

		// Token: 0x0400F43C RID: 62524
		[Nullable(2)]
		private TetrisGameSnapshot TakeBackSnapshot;

		// Token: 0x0400F43D RID: 62525
		private long LevelStartTime;

		// Token: 0x0400F43E RID: 62526
		private string CurrentTraceId = "";

		// Token: 0x0400F43F RID: 62527
		private int PlaceCount;

		// Token: 0x0400F440 RID: 62528
		private string FirstRefillHandShapesSerialized = "";

		// Token: 0x0400F441 RID: 62529
		private string CurrentRoundRefillHandShapesSerialized = "";

		// Token: 0x0400F442 RID: 62530
		private int CurrentStageIndex;

		// Token: 0x0400F443 RID: 62531
		private int RotateCount1;

		// Token: 0x0400F444 RID: 62532
		private int RotateCount2;

		// Token: 0x0400F445 RID: 62533
		private int RotateCount3;

		// Token: 0x0400F446 RID: 62534
		private int RotateCount4;

		// Token: 0x0400F447 RID: 62535
		private int ExplosionCount;

		// Token: 0x0400F448 RID: 62536
		private int CurrentRoundRotateCount1;

		// Token: 0x0400F449 RID: 62537
		private int CurrentRoundRotateCount2;

		// Token: 0x0400F44A RID: 62538
		private int CurrentRoundRotateCount3;

		// Token: 0x0400F44B RID: 62539
		private int CurrentRoundRotateCount4;

		// Token: 0x0400F44C RID: 62540
		private int CurrentRoundExplosionCount;

		// Token: 0x0400F44D RID: 62541
		private List<RewardItemData> PendingFirstTimeRewards = new List<RewardItemData>();

		// Token: 0x0400F44E RID: 62542
		private bool IsAnimatingInternal;

		// Token: 0x0400F44F RID: 62543
		[Nullable(2)]
		public Action<bool> OnAnimatingChanged;

		// Token: 0x0400F450 RID: 62544
		private bool IsSettlingScoreInternal;

		// Token: 0x0400F451 RID: 62545
		[Nullable(2)]
		internal Action OnScoreSettlementChanged;

		// Token: 0x0400F452 RID: 62546
		private bool UseDialogWinOnly;

		// Token: 0x0400F453 RID: 62547
		[Nullable(2)]
		public Action<bool, bool> OnDataUpdate;

		// Token: 0x0400F454 RID: 62548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ComboData> OnCombo;

		// Token: 0x0400F455 RID: 62549
		[Nullable(2)]
		public Action OnRefillHandShapes;

		// Token: 0x0400F456 RID: 62550
		[Nullable(2)]
		public Action OnHandShapesCleared;

		// Token: 0x0400F457 RID: 62551
		[Nullable(2)]
		internal Action OnBeforeOpenPopup;

		// Token: 0x0400F458 RID: 62552
		[Nullable(2)]
		public TetrisPlayController.Delegate_OnPlaceAnimation OnPlaceAnimation;

		// Token: 0x0400F459 RID: 62553
		[Nullable(2)]
		public TetrisPlayController.Delegate_OnRemoveAnimation OnRemoveAnimation;

		// Token: 0x0400F45A RID: 62554
		[Nullable(2)]
		public TetrisPlayController.Delegate_OnCleanAnimation OnCleanAnimation;

		// Token: 0x0400F45B RID: 62555
		[Nullable(2)]
		public TetrisPlayController.Delegate_OnLoseBoardAnimation OnLoseBoardAnimation;

		// Token: 0x0400F45C RID: 62556
		private readonly byte[,] BombCoverage = new byte[8, 8];

		// Token: 0x0400F45D RID: 62557
		private readonly Random RandomNumberGenerator = new Random();

		// Token: 0x02008C32 RID: 35890
		// (Invoke) Token: 0x06042CA1 RID: 273569
		[NullableContext(0)]
		public delegate void Delegate_OnPlaceAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ValueTuple<int, int>> positions, Action onComplete = null);

		// Token: 0x02008C33 RID: 35891
		// (Invoke) Token: 0x06042CA5 RID: 273573
		[NullableContext(0)]
		public delegate void Delegate_OnRemoveAnimation(TetrisClearInfo clearInfo, Action onNext = null, Action onComplete = null);

		// Token: 0x02008C34 RID: 35892
		// (Invoke) Token: 0x06042CA9 RID: 273577
		[NullableContext(0)]
		public delegate void Delegate_OnCleanAnimation(bool isReset, Action onComplete = null);

		// Token: 0x02008C35 RID: 35893
		// (Invoke) Token: 0x06042CAD RID: 273581
		[NullableContext(0)]
		public delegate void Delegate_OnLoseBoardAnimation(Action onComplete);
	}
}
