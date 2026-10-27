using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A71 RID: 6769
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedTime
	{
		// Token: 0x060090F4 RID: 37108 RVA: 0x00151AF8 File Offset: 0x0014FCF8
		private IFixedTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedTime_SetValue());
			}
			return result;
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x00151B30 File Offset: 0x0014FD30
		public static IFixedTime Create([Nullable(2)] IFixedTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00151B43 File Offset: 0x0014FD43
		public static IFixedTime CreateFromSetValue([Nullable(2)] IFixedTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00151B56 File Offset: 0x0014FD56
		public IFixedTime_SetValue ToSetValue()
		{
			return new IFixedTime_SetValue
			{
				Hour = this.Hour,
				Minutes = this.Minutes
			};
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x060090F8 RID: 37112 RVA: 0x00151B75 File Offset: 0x0014FD75
		// (set) Token: 0x060090F9 RID: 37113 RVA: 0x00151BA0 File Offset: 0x0014FDA0
		public virtual int Hour
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hour;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hour;
			}
			set
			{
				this.GetOrCreatePoco().Hour = value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x00151BAE File Offset: 0x0014FDAE
		// (set) Token: 0x060090FB RID: 37115 RVA: 0x00151BD9 File Offset: 0x0014FDD9
		public virtual int Minutes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Minutes;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Minutes;
			}
			set
			{
				this.GetOrCreatePoco().Minutes = value;
			}
		}

		// Token: 0x04005977 RID: 22903
		[Nullable(2)]
		protected IFixedTime FbInstance;

		// Token: 0x04005978 RID: 22904
		[Nullable(2)]
		protected IFixedTime_SetValue PocoInterface;
	}
}
