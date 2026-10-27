using System;
using System.Runtime.CompilerServices;

// Token: 0x0200296A RID: 10602
[NullableContext(1)]
[Nullable(0)]
public class SdkPayProductInformationViewData
{
	// Token: 0x06015E83 RID: 89731 RVA: 0x0058699D File Offset: 0x00584B9D
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

	// Token: 0x0400A313 RID: 41747
	public string ProductName = "";

	// Token: 0x0400A314 RID: 41748
	public string ContentName = "";

	// Token: 0x0400A315 RID: 41749
	public string ProductId = "";

	// Token: 0x0400A316 RID: 41750
	public Action<string> OnClickConfirmBtn = delegate(string productId)
	{
	};
}
