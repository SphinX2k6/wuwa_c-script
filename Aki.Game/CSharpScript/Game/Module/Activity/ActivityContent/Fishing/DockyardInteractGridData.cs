using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A6 RID: 26022
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractGridData
	{
		// Token: 0x1700957B RID: 38267
		// (get) Token: 0x060413EC RID: 267244 RVA: 0x00FCF395 File Offset: 0x00FCD595
		public int TargetId
		{
			get
			{
				return this.TargetIdInternal;
			}
		}

		// Token: 0x060413ED RID: 267245 RVA: 0x00FCF39D File Offset: 0x00FCD59D
		public DockyardInteractGridData(IPanelPos posData)
		{
			this.PosData = posData;
			this.TargetIdInternal = -1;
			this.IsFinish = false;
		}

		// Token: 0x060413EE RID: 267246 RVA: 0x00FCF3BA File Offset: 0x00FCD5BA
		public void SetTargetId(int id)
		{
			this.TargetIdInternal = id;
		}

		// Token: 0x04021F72 RID: 139122
		private int TargetIdInternal;

		// Token: 0x04021F73 RID: 139123
		public bool IsFinish;

		// Token: 0x04021F74 RID: 139124
		protected readonly IPanelPos PosData;
	}
}
