using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006410 RID: 25616
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MotorFightGridTemplateData : MultiTemplateGridDataBase<MotorFightItemData, MotorFightGridItem>
	{
		// Token: 0x060406E7 RID: 263911 RVA: 0x00F96189 File Offset: 0x00F94389
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060406E8 RID: 263912 RVA: 0x00F9618C File Offset: 0x00F9438C
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

		// Token: 0x04021808 RID: 137224
		public Func<int, bool> IsSelected = (int id) => false;

		// Token: 0x04021809 RID: 137225
		public Action<MotorFightItemData, int> OnClickCb;
	}
}
