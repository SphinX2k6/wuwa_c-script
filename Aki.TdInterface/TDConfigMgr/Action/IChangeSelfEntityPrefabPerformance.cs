using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001876 RID: 6262
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeSelfEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x06008691 RID: 34449 RVA: 0x0013F9A4 File Offset: 0x0013DBA4
		private IChangeSelfEntityPrefabPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeSelfEntityPrefabPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeSelfEntityPrefabPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeSelfEntityPrefabPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x0013F9DC File Offset: 0x0013DBDC
		public static IChangeSelfEntityPrefabPerformance Create([Nullable(2)] IChangeSelfEntityPrefabPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeSelfEntityPrefabPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x0013F9EF File Offset: 0x0013DBEF
		public static IChangeSelfEntityPrefabPerformance CreateFromSetValue([Nullable(2)] IChangeSelfEntityPrefabPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeSelfEntityPrefabPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x0013FA02 File Offset: 0x0013DC02
		public new IChangeSelfEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new IChangeSelfEntityPrefabPerformance_SetValue
			{
				Type = this.Type,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06008695 RID: 34453 RVA: 0x0013FA21 File Offset: 0x0013DC21
		// (set) Token: 0x06008696 RID: 34454 RVA: 0x0013FA4C File Offset: 0x0013DC4C
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06008697 RID: 34455 RVA: 0x0013FA5A File Offset: 0x0013DC5A
		// (set) Token: 0x06008698 RID: 34456 RVA: 0x0013FA85 File Offset: 0x0013DC85
		public virtual string PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PerformanceTag;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceTag = value;
			}
		}

		// Token: 0x040054DB RID: 21723
		[Nullable(2)]
		protected new IChangeSelfEntityPrefabPerformance FbInstance;

		// Token: 0x040054DC RID: 21724
		[Nullable(2)]
		protected new IChangeSelfEntityPrefabPerformance_SetValue PocoInterface;
	}
}
