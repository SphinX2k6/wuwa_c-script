using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001898 RID: 6296
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtTarget
	{
		// Token: 0x06008733 RID: 34611 RVA: 0x00140B10 File Offset: 0x0013ED10
		private ICheckFlowLookAtTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00140B48 File Offset: 0x0013ED48
		public static ICheckFlowLookAtTarget Create([Nullable(2)] ICheckFlowLookAtTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00140B5B File Offset: 0x0013ED5B
		public static ICheckFlowLookAtTarget CreateFromSetValue([Nullable(2)] ICheckFlowLookAtTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00140B6E File Offset: 0x0013ED6E
		public ICheckFlowLookAtTarget_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06008737 RID: 34615 RVA: 0x00140B81 File Offset: 0x0013ED81
		// (set) Token: 0x06008738 RID: 34616 RVA: 0x00140BAC File Offset: 0x0013EDAC
		public virtual ECheckFlowLookAtTargetType Type
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

		// Token: 0x04005525 RID: 21797
		[Nullable(2)]
		protected ICheckFlowLookAtTarget FbInstance;

		// Token: 0x04005526 RID: 21798
		[Nullable(2)]
		protected ICheckFlowLookAtTarget_SetValue PocoInterface;
	}
}
