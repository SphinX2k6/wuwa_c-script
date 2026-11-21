using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CB RID: 6091
	public class EnterNpcVehicle : ActionParams
	{
		// Token: 0x060083A7 RID: 33703 RVA: 0x0013ADB4 File Offset: 0x00138FB4
		private EnterNpcVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnterNpcVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnterNpcVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnterNpcVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x0013ADEC File Offset: 0x00138FEC
		public static EnterNpcVehicle Create([Nullable(2)] EnterNpcVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterNpcVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0013ADFF File Offset: 0x00138FFF
		public static EnterNpcVehicle CreateFromSetValue([Nullable(2)] EnterNpcVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnterNpcVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x0013AE12 File Offset: 0x00139012
		public EnterNpcVehicle_SetValue ToSetValue()
		{
			return new EnterNpcVehicle_SetValue
			{
				Target = this.Target,
				Seat = this.Seat
			};
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x060083AB RID: 33707 RVA: 0x0013AE31 File Offset: 0x00139031
		// (set) Token: 0x060083AC RID: 33708 RVA: 0x0013AE5C File Offset: 0x0013905C
		public virtual int Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x060083AD RID: 33709 RVA: 0x0013AE6A File Offset: 0x0013906A
		// (set) Token: 0x060083AE RID: 33710 RVA: 0x0013AE95 File Offset: 0x00139095
		public virtual int Seat
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Seat;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Seat;
			}
			set
			{
				this.GetOrCreatePoco().Seat = value;
			}
		}

		// Token: 0x040050AA RID: 20650
		[Nullable(2)]
		protected new EnterNpcVehicle FbInstance;

		// Token: 0x040050AB RID: 20651
		[Nullable(2)]
		protected EnterNpcVehicle_SetValue PocoInterface;
	}
}
