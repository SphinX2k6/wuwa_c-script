using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E6 RID: 1510
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolCycleOncely : ICycleModeType
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x000594FC File Offset: 0x000576FC
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

		// Token: 0x06001FFF RID: 8191 RVA: 0x00059534 File Offset: 0x00057734
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

		// Token: 0x06002000 RID: 8192 RVA: 0x00059547 File Offset: 0x00057747
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

		// Token: 0x06002001 RID: 8193 RVA: 0x0005955A File Offset: 0x0005775A
		public new IPatrolCycleOncely_SetValue ToSetValue()
		{
			return new IPatrolCycleOncely_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0005956D File Offset: 0x0005776D
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00059598 File Offset: 0x00057798
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

		// Token: 0x0400167D RID: 5757
		[Nullable(2)]
		protected new IPatrolCycleOncely FbInstance;

		// Token: 0x0400167E RID: 5758
		[Nullable(2)]
		protected new IPatrolCycleOncely_SetValue PocoInterface;
	}
}
