using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001678 RID: 5752
public class ActivityDefine : IStaticVariableResetter
{
	// Token: 0x0600A295 RID: 41621 RVA: 0x0023DC45 File Offset: 0x0023BE45
	static ActivityDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDefine.CreateStaticDefaultValue), new Action(ActivityDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600A296 RID: 41622 RVA: 0x0023DC64 File Offset: 0x0023BE64
	public static void CreateStaticDefaultValue()
	{
		Dictionary<ECaptionDecorationFunc, Func<ActivityCaptionDecorationTagBase>> dictionary = new Dictionary<ECaptionDecorationFunc, Func<ActivityCaptionDecorationTagBase>>();
		dictionary.Add(ECaptionDecorationFunc.AnniversaryCelebrationTitleIcon, () => new AnniversaryCelebrationTitleIcon());
		ActivityDefine.captionDecorationFuncMap = dictionary;
		ActivityDefine.captionDecorationResourceIdMap = new Dictionary<ECaptionDecorationFunc, string>
		{
			{
				ECaptionDecorationFunc.AnniversaryCelebrationTitleIcon,
				"UiItem_AnniversaryCelebrationTitleIcon"
			}
		};
	}

	// Token: 0x0600A297 RID: 41623 RVA: 0x0023DCB7 File Offset: 0x0023BEB7
	public static void ResetStaticDefaultValue()
	{
		ActivityDefine.captionDecorationFuncMap = null;
		ActivityDefine.captionDecorationResourceIdMap = null;
	}

	// Token: 0x040049F1 RID: 18929
	public const int LOW_MEMORY_CACHE_VIEW_COUNT = 3;

	// Token: 0x040049F2 RID: 18930
	public const int NORMAL_MEMORY_CACHE_VIEW_COUNT = 10;

	// Token: 0x040049F3 RID: 18931
	[Nullable(1)]
	public static Dictionary<ECaptionDecorationFunc, Func<ActivityCaptionDecorationTagBase>> captionDecorationFuncMap;

	// Token: 0x040049F4 RID: 18932
	[Nullable(1)]
	public static Dictionary<ECaptionDecorationFunc, string> captionDecorationResourceIdMap;

	// Token: 0x040049F5 RID: 18933
	public const int ACTIVITY_BUBBLE_CACHE_KEY = 1011;
}
