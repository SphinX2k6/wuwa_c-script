using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005524 RID: 21796
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractGridData
	{
		// Token: 0x170068DD RID: 26845
		// (get) Token: 0x060360B1 RID: 221361 RVA: 0x00F16399 File Offset: 0x00F14599
		public int TargetId
		{
			get
			{
				return this.TargetIdInternal;
			}
		}

		// Token: 0x060360B2 RID: 221362 RVA: 0x00F163A1 File Offset: 0x00F145A1
		public DockyardInteractGridData(IPanelPos posData)
		{
			this.PosData = posData;
			this.TargetIdInternal = -1;
			this.IsFinish = false;
		}

		// Token: 0x060360B3 RID: 221363 RVA: 0x00F163BE File Offset: 0x00F145BE
		public void SetTargetId(int id)
		{
			this.TargetIdInternal = id;
		}

		// Token: 0x0401C8A3 RID: 116899
		private int TargetIdInternal;

		// Token: 0x0401C8A4 RID: 116900
		public bool IsFinish;

		// Token: 0x0401C8A5 RID: 116901
		protected readonly IPanelPos PosData;
	}
}
