using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004B7 RID: 1207
	public class IInhaledDestroySelf : IInhaledPerResultType
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x000495A8 File Offset: 0x000477A8
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

		// Token: 0x06001832 RID: 6194 RVA: 0x000495E0 File Offset: 0x000477E0
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

		// Token: 0x06001833 RID: 6195 RVA: 0x000495F3 File Offset: 0x000477F3
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

		// Token: 0x06001834 RID: 6196 RVA: 0x00049606 File Offset: 0x00047806
		public new IInhaledDestroySelf_SetValue ToSetValue()
		{
			return new IInhaledDestroySelf_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00049619 File Offset: 0x00047819
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00049644 File Offset: 0x00047844
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

		// Token: 0x04001253 RID: 4691
		[Nullable(2)]
		protected new IInhaledDestroySelf FbInstance;

		// Token: 0x04001254 RID: 4692
		[Nullable(2)]
		protected new IInhaledDestroySelf_SetValue PocoInterface;
	}
}
