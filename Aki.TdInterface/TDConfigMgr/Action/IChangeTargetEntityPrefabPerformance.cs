using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A03 RID: 6659
	public class IChangeTargetEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x06008DC3 RID: 36291 RVA: 0x0014F2D8 File Offset: 0x0014D4D8
		private IChangeTargetEntityPrefabPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeTargetEntityPrefabPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeTargetEntityPrefabPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeTargetEntityPrefabPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x0014F310 File Offset: 0x0014D510
		public static IChangeTargetEntityPrefabPerformance Create([Nullable(2)] IChangeTargetEntityPrefabPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTargetEntityPrefabPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x0014F323 File Offset: 0x0014D523
		public static IChangeTargetEntityPrefabPerformance CreateFromSetValue([Nullable(2)] IChangeTargetEntityPrefabPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeTargetEntityPrefabPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x0014F336 File Offset: 0x0014D536
		public new IChangeTargetEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new IChangeTargetEntityPrefabPerformance_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x06008DC7 RID: 36295 RVA: 0x0014F361 File Offset: 0x0014D561
		// (set) Token: 0x06008DC8 RID: 36296 RVA: 0x0014F38C File Offset: 0x0014D58C
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

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x0014F39A File Offset: 0x0014D59A
		// (set) Token: 0x06008DCA RID: 36298 RVA: 0x0014F3C5 File Offset: 0x0014D5C5
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x06008DCB RID: 36299 RVA: 0x0014F3D3 File Offset: 0x0014D5D3
		// (set) Token: 0x06008DCC RID: 36300 RVA: 0x0014F3FE File Offset: 0x0014D5FE
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

		// Token: 0x0400592C RID: 22828
		[Nullable(2)]
		protected new IChangeTargetEntityPrefabPerformance FbInstance;

		// Token: 0x0400592D RID: 22829
		[Nullable(2)]
		protected new IChangeTargetEntityPrefabPerformance_SetValue PocoInterface;
	}
}
