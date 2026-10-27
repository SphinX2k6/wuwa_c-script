using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF1 RID: 27889
	public class IPlayerEntityT
	{
		// Token: 0x1700CFB8 RID: 53176
		// (get) Token: 0x060312DF RID: 201439 RVA: 0x006AC256 File Offset: 0x006AA456
		// (set) Token: 0x060312E0 RID: 201440 RVA: 0x006AC25E File Offset: 0x006AA45E
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700CFB9 RID: 53177
		// (get) Token: 0x060312E1 RID: 201441 RVA: 0x006AC267 File Offset: 0x006AA467
		// (set) Token: 0x060312E2 RID: 201442 RVA: 0x006AC26F File Offset: 0x006AA46F
		public EPlayerTargetType PlayerTargetType { get; set; }

		// Token: 0x1700CFBA RID: 53178
		// (get) Token: 0x060312E3 RID: 201443 RVA: 0x006AC278 File Offset: 0x006AA478
		// (set) Token: 0x060312E4 RID: 201444 RVA: 0x006AC280 File Offset: 0x006AA480
		public byte NullMask { get; set; }

		// Token: 0x060312E5 RID: 201445 RVA: 0x006AC289 File Offset: 0x006AA489
		public IPlayerEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.PlayerTargetType = EPlayerTargetType.CurrentRole;
			this.NullMask = 0;
		}
	}
}
