using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02005758 RID: 22360
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelItemTemplateData : MultiTemplateGridDataBase<int, KurotatoLevelItem>
	{
		// Token: 0x06038D1E RID: 232734 RVA: 0x00D7EEE5 File Offset: 0x00D7D0E5
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06038D1F RID: 232735 RVA: 0x00D7EEE8 File Offset: 0x00D7D0E8
		public override KurotatoLevelItem CreateProxy()
		{
			KurotatoLevelItem proxy = new KurotatoLevelItem();
			proxy.OnClickCb = delegate(int id)
			{
				this.OnClickCb(id, proxy.GridIndex);
			};
			proxy.IsSelected = this.IsSelected;
			return proxy;
		}

		// Token: 0x0401DCC4 RID: 122052
		public Action<int, int> OnClickCb = delegate(int _, int _)
		{
		};

		// Token: 0x0401DCC5 RID: 122053
		public Func<int, bool> IsSelected = (int _) => false;
	}
}
