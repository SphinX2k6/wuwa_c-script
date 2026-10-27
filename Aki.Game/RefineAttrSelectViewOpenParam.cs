using System;
using System.Runtime.CompilerServices;

// Token: 0x0200172C RID: 5932
[NullableContext(2)]
[Nullable(0)]
public class RefineAttrSelectViewOpenParam : IRefineAttrSelectViewOpenParam
{
	// Token: 0x17000E2F RID: 3631
	// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x00267CDB File Offset: 0x00265EDB
	// (set) Token: 0x0600AB68 RID: 43880 RVA: 0x00267CE3 File Offset: 0x00265EE3
	public int IncId { get; set; }

	// Token: 0x17000E30 RID: 3632
	// (get) Token: 0x0600AB69 RID: 43881 RVA: 0x00267CEC File Offset: 0x00265EEC
	// (set) Token: 0x0600AB6A RID: 43882 RVA: 0x00267CF4 File Offset: 0x00265EF4
	public bool DataConfirmed { get; set; }

	// Token: 0x17000E31 RID: 3633
	// (get) Token: 0x0600AB6B RID: 43883 RVA: 0x00267CFD File Offset: 0x00265EFD
	// (set) Token: 0x0600AB6C RID: 43884 RVA: 0x00267D05 File Offset: 0x00265F05
	public IRefineAttrItemData SelectAttribute { get; set; }

	// Token: 0x17000E32 RID: 3634
	// (get) Token: 0x0600AB6D RID: 43885 RVA: 0x00267D0E File Offset: 0x00265F0E
	// (set) Token: 0x0600AB6E RID: 43886 RVA: 0x00267D16 File Offset: 0x00265F16
	public Action<IRefineAttrItemData> Callback { get; set; }

	// Token: 0x17000E33 RID: 3635
	// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x00267D1F File Offset: 0x00265F1F
	// (set) Token: 0x0600AB70 RID: 43888 RVA: 0x00267D27 File Offset: 0x00265F27
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int[]> GetSelectedPropItemIdList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
