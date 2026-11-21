using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDC RID: 28380
	public class IFollowShooterLeisureInteractT
	{
		// Token: 0x1700D024 RID: 53284
		// (get) Token: 0x060311AB RID: 201131 RVA: 0x006A860B File Offset: 0x006A680B
		// (set) Token: 0x060311AC RID: 201132 RVA: 0x006A8613 File Offset: 0x006A6813
		public int Id { get; set; }

		// Token: 0x1700D025 RID: 53285
		// (get) Token: 0x060311AD RID: 201133 RVA: 0x006A861C File Offset: 0x006A681C
		// (set) Token: 0x060311AE RID: 201134 RVA: 0x006A8624 File Offset: 0x006A6824
		public TFollowShooterLeisureTypeUnion InteractType { get; set; }

		// Token: 0x060311AF RID: 201135 RVA: 0x006A862D File Offset: 0x006A682D
		public IFollowShooterLeisureInteractT()
		{
			this.Id = 0;
			this.InteractType = null;
		}
	}
}
