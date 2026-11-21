using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x0200366C RID: 13932
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoRollbackSnapshot
	{
		// Token: 0x0602425F RID: 148063 RVA: 0x00A3C172 File Offset: 0x00A3A372
		private WuWaGoRollbackSnapshot(int round, Dictionary<int, IRollbackCapture> captures)
		{
			this.Round = round;
			this.Captures = captures;
		}

		// Token: 0x06024260 RID: 148064 RVA: 0x00A3C188 File Offset: 0x00A3A388
		public static WuWaGoRollbackSnapshot CreateFromCaptures(int round, Dictionary<int, IRollbackCapture> captures)
		{
			return new WuWaGoRollbackSnapshot(round, captures);
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06024261 RID: 148065 RVA: 0x00A3C191 File Offset: 0x00A3A391
		public int Size
		{
			get
			{
				return this.Captures.Count;
			}
		}

		// Token: 0x06024262 RID: 148066 RVA: 0x00A3C19E File Offset: 0x00A3A39E
		public IReadOnlyList<IRollbackCapture> GetCaptures()
		{
			return new List<IRollbackCapture>(this.Captures.Values);
		}

		// Token: 0x06024263 RID: 148067 RVA: 0x00A3C1B0 File Offset: 0x00A3A3B0
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

		// Token: 0x04014275 RID: 82549
		public readonly int Round;

		// Token: 0x04014276 RID: 82550
		private readonly Dictionary<int, IRollbackCapture> Captures;
	}
}
