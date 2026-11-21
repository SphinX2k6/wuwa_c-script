using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289D RID: 10397
	public class IBasePos2
	{
		// Token: 0x0600E7AF RID: 59311 RVA: 0x002244F3 File Offset: 0x002226F3
		public static IBasePos2 Create(IBasePos2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBasePos2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x00224512 File Offset: 0x00222712
		public virtual EPos2 Type
		{
			get
			{
				return (EPos2)this.Instance.Type;
			}
		}

		// Token: 0x04007F9B RID: 32667
		private IBasePos2 Instance;
	}
}
