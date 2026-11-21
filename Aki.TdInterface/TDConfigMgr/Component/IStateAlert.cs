using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007A8 RID: 1960
	public class IStateAlert
	{
		// Token: 0x060029D3 RID: 10707 RVA: 0x0006E678 File Offset: 0x0006C878
		private IStateAlert_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateAlert 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateAlert_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateAlert_SetValue());
			}
			return result;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x0006E6B0 File Offset: 0x0006C8B0
		public static IStateAlert Create([Nullable(2)] IStateAlert instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateAlert
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0006E6C3 File Offset: 0x0006C8C3
		public static IStateAlert CreateFromSetValue([Nullable(2)] IStateAlert_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateAlert
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0006E6D6 File Offset: 0x0006C8D6
		public IStateAlert_SetValue ToSetValue()
		{
			return new IStateAlert_SetValue
			{
				State = this.State,
				Alert = this.Alert
			};
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0006E6F5 File Offset: 0x0006C8F5
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x0006E720 File Offset: 0x0006C920
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0006E72E File Offset: 0x0006C92E
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x0006E759 File Offset: 0x0006C959
		public virtual int Alert
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Alert;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Alert;
			}
			set
			{
				this.GetOrCreatePoco().Alert = value;
			}
		}

		// Token: 0x04001C32 RID: 7218
		[Nullable(2)]
		protected IStateAlert FbInstance;

		// Token: 0x04001C33 RID: 7219
		[Nullable(2)]
		protected IStateAlert_SetValue PocoInterface;
	}
}
