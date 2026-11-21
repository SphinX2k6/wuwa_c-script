using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200538E RID: 21390
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MotorFightGridTemplateData : MultiTemplateGridDataBase<MotorFightItemData, MotorFightGridItem>
	{
		// Token: 0x060353A8 RID: 218024 RVA: 0x00EDD129 File Offset: 0x00EDB329
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060353A9 RID: 218025 RVA: 0x00EDD12C File Offset: 0x00EDB32C
		public override MotorFightGridItem CreateProxy()
		{
			MotorFightGridItem proxy = new MotorFightGridItem();
			proxy.OnClickCb = delegate(MotorFightItemData data)
			{
				this.OnClickCb(data, proxy.GridIndex);
			};
			proxy.IsSelected = this.IsSelected;
			return proxy;
		}

		// Token: 0x0401C137 RID: 114999
		public Func<int, bool> IsSelected = (int id) => false;

		// Token: 0x0401C138 RID: 115000
		public Action<MotorFightItemData, int> OnClickCb;
	}
}
