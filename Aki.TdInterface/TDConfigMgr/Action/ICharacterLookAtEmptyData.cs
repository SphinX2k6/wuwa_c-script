using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0D RID: 6669
	public class ICharacterLookAtEmptyData : ICharacterLookAtData
	{
		// Token: 0x06008DF1 RID: 36337 RVA: 0x0014F750 File Offset: 0x0014D950
		private ICharacterLookAtEmptyData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtEmptyData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtEmptyData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtEmptyData_SetValue());
			}
			return result;
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0014F788 File Offset: 0x0014D988
		public static ICharacterLookAtEmptyData Create([Nullable(2)] ICharacterLookAtEmptyData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x0014F79B File Offset: 0x0014D99B
		public static ICharacterLookAtEmptyData CreateFromSetValue([Nullable(2)] ICharacterLookAtEmptyData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x0014F7AE File Offset: 0x0014D9AE
		public new ICharacterLookAtEmptyData_SetValue ToSetValue()
		{
			return new ICharacterLookAtEmptyData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x0014F7C1 File Offset: 0x0014D9C1
		// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x0014F7EC File Offset: 0x0014D9EC
		public override ECharacterLookAt Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECharacterLookAt.Empty;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400593E RID: 22846
		[Nullable(2)]
		protected new ICharacterLookAtEmptyData FbInstance;

		// Token: 0x0400593F RID: 22847
		[Nullable(2)]
		protected new ICharacterLookAtEmptyData_SetValue PocoInterface;
	}
}
