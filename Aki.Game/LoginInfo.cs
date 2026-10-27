using System;
using System.Runtime.CompilerServices;

// Token: 0x0200208A RID: 8330
[NullableContext(1)]
[Nullable(0)]
public class LoginInfo : ILoginInfo
{
	// Token: 0x17001442 RID: 5186
	// (get) Token: 0x0601064F RID: 67151 RVA: 0x003FF2D5 File Offset: 0x003FD4D5
	// (set) Token: 0x06010650 RID: 67152 RVA: 0x003FF2DD File Offset: 0x003FD4DD
	public int LoginCode { get; set; }

	// Token: 0x17001443 RID: 5187
	// (get) Token: 0x06010651 RID: 67153 RVA: 0x003FF2E6 File Offset: 0x003FD4E6
	// (set) Token: 0x06010652 RID: 67154 RVA: 0x003FF2EE File Offset: 0x003FD4EE
	public string Uid { get; set; }

	// Token: 0x17001444 RID: 5188
	// (get) Token: 0x06010653 RID: 67155 RVA: 0x003FF2F7 File Offset: 0x003FD4F7
	// (set) Token: 0x06010654 RID: 67156 RVA: 0x003FF2FF File Offset: 0x003FD4FF
	public string UserName { get; set; }

	// Token: 0x17001445 RID: 5189
	// (get) Token: 0x06010655 RID: 67157 RVA: 0x003FF308 File Offset: 0x003FD508
	// (set) Token: 0x06010656 RID: 67158 RVA: 0x003FF310 File Offset: 0x003FD510
	public string Token { get; set; }
}
