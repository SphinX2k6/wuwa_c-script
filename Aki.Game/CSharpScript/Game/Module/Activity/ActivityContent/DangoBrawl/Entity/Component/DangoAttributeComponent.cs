using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Entity.Component
{
	// Token: 0x020057E4 RID: 22500
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoAttributeComponent : ActivityAttributeComponent
	{
		// Token: 0x17006AF8 RID: 27384
		// (get) Token: 0x0603786C RID: 227436 RVA: 0x00F8500F File Offset: 0x00F8320F
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(DangoBrawlDataComponent)
				};
			}
		}
	}
}
