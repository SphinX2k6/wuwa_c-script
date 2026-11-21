using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007092 RID: 28818
	public class ILeisureInteractT
	{
		// Token: 0x1700D31F RID: 54047
		// (get) Token: 0x06032021 RID: 204833 RVA: 0x006C5275 File Offset: 0x006C3475
		// (set) Token: 0x06032022 RID: 204834 RVA: 0x006C527D File Offset: 0x006C347D
		public TLeisureInteractOptionUnion Option { get; set; }

		// Token: 0x1700D320 RID: 54048
		// (get) Token: 0x06032023 RID: 204835 RVA: 0x006C5286 File Offset: 0x006C3486
		// (set) Token: 0x06032024 RID: 204836 RVA: 0x006C528E File Offset: 0x006C348E
		public int SceneEntity { get; set; }

		// Token: 0x1700D321 RID: 54049
		// (get) Token: 0x06032025 RID: 204837 RVA: 0x006C5297 File Offset: 0x006C3497
		// (set) Token: 0x06032026 RID: 204838 RVA: 0x006C529F File Offset: 0x006C349F
		public byte NullMask { get; set; }

		// Token: 0x06032027 RID: 204839 RVA: 0x006C52A8 File Offset: 0x006C34A8
		public ILeisureInteractT()
		{
			this.Option = null;
			this.SceneEntity = 0;
			this.NullMask = 0;
		}
	}
}
