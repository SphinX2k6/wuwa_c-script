using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BF RID: 959
	public class IFanInteractByHit : IFanInteractType
	{
		// Token: 0x060012DF RID: 4831 RVA: 0x0003E69C File Offset: 0x0003C89C
		private IFanInteractByHit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFanInteractByHit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFanInteractByHit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFanInteractByHit_SetValue());
			}
			return result;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0003E6D4 File Offset: 0x0003C8D4
		public static IFanInteractByHit Create([Nullable(2)] IFanInteractByHit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0003E6E7 File Offset: 0x0003C8E7
		public static IFanInteractByHit CreateFromSetValue([Nullable(2)] IFanInteractByHit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFanInteractByHit
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0003E6FA File Offset: 0x0003C8FA
		public new IFanInteractByHit_SetValue ToSetValue()
		{
			return new IFanInteractByHit_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0003E70D File Offset: 0x0003C90D
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0003E738 File Offset: 0x0003C938
		public override EFanInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFanInteractType.Hit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F60 RID: 3936
		[Nullable(2)]
		protected new IFanInteractByHit FbInstance;

		// Token: 0x04000F61 RID: 3937
		[Nullable(2)]
		protected new IFanInteractByHit_SetValue PocoInterface;
	}
}
