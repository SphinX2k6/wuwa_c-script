using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055BE RID: 21950
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpTeleport : MapRogueOp
	{
		// Token: 0x170086D4 RID: 34516
		// (get) Token: 0x06037F58 RID: 229208 RVA: 0x00D41FCD File Offset: 0x00D401CD
		// (set) Token: 0x06037F59 RID: 229209 RVA: 0x00D41FD5 File Offset: 0x00D401D5
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037F5A RID: 229210 RVA: 0x00D41FDE File Offset: 0x00D401DE
		public MapRogueOpTeleport()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x06037F5B RID: 229211 RVA: 0x00D41FFC File Offset: 0x00D401FC
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

		// Token: 0x06037F5C RID: 229212 RVA: 0x00D4206A File Offset: 0x00D4026A
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x06037F5D RID: 229213 RVA: 0x00D42074 File Offset: 0x00D40274
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

		// Token: 0x06037F5E RID: 229214 RVA: 0x00D420DB File Offset: 0x00D402DB
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}
	}
}
