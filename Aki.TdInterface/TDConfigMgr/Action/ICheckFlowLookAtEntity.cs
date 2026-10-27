using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001894 RID: 6292
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtEntity : ICheckFlowLookAtTarget
	{
		// Token: 0x06008721 RID: 34593 RVA: 0x00140954 File Offset: 0x0013EB54
		private ICheckFlowLookAtEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x0014098C File Offset: 0x0013EB8C
		public static ICheckFlowLookAtEntity Create([Nullable(2)] ICheckFlowLookAtEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x0014099F File Offset: 0x0013EB9F
		public static ICheckFlowLookAtEntity CreateFromSetValue([Nullable(2)] ICheckFlowLookAtEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x001409B2 File Offset: 0x0013EBB2
		public new ICheckFlowLookAtEntity_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06008725 RID: 34597 RVA: 0x001409D1 File Offset: 0x0013EBD1
		// (set) Token: 0x06008726 RID: 34598 RVA: 0x001409FC File Offset: 0x0013EBFC
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06008727 RID: 34599 RVA: 0x00140A0A File Offset: 0x0013EC0A
		// (set) Token: 0x06008728 RID: 34600 RVA: 0x00140A35 File Offset: 0x0013EC35
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

		// Token: 0x0400551E RID: 21790
		[Nullable(2)]
		protected new ICheckFlowLookAtEntity FbInstance;

		// Token: 0x0400551F RID: 21791
		[Nullable(2)]
		protected new ICheckFlowLookAtEntity_SetValue PocoInterface;
	}
}
