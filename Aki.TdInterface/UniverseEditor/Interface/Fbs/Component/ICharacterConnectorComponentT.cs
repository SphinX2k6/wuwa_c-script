using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AC RID: 21676
	public class ICharacterConnectorComponentT
	{
		// Token: 0x17009A8B RID: 39563
		// (get) Token: 0x06022233 RID: 139827 RVA: 0x004B499D File Offset: 0x004B2B9D
		// (set) Token: 0x06022234 RID: 139828 RVA: 0x004B49A5 File Offset: 0x004B2BA5
		public bool Disabled { get; set; }

		// Token: 0x17009A8C RID: 39564
		// (get) Token: 0x06022235 RID: 139829 RVA: 0x004B49AE File Offset: 0x004B2BAE
		// (set) Token: 0x06022236 RID: 139830 RVA: 0x004B49B6 File Offset: 0x004B2BB6
		public ICharacterConnectorRangeT LogicType { get; set; }

		// Token: 0x17009A8D RID: 39565
		// (get) Token: 0x06022237 RID: 139831 RVA: 0x004B49BF File Offset: 0x004B2BBF
		// (set) Token: 0x06022238 RID: 139832 RVA: 0x004B49C7 File Offset: 0x004B2BC7
		public byte NullMask { get; set; }

		// Token: 0x06022239 RID: 139833 RVA: 0x004B49D0 File Offset: 0x004B2BD0
		public ICharacterConnectorComponentT()
		{
			this.Disabled = false;
			this.LogicType = null;
			this.NullMask = 0;
		}
	}
}
