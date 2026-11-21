using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x0200588A RID: 22666
	public class ActivityGameplayEntityDefine
	{
		// Token: 0x06037DA5 RID: 228773 RVA: 0x00F9F5D4 File Offset: 0x00F9D7D4
		[NullableContext(1)]
		public static Dictionary<EActivityEntityKind, IActivityEntityComposition> GetActivityEntityComposeMap()
		{
			if (ActivityGameplayEntityDefine.composeMap == null)
			{
				Dictionary<EActivityEntityKind, IActivityEntityComposition> dictionary = new Dictionary<EActivityEntityKind, IActivityEntityComposition>();
				dictionary[EActivityEntityKind.DangoBrawlDango] = new ActivityEntityComposition
				{
					Components = new List<Type>
					{
						typeof(DangoBrawlDataComponent),
						typeof(DangoAttributeComponent),
						typeof(DangoBrawlActorComponent),
						typeof(DangoBrawlMontageComponent)
					}
				};
				ActivityGameplayEntityDefine.composeMap = dictionary;
			}
			return ActivityGameplayEntityDefine.composeMap;
		}

		// Token: 0x0401D7B6 RID: 120758
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[StaticVariableRuleIgnore]
		private static Dictionary<EActivityEntityKind, IActivityEntityComposition> composeMap;
	}
}
