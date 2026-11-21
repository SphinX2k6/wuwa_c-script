using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02004737 RID: 18231
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class KurotatoLevelTitleItemTemplateData : MultiTemplateGridDataBase<KurotatoLevelTitleItemData, KurotatoLevelTitleItem>
	{
		// Token: 0x0602DC5F RID: 187487 RVA: 0x00CCEE4E File Offset: 0x00CCD04E
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0602DC60 RID: 187488 RVA: 0x00CCEE51 File Offset: 0x00CCD051
		public override KurotatoLevelTitleItem CreateProxy()
		{
			return new KurotatoLevelTitleItem();
		}
	}
}
