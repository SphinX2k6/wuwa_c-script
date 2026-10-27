using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029BA RID: 10682
	public class EnterNpcVehicle : ActionParams
	{
		// Token: 0x0600EC3E RID: 60478 RVA: 0x00228256 File Offset: 0x00226456
		[NullableContext(1)]
		public static EnterNpcVehicle Create(IEnterNpcVehicle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterNpcVehicle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x0600EC3F RID: 60479 RVA: 0x00228275 File Offset: 0x00226475
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x0600EC40 RID: 60480 RVA: 0x00228282 File Offset: 0x00226482
		public virtual int Seat
		{
			get
			{
				return this.Instance.Seat;
			}
		}

		// Token: 0x04008212 RID: 33298
		private IEnterNpcVehicle Instance;
	}
}
