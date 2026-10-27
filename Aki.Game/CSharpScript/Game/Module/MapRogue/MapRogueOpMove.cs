using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B9 RID: 21945
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpMove : MapRogueOp
	{
		// Token: 0x170086CF RID: 34511
		// (get) Token: 0x06037F23 RID: 229155 RVA: 0x00D412A3 File Offset: 0x00D3F4A3
		// (set) Token: 0x06037F24 RID: 229156 RVA: 0x00D412AB File Offset: 0x00D3F4AB
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037F25 RID: 229157 RVA: 0x00D412B4 File Offset: 0x00D3F4B4
		public MapRogueOpMove(int lastGridIndex)
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
			this.LastGridIndex = lastGridIndex;
		}

		// Token: 0x06037F26 RID: 229158 RVA: 0x00D41318 File Offset: 0x00D3F518
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

		// Token: 0x06037F27 RID: 229159 RVA: 0x00D41384 File Offset: 0x00D3F584
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

		// Token: 0x06037F28 RID: 229160 RVA: 0x00D4144C File Offset: 0x00D3F64C
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

		// Token: 0x06037F29 RID: 229161 RVA: 0x00D414C4 File Offset: 0x00D3F6C4
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

		// Token: 0x06037F2A RID: 229162 RVA: 0x00D41510 File Offset: 0x00D3F710
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

		// Token: 0x06037F2B RID: 229163 RVA: 0x00D415B0 File Offset: 0x00D3F7B0
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

		// Token: 0x06037F2C RID: 229164 RVA: 0x00D41624 File Offset: 0x00D3F824
		private List<int> GetWholePath()
		{
			List<int> list = new List<int>();
			list.Add(this.LastGridIndex);
			list.AddRange(this.Path);
			return list;
		}

		// Token: 0x06037F2D RID: 229165 RVA: 0x00D41644 File Offset: 0x00D3F844
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

		// Token: 0x06037F2E RID: 229166 RVA: 0x00D416E4 File Offset: 0x00D3F8E4
		protected bool IsShapeCorner(int curId, int preId, int nextId)
		{
			int num = MapRogueOpMove.<IsShapeCorner>g__directionFunc|22_0(curId, preId);
			int num2 = MapRogueOpMove.<IsShapeCorner>g__directionFunc|22_0(curId, nextId);
			return num != num2;
		}

		// Token: 0x06037F2F RID: 229167 RVA: 0x00D41706 File Offset: 0x00D3F906
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
			gameInfo.SetInteractAvailable(EMapForbiddenTag.WaitExecuteOp, false);
			gameInfo.EndMove();
		}

		// Token: 0x06037F30 RID: 229168 RVA: 0x00D41716 File Offset: 0x00D3F916
		[CompilerGenerated]
		internal static int <IsShapeCorner>g__directionFunc|22_0(int g0, int g1)
		{
			if (g0 + 1 == g1 || g0 - 1 == g1)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0401D628 RID: 120360
		private List<int> Path = new List<int>();

		// Token: 0x0401D629 RID: 120361
		private readonly List<List<int>> UnlockGridVisions = new List<List<int>>();

		// Token: 0x0401D62A RID: 120362
		public List<int> CornerIndex = new List<int>();

		// Token: 0x0401D62B RID: 120363
		public List<int> CornerSingleLength = new List<int>();

		// Token: 0x0401D62C RID: 120364
		public int CurrentFocusGridIndex = -1;

		// Token: 0x0401D62D RID: 120365
		public int LastGridIndex;

		// Token: 0x0401D62E RID: 120366
		private const int THOUSANDTH_RATIO = 1000;

		// Token: 0x0401D62F RID: 120367
		private const float FOCUS_PLAYER_TWEEN_TIME = 0.25f;

		// Token: 0x0401D630 RID: 120368
		private const int MIN_FOCUS_PATH_COUNT = 3;
	}
}
