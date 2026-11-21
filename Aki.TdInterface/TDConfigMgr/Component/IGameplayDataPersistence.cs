using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000425 RID: 1061
	public class IGameplayDataPersistence
	{
		// Token: 0x06001521 RID: 5409 RVA: 0x000433AC File Offset: 0x000415AC
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

		// Token: 0x06001522 RID: 5410 RVA: 0x000433E4 File Offset: 0x000415E4
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

		// Token: 0x06001523 RID: 5411 RVA: 0x000433F7 File Offset: 0x000415F7
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

		// Token: 0x06001524 RID: 5412 RVA: 0x0004340A File Offset: 0x0004160A
		public IGameplayDataPersistence_SetValue ToSetValue()
		{
			return new IGameplayDataPersistence_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0004341D File Offset: 0x0004161D
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x00043448 File Offset: 0x00041648
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

		// Token: 0x040010B0 RID: 4272
		[Nullable(2)]
		protected IGameplayDataPersistence FbInstance;

		// Token: 0x040010B1 RID: 4273
		[Nullable(2)]
		protected IGameplayDataPersistence_SetValue PocoInterface;
	}
}
