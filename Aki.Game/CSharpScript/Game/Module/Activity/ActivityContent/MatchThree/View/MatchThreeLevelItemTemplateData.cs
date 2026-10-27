using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02006499 RID: 25753
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class MatchThreeLevelItemTemplateData : MultiTemplateGridDataBase<MatchThreeChapterSelectData, MatchThreeLevelItem>
	{
		// Token: 0x06040ADB RID: 264923 RVA: 0x00FA8282 File Offset: 0x00FA6482
		public override int GetTemplateIndex()
		{
			return (base.Data.IsEndless > false) ? 1 : 0;
		}

		// Token: 0x06040ADC RID: 264924 RVA: 0x00FA8292 File Offset: 0x00FA6492
		public override MatchThreeLevelItem CreateProxy()
		{
			return new MatchThreeLevelItem
			{
				OnSelected = this.OnSelected
			};
		}

		// Token: 0x04021A71 RID: 137841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MatchThreeChapterSelectData> OnSelected;
	}
}
