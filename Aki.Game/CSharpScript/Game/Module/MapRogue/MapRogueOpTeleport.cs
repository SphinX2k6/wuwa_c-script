using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004594 RID: 17812
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpTeleport : MapRogueOp
	{
		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x0602CE56 RID: 183894 RVA: 0x00C8FD15 File Offset: 0x00C8DF15
		// (set) Token: 0x0602CE57 RID: 183895 RVA: 0x00C8FD1D File Offset: 0x00C8DF1D
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CE58 RID: 183896 RVA: 0x00C8FD26 File Offset: 0x00C8DF26
		public MapRogueOpTeleport()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x0602CE59 RID: 183897 RVA: 0x00C8FD44 File Offset: 0x00C8DF44
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Teleport] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" GridId:");
			MapTeleportByLocationOp mapTeleportByLocationOp = this.Data.MapTeleportByLocationOp;
			defaultInterpolatedStringHandler.AppendFormatted<int?>((mapTeleportByLocationOp != null) ? new int?(mapTeleportByLocationOp.GridIndex) : null);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CE5A RID: 183898 RVA: 0x00C8FDB2 File Offset: 0x00C8DFB2
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x0602CE5B RID: 183899 RVA: 0x00C8FDBC File Offset: 0x00C8DFBC
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			MapTeleportByLocationOp mapTeleportByLocationOp = this.Data.MapTeleportByLocationOp;
			if (mapTeleportByLocationOp == null)
			{
				return;
			}
			List<int> list = new List<int>();
			list.AddRange(mapTeleportByLocationOp.Grids);
			gameInfo.TeleportFlow(mapTeleportByLocationOp.GridIndex, list).ContinueWith(delegate()
			{
				this.Execute(gameInfo, null);
			});
		}

		// Token: 0x0602CE5C RID: 183900 RVA: 0x00C8FE23 File Offset: 0x00C8E023
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}
	}
}
