using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EE5 RID: 7909
[NullableContext(1)]
[Nullable(0)]
public class SdkPayProductInformationViewData
{
	// Token: 0x06013887 RID: 80007 RVA: 0x005B19A1 File Offset: 0x005AFBA1
	[NullableContext(2)]
	[return: Nullable(1)]
	public static SdkPayProductInformationViewData Create(string productName, string contentName, string productId, [Nullable(1)] Action<string> onClickConfirmBtn)
	{
		return new SdkPayProductInformationViewData
		{
			ProductName = (productName ?? ""),
			ContentName = (contentName ?? ""),
			ProductId = (productId ?? ""),
			OnClickConfirmBtn = onClickConfirmBtn
		};
	}

	// Token: 0x0400A6FD RID: 42749
	public string ProductName = "";

	// Token: 0x0400A6FE RID: 42750
	public string ContentName = "";

	// Token: 0x0400A6FF RID: 42751
	public string ProductId = "";

	// Token: 0x0400A700 RID: 42752
	public Action<string> OnClickConfirmBtn = delegate(string productId)
	{
	};
}
