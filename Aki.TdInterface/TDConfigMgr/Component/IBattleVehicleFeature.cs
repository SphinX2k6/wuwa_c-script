using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000218 RID: 536
	public class IBattleVehicleFeature : IVehicleFeature
	{
		// Token: 0x06000896 RID: 2198 RVA: 0x00027C18 File Offset: 0x00025E18
		private IBattleVehicleFeature_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleVehicleFeature 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleVehicleFeature_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleVehicleFeature_SetValue());
			}
			return result;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00027C50 File Offset: 0x00025E50
		public static IBattleVehicleFeature Create([Nullable(2)] IBattleVehicleFeature instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleVehicleFeature
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00027C63 File Offset: 0x00025E63
		public static IBattleVehicleFeature CreateFromSetValue([Nullable(2)] IBattleVehicleFeature_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleVehicleFeature
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00027C76 File Offset: 0x00025E76
		public new IBattleVehicleFeature_SetValue ToSetValue()
		{
			return new IBattleVehicleFeature_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00027C89 File Offset: 0x00025E89
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00027CB4 File Offset: 0x00025EB4
		public override EVehicleFeatureFlag Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EVehicleFeatureFlag)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000989 RID: 2441
		[Nullable(2)]
		protected new IBattleVehicleFeature FbInstance;

		// Token: 0x0400098A RID: 2442
		[Nullable(2)]
		protected new IBattleVehicleFeature_SetValue PocoInterface;
	}
}
