using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x0200473B RID: 18235
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoRollbackSnapshot
	{
		// Token: 0x0602FA95 RID: 195221 RVA: 0x00B0C1A6 File Offset: 0x00B0A3A6
		private WuWaGoRollbackSnapshot(int round, Dictionary<int, IRollbackCapture> captures)
		{
			this.Round = round;
			this.Captures = captures;
		}

		// Token: 0x0602FA96 RID: 195222 RVA: 0x00B0C1BC File Offset: 0x00B0A3BC
		public static WuWaGoRollbackSnapshot CreateFromCaptures(int round, Dictionary<int, IRollbackCapture> captures)
		{
			return new WuWaGoRollbackSnapshot(round, captures);
		}

		// Token: 0x17007713 RID: 30483
		// (get) Token: 0x0602FA97 RID: 195223 RVA: 0x00B0C1C5 File Offset: 0x00B0A3C5
		public int Size
		{
			get
			{
				return this.Captures.Count;
			}
		}

		// Token: 0x0602FA98 RID: 195224 RVA: 0x00B0C1D2 File Offset: 0x00B0A3D2
		public IReadOnlyList<IRollbackCapture> GetCaptures()
		{
			return this.Captures.Values.ToList<IRollbackCapture>();
		}

		// Token: 0x0602FA99 RID: 195225 RVA: 0x00B0C1E4 File Offset: 0x00B0A3E4
		public void RestoreToGameData(WuWaGoGameData gameData)
		{
			gameData.Round = this.Round;
			foreach (KeyValuePair<int, IRollbackCapture> keyValuePair in this.Captures)
			{
				int num;
				IRollbackCapture rollbackCapture;
				keyValuePair.Deconstruct(out num, out rollbackCapture);
				rollbackCapture.Restore();
			}
		}

		// Token: 0x04019BC5 RID: 105413
		public readonly int Round;

		// Token: 0x04019BC6 RID: 105414
		private readonly Dictionary<int, IRollbackCapture> Captures;
	}
}
