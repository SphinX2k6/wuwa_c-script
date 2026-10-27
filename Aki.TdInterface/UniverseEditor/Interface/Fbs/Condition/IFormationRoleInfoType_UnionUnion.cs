using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C2C RID: 19500
	public class IFormationRoleInfoType_UnionUnion
	{
		// Token: 0x17008DA8 RID: 36264
		// (get) Token: 0x0601EE53 RID: 126547 RVA: 0x00452D6D File Offset: 0x00450F6D
		// (set) Token: 0x0601EE54 RID: 126548 RVA: 0x00452D75 File Offset: 0x00450F75
		public IFormationRoleInfoType_Union Type { get; set; }

		// Token: 0x17008DA9 RID: 36265
		// (get) Token: 0x0601EE55 RID: 126549 RVA: 0x00452D7E File Offset: 0x00450F7E
		// (set) Token: 0x0601EE56 RID: 126550 RVA: 0x00452D86 File Offset: 0x00450F86
		public object Value { get; set; }

		// Token: 0x0601EE57 RID: 126551 RVA: 0x00452D8F File Offset: 0x00450F8F
		public IFormationRoleInfoType_UnionUnion()
		{
			this.Type = IFormationRoleInfoType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EE58 RID: 126552 RVA: 0x00452DA5 File Offset: 0x00450FA5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EE59 RID: 126553 RVA: 0x00452DB7 File Offset: 0x00450FB7
		public IFormationRoleInfoTypeT AsIFormationRoleInfoType()
		{
			return this.As<IFormationRoleInfoTypeT>();
		}

		// Token: 0x0601EE5A RID: 126554 RVA: 0x00452DBF File Offset: 0x00450FBF
		public static IFormationRoleInfoType_UnionUnion FromIFormationRoleInfoType(IFormationRoleInfoTypeT _iformationroleinfotype)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IFormationRoleInfoType,
				Value = _iformationroleinfotype
			};
		}

		// Token: 0x0601EE5B RID: 126555 RVA: 0x00452DD4 File Offset: 0x00450FD4
		public IRoleLevelT AsIRoleLevel()
		{
			return this.As<IRoleLevelT>();
		}

		// Token: 0x0601EE5C RID: 126556 RVA: 0x00452DDC File Offset: 0x00450FDC
		public static IFormationRoleInfoType_UnionUnion FromIRoleLevel(IRoleLevelT _irolelevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IRoleLevel,
				Value = _irolelevel
			};
		}

		// Token: 0x0601EE5D RID: 126557 RVA: 0x00452DF1 File Offset: 0x00450FF1
		public IWeaponLevelT AsIWeaponLevel()
		{
			return this.As<IWeaponLevelT>();
		}

		// Token: 0x0601EE5E RID: 126558 RVA: 0x00452DF9 File Offset: 0x00450FF9
		public static IFormationRoleInfoType_UnionUnion FromIWeaponLevel(IWeaponLevelT _iweaponlevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IWeaponLevel,
				Value = _iweaponlevel
			};
		}

		// Token: 0x0601EE5F RID: 126559 RVA: 0x00452E0E File Offset: 0x0045100E
		public IHasEquippedVisionT AsIHasEquippedVision()
		{
			return this.As<IHasEquippedVisionT>();
		}

		// Token: 0x0601EE60 RID: 126560 RVA: 0x00452E16 File Offset: 0x00451016
		public static IFormationRoleInfoType_UnionUnion FromIHasEquippedVision(IHasEquippedVisionT _ihasequippedvision)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IHasEquippedVision,
				Value = _ihasequippedvision
			};
		}

		// Token: 0x0601EE61 RID: 126561 RVA: 0x00452E2B File Offset: 0x0045102B
		public IHasUpgradableVisionT AsIHasUpgradableVision()
		{
			return this.As<IHasUpgradableVisionT>();
		}

		// Token: 0x0601EE62 RID: 126562 RVA: 0x00452E33 File Offset: 0x00451033
		public static IFormationRoleInfoType_UnionUnion FromIHasUpgradableVision(IHasUpgradableVisionT _ihasupgradablevision)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IHasUpgradableVision,
				Value = _ihasupgradablevision
			};
		}

		// Token: 0x0601EE63 RID: 126563 RVA: 0x00452E48 File Offset: 0x00451048
		public IFeatureCollectionLevelT AsIFeatureCollectionLevel()
		{
			return this.As<IFeatureCollectionLevelT>();
		}

		// Token: 0x0601EE64 RID: 126564 RVA: 0x00452E50 File Offset: 0x00451050
		public static IFormationRoleInfoType_UnionUnion FromIFeatureCollectionLevel(IFeatureCollectionLevelT _ifeaturecollectionlevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IFeatureCollectionLevel,
				Value = _ifeaturecollectionlevel
			};
		}

		// Token: 0x0601EE65 RID: 126565 RVA: 0x00452E68 File Offset: 0x00451068
		public static int Pack(FlatBufferBuilder builder, IFormationRoleInfoType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFormationRoleInfoType_Union.IFormationRoleInfoType:
				return IFormationRoleInfoType.Pack(builder, _o.AsIFormationRoleInfoType()).Value;
			case IFormationRoleInfoType_Union.IRoleLevel:
				return IRoleLevel.Pack(builder, _o.AsIRoleLevel()).Value;
			case IFormationRoleInfoType_Union.IWeaponLevel:
				return IWeaponLevel.Pack(builder, _o.AsIWeaponLevel()).Value;
			case IFormationRoleInfoType_Union.IHasEquippedVision:
				return IHasEquippedVision.Pack(builder, _o.AsIHasEquippedVision()).Value;
			case IFormationRoleInfoType_Union.IHasUpgradableVision:
				return IHasUpgradableVision.Pack(builder, _o.AsIHasUpgradableVision()).Value;
			case IFormationRoleInfoType_Union.IFeatureCollectionLevel:
				return IFeatureCollectionLevel.Pack(builder, _o.AsIFeatureCollectionLevel()).Value;
			default:
				return 0;
			}
		}
	}
}
