using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001F0 RID: 496
	public class IAreaBouns : IWorldLevelBonusType
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00026120 File Offset: 0x00024320
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x00026158 File Offset: 0x00024358
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

		// Token: 0x060007BA RID: 1978 RVA: 0x0002616B File Offset: 0x0002436B
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

		// Token: 0x060007BB RID: 1979 RVA: 0x0002617E File Offset: 0x0002437E
		public new IAreaBouns_SetValue ToSetValue()
		{
			return new IAreaBouns_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00026191 File Offset: 0x00024391
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000261BC File Offset: 0x000243BC
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

		// Token: 0x04000912 RID: 2322
		[Nullable(2)]
		protected new IAreaBouns FbInstance;

		// Token: 0x04000913 RID: 2323
		[Nullable(2)]
		protected new IAreaBouns_SetValue PocoInterface;
	}
}
