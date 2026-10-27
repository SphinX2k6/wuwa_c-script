using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003CE RID: 974
	[NullableContext(1)]
	[Nullable(0)]
	public class IGameplayDataPersistence
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x0003F82C File Offset: 0x0003DA2C
		private IGameplayDataPersistence_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGameplayDataPersistence 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGameplayDataPersistence_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGameplayDataPersistence_SetValue());
			}
			return result;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003F864 File Offset: 0x0003DA64
		public static IGameplayDataPersistence Create([Nullable(2)] IGameplayDataPersistence instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayDataPersistence
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0003F877 File Offset: 0x0003DA77
		public static IGameplayDataPersistence CreateFromSetValue([Nullable(2)] IGameplayDataPersistence_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGameplayDataPersistence
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003F88A File Offset: 0x0003DA8A
		public IGameplayDataPersistence_SetValue ToSetValue()
		{
			return new IGameplayDataPersistence_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0003F89D File Offset: 0x0003DA9D
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0003F8C8 File Offset: 0x0003DAC8
		public virtual EDataPersistenceGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDataPersistenceGameplayType.TetrisBoardGame;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F97 RID: 3991
		[Nullable(2)]
		protected IGameplayDataPersistence FbInstance;

		// Token: 0x04000F98 RID: 3992
		[Nullable(2)]
		protected IGameplayDataPersistence_SetValue PocoInterface;
	}
}
