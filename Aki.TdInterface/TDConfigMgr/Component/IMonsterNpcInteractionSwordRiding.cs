using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000510 RID: 1296
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionSwordRiding : IMonsterNpcInteractionConfig
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x0004CC4C File Offset: 0x0004AE4C
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

		// Token: 0x06001A4B RID: 6731 RVA: 0x0004CC84 File Offset: 0x0004AE84
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

		// Token: 0x06001A4C RID: 6732 RVA: 0x0004CC97 File Offset: 0x0004AE97
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

		// Token: 0x06001A4D RID: 6733 RVA: 0x0004CCAA File Offset: 0x0004AEAA
		public new IMonsterNpcInteractionSwordRiding_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionSwordRiding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0004CCBD File Offset: 0x0004AEBD
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0004CCE8 File Offset: 0x0004AEE8
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

		// Token: 0x04001314 RID: 4884
		[Nullable(2)]
		protected new IMonsterNpcInteractionSwordRiding FbInstance;

		// Token: 0x04001315 RID: 4885
		[Nullable(2)]
		protected new IMonsterNpcInteractionSwordRiding_SetValue PocoInterface;
	}
}
