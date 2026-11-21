using System;
using System.Runtime.CompilerServices;

// Token: 0x020006E5 RID: 1765
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRoundBuffData : IDangoMonopolyRoundBuffData
{
	// Token: 0x17000AC8 RID: 2760
	// (get) Token: 0x0600517E RID: 20862 RVA: 0x001B3A64 File Offset: 0x001B1C64
	// (set) Token: 0x0600517F RID: 20863 RVA: 0x001B3A6C File Offset: 0x001B1C6C
	public int DangoId { get; set; }

	// Token: 0x17000AC9 RID: 2761
	// (get) Token: 0x06005180 RID: 20864 RVA: 0x001B3A75 File Offset: 0x001B1C75
	// (set) Token: 0x06005181 RID: 20865 RVA: 0x001B3A7D File Offset: 0x001B1C7D
	public int PropertyId { get; set; }

	// Token: 0x17000ACA RID: 2762
	// (get) Token: 0x06005182 RID: 20866 RVA: 0x001B3A86 File Offset: 0x001B1C86
	// (set) Token: 0x06005183 RID: 20867 RVA: 0x001B3A8E File Offset: 0x001B1C8E
	public int GridId { get; set; }

	// Token: 0x17000ACB RID: 2763
	// (get) Token: 0x06005184 RID: 20868 RVA: 0x001B3A97 File Offset: 0x001B1C97
	// (set) Token: 0x06005185 RID: 20869 RVA: 0x001B3A9F File Offset: 0x001B1C9F
	public bool IsActive { get; set; }

	// Token: 0x17000ACC RID: 2764
	// (get) Token: 0x06005186 RID: 20870 RVA: 0x001B3AA8 File Offset: 0x001B1CA8
	// (set) Token: 0x06005187 RID: 20871 RVA: 0x001B3AB0 File Offset: 0x001B1CB0
	public string DangoIcon { get; set; } = "";

	// Token: 0x17000ACD RID: 2765
	// (get) Token: 0x06005188 RID: 20872 RVA: 0x001B3AB9 File Offset: 0x001B1CB9
	// (set) Token: 0x06005189 RID: 20873 RVA: 0x001B3AC1 File Offset: 0x001B1CC1
	public string DangoName { get; set; } = "";

	// Token: 0x17000ACE RID: 2766
	// (get) Token: 0x0600518A RID: 20874 RVA: 0x001B3ACA File Offset: 0x001B1CCA
	// (set) Token: 0x0600518B RID: 20875 RVA: 0x001B3AD2 File Offset: 0x001B1CD2
	public string PropertyDesc { get; set; } = "";

	// Token: 0x17000ACF RID: 2767
	// (get) Token: 0x0600518C RID: 20876 RVA: 0x001B3ADB File Offset: 0x001B1CDB
	// (set) Token: 0x0600518D RID: 20877 RVA: 0x001B3AE3 File Offset: 0x001B1CE3
	public string PropertyTitle { get; set; } = "";
}
