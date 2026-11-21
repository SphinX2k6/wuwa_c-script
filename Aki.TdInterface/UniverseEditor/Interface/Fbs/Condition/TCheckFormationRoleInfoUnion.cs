using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200522D RID: 21037
	public class TCheckFormationRoleInfoUnion
	{
		// Token: 0x17009674 RID: 38516
		// (get) Token: 0x0602121F RID: 135711 RVA: 0x0049344E File Offset: 0x0049164E
		// (set) Token: 0x06021220 RID: 135712 RVA: 0x00493456 File Offset: 0x00491656
		public TCheckFormationRoleInfo Type { get; set; }

		// Token: 0x17009675 RID: 38517
		// (get) Token: 0x06021221 RID: 135713 RVA: 0x0049345F File Offset: 0x0049165F
		// (set) Token: 0x06021222 RID: 135714 RVA: 0x00493467 File Offset: 0x00491667
		public object Value { get; set; }

		// Token: 0x06021223 RID: 135715 RVA: 0x00493470 File Offset: 0x00491670
		public TCheckFormationRoleInfoUnion()
		{
			this.Type = TCheckFormationRoleInfo.NONE;
			this.Value = null;
		}

		// Token: 0x06021224 RID: 135716 RVA: 0x00493486 File Offset: 0x00491686
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021225 RID: 135717 RVA: 0x00493498 File Offset: 0x00491698
		public IFeatureCollectionLevelT AsIFeatureCollectionLevel()
		{
			return this.As<IFeatureCollectionLevelT>();
		}

		// Token: 0x06021226 RID: 135718 RVA: 0x004934A0 File Offset: 0x004916A0
		public static TCheckFormationRoleInfoUnion FromIFeatureCollectionLevel(IFeatureCollectionLevelT _ifeaturecollectionlevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IFeatureCollectionLevel,
				Value = _ifeaturecollectionlevel
			};
		}

		// Token: 0x06021227 RID: 135719 RVA: 0x004934B5 File Offset: 0x004916B5
		public IHasEquippedVisionT AsIHasEquippedVision()
		{
			return this.As<IHasEquippedVisionT>();
		}

		// Token: 0x06021228 RID: 135720 RVA: 0x004934BD File Offset: 0x004916BD
		public static TCheckFormationRoleInfoUnion FromIHasEquippedVision(IHasEquippedVisionT _ihasequippedvision)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IHasEquippedVision,
				Value = _ihasequippedvision
			};
		}

		// Token: 0x06021229 RID: 135721 RVA: 0x004934D2 File Offset: 0x004916D2
		public IHasUpgradableVisionT AsIHasUpgradableVision()
		{
			return this.As<IHasUpgradableVisionT>();
		}

		// Token: 0x0602122A RID: 135722 RVA: 0x004934DA File Offset: 0x004916DA
		public static TCheckFormationRoleInfoUnion FromIHasUpgradableVision(IHasUpgradableVisionT _ihasupgradablevision)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IHasUpgradableVision,
				Value = _ihasupgradablevision
			};
		}

		// Token: 0x0602122B RID: 135723 RVA: 0x004934EF File Offset: 0x004916EF
		public IRoleLevelT AsIRoleLevel()
		{
			return this.As<IRoleLevelT>();
		}

		// Token: 0x0602122C RID: 135724 RVA: 0x004934F7 File Offset: 0x004916F7
		public static TCheckFormationRoleInfoUnion FromIRoleLevel(IRoleLevelT _irolelevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IRoleLevel,
				Value = _irolelevel
			};
		}

		// Token: 0x0602122D RID: 135725 RVA: 0x0049350C File Offset: 0x0049170C
		public IWeaponLevelT AsIWeaponLevel()
		{
			return this.As<IWeaponLevelT>();
		}

		// Token: 0x0602122E RID: 135726 RVA: 0x00493514 File Offset: 0x00491714
		public static TCheckFormationRoleInfoUnion FromIWeaponLevel(IWeaponLevelT _iweaponlevel)
		{
			return new TCheckFormationRoleInfoUnion
			{
				Type = TCheckFormationRoleInfo.IWeaponLevel,
				Value = _iweaponlevel
			};
		}

		// Token: 0x0602122F RID: 135727 RVA: 0x0049352C File Offset: 0x0049172C
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
