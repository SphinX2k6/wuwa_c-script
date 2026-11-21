using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037BC RID: 14268
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelReadRecord
	{
		// Token: 0x06025237 RID: 152119 RVA: 0x00A79DE4 File Offset: 0x00A77FE4
		public bool Record(int plotId)
		{
			return !this.KeyIds.Contains(plotId) && this.PendingKeyIds.Add(plotId);
		}

		// Token: 0x06025238 RID: 152120 RVA: 0x00A79E05 File Offset: 0x00A78005
		public bool Contains(int plotId)
		{
			return this.KeyIds.Contains(plotId) || this.PendingKeyIds.Contains(plotId);
		}

		// Token: 0x06025239 RID: 152121 RVA: 0x00A79E23 File Offset: 0x00A78023
		public bool IsRead(int plotId)
		{
			return this.KeyIds.Contains(plotId);
		}

		// Token: 0x0602523A RID: 152122 RVA: 0x00A79E34 File Offset: 0x00A78034
		[NullableContext(2)]
		public void Commit(Action<int> syncReadRecord)
		{
			foreach (int obj in this.PendingKeyIds)
			{
				if (syncReadRecord != null)
				{
					syncReadRecord(obj);
				}
			}
			this.KeyIds.UnionWith(this.PendingKeyIds);
			this.PendingKeyIds.Clear();
		}

		// Token: 0x0602523B RID: 152123 RVA: 0x00A79EA8 File Offset: 0x00A780A8
		public void DiscardPending()
		{
			this.PendingKeyIds.Clear();
		}

		// Token: 0x0602523C RID: 152124 RVA: 0x00A79EB5 File Offset: 0x00A780B5
		public void Load(IEnumerable<int> plotIds)
		{
			this.KeyIds.Clear();
			this.PendingKeyIds.Clear();
			this.KeyIds.UnionWith(plotIds);
		}

		// Token: 0x0602523D RID: 152125 RVA: 0x00A79ED9 File Offset: 0x00A780D9
		public void Clear()
		{
			this.KeyIds.Clear();
			this.PendingKeyIds.Clear();
		}

		// Token: 0x0401489A RID: 84122
		private readonly HashSet<int> KeyIds = new HashSet<int>();

		// Token: 0x0401489B RID: 84123
		private readonly HashSet<int> PendingKeyIds = new HashSet<int>();
	}
}
