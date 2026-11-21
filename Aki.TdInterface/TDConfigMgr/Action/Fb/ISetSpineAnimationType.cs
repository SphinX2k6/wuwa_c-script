using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CEB RID: 11499
	public class ISetSpineAnimationType
	{
		// Token: 0x0600FBD9 RID: 64473 RVA: 0x002473B1 File Offset: 0x002455B1
		public static ISetSpineAnimationType Create(ISetSpineAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x0600FBDA RID: 64474 RVA: 0x002473D0 File Offset: 0x002455D0
		public virtual ESetSpineAnimation Type
		{
			get
			{
				return (ESetSpineAnimation)this.Instance.Type;
			}
		}

		// Token: 0x0400898F RID: 35215
		private ISetSpineAnimationType Instance;
	}
}
