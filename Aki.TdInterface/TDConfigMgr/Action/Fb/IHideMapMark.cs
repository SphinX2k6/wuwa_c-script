using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C46 RID: 11334
	public class IHideMapMark : ToggleMapMarkState
	{
		// Token: 0x0600F94E RID: 63822 RVA: 0x0024388A File Offset: 0x00241A8A
		public static IHideMapMark Create(IHideMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D70 RID: 19824
		// (get) Token: 0x0600F94F RID: 63823 RVA: 0x002438A9 File Offset: 0x00241AA9
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x17004D71 RID: 19825
		// (get) Token: 0x0600F950 RID: 63824 RVA: 0x002438B6 File Offset: 0x00241AB6
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x0400884A RID: 34890
		private IHideMapMark Instance;
	}
}
