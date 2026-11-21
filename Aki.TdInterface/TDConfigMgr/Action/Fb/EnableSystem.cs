using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA4 RID: 10916
	public class EnableSystem : ActionParams
	{
		// Token: 0x0600F0BA RID: 61626 RVA: 0x0023422E File Offset: 0x0023242E
		public static EnableSystem Create(IEnableSystem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableSystem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x0600F0BB RID: 61627 RVA: 0x0023424D File Offset: 0x0023244D
		public virtual ESystem SystemType
		{
			get
			{
				return (ESystem)this.Instance.SystemType;
			}
		}

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x0600F0BC RID: 61628 RVA: 0x0023425A File Offset: 0x0023245A
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x0400845A RID: 33882
		private IEnableSystem Instance;
	}
}
