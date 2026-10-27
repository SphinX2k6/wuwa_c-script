using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02005760 RID: 22368
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class KurotatoLevelTitleItemTemplateData : MultiTemplateGridDataBase<KurotatoLevelTitleItemData, KurotatoLevelTitleItem>
	{
		// Token: 0x06038D4F RID: 232783 RVA: 0x00D803A6 File Offset: 0x00D7E5A6
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06038D50 RID: 232784 RVA: 0x00D803A9 File Offset: 0x00D7E5A9
		public override KurotatoLevelTitleItem CreateProxy()
		{
			return new KurotatoLevelTitleItem();
		}
	}
}
