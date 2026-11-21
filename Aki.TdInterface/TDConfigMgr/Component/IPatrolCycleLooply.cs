using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000675 RID: 1653
	public class IPatrolCycleLooply : ICycleModeType
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x0005FA88 File Offset: 0x0005DC88
		private IPatrolCycleLooply_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolCycleLooply 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolCycleLooply_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolCycleLooply_SetValue());
			}
			return result;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0005FAC0 File Offset: 0x0005DCC0
		public static IPatrolCycleLooply Create([Nullable(2)] IPatrolCycleLooply instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0005FAD3 File Offset: 0x0005DCD3
		public static IPatrolCycleLooply CreateFromSetValue([Nullable(2)] IPatrolCycleLooply_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0005FAE6 File Offset: 0x0005DCE6
		public new IPatrolCycleLooply_SetValue ToSetValue()
		{
			return new IPatrolCycleLooply_SetValue
			{
				Type = this.Type,
				IsCircle = this.IsCircle
			};
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0005FB05 File Offset: 0x0005DD05
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x0005FB30 File Offset: 0x0005DD30
		public override EPatrolCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0005FB3E File Offset: 0x0005DD3E
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0005FB69 File Offset: 0x0005DD69
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x04001850 RID: 6224
		[Nullable(2)]
		protected new IPatrolCycleLooply FbInstance;

		// Token: 0x04001851 RID: 6225
		[Nullable(2)]
		protected new IPatrolCycleLooply_SetValue PocoInterface;
	}
}
