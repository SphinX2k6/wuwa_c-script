using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EF RID: 495
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleVehicleFeature : IVehicleFeature
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x000262C4 File Offset: 0x000244C4
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

		// Token: 0x06000817 RID: 2071 RVA: 0x000262FC File Offset: 0x000244FC
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

		// Token: 0x06000818 RID: 2072 RVA: 0x0002630F File Offset: 0x0002450F
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

		// Token: 0x06000819 RID: 2073 RVA: 0x00026322 File Offset: 0x00024522
		public new IBattleVehicleFeature_SetValue ToSetValue()
		{
			return new IBattleVehicleFeature_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00026335 File Offset: 0x00024535
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00026360 File Offset: 0x00024560
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

		// Token: 0x040008F8 RID: 2296
		[Nullable(2)]
		protected new IBattleVehicleFeature FbInstance;

		// Token: 0x040008F9 RID: 2297
		[Nullable(2)]
		protected new IBattleVehicleFeature_SetValue PocoInterface;
	}
}
