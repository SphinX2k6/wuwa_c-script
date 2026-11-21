using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B03 RID: 6915
	public class IDeadeyeFollowShooterConfig
	{
		// Token: 0x060092E1 RID: 37601 RVA: 0x00157DF8 File Offset: 0x00155FF8
		private IDeadeyeFollowShooterConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeadeyeFollowShooterConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeadeyeFollowShooterConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeadeyeFollowShooterConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x00157E30 File Offset: 0x00156030
		public static IDeadeyeFollowShooterConfig Create([Nullable(2)] IDeadeyeFollowShooterConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x00157E43 File Offset: 0x00156043
		public static IDeadeyeFollowShooterConfig CreateFromSetValue([Nullable(2)] IDeadeyeFollowShooterConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeadeyeFollowShooterConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x00157E56 File Offset: 0x00156056
		public IDeadeyeFollowShooterConfig_SetValue ToSetValue()
		{
			return new IDeadeyeFollowShooterConfig_SetValue
			{
				DeadeyeShooterDa = this.DeadeyeShooterDa
			};
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x00157E69 File Offset: 0x00156069
		// (set) Token: 0x060092E6 RID: 37606 RVA: 0x00157E94 File Offset: 0x00156094
		public virtual string DeadeyeShooterDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeadeyeShooterDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.DeadeyeShooterDa;
			}
			set
			{
				this.GetOrCreatePoco().DeadeyeShooterDa = value;
			}
		}

		// Token: 0x04005B69 RID: 23401
		[Nullable(2)]
		protected IDeadeyeFollowShooterConfig FbInstance;

		// Token: 0x04005B6A RID: 23402
		[Nullable(2)]
		protected IDeadeyeFollowShooterConfig_SetValue PocoInterface;
	}
}
