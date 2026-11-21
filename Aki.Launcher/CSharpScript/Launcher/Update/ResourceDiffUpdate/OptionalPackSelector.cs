using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A0 RID: 160
	[NullableContext(1)]
	[Nullable(0)]
	public class OptionalPackSelector
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x000332B8 File Offset: 0x000314B8
		public static SelectionDecision Select(IReadOnlyList<IResourceTypeModule> modules, ResourceSelectionContext context, ETier tier = ETier.None)
		{
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			List<ResPackageInfo> list2 = new List<ResPackageInfo>();
			long num = 0L;
			long num2 = 0L;
			foreach (IResourceTypeModule resourceTypeModule in modules)
			{
				PackClassification packClassification = resourceTypeModule.ClassifyPacks(context, tier, false);
				list.AddRange(packClassification.MinPacks);
				list2.AddRange(packClassification.MaxPacks);
				num += packClassification.MinSize;
				num2 += packClassification.MaxSize;
			}
			return new SelectionDecision
			{
				MinSize = num,
				MaxSize = num2,
				MinPacks = list,
				MaxPacks = list2
			};
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00033368 File Offset: 0x00031568
		public static SelectionDecision SelectMax(IReadOnlyList<IResourceTypeModule> modules, ResourceSelectionContext context, ETier tier = ETier.None)
		{
			List<ResPackageInfo> list = new List<ResPackageInfo>();
			long num = 0L;
			foreach (IResourceTypeModule resourceTypeModule in modules)
			{
				PackClassification packClassification = resourceTypeModule.ClassifyPacks(context, tier, true);
				list.AddRange(packClassification.MaxPacks);
				num += packClassification.MaxSize;
			}
			return new SelectionDecision
			{
				MinSize = num,
				MaxSize = num,
				MinPacks = list,
				MaxPacks = list
			};
		}
	}
}
