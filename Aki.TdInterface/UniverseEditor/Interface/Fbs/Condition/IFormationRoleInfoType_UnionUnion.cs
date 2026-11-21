using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200511F RID: 20767
	public class IFormationRoleInfoType_UnionUnion
	{
		// Token: 0x170094D1 RID: 38097
		// (get) Token: 0x06020A57 RID: 133719 RVA: 0x00486649 File Offset: 0x00484849
		// (set) Token: 0x06020A58 RID: 133720 RVA: 0x00486651 File Offset: 0x00484851
		public IFormationRoleInfoType_Union Type { get; set; }

		// Token: 0x170094D2 RID: 38098
		// (get) Token: 0x06020A59 RID: 133721 RVA: 0x0048665A File Offset: 0x0048485A
		// (set) Token: 0x06020A5A RID: 133722 RVA: 0x00486662 File Offset: 0x00484862
		public object Value { get; set; }

		// Token: 0x06020A5B RID: 133723 RVA: 0x0048666B File Offset: 0x0048486B
		public IFormationRoleInfoType_UnionUnion()
		{
			this.Type = IFormationRoleInfoType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020A5C RID: 133724 RVA: 0x00486681 File Offset: 0x00484881
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020A5D RID: 133725 RVA: 0x00486693 File Offset: 0x00484893
		public IFormationRoleInfoTypeT AsIFormationRoleInfoType()
		{
			return this.As<IFormationRoleInfoTypeT>();
		}

		// Token: 0x06020A5E RID: 133726 RVA: 0x0048669B File Offset: 0x0048489B
		public static IFormationRoleInfoType_UnionUnion FromIFormationRoleInfoType(IFormationRoleInfoTypeT _iformationroleinfotype)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IFormationRoleInfoType,
				Value = _iformationroleinfotype
			};
		}

		// Token: 0x06020A5F RID: 133727 RVA: 0x004866B0 File Offset: 0x004848B0
		public IRoleLevelT AsIRoleLevel()
		{
			return this.As<IRoleLevelT>();
		}

		// Token: 0x06020A60 RID: 133728 RVA: 0x004866B8 File Offset: 0x004848B8
		public static IFormationRoleInfoType_UnionUnion FromIRoleLevel(IRoleLevelT _irolelevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IRoleLevel,
				Value = _irolelevel
			};
		}

		// Token: 0x06020A61 RID: 133729 RVA: 0x004866CD File Offset: 0x004848CD
		public IWeaponLevelT AsIWeaponLevel()
		{
			return this.As<IWeaponLevelT>();
		}

		// Token: 0x06020A62 RID: 133730 RVA: 0x004866D5 File Offset: 0x004848D5
		public static IFormationRoleInfoType_UnionUnion FromIWeaponLevel(IWeaponLevelT _iweaponlevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IWeaponLevel,
				Value = _iweaponlevel
			};
		}

		// Token: 0x06020A63 RID: 133731 RVA: 0x004866EA File Offset: 0x004848EA
		public IHasEquippedVisionT AsIHasEquippedVision()
		{
			return this.As<IHasEquippedVisionT>();
		}

		// Token: 0x06020A64 RID: 133732 RVA: 0x004866F2 File Offset: 0x004848F2
		public static IFormationRoleInfoType_UnionUnion FromIHasEquippedVision(IHasEquippedVisionT _ihasequippedvision)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IHasEquippedVision,
				Value = _ihasequippedvision
			};
		}

		// Token: 0x06020A65 RID: 133733 RVA: 0x00486707 File Offset: 0x00484907
		public IHasUpgradableVisionT AsIHasUpgradableVision()
		{
			return this.As<IHasUpgradableVisionT>();
		}

		// Token: 0x06020A66 RID: 133734 RVA: 0x0048670F File Offset: 0x0048490F
		public static IFormationRoleInfoType_UnionUnion FromIHasUpgradableVision(IHasUpgradableVisionT _ihasupgradablevision)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IHasUpgradableVision,
				Value = _ihasupgradablevision
			};
		}

		// Token: 0x06020A67 RID: 133735 RVA: 0x00486724 File Offset: 0x00484924
		public IFeatureCollectionLevelT AsIFeatureCollectionLevel()
		{
			return this.As<IFeatureCollectionLevelT>();
		}

		// Token: 0x06020A68 RID: 133736 RVA: 0x0048672C File Offset: 0x0048492C
		public static IFormationRoleInfoType_UnionUnion FromIFeatureCollectionLevel(IFeatureCollectionLevelT _ifeaturecollectionlevel)
		{
			return new IFormationRoleInfoType_UnionUnion
			{
				Type = IFormationRoleInfoType_Union.IFeatureCollectionLevel,
				Value = _ifeaturecollectionlevel
			};
		}

		// Token: 0x06020A69 RID: 133737 RVA: 0x00486744 File Offset: 0x00484944
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
