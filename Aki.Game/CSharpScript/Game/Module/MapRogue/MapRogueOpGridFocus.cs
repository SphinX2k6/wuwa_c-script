using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B8 RID: 21944
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGridFocus : MapRogueOp
	{
		// Token: 0x170086CE RID: 34510
		// (get) Token: 0x06037F1B RID: 229147 RVA: 0x00D410EB File Offset: 0x00D3F2EB
		// (set) Token: 0x06037F1C RID: 229148 RVA: 0x00D410F3 File Offset: 0x00D3F2F3
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037F1D RID: 229149 RVA: 0x00D410FC File Offset: 0x00D3F2FC
		public MapRogueOpGridFocus()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x06037F1E RID: 229150 RVA: 0x00D41148 File Offset: 0x00D3F348
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

		// Token: 0x06037F1F RID: 229151 RVA: 0x00D411B6 File Offset: 0x00D3F3B6
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x06037F20 RID: 229152 RVA: 0x00D411C0 File Offset: 0x00D3F3C0
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

		// Token: 0x06037F21 RID: 229153 RVA: 0x00D41234 File Offset: 0x00D3F434
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

		// Token: 0x06037F22 RID: 229154 RVA: 0x00D412A1 File Offset: 0x00D3F4A1
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0401D625 RID: 120357
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;
	}
}
