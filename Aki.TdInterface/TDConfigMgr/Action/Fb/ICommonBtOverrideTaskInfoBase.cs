using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A78 RID: 10872
	public class ICommonBtOverrideTaskInfoBase
	{
		// Token: 0x0600EF04 RID: 61188 RVA: 0x0022C468 File Offset: 0x0022A668
		[NullableContext(1)]
		public static ICommonBtOverrideTaskInfoBase Create(ICommonBtOverrideTaskInfoBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtOverrideTaskInfoBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x0600EF05 RID: 61189 RVA: 0x0022C487 File Offset: 0x0022A687
		public virtual ECommonBtPlaceholderTargetType Type
		{
			get
			{
				return (ECommonBtPlaceholderTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008382 RID: 33666
		private ICommonBtOverrideTaskInfoBase Instance;
	}
}
