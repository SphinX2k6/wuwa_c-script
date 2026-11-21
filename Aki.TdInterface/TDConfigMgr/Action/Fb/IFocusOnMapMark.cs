using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C48 RID: 11336
	public class IFocusOnMapMark
	{
		// Token: 0x0600F956 RID: 63830 RVA: 0x0024390C File Offset: 0x00241B0C
		public static IFocusOnMapMark Create(IFocusOnMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D74 RID: 19828
		// (get) Token: 0x0600F957 RID: 63831 RVA: 0x0024392B File Offset: 0x00241B2B
		public virtual EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x0400884C RID: 34892
		private IFocusOnMapMark Instance;
	}
}
