using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200045E RID: 1118
	[NullableContext(1)]
	[Nullable(0)]
	public class IInhaledDestroySelf : IInhaledPerResultType
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00045860 File Offset: 0x00043A60
		private IInhaledDestroySelf_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInhaledDestroySelf 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInhaledDestroySelf_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInhaledDestroySelf_SetValue());
			}
			return result;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00045898 File Offset: 0x00043A98
		public static IInhaledDestroySelf Create([Nullable(2)] IInhaledDestroySelf instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledDestroySelf
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000458AB File Offset: 0x00043AAB
		public static IInhaledDestroySelf CreateFromSetValue([Nullable(2)] IInhaledDestroySelf_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInhaledDestroySelf
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000458BE File Offset: 0x00043ABE
		public new IInhaledDestroySelf_SetValue ToSetValue()
		{
			return new IInhaledDestroySelf_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x000458D1 File Offset: 0x00043AD1
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x000458FC File Offset: 0x00043AFC
		public override EInhaledPerResultType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInhaledPerResultType.DestroySelf;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001131 RID: 4401
		[Nullable(2)]
		protected new IInhaledDestroySelf FbInstance;

		// Token: 0x04001132 RID: 4402
		[Nullable(2)]
		protected new IInhaledDestroySelf_SetValue PocoInterface;
	}
}
