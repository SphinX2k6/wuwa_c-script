using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E92 RID: 3730
	public class ISlidePerformType
	{
		// Token: 0x0600543C RID: 21564 RVA: 0x000CFA3B File Offset: 0x000CDC3B
		public static ISlidePerformType Create(ISlidePerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x000CFA5A File Offset: 0x000CDC5A
		public virtual ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x04003039 RID: 12345
		private ISlidePerformType Instance;
	}
}
