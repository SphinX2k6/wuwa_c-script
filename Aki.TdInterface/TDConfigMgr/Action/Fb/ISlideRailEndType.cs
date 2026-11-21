using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D04 RID: 11524
	public class ISlideRailEndType
	{
		// Token: 0x0600FC29 RID: 64553 RVA: 0x00247A12 File Offset: 0x00245C12
		public static ISlideRailEndType Create(ISlideRailEndType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailEndType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x0600FC2A RID: 64554 RVA: 0x00247A31 File Offset: 0x00245C31
		public virtual ESlideRailEndType Type
		{
			get
			{
				return (ESlideRailEndType)this.Instance.Type;
			}
		}

		// Token: 0x040089B6 RID: 35254
		private ISlideRailEndType Instance;
	}
}
