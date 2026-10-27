using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x0200009D RID: 157
	[NullableContext(1)]
	[Nullable(0)]
	public class OptionalPackSelector
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00031D50 File Offset: 0x0002FF50
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

		// Token: 0x0600057F RID: 1407 RVA: 0x00031E00 File Offset: 0x00030000
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
