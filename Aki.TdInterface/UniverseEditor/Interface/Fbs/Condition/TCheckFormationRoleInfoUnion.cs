using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D31 RID: 19761
	public class TCheckFormationRoleInfoUnion
	{
		// Token: 0x17008F3B RID: 36667
		// (get) Token: 0x0601F5D8 RID: 128472 RVA: 0x0045F4BE File Offset: 0x0045D6BE
		// (set) Token: 0x0601F5D9 RID: 128473 RVA: 0x0045F4C6 File Offset: 0x0045D6C6
		public TCheckFormationRoleInfo Type { get; set; }

		// Token: 0x17008F3C RID: 36668
		// (get) Token: 0x0601F5DA RID: 128474 RVA: 0x0045F4CF File Offset: 0x0045D6CF
		// (set) Token: 0x0601F5DB RID: 128475 RVA: 0x0045F4D7 File Offset: 0x0045D6D7
		public object Value { get; set; }

		// Token: 0x0601F5DC RID: 128476 RVA: 0x0045F4E0 File Offset: 0x0045D6E0
		public TCheckFormationRoleInfoUnion()
		{
			this.Type = TCheckFormationRoleInfo.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5DD RID: 128477 RVA: 0x0045F4F6 File Offset: 0x0045D6F6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5DE RID: 128478 RVA: 0x0045F508 File Offset: 0x0045D708
		public IFeatureCollectionLevelT AsIFeatureCollectionLevel()
		{
			return this.As<IFeatureCollectionLevelT>();
		}

		// Token: 0x0601F5DF RID: 128479 RVA: 0x0045F510 File Offset: 0x0045D710
		public static TCheckFormationRoleInfoUnion FromIFeatureCollectionLevel(IFeatureCollectionLevelT _ifeaturecollectionlevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IFeatureCollectionLevel,
				Value = _ifeaturecollectionlevel
			};
		}

		// Token: 0x0601F5E0 RID: 128480 RVA: 0x0045F525 File Offset: 0x0045D725
		public IHasEquippedVisionT AsIHasEquippedVision()
		{
			return this.As<IHasEquippedVisionT>();
		}

		// Token: 0x0601F5E1 RID: 128481 RVA: 0x0045F52D File Offset: 0x0045D72D
		public static TCheckFormationRoleInfoUnion FromIHasEquippedVision(IHasEquippedVisionT _ihasequippedvision)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IHasEquippedVision,
				Value = _ihasequippedvision
			};
		}

		// Token: 0x0601F5E2 RID: 128482 RVA: 0x0045F542 File Offset: 0x0045D742
		public IHasUpgradableVisionT AsIHasUpgradableVision()
		{
			return this.As<IHasUpgradableVisionT>();
		}

		// Token: 0x0601F5E3 RID: 128483 RVA: 0x0045F54A File Offset: 0x0045D74A
		public static TCheckFormationRoleInfoUnion FromIHasUpgradableVision(IHasUpgradableVisionT _ihasupgradablevision)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IHasUpgradableVision,
				Value = _ihasupgradablevision
			};
		}

		// Token: 0x0601F5E4 RID: 128484 RVA: 0x0045F55F File Offset: 0x0045D75F
		public IRoleLevelT AsIRoleLevel()
		{
			return this.As<IRoleLevelT>();
		}

		// Token: 0x0601F5E5 RID: 128485 RVA: 0x0045F567 File Offset: 0x0045D767
		public static TCheckFormationRoleInfoUnion FromIRoleLevel(IRoleLevelT _irolelevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IRoleLevel,
				Value = _irolelevel
			};
		}

		// Token: 0x0601F5E6 RID: 128486 RVA: 0x0045F57C File Offset: 0x0045D77C
		public IWeaponLevelT AsIWeaponLevel()
		{
			return this.As<IWeaponLevelT>();
		}

		// Token: 0x0601F5E7 RID: 128487 RVA: 0x0045F584 File Offset: 0x0045D784
		public static TCheckFormationRoleInfoUnion FromIWeaponLevel(IWeaponLevelT _iweaponlevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IWeaponLevel,
				Value = _iweaponlevel
			};
		}

		// Token: 0x0601F5E8 RID: 128488 RVA: 0x0045F59C File Offset: 0x0045D79C
		public static int Pack(FlatBufferBuilder builder, TCheckFormationRoleInfoUnion _o)
		{
			switch (_o.Type)
			{
			case TCheckFormationRoleInfo.IFeatureCollectionLevel:
				return IFeatureCollectionLevel.Pack(builder, _o.AsIFeatureCollectionLevel()).Value;
			case TCheckFormationRoleInfo.IHasEquippedVision:
				return IHasEquippedVision.Pack(builder, _o.AsIHasEquippedVision()).Value;
			case TCheckFormationRoleInfo.IHasUpgradableVision:
				return IHasUpgradableVision.Pack(builder, _o.AsIHasUpgradableVision()).Value;
			case TCheckFormationRoleInfo.IRoleLevel:
				return IRoleLevel.Pack(builder, _o.AsIRoleLevel()).Value;
			case TCheckFormationRoleInfo.IWeaponLevel:
				return IWeaponLevel.Pack(builder, _o.AsIWeaponLevel()).Value;
			default:
				return 0;
			}
		}
	}
}
