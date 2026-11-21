using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000B30 RID: 2864
public class ActivityDefine : IStaticVariableResetter
{
	// Token: 0x06007673 RID: 30323 RVA: 0x00247AD5 File Offset: 0x00245CD5
	static ActivityDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDefine.CreateStaticDefaultValue), new Action(ActivityDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06007674 RID: 30324 RVA: 0x00247AF4 File Offset: 0x00245CF4
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

	// Token: 0x06007675 RID: 30325 RVA: 0x00247B47 File Offset: 0x00245D47
	public static void ResetStaticDefaultValue()
	{
		ActivityDefine.captionDecorationFuncMap = null;
		ActivityDefine.captionDecorationResourceIdMap = null;
	}

	// Token: 0x04004A97 RID: 19095
	public const int LOW_MEMORY_CACHE_VIEW_COUNT = 3;

	// Token: 0x04004A98 RID: 19096
	public const int NORMAL_MEMORY_CACHE_VIEW_COUNT = 10;

	// Token: 0x04004A99 RID: 19097
	[Nullable(1)]
	public static Dictionary<ECaptionDecorationFunc, Func<ActivityCaptionDecorationTagBase>> captionDecorationFuncMap;

	// Token: 0x04004A9A RID: 19098
	[Nullable(1)]
	public static Dictionary<ECaptionDecorationFunc, string> captionDecorationResourceIdMap;

	// Token: 0x04004A9B RID: 19099
	public const int ACTIVITY_BUBBLE_CACHE_KEY = 1011;
}
