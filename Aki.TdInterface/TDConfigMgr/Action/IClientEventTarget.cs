using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B0 RID: 6320
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEventTarget
	{
		// Token: 0x060087A7 RID: 34727 RVA: 0x00141714 File Offset: 0x0013F914
		private IClientEventTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEventTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEventTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEventTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x0014174C File Offset: 0x0013F94C
		public static IClientEventTarget Create([Nullable(2)] IClientEventTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x0014175F File Offset: 0x0013F95F
		public static IClientEventTarget CreateFromSetValue([Nullable(2)] IClientEventTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x00141772 File Offset: 0x0013F972
		public IClientEventTarget_SetValue ToSetValue()
		{
			return new IClientEventTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x060087AB RID: 34731 RVA: 0x00141785 File Offset: 0x0013F985
		// (set) Token: 0x060087AC RID: 34732 RVA: 0x001417B0 File Offset: 0x0013F9B0
		public virtual EClientEventTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientEventTarget.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005557 RID: 21847
		[Nullable(2)]
		protected IClientEventTarget FbInstance;

		// Token: 0x04005558 RID: 21848
		[Nullable(2)]
		protected IClientEventTarget_SetValue PocoInterface;
	}
}
