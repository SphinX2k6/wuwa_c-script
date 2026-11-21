using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E6D RID: 3693
[NullableContext(1)]
[Nullable(0)]
public class CommonTabComponentData<[Nullable(0)] TTabItem> where TTabItem : CommonTabItemBase
{
	// Token: 0x060093D7 RID: 37847 RVA: 0x002BF69A File Offset: 0x002BD89A
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

	// Token: 0x17001038 RID: 4152
	// (get) Token: 0x060093D8 RID: 37848 RVA: 0x002BF6B7 File Offset: 0x002BD8B7
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

	// Token: 0x17001039 RID: 4153
	// (get) Token: 0x060093D9 RID: 37849 RVA: 0x002BF6BF File Offset: 0x002BD8BF
	public Action<int> ToggleCallBack { get; }

	// Token: 0x1700103A RID: 4154
	// (get) Token: 0x060093DA RID: 37850 RVA: 0x002BF6C7 File Offset: 0x002BD8C7
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
