using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CA7 RID: 11431
	public class EnterNpcVehicle : ActionParams
	{
		// Token: 0x0600FAD5 RID: 64213 RVA: 0x00245BDA File Offset: 0x00243DDA
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

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x0600FAD6 RID: 64214 RVA: 0x00245BF9 File Offset: 0x00243DF9
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x0600FAD7 RID: 64215 RVA: 0x00245C06 File Offset: 0x00243E06
		public virtual int Seat
		{
			get
			{
				return this.Instance.Seat;
			}
		}

		// Token: 0x04008903 RID: 35075
		private IEnterNpcVehicle Instance;
	}
}
