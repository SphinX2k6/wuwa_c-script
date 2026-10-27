using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0B RID: 3083
	public class IGuideLineCreatorScanOption
	{
		// Token: 0x060046C6 RID: 18118 RVA: 0x000B2921 File Offset: 0x000B0B21
		[NullableContext(1)]
		public static IGuideLineCreatorScanOption Create(IGuideLineCreatorScanOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGuideLineCreatorScanOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x000B2940 File Offset: 0x000B0B40
		public virtual int ResponseRange
		{
			get
			{
				return this.Instance.ResponseRange;
			}
		}

		// Token: 0x0400283A RID: 10298
		private IGuideLineCreatorScanOption Instance;
	}
}
