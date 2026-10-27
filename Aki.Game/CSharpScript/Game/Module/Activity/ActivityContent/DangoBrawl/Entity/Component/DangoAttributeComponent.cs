using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x02006894 RID: 26772
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAttributeComponent : ActivityAttributeComponent
	{
		// Token: 0x170097B8 RID: 38840
		// (get) Token: 0x06042D14 RID: 273684 RVA: 0x01043A8F File Offset: 0x01041C8F
		public new static List<Type> Dependencies
		{
			get
			{
				return new List<Type>
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}
	}
}
