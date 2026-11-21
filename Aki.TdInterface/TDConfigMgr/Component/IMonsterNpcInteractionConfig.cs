using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200056F RID: 1391
	public class IMonsterNpcInteractionConfig
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x0005171C File Offset: 0x0004F91C
		private IMonsterNpcInteractionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00051754 File Offset: 0x0004F954
		public static IMonsterNpcInteractionConfig Create([Nullable(2)] IMonsterNpcInteractionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00051767 File Offset: 0x0004F967
		public static IMonsterNpcInteractionConfig CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0005177A File Offset: 0x0004F97A
		public IMonsterNpcInteractionConfig_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0005178D File Offset: 0x0004F98D
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x000517B8 File Offset: 0x0004F9B8
		public virtual EMonsterNpcInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001472 RID: 5234
		[Nullable(2)]
		protected IMonsterNpcInteractionConfig FbInstance;

		// Token: 0x04001473 RID: 5235
		[Nullable(2)]
		protected IMonsterNpcInteractionConfig_SetValue PocoInterface;
	}
}
