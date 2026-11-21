using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200472F RID: 18223
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelItemTemplateData : MultiTemplateGridDataBase<int, KurotatoLevelItem>
	{
		// Token: 0x0602DC2E RID: 187438 RVA: 0x00CCD8BD File Offset: 0x00CCBABD
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0602DC2F RID: 187439 RVA: 0x00CCD8C0 File Offset: 0x00CCBAC0
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

		// Token: 0x0401875A RID: 100186
		public Action<int, int> OnClickCb = delegate(int _, int _)
		{
		};

		// Token: 0x0401875B RID: 100187
		public Func<int, bool> IsSelected = (int _) => false;
	}
}
