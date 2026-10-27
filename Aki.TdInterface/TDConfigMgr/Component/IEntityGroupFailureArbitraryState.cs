using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200031B RID: 795
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityGroupFailureArbitraryState : IEntityGroupFailureCondition
	{
		// Token: 0x06000FA0 RID: 4000 RVA: 0x000372B0 File Offset: 0x000354B0
		private IEntityGroupFailureArbitraryState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityGroupFailureArbitraryState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityGroupFailureArbitraryState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityGroupFailureArbitraryState_SetValue());
			}
			return result;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000372E8 File Offset: 0x000354E8
		public static IEntityGroupFailureArbitraryState Create([Nullable(2)] IEntityGroupFailureArbitraryState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000372FB File Offset: 0x000354FB
		public static IEntityGroupFailureArbitraryState CreateFromSetValue([Nullable(2)] IEntityGroupFailureArbitraryState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0003730E File Offset: 0x0003550E
		public new IEntityGroupFailureArbitraryState_SetValue ToSetValue()
		{
			return new IEntityGroupFailureArbitraryState_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0003732D File Offset: 0x0003552D
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00037358 File Offset: 0x00035558
		public override EEntityGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00037366 File Offset: 0x00035566
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00037391 File Offset: 0x00035591
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

		// Token: 0x04000D5B RID: 3419
		[Nullable(2)]
		protected new IEntityGroupFailureArbitraryState FbInstance;

		// Token: 0x04000D5C RID: 3420
		[Nullable(2)]
		protected new IEntityGroupFailureArbitraryState_SetValue PocoInterface;
	}
}
