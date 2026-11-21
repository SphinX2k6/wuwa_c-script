using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000577 RID: 1399
	public class IMonsterNpcInteractionSwordRiding : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x00051A08 File Offset: 0x0004FC08
		private IMonsterNpcInteractionSwordRiding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionSwordRiding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionSwordRiding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionSwordRiding_SetValue());
			}
			return result;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00051A40 File Offset: 0x0004FC40
		public static IMonsterNpcInteractionSwordRiding Create([Nullable(2)] IMonsterNpcInteractionSwordRiding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionSwordRiding
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00051A53 File Offset: 0x0004FC53
		public static IMonsterNpcInteractionSwordRiding CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionSwordRiding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionSwordRiding
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00051A66 File Offset: 0x0004FC66
		public new IMonsterNpcInteractionSwordRiding_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionSwordRiding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00051A79 File Offset: 0x0004FC79
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x00051AA4 File Offset: 0x0004FCA4
		public override EMonsterNpcInteractionType Type
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

		// Token: 0x0400147E RID: 5246
		[Nullable(2)]
		protected new IMonsterNpcInteractionSwordRiding FbInstance;

		// Token: 0x0400147F RID: 5247
		[Nullable(2)]
		protected new IMonsterNpcInteractionSwordRiding_SetValue PocoInterface;
	}
}
