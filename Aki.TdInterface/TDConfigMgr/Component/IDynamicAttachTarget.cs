using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002DD RID: 733
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicAttachTarget : IAttachTarget
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x000335DC File Offset: 0x000317DC
		private IDynamicAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00033614 File Offset: 0x00031814
		public static IDynamicAttachTarget Create([Nullable(2)] IDynamicAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00033627 File Offset: 0x00031827
		public static IDynamicAttachTarget CreateFromSetValue([Nullable(2)] IDynamicAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003363A File Offset: 0x0003183A
		public new IDynamicAttachTarget_SetValue ToSetValue()
		{
			return new IDynamicAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0003364D File Offset: 0x0003184D
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00033678 File Offset: 0x00031878
		public override EAttachType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachType.Actor;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C7F RID: 3199
		[Nullable(2)]
		protected new IDynamicAttachTarget FbInstance;

		// Token: 0x04000C80 RID: 3200
		[Nullable(2)]
		protected new IDynamicAttachTarget_SetValue PocoInterface;
	}
}
