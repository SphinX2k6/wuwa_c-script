using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F93 RID: 16275
	public class IPhotographTargetPlayerT
	{
		// Token: 0x1700719E RID: 29086
		// (get) Token: 0x060173F4 RID: 95220 RVA: 0x0035A6E5 File Offset: 0x003588E5
		// (set) Token: 0x060173F5 RID: 95221 RVA: 0x0035A6ED File Offset: 0x003588ED
		public EPhotographTargetType Type { get; set; }

		// Token: 0x1700719F RID: 29087
		// (get) Token: 0x060173F6 RID: 95222 RVA: 0x0035A6F6 File Offset: 0x003588F6
		// (set) Token: 0x060173F7 RID: 95223 RVA: 0x0035A6FE File Offset: 0x003588FE
		public int RoleId { get; set; }

		// Token: 0x170071A0 RID: 29088
		// (get) Token: 0x060173F8 RID: 95224 RVA: 0x0035A707 File Offset: 0x00358907
		// (set) Token: 0x060173F9 RID: 95225 RVA: 0x0035A70F File Offset: 0x0035890F
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x170071A1 RID: 29089
		// (get) Token: 0x060173FA RID: 95226 RVA: 0x0035A718 File Offset: 0x00358918
		// (set) Token: 0x060173FB RID: 95227 RVA: 0x0035A720 File Offset: 0x00358920
		public IConditionGroupT CommonCondition { get; set; }

		// Token: 0x170071A2 RID: 29090
		// (get) Token: 0x060173FC RID: 95228 RVA: 0x0035A729 File Offset: 0x00358929
		// (set) Token: 0x060173FD RID: 95229 RVA: 0x0035A731 File Offset: 0x00358931
		public byte NullMask { get; set; }

		// Token: 0x060173FE RID: 95230 RVA: 0x0035A73A File Offset: 0x0035893A
		public IPhotographTargetPlayerT()
		{
			this.Type = EPhotographTargetType.Player;
			this.RoleId = 0;
			this.OnCameraCheckType = EOnCameraCheckType.All;
			this.CommonCondition = null;
			this.NullMask = 0;
		}
	}
}
