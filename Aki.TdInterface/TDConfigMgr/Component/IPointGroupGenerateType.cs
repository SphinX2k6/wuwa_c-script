using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006AF RID: 1711
	public class IPointGroupGenerateType
	{
		// Token: 0x0600242E RID: 9262 RVA: 0x00062C50 File Offset: 0x00060E50
		private IPointGroupGenerateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointGroupGenerateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointGroupGenerateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointGroupGenerateType_SetValue());
			}
			return result;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00062C88 File Offset: 0x00060E88
		public static IPointGroupGenerateType Create([Nullable(2)] IPointGroupGenerateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00062C9B File Offset: 0x00060E9B
		public static IPointGroupGenerateType CreateFromSetValue([Nullable(2)] IPointGroupGenerateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00062CAE File Offset: 0x00060EAE
		public IPointGroupGenerateType_SetValue ToSetValue()
		{
			return new IPointGroupGenerateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x00062CC1 File Offset: 0x00060EC1
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x00062CEC File Offset: 0x00060EEC
		public virtual EPointGroupGenerateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPointGroupGenerateType.Layer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001922 RID: 6434
		[Nullable(2)]
		protected IPointGroupGenerateType FbInstance;

		// Token: 0x04001923 RID: 6435
		[Nullable(2)]
		protected IPointGroupGenerateType_SetValue PocoInterface;
	}
}
