using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200520E RID: 21006
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaTitleGridData : MultiTemplateGridDataBase<RealmBetweenAreaData, AreaTitleItem>
	{
		// Token: 0x0603449A RID: 214170 RVA: 0x00EA09CA File Offset: 0x00E9EBCA
		public AreaTitleGridData(RealmBetweenAreaData data, ActivityRealmBetweenData activity)
		{
			base.Data = data;
			this.Activity = activity;
		}

		// Token: 0x0603449B RID: 214171 RVA: 0x00EA09E0 File Offset: 0x00E9EBE0
		public override int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603449C RID: 214172 RVA: 0x00EA09E3 File Offset: 0x00E9EBE3
		public override AreaTitleItem CreateProxy()
		{
			return new AreaTitleItem(this.Activity);
		}

		// Token: 0x0401BC35 RID: 113717
		private readonly ActivityRealmBetweenData Activity;
	}
}
