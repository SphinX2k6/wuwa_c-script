using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165B RID: 5723
	[NullableContext(1)]
	[Nullable(0)]
	public class EnterNpcVehicle : ActionParams
	{
		// Token: 0x06007CC9 RID: 31945 RVA: 0x0012BD08 File Offset: 0x00129F08
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

		// Token: 0x06007CCA RID: 31946 RVA: 0x0012BD40 File Offset: 0x00129F40
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

		// Token: 0x06007CCB RID: 31947 RVA: 0x0012BD53 File Offset: 0x00129F53
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

		// Token: 0x06007CCC RID: 31948 RVA: 0x0012BD66 File Offset: 0x00129F66
		public EnterNpcVehicle_SetValue ToSetValue()
		{
			return new EnterNpcVehicle_SetValue
			{
				Target = this.Target,
				Seat = this.Seat
			};
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x0012BD85 File Offset: 0x00129F85
		// (set) Token: 0x06007CCE RID: 31950 RVA: 0x0012BDB0 File Offset: 0x00129FB0
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

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06007CCF RID: 31951 RVA: 0x0012BDBE File Offset: 0x00129FBE
		// (set) Token: 0x06007CD0 RID: 31952 RVA: 0x0012BDE9 File Offset: 0x00129FE9
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

		// Token: 0x04004CAF RID: 19631
		[Nullable(2)]
		protected new EnterNpcVehicle FbInstance;

		// Token: 0x04004CB0 RID: 19632
		[Nullable(2)]
		protected EnterNpcVehicle_SetValue PocoInterface;
	}
}
