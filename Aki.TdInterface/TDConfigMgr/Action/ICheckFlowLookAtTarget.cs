using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A23 RID: 6691
	public class ICheckFlowLookAtTarget
	{
		// Token: 0x06008E5B RID: 36443 RVA: 0x00150344 File Offset: 0x0014E544
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

		// Token: 0x06008E5C RID: 36444 RVA: 0x0015037C File Offset: 0x0014E57C
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

		// Token: 0x06008E5D RID: 36445 RVA: 0x0015038F File Offset: 0x0014E58F
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

		// Token: 0x06008E5E RID: 36446 RVA: 0x001503A2 File Offset: 0x0014E5A2
		public ICheckFlowLookAtTarget_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x001503B5 File Offset: 0x0014E5B5
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x001503E0 File Offset: 0x0014E5E0
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

		// Token: 0x04005972 RID: 22898
		[Nullable(2)]
		protected ICheckFlowLookAtTarget FbInstance;

		// Token: 0x04005973 RID: 22899
		[Nullable(2)]
		protected ICheckFlowLookAtTarget_SetValue PocoInterface;
	}
}
