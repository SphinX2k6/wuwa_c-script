using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020019AF RID: 6575
[NullableContext(1)]
[Nullable(0)]
public class CommonTabComponentData<[Nullable(0)] TTabItem> where TTabItem : CommonTabItemBase
{
	// Token: 0x0600BFCD RID: 49101 RVA: 0x002B470A File Offset: 0x002B290A
	public CommonTabComponentData([Nullable(new byte[]
	{
		1,
		2,
		1
	})] Func<UUIItem, int?, TTabItem> proxyCreate, Action<int> toggleCallBack, [Nullable(new byte[]
	{
		1,
		2
	})] Func<int, CommonTabData> getCommonData)
	{
		this.ProxyCreate = proxyCreate;
		this.ToggleCallBack = toggleCallBack;
		this.GetCommonData = getCommonData;
	}

	// Token: 0x17001013 RID: 4115
	// (get) Token: 0x0600BFCE RID: 49102 RVA: 0x002B4727 File Offset: 0x002B2927
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	public Func<UUIItem, int?, TTabItem> ProxyCreate { [return: Nullable(new byte[]
	{
		1,
		2,
		1
	})] get; }

	// Token: 0x17001014 RID: 4116
	// (get) Token: 0x0600BFCF RID: 49103 RVA: 0x002B472F File Offset: 0x002B292F
	public Action<int> ToggleCallBack { get; }

	// Token: 0x17001015 RID: 4117
	// (get) Token: 0x0600BFD0 RID: 49104 RVA: 0x002B4737 File Offset: 0x002B2937
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Func<int, CommonTabData> GetCommonData { [return: Nullable(new byte[]
	{
		1,
		2
	})] get; }
}
