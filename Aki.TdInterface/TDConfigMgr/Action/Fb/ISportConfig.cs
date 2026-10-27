using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028ED RID: 10477
	public class ISportConfig
	{
		// Token: 0x0600E8C2 RID: 59586 RVA: 0x00222795 File Offset: 0x00220995
		[NullableContext(1)]
		public static ISportConfig Create(ISportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x0600E8C3 RID: 59587 RVA: 0x002227B4 File Offset: 0x002209B4
		public virtual ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x0400807F RID: 32895
		private ISportConfig Instance;
	}
}
