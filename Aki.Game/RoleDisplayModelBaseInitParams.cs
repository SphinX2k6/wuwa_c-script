using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D4E RID: 7502
[NullableContext(1)]
[Nullable(0)]
public class RoleDisplayModelBaseInitParams
{
	// Token: 0x17001BA7 RID: 7079
	// (get) Token: 0x0601292F RID: 76079 RVA: 0x0057BB75 File Offset: 0x00579D75
	// (set) Token: 0x06012930 RID: 76080 RVA: 0x0057BB7D File Offset: 0x00579D7D
	public int Id { get; set; }

	// Token: 0x17001BA8 RID: 7080
	// (get) Token: 0x06012931 RID: 76081 RVA: 0x0057BB86 File Offset: 0x00579D86
	// (set) Token: 0x06012932 RID: 76082 RVA: 0x0057BB8E File Offset: 0x00579D8E
	public string Name { get; set; }

	// Token: 0x17001BA9 RID: 7081
	// (get) Token: 0x06012933 RID: 76083 RVA: 0x0057BB97 File Offset: 0x00579D97
	// (set) Token: 0x06012934 RID: 76084 RVA: 0x0057BB9F File Offset: 0x00579D9F
	public int SkinId { get; set; }

	// Token: 0x17001BAA RID: 7082
	// (get) Token: 0x06012935 RID: 76085 RVA: 0x0057BBA8 File Offset: 0x00579DA8
	// (set) Token: 0x06012936 RID: 76086 RVA: 0x0057BBB0 File Offset: 0x00579DB0
	public int ElementId { get; set; }

	// Token: 0x17001BAB RID: 7083
	// (get) Token: 0x06012937 RID: 76087 RVA: 0x0057BBB9 File Offset: 0x00579DB9
	// (set) Token: 0x06012938 RID: 76088 RVA: 0x0057BBC1 File Offset: 0x00579DC1
	public int Level { get; set; }

	// Token: 0x17001BAC RID: 7084
	// (get) Token: 0x06012939 RID: 76089 RVA: 0x0057BBCA File Offset: 0x00579DCA
	// (set) Token: 0x0601293A RID: 76090 RVA: 0x0057BBD2 File Offset: 0x00579DD2
	public bool IsInTeam { get; set; }

	// Token: 0x17001BAD RID: 7085
	// (get) Token: 0x0601293B RID: 76091 RVA: 0x0057BBDB File Offset: 0x00579DDB
	// (set) Token: 0x0601293C RID: 76092 RVA: 0x0057BBE3 File Offset: 0x00579DE3
	public bool IsTrial { get; set; }

	// Token: 0x17001BAE RID: 7086
	// (get) Token: 0x0601293D RID: 76093 RVA: 0x0057BBEC File Offset: 0x00579DEC
	// (set) Token: 0x0601293E RID: 76094 RVA: 0x0057BBF4 File Offset: 0x00579DF4
	public bool IsNew { get; set; }

	// Token: 0x17001BAF RID: 7087
	// (get) Token: 0x0601293F RID: 76095 RVA: 0x0057BBFD File Offset: 0x00579DFD
	// (set) Token: 0x06012940 RID: 76096 RVA: 0x0057BC05 File Offset: 0x00579E05
	public ERoleTypeTag TypeTag { get; set; }
}
