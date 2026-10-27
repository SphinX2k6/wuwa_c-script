using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001878 RID: 6264
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeTargetEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x0600869B RID: 34459 RVA: 0x0013FAA4 File Offset: 0x0013DCA4
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

		// Token: 0x0600869C RID: 34460 RVA: 0x0013FADC File Offset: 0x0013DCDC
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

		// Token: 0x0600869D RID: 34461 RVA: 0x0013FAEF File Offset: 0x0013DCEF
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

		// Token: 0x0600869E RID: 34462 RVA: 0x0013FB02 File Offset: 0x0013DD02
		public new IChangeTargetEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new IChangeTargetEntityPrefabPerformance_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600869F RID: 34463 RVA: 0x0013FB2D File Offset: 0x0013DD2D
		// (set) Token: 0x060086A0 RID: 34464 RVA: 0x0013FB58 File Offset: 0x0013DD58
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

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x060086A1 RID: 34465 RVA: 0x0013FB66 File Offset: 0x0013DD66
		// (set) Token: 0x060086A2 RID: 34466 RVA: 0x0013FB91 File Offset: 0x0013DD91
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

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x060086A3 RID: 34467 RVA: 0x0013FB9F File Offset: 0x0013DD9F
		// (set) Token: 0x060086A4 RID: 34468 RVA: 0x0013FBCA File Offset: 0x0013DDCA
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

		// Token: 0x040054DF RID: 21727
		[Nullable(2)]
		protected new IChangeTargetEntityPrefabPerformance FbInstance;

		// Token: 0x040054E0 RID: 21728
		[Nullable(2)]
		protected new IChangeTargetEntityPrefabPerformance_SetValue PocoInterface;
	}
}
