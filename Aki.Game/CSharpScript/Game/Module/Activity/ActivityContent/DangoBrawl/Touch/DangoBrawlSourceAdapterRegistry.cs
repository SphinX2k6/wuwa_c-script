using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch
{
	// Token: 0x020057A3 RID: 22435
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSourceAdapterRegistry
	{
		// Token: 0x06037631 RID: 226865 RVA: 0x00F79A1C File Offset: 0x00F77C1C
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

		// Token: 0x06037632 RID: 226866 RVA: 0x00F79A88 File Offset: 0x00F77C88
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

		// Token: 0x0401D3D3 RID: 119763
		private readonly Dictionary<EDragSourceKind, IDragSourceAdapter> Adapters = new Dictionary<EDragSourceKind, IDragSourceAdapter>();
	}
}
