using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CD RID: 461
	[NullableContext(1)]
	[Nullable(0)]
	public class IAreaBouns : IWorldLevelBonusType
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x00024E1C File Offset: 0x0002301C
		private IAreaBouns_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAreaBouns 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAreaBouns_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAreaBouns_SetValue());
			}
			return result;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00024E54 File Offset: 0x00023054
		public static IAreaBouns Create([Nullable(2)] IAreaBouns instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaBouns
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00024E67 File Offset: 0x00023067
		public static IAreaBouns CreateFromSetValue([Nullable(2)] IAreaBouns_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAreaBouns
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00024E7A File Offset: 0x0002307A
		public new IAreaBouns_SetValue ToSetValue()
		{
			return new IAreaBouns_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x00024E8D File Offset: 0x0002308D
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00024EB8 File Offset: 0x000230B8
		public override EWorldLevelBonus Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400089E RID: 2206
		[Nullable(2)]
		protected new IAreaBouns FbInstance;

		// Token: 0x0400089F RID: 2207
		[Nullable(2)]
		protected new IAreaBouns_SetValue PocoInterface;
	}
}
