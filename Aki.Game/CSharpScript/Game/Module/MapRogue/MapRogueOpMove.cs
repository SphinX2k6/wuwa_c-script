using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200458F RID: 17807
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpMove : MapRogueOp
	{
		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0602CE21 RID: 183841 RVA: 0x00C8EFEB File Offset: 0x00C8D1EB
		// (set) Token: 0x0602CE22 RID: 183842 RVA: 0x00C8EFF3 File Offset: 0x00C8D1F3
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CE23 RID: 183843 RVA: 0x00C8EFFC File Offset: 0x00C8D1FC
		public MapRogueOpMove(int lastGridIndex)
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
			this.LastGridIndex = lastGridIndex;
		}

		// Token: 0x0602CE24 RID: 183844 RVA: 0x00C8F060 File Offset: 0x00C8D260
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[Move] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			defaultInterpolatedStringHandler.AppendLiteral(" StepSize:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.StepSize);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CE25 RID: 183845 RVA: 0x00C8F0CC File Offset: 0x00C8D2CC
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			MoveOp moveOp = this.Data.MoveOp;
			RepeatedField<int> repeatedField = (moveOp != null) ? moveOp.Paths : null;
			MoveOp moveOp2 = this.Data.MoveOp;
			RepeatedField<GridVision> repeatedField2 = (moveOp2 != null) ? moveOp2.GridVisions : null;
			if (repeatedField != null)
			{
				this.Path.Clear();
				this.Path.AddRange(repeatedField);
				this.StepSize = this.Path.Count;
				this.InitPathInfo();
			}
			if (repeatedField2 != null)
			{
				foreach (GridVision gridVision in repeatedField2)
				{
					List<int> list = new List<int>();
					list.AddRange(gridVision.Grids);
					this.UnlockGridVisions.Add(list);
				}
			}
		}

		// Token: 0x0602CE26 RID: 183846 RVA: 0x00C8F194 File Offset: 0x00C8D394
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			int num = this.Path[this.Path.Count - 1];
			gameInfo.SetMoveTimeGap(this.Path.Count);
			if (gameInfo.CurSelectedIndex >= 0 && gameInfo.CurSelectedIndex != num)
			{
				gameInfo.SetMapGridBgStateProxy(gameInfo.CurSelectedIndex, false, null);
				gameInfo.SetMapGridBgStateProxy(num, true, null);
			}
			this.StartMoveAsync(gameInfo);
		}

		// Token: 0x0602CE27 RID: 183847 RVA: 0x00C8F20C File Offset: 0x00C8D40C
		private UniTask StartMoveAsync(MapRogueGameInfo gameInfo)
		{
			MapRogueOpMove.<StartMoveAsync>d__17 <StartMoveAsync>d__;
			<StartMoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartMoveAsync>d__.<>4__this = this;
			<StartMoveAsync>d__.gameInfo = gameInfo;
			<StartMoveAsync>d__.<>1__state = -1;
			<StartMoveAsync>d__.<>t__builder.Start<MapRogueOpMove.<StartMoveAsync>d__17>(ref <StartMoveAsync>d__);
			return <StartMoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CE28 RID: 183848 RVA: 0x00C8F258 File Offset: 0x00C8D458
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			int num = this.Path[this.CurrentStep - 1];
			foreach (int index in this.UnlockGridVisions[this.CurrentStep - 1])
			{
				gameInfo.SetGridVisionProxy(index, true);
			}
			if (this.CurrentFocusGridIndex == num)
			{
				this.FocusNextPath(gameInfo);
			}
			gameInfo.MoveOneStep(this.LastGridIndex, num);
			this.LastGridIndex = num;
			gameInfo.GameStage = EMapRogueGameStage.Move;
		}

		// Token: 0x0602CE29 RID: 183849 RVA: 0x00C8F2F8 File Offset: 0x00C8D4F8
		private void FocusNextPath(MapRogueGameInfo gameInfo)
		{
			if (this.CornerIndex.Count == 0)
			{
				return;
			}
			this.CurrentFocusGridIndex = this.CornerIndex[0];
			this.CornerIndex.RemoveAt(0);
			int num = this.CornerSingleLength[0];
			this.CornerSingleLength.RemoveAt(0);
			gameInfo.FocusOnGrid(this.CurrentFocusGridIndex, true, null, new float?(gameInfo.MoveTimeGap * (float)num / 1000f));
		}

		// Token: 0x0602CE2A RID: 183850 RVA: 0x00C8F36C File Offset: 0x00C8D56C
		private List<int> GetWholePath()
		{
			List<int> list = new List<int>();
			list.Add(this.LastGridIndex);
			list.AddRange(this.Path);
			return list;
		}

		// Token: 0x0602CE2B RID: 183851 RVA: 0x00C8F38C File Offset: 0x00C8D58C
		private void InitPathInfo()
		{
			int num = 0;
			List<int> wholePath = this.GetWholePath();
			for (int i = 1; i < wholePath.Count - 1; i++)
			{
				num++;
				int num2 = wholePath[i];
				int preId = wholePath[i - 1];
				int nextId = wholePath[i + 1];
				if (num >= 3 && this.IsShapeCorner(num2, preId, nextId))
				{
					this.CornerIndex.Add(num2);
					this.CornerSingleLength.Add(num);
					num = 0;
				}
			}
			this.CornerIndex.Add(wholePath[wholePath.Count - 1]);
			this.CornerSingleLength.Add(num + 1);
		}

		// Token: 0x0602CE2C RID: 183852 RVA: 0x00C8F42C File Offset: 0x00C8D62C
		protected bool IsShapeCorner(int curId, int preId, int nextId)
		{
			int num = MapRogueOpMove.<IsShapeCorner>g__directionFunc|22_0(curId, preId);
			int num2 = MapRogueOpMove.<IsShapeCorner>g__directionFunc|22_0(curId, nextId);
			return num != num2;
		}

		// Token: 0x0602CE2D RID: 183853 RVA: 0x00C8F44E File Offset: 0x00C8D64E
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
			gameInfo.SetInteractAvailable(EMapForbiddenTag.WaitExecuteOp, false);
			gameInfo.EndMove();
		}

		// Token: 0x0602CE2E RID: 183854 RVA: 0x00C8F45E File Offset: 0x00C8D65E
		[CompilerGenerated]
		internal static int <IsShapeCorner>g__directionFunc|22_0(int g0, int g1)
		{
			if (g0 + 1 == g1 || g0 - 1 == g1)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x040180B3 RID: 98483
		private List<int> Path = new List<int>();

		// Token: 0x040180B4 RID: 98484
		private readonly List<List<int>> UnlockGridVisions = new List<List<int>>();

		// Token: 0x040180B5 RID: 98485
		public List<int> CornerIndex = new List<int>();

		// Token: 0x040180B6 RID: 98486
		public List<int> CornerSingleLength = new List<int>();

		// Token: 0x040180B7 RID: 98487
		public int CurrentFocusGridIndex = -1;

		// Token: 0x040180B8 RID: 98488
		public int LastGridIndex;

		// Token: 0x040180B9 RID: 98489
		private const int THOUSANDTH_RATIO = 1000;

		// Token: 0x040180BA RID: 98490
		private const float FOCUS_PLAYER_TWEEN_TIME = 0.25f;

		// Token: 0x040180BB RID: 98491
		private const int MIN_FOCUS_PATH_COUNT = 3;
	}
}
