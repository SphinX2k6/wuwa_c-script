using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000707 RID: 1799
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateAlert
	{
		// Token: 0x060026B3 RID: 9907 RVA: 0x00067608 File Offset: 0x00065808
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

		// Token: 0x060026B4 RID: 9908 RVA: 0x00067640 File Offset: 0x00065840
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

		// Token: 0x060026B5 RID: 9909 RVA: 0x00067653 File Offset: 0x00065853
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

		// Token: 0x060026B6 RID: 9910 RVA: 0x00067666 File Offset: 0x00065866
		public IStateAlert_SetValue ToSetValue()
		{
			return new IStateAlert_SetValue
			{
				State = this.State,
				Alert = this.Alert
			};
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x00067685 File Offset: 0x00065885
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x000676B0 File Offset: 0x000658B0
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

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000676BE File Offset: 0x000658BE
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x000676E9 File Offset: 0x000658E9
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

		// Token: 0x04001A33 RID: 6707
		[Nullable(2)]
		protected IStateAlert FbInstance;

		// Token: 0x04001A34 RID: 6708
		[Nullable(2)]
		protected IStateAlert_SetValue PocoInterface;
	}
}
