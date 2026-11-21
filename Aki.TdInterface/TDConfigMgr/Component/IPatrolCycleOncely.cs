using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000677 RID: 1655
	public class IPatrolCycleOncely : ICycleModeType
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x0005FB88 File Offset: 0x0005DD88
		private IPatrolCycleOncely_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolCycleOncely 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolCycleOncely_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolCycleOncely_SetValue());
			}
			return result;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0005FBC0 File Offset: 0x0005DDC0
		public static IPatrolCycleOncely Create([Nullable(2)] IPatrolCycleOncely instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleOncely
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0005FBD3 File Offset: 0x0005DDD3
		public static IPatrolCycleOncely CreateFromSetValue([Nullable(2)] IPatrolCycleOncely_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolCycleOncely
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0005FBE6 File Offset: 0x0005DDE6
		public new IPatrolCycleOncely_SetValue ToSetValue()
		{
			return new IPatrolCycleOncely_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0005FBF9 File Offset: 0x0005DDF9
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0005FC24 File Offset: 0x0005DE24
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

		// Token: 0x04001854 RID: 6228
		[Nullable(2)]
		protected new IPatrolCycleOncely FbInstance;

		// Token: 0x04001855 RID: 6229
		[Nullable(2)]
		protected new IPatrolCycleOncely_SetValue PocoInterface;
	}
}
