using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02006939 RID: 26937
	public class ActivityGameplayEntityDefine
	{
		// Token: 0x06043248 RID: 275016 RVA: 0x0105DF64 File Offset: 0x0105C164
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

		// Token: 0x04022F59 RID: 143193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[StaticVariableRuleIgnore]
		private static Dictionary<EActivityEntityKind, IActivityEntityComposition> composeMap;
	}
}
