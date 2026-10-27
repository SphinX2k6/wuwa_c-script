using System;
using System.Runtime.CompilerServices;

// Token: 0x0200247A RID: 9338
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomGridRowTitleTemplateData : MultiTemplateGridDataBase<int, PhantomGridRowTitleItem>
{
	// Token: 0x06012BE4 RID: 76772 RVA: 0x0049FC36 File Offset: 0x0049DE36
	public override int GetTemplateIndex()
	{
		return 0;
	}

	// Token: 0x06012BE5 RID: 76773 RVA: 0x0049FC39 File Offset: 0x0049DE39
	public override PhantomGridRowTitleItem CreateProxy()
	{
		return new PhantomGridRowTitleItem
		{
			ClickRecommendBtnCb = delegate()
			{
				Action clickRecommendBtnCb = this.ClickRecommendBtnCb;
				if (clickRecommendBtnCb == null)
				{
					return;
				}
				clickRecommendBtnCb();
			}
		};
	}

	// Token: 0x04008D2C RID: 36140
	[Nullable(2)]
	public Action ClickRecommendBtnCb;
}
