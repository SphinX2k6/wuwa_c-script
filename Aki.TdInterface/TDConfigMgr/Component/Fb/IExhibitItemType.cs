using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED0 RID: 3792
	public class IExhibitItemType
	{
		// Token: 0x06005578 RID: 21880 RVA: 0x000D2056 File Offset: 0x000D0256
		public static IExhibitItemType Create(IExhibitItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x000D2075 File Offset: 0x000D0275
		public virtual EExhibitItemType Type
		{
			get
			{
				return (EExhibitItemType)this.Instance.Type;
			}
		}

		// Token: 0x040030DF RID: 12511
		private IExhibitItemType Instance;
	}
}
