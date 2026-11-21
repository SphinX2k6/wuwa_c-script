using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542B RID: 21547
	public class IBatchBulletCasterComponentT
	{
		// Token: 0x170098F9 RID: 39161
		// (get) Token: 0x06021C66 RID: 138342 RVA: 0x004A8212 File Offset: 0x004A6412
		// (set) Token: 0x06021C67 RID: 138343 RVA: 0x004A821A File Offset: 0x004A641A
		public bool Disabled { get; set; }

		// Token: 0x170098FA RID: 39162
		// (get) Token: 0x06021C68 RID: 138344 RVA: 0x004A8223 File Offset: 0x004A6423
		// (set) Token: 0x06021C69 RID: 138345 RVA: 0x004A822B File Offset: 0x004A642B
		public string WarningEffect { get; set; }

		// Token: 0x170098FB RID: 39163
		// (get) Token: 0x06021C6A RID: 138346 RVA: 0x004A8234 File Offset: 0x004A6434
		// (set) Token: 0x06021C6B RID: 138347 RVA: 0x004A823C File Offset: 0x004A643C
		public EBatchBulletMovementType MovementType { get; set; }

		// Token: 0x170098FC RID: 39164
		// (get) Token: 0x06021C6C RID: 138348 RVA: 0x004A8245 File Offset: 0x004A6445
		// (set) Token: 0x06021C6D RID: 138349 RVA: 0x004A824D File Offset: 0x004A644D
		public List<IPosRotT> BulletList { get; set; }

		// Token: 0x170098FD RID: 39165
		// (get) Token: 0x06021C6E RID: 138350 RVA: 0x004A8256 File Offset: 0x004A6456
		// (set) Token: 0x06021C6F RID: 138351 RVA: 0x004A825E File Offset: 0x004A645E
		public List<IBatchBulletItemT> BatchList { get; set; }

		// Token: 0x170098FE RID: 39166
		// (get) Token: 0x06021C70 RID: 138352 RVA: 0x004A8267 File Offset: 0x004A6467
		// (set) Token: 0x06021C71 RID: 138353 RVA: 0x004A826F File Offset: 0x004A646F
		public byte NullMask { get; set; }

		// Token: 0x06021C72 RID: 138354 RVA: 0x004A8278 File Offset: 0x004A6478
		public IBatchBulletCasterComponentT()
		{
			this.Disabled = false;
			this.WarningEffect = null;
			this.MovementType = EBatchBulletMovementType.Sprint;
			this.BulletList = null;
			this.BatchList = null;
			this.NullMask = 0;
		}
	}
}
