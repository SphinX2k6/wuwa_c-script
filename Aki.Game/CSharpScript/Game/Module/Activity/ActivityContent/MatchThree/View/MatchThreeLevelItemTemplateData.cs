using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005417 RID: 21527
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MatchThreeLevelItemTemplateData : MultiTemplateGridDataBase<MatchThreeChapterSelectData, MatchThreeLevelItem>
	{
		// Token: 0x0603579F RID: 219039 RVA: 0x00EEF2CA File Offset: 0x00EED4CA
		public override int GetTemplateIndex()
		{
			return (base.Data.IsEndless > false) ? 1 : 0;
		}

		// Token: 0x060357A0 RID: 219040 RVA: 0x00EEF2DA File Offset: 0x00EED4DA
		public override MatchThreeLevelItem CreateProxy()
		{
			return new MatchThreeLevelItem
			{
				OnSelected = this.OnSelected
			};
		}

		// Token: 0x0401C3A2 RID: 115618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MatchThreeChapterSelectData> OnSelected;
	}
}
