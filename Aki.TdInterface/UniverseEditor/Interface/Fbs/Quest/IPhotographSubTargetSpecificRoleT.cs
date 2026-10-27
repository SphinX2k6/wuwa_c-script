using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F8A RID: 16266
	public class IPhotographSubTargetSpecificRoleT
	{
		// Token: 0x1700718E RID: 29070
		// (get) Token: 0x060173B2 RID: 95154 RVA: 0x00359FF9 File Offset: 0x003581F9
		// (set) Token: 0x060173B3 RID: 95155 RVA: 0x0035A001 File Offset: 0x00358201
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x1700718F RID: 29071
		// (get) Token: 0x060173B4 RID: 95156 RVA: 0x0035A00A File Offset: 0x0035820A
		// (set) Token: 0x060173B5 RID: 95157 RVA: 0x0035A012 File Offset: 0x00358212
		public int RoleId { get; set; }

		// Token: 0x17007190 RID: 29072
		// (get) Token: 0x060173B6 RID: 95158 RVA: 0x0035A01B File Offset: 0x0035821B
		// (set) Token: 0x060173B7 RID: 95159 RVA: 0x0035A023 File Offset: 0x00358223
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x17007191 RID: 29073
		// (get) Token: 0x060173B8 RID: 95160 RVA: 0x0035A02C File Offset: 0x0035822C
		// (set) Token: 0x060173B9 RID: 95161 RVA: 0x0035A034 File Offset: 0x00358234
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007192 RID: 29074
		// (get) Token: 0x060173BA RID: 95162 RVA: 0x0035A03D File Offset: 0x0035823D
		// (set) Token: 0x060173BB RID: 95163 RVA: 0x0035A045 File Offset: 0x00358245
		public byte NullMask { get; set; }

		// Token: 0x060173BC RID: 95164 RVA: 0x0035A04E File Offset: 0x0035824E
		public IPhotographSubTargetSpecificRoleT()
		{
			this.Type = EPhotographSubTargetType.SpecificRole;
			this.RoleId = 0;
			this.OnCameraCheckType = EOnCameraCheckType.All;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
