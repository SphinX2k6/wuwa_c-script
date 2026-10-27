using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200194E RID: 6478
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenLoadingCyberpunk : ICustomScreenLoadingTypeBase
	{
		// Token: 0x06008ACF RID: 35535 RVA: 0x00146B90 File Offset: 0x00144D90
		private ICustomScreenLoadingCyberpunk_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenLoadingCyberpunk 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenLoadingCyberpunk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenLoadingCyberpunk_SetValue());
			}
			return result;
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00146BC8 File Offset: 0x00144DC8
		public static ICustomScreenLoadingCyberpunk Create([Nullable(2)] ICustomScreenLoadingCyberpunk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x00146BDB File Offset: 0x00144DDB
		public static ICustomScreenLoadingCyberpunk CreateFromSetValue([Nullable(2)] ICustomScreenLoadingCyberpunk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x00146BEE File Offset: 0x00144DEE
		public new ICustomScreenLoadingCyberpunk_SetValue ToSetValue()
		{
			return new ICustomScreenLoadingCyberpunk_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x00146C01 File Offset: 0x00144E01
		// (set) Token: 0x06008AD4 RID: 35540 RVA: 0x00146C2C File Offset: 0x00144E2C
		public override ECustomScreenLoading Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040056B2 RID: 22194
		[Nullable(2)]
		protected new ICustomScreenLoadingCyberpunk FbInstance;

		// Token: 0x040056B3 RID: 22195
		[Nullable(2)]
		protected new ICustomScreenLoadingCyberpunk_SetValue PocoInterface;
	}
}
