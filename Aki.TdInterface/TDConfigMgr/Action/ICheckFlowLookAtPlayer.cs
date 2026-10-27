using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001896 RID: 6294
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtPlayer : ICheckFlowLookAtTarget
	{
		// Token: 0x0600872B RID: 34603 RVA: 0x00140A54 File Offset: 0x0013EC54
		private ICheckFlowLookAtPlayer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtPlayer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtPlayer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtPlayer_SetValue());
			}
			return result;
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x00140A8C File Offset: 0x0013EC8C
		public static ICheckFlowLookAtPlayer Create([Nullable(2)] ICheckFlowLookAtPlayer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x00140A9F File Offset: 0x0013EC9F
		public static ICheckFlowLookAtPlayer CreateFromSetValue([Nullable(2)] ICheckFlowLookAtPlayer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00140AB2 File Offset: 0x0013ECB2
		public new ICheckFlowLookAtPlayer_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtPlayer_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600872F RID: 34607 RVA: 0x00140AC5 File Offset: 0x0013ECC5
		// (set) Token: 0x06008730 RID: 34608 RVA: 0x00140AF0 File Offset: 0x0013ECF0
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

		// Token: 0x04005522 RID: 21794
		[Nullable(2)]
		protected new ICheckFlowLookAtPlayer FbInstance;

		// Token: 0x04005523 RID: 21795
		[Nullable(2)]
		protected new ICheckFlowLookAtPlayer_SetValue PocoInterface;
	}
}
