using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A11 RID: 6673
	public class ICharacterLookAtPlayerData : ICharacterLookAtData
	{
		// Token: 0x06008E03 RID: 36355 RVA: 0x0014F90C File Offset: 0x0014DB0C
		private ICharacterLookAtPlayerData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterLookAtPlayerData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterLookAtPlayerData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterLookAtPlayerData_SetValue());
			}
			return result;
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x0014F944 File Offset: 0x0014DB44
		public static ICharacterLookAtPlayerData Create([Nullable(2)] ICharacterLookAtPlayerData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtPlayerData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x0014F957 File Offset: 0x0014DB57
		public static ICharacterLookAtPlayerData CreateFromSetValue([Nullable(2)] ICharacterLookAtPlayerData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterLookAtPlayerData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x0014F96A File Offset: 0x0014DB6A
		public new ICharacterLookAtPlayerData_SetValue ToSetValue()
		{
			return new ICharacterLookAtPlayerData_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x0014F97D File Offset: 0x0014DB7D
		// (set) Token: 0x06008E08 RID: 36360 RVA: 0x0014F9A8 File Offset: 0x0014DBA8
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

		// Token: 0x04005945 RID: 22853
		[Nullable(2)]
		protected new ICharacterLookAtPlayerData FbInstance;

		// Token: 0x04005946 RID: 22854
		[Nullable(2)]
		protected new ICharacterLookAtPlayerData_SetValue PocoInterface;
	}
}
