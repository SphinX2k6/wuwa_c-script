using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0B RID: 11019
	public class IChangeElementalBoxStateTarget
	{
		// Token: 0x0600F145 RID: 61765 RVA: 0x0022FD8E File Offset: 0x0022DF8E
		[NullableContext(1)]
		public static IChangeElementalBoxStateTarget Create(IChangeElementalBoxStateTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x0600F146 RID: 61766 RVA: 0x0022FDAD File Offset: 0x0022DFAD
		public virtual EChangeElementalBoxStateTargetType Type
		{
			get
			{
				return (EChangeElementalBoxStateTargetType)this.Instance.Type;
			}
		}

		// Token: 0x040084B1 RID: 33969
		private IChangeElementalBoxStateTarget Instance;
	}
}
