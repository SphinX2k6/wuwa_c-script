using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D49 RID: 11593
	public class INpcGroupPerformInitiatorType
	{
		// Token: 0x0600FD22 RID: 64802 RVA: 0x00249107 File Offset: 0x00247307
		public static INpcGroupPerformInitiatorType Create(INpcGroupPerformInitiatorType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x0600FD23 RID: 64803 RVA: 0x00249126 File Offset: 0x00247326
		public virtual ENpcGroupPerformInitiatorType Type
		{
			get
			{
				return (ENpcGroupPerformInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008A2F RID: 35375
		private INpcGroupPerformInitiatorType Instance;
	}
}
