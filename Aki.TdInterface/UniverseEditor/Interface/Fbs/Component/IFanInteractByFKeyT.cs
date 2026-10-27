using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005232 RID: 21042
	public class IFanInteractByFKeyT
	{
		// Token: 0x17009A31 RID: 39473
		// (get) Token: 0x0602239F RID: 140191 RVA: 0x004BF84B File Offset: 0x004BDA4B
		// (set) Token: 0x060223A0 RID: 140192 RVA: 0x004BF853 File Offset: 0x004BDA53
		public EFanInteractType Type { get; set; }

		// Token: 0x17009A32 RID: 39474
		// (get) Token: 0x060223A1 RID: 140193 RVA: 0x004BF85C File Offset: 0x004BDA5C
		// (set) Token: 0x060223A2 RID: 140194 RVA: 0x004BF864 File Offset: 0x004BDA64
		public string TidInteractOptionText { get; set; }

		// Token: 0x060223A3 RID: 140195 RVA: 0x004BF86D File Offset: 0x004BDA6D
		public IFanInteractByFKeyT()
		{
			this.Type = EFanInteractType.Hit;
			this.TidInteractOptionText = null;
		}
	}
}
