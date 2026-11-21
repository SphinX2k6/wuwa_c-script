using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BE4 RID: 3044
[NullableContext(2)]
[Nullable(0)]
public class RefineAttrSelectViewOpenParam : IRefineAttrSelectViewOpenParam
{
	// Token: 0x17000E50 RID: 3664
	// (get) Token: 0x06007F49 RID: 32585 RVA: 0x002720B3 File Offset: 0x002702B3
	// (set) Token: 0x06007F4A RID: 32586 RVA: 0x002720BB File Offset: 0x002702BB
	public int IncId { get; set; }

	// Token: 0x17000E51 RID: 3665
	// (get) Token: 0x06007F4B RID: 32587 RVA: 0x002720C4 File Offset: 0x002702C4
	// (set) Token: 0x06007F4C RID: 32588 RVA: 0x002720CC File Offset: 0x002702CC
	public bool DataConfirmed { get; set; }

	// Token: 0x17000E52 RID: 3666
	// (get) Token: 0x06007F4D RID: 32589 RVA: 0x002720D5 File Offset: 0x002702D5
	// (set) Token: 0x06007F4E RID: 32590 RVA: 0x002720DD File Offset: 0x002702DD
	public IRefineAttrItemData SelectAttribute { get; set; }

	// Token: 0x17000E53 RID: 3667
	// (get) Token: 0x06007F4F RID: 32591 RVA: 0x002720E6 File Offset: 0x002702E6
	// (set) Token: 0x06007F50 RID: 32592 RVA: 0x002720EE File Offset: 0x002702EE
	public Action<IRefineAttrItemData> Callback { get; set; }

	// Token: 0x17000E54 RID: 3668
	// (get) Token: 0x06007F51 RID: 32593 RVA: 0x002720F7 File Offset: 0x002702F7
	// (set) Token: 0x06007F52 RID: 32594 RVA: 0x002720FF File Offset: 0x002702FF
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
