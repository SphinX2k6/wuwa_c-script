using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200063A RID: 1594
	[NullableContext(1)]
	[Nullable(0)]
	public class IQteType
	{
		// Token: 0x0600220A RID: 8714 RVA: 0x0005DC40 File Offset: 0x0005BE40
		private IQteType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQteType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQteType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQteType_SetValue());
			}
			return result;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0005DC78 File Offset: 0x0005BE78
		public static IQteType Create([Nullable(2)] IQteType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQteType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0005DC8B File Offset: 0x0005BE8B
		public static IQteType CreateFromSetValue([Nullable(2)] IQteType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQteType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0005DC9E File Offset: 0x0005BE9E
		public IQteType_SetValue ToSetValue()
		{
			return new IQteType_SetValue
			{
				Type = this.Type,
				QteId = this.QteId
			};
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x0005DCBD File Offset: 0x0005BEBD
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x0005DCE8 File Offset: 0x0005BEE8
		public virtual EQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EQteType.SingleBtn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0005DCF6 File Offset: 0x0005BEF6
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0005DD21 File Offset: 0x0005BF21
		public virtual int QteId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QteId;
			}
			set
			{
				this.GetOrCreatePoco().QteId = value;
			}
		}

		// Token: 0x040017AD RID: 6061
		[Nullable(2)]
		protected IQteType FbInstance;

		// Token: 0x040017AE RID: 6062
		[Nullable(2)]
		protected IQteType_SetValue PocoInterface;
	}
}
