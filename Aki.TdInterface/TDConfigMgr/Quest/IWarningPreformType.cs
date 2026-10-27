using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120E RID: 4622
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreformType
	{
		// Token: 0x060068E2 RID: 26850 RVA: 0x000FA2D4 File Offset: 0x000F84D4
		private IWarningPreformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWarningPreformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWarningPreformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWarningPreformType_SetValue());
			}
			return result;
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x000FA30C File Offset: 0x000F850C
		public static IWarningPreformType Create([Nullable(2)] IWarningPreformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x000FA31F File Offset: 0x000F851F
		public static IWarningPreformType CreateFromSetValue([Nullable(2)] IWarningPreformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x000FA332 File Offset: 0x000F8532
		public IWarningPreformType_SetValue ToSetValue()
		{
			return new IWarningPreformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x000FA345 File Offset: 0x000F8545
		// (set) Token: 0x060068E7 RID: 26855 RVA: 0x000FA370 File Offset: 0x000F8570
		public virtual EWarningPreformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003EBE RID: 16062
		[Nullable(2)]
		protected IWarningPreformType FbInstance;

		// Token: 0x04003EBF RID: 16063
		[Nullable(2)]
		protected IWarningPreformType_SetValue PocoInterface;
	}
}
