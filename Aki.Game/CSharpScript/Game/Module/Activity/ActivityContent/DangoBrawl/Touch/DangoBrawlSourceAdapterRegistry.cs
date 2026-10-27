using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x02006853 RID: 26707
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSourceAdapterRegistry
	{
		// Token: 0x06042ADC RID: 273116 RVA: 0x010384D0 File Offset: 0x010366D0
		public DangoBrawlSourceAdapterRegistry(ActivityDangoBrawlData data, DragContext context, DangoBrawlPlatformState platformState)
		{
			foreach (IDragSourceAdapter dragSourceAdapter in new IDragSourceAdapter[]
			{
				new BagSourceAdapter(data, context, platformState),
				new BenchSourceAdapter(data, context, platformState),
				new ShopSourceAdapter(data, context, platformState)
			})
			{
				this.Adapters[dragSourceAdapter.Kind] = dragSourceAdapter;
			}
		}

		// Token: 0x06042ADD RID: 273117 RVA: 0x0103853C File Offset: 0x0103673C
		[NullableContext(2)]
		public IDragSourceAdapter Get(EDragSourceKind kind)
		{
			IDragSourceAdapter result;
			if (!this.Adapters.TryGetValue(kind, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x04022B76 RID: 142198
		private readonly Dictionary<EDragSourceKind, IDragSourceAdapter> Adapters = new Dictionary<EDragSourceKind, IDragSourceAdapter>();
	}
}
