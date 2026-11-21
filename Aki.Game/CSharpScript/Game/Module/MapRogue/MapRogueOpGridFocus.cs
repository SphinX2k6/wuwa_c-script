using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200458E RID: 17806
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGridFocus : MapRogueOp
	{
		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x0602CE19 RID: 183833 RVA: 0x00C8EE33 File Offset: 0x00C8D033
		// (set) Token: 0x0602CE1A RID: 183834 RVA: 0x00C8EE3B File Offset: 0x00C8D03B
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CE1B RID: 183835 RVA: 0x00C8EE44 File Offset: 0x00C8D044
		public MapRogueOpGridFocus()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x0602CE1C RID: 183836 RVA: 0x00C8EE90 File Offset: 0x00C8D090
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[GridFocus] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" GridId:");
			LightBlockByLocationOp lightBlockByLocationOp = this.Data.LightBlockByLocationOp;
			defaultInterpolatedStringHandler.AppendFormatted<int?>((lightBlockByLocationOp != null) ? new int?(lightBlockByLocationOp.GridIndex) : null);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CE1D RID: 183837 RVA: 0x00C8EEFE File Offset: 0x00C8D0FE
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x0602CE1E RID: 183838 RVA: 0x00C8EF08 File Offset: 0x00C8D108
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			LightBlockByLocationOp lightBlockByLocationOp = this.Data.LightBlockByLocationOp;
			if (lightBlockByLocationOp == null)
			{
				return;
			}
			gameInfo.SetInteractAvailable(EMapForbiddenTag.FocusLock, false);
			this.GridFocusFlow(gameInfo, lightBlockByLocationOp.GridIndex, lightBlockByLocationOp.FocusTime, lightBlockByLocationOp.Grids, lightBlockByLocationOp.BackToPlayer).ContinueWith(delegate()
			{
				gameInfo.SetInteractAvailable(EMapForbiddenTag.FocusLock, true);
				this.Execute(gameInfo, null);
			});
		}

		// Token: 0x0602CE1F RID: 183839 RVA: 0x00C8EF7C File Offset: 0x00C8D17C
		private UniTask GridFocusFlow(MapRogueGameInfo gameInfo, int gridIndex, int focusTime, IList<int> unlockGrids, bool backToPlayer)
		{
			MapRogueOpGridFocus.<GridFocusFlow>d__9 <GridFocusFlow>d__;
			<GridFocusFlow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GridFocusFlow>d__.<>4__this = this;
			<GridFocusFlow>d__.gameInfo = gameInfo;
			<GridFocusFlow>d__.gridIndex = gridIndex;
			<GridFocusFlow>d__.focusTime = focusTime;
			<GridFocusFlow>d__.unlockGrids = unlockGrids;
			<GridFocusFlow>d__.backToPlayer = backToPlayer;
			<GridFocusFlow>d__.<>1__state = -1;
			<GridFocusFlow>d__.<>t__builder.Start<MapRogueOpGridFocus.<GridFocusFlow>d__9>(ref <GridFocusFlow>d__);
			return <GridFocusFlow>d__.<>t__builder.Task;
		}

		// Token: 0x0602CE20 RID: 183840 RVA: 0x00C8EFE9 File Offset: 0x00C8D1E9
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x040180B0 RID: 98480
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;
	}
}
