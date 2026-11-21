using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001F2 RID: 498
	public class IAttachTarget
	{
		// Token: 0x060007C0 RID: 1984 RVA: 0x000261DC File Offset: 0x000243DC
		private IAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00026214 File Offset: 0x00024414
		public static IAttachTarget Create([Nullable(2)] IAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00026227 File Offset: 0x00024427
		public static IAttachTarget CreateFromSetValue([Nullable(2)] IAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002623A File Offset: 0x0002443A
		public IAttachTarget_SetValue ToSetValue()
		{
			return new IAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0002624D File Offset: 0x0002444D
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00026278 File Offset: 0x00024478
		public virtual EAttachType Type
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

		// Token: 0x04000915 RID: 2325
		[Nullable(2)]
		protected IAttachTarget FbInstance;

		// Token: 0x04000916 RID: 2326
		[Nullable(2)]
		protected IAttachTarget_SetValue PocoInterface;
	}
}
