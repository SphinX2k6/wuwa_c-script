using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006D7 RID: 1751
	public class IQteType
	{
		// Token: 0x06002510 RID: 9488 RVA: 0x00064954 File Offset: 0x00062B54
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

		// Token: 0x06002511 RID: 9489 RVA: 0x0006498C File Offset: 0x00062B8C
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

		// Token: 0x06002512 RID: 9490 RVA: 0x0006499F File Offset: 0x00062B9F
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

		// Token: 0x06002513 RID: 9491 RVA: 0x000649B2 File Offset: 0x00062BB2
		public IQteType_SetValue ToSetValue()
		{
			return new IQteType_SetValue
			{
				Type = this.Type,
				QteId = this.QteId
			};
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000649D1 File Offset: 0x00062BD1
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000649FC File Offset: 0x00062BFC
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00064A0A File Offset: 0x00062C0A
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x00064A35 File Offset: 0x00062C35
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

		// Token: 0x0400199F RID: 6559
		[Nullable(2)]
		protected IQteType FbInstance;

		// Token: 0x040019A0 RID: 6560
		[Nullable(2)]
		protected IQteType_SetValue PocoInterface;
	}
}
