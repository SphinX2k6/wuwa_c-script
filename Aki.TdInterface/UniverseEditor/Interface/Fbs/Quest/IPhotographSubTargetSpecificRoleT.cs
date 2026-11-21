using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043CB RID: 17355
	public class IPhotographSubTargetSpecificRoleT
	{
		// Token: 0x1700778C RID: 30604
		// (get) Token: 0x06018A41 RID: 100929 RVA: 0x00383C11 File Offset: 0x00381E11
		// (set) Token: 0x06018A42 RID: 100930 RVA: 0x00383C19 File Offset: 0x00381E19
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x1700778D RID: 30605
		// (get) Token: 0x06018A43 RID: 100931 RVA: 0x00383C22 File Offset: 0x00381E22
		// (set) Token: 0x06018A44 RID: 100932 RVA: 0x00383C2A File Offset: 0x00381E2A
		public int RoleId { get; set; }

		// Token: 0x1700778E RID: 30606
		// (get) Token: 0x06018A45 RID: 100933 RVA: 0x00383C33 File Offset: 0x00381E33
		// (set) Token: 0x06018A46 RID: 100934 RVA: 0x00383C3B File Offset: 0x00381E3B
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x1700778F RID: 30607
		// (get) Token: 0x06018A47 RID: 100935 RVA: 0x00383C44 File Offset: 0x00381E44
		// (set) Token: 0x06018A48 RID: 100936 RVA: 0x00383C4C File Offset: 0x00381E4C
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007790 RID: 30608
		// (get) Token: 0x06018A49 RID: 100937 RVA: 0x00383C55 File Offset: 0x00381E55
		// (set) Token: 0x06018A4A RID: 100938 RVA: 0x00383C5D File Offset: 0x00381E5D
		public byte NullMask { get; set; }

		// Token: 0x06018A4B RID: 100939 RVA: 0x00383C66 File Offset: 0x00381E66
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
