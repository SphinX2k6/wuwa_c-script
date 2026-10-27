using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006290 RID: 25232
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaTitleGridData : MultiTemplateGridDataBase<RealmBetweenAreaData, AreaTitleItem>
	{
		// Token: 0x0603F7D9 RID: 260057 RVA: 0x00F59A6E File Offset: 0x00F57C6E
		public AreaTitleGridData(RealmBetweenAreaData data, ActivityRealmBetweenData activity)
		{
			base.Data = data;
			this.Activity = activity;
		}

		// Token: 0x0603F7DA RID: 260058 RVA: 0x00F59A84 File Offset: 0x00F57C84
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603F7DB RID: 260059 RVA: 0x00F59A87 File Offset: 0x00F57C87
		public override AreaTitleItem CreateProxy()
		{
			return new AreaTitleItem(this.Activity);
		}

		// Token: 0x04021306 RID: 135942
		private readonly ActivityRealmBetweenData Activity;
	}
}
