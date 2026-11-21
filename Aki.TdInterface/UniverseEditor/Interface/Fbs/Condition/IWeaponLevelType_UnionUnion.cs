using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200521E RID: 21022
	public class IWeaponLevelType_UnionUnion
	{
		// Token: 0x17009661 RID: 38497
		// (get) Token: 0x060211B7 RID: 135607 RVA: 0x004929C9 File Offset: 0x00490BC9
		// (set) Token: 0x060211B8 RID: 135608 RVA: 0x004929D1 File Offset: 0x00490BD1
		public IWeaponLevelType_Union Type { get; set; }

		// Token: 0x17009662 RID: 38498
		// (get) Token: 0x060211B9 RID: 135609 RVA: 0x004929DA File Offset: 0x00490BDA
		// (set) Token: 0x060211BA RID: 135610 RVA: 0x004929E2 File Offset: 0x00490BE2
		public object Value { get; set; }

		// Token: 0x060211BB RID: 135611 RVA: 0x004929EB File Offset: 0x00490BEB
		public IWeaponLevelType_UnionUnion()
		{
			this.Type = IWeaponLevelType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060211BC RID: 135612 RVA: 0x00492A01 File Offset: 0x00490C01
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060211BD RID: 135613 RVA: 0x00492A13 File Offset: 0x00490C13
		public IWeaponLevelTypeT AsIWeaponLevelType()
		{
			return this.As<IWeaponLevelTypeT>();
		}

		// Token: 0x060211BE RID: 135614 RVA: 0x00492A1B File Offset: 0x00490C1B
		public static IWeaponLevelType_UnionUnion FromIWeaponLevelType(IWeaponLevelTypeT _iweaponleveltype)
		{
			return new IWeaponLevelType_UnionUnion
			{
				Type = IWeaponLevelType_Union.IWeaponLevelType,
				Value = _iweaponleveltype
			};
		}

		// Token: 0x060211BF RID: 135615 RVA: 0x00492A30 File Offset: 0x00490C30
		public ISpecifyRoleWeaponLevelT AsISpecifyRoleWeaponLevel()
		{
			return this.As<ISpecifyRoleWeaponLevelT>();
		}

		// Token: 0x060211C0 RID: 135616 RVA: 0x00492A38 File Offset: 0x00490C38
		public static IWeaponLevelType_UnionUnion FromISpecifyRoleWeaponLevel(ISpecifyRoleWeaponLevelT _ispecifyroleweaponlevel)
		{
			return new IWeaponLevelType_UnionUnion
			{
				Type = IWeaponLevelType_Union.ISpecifyRoleWeaponLevel,
				Value = _ispecifyroleweaponlevel
			};
		}

		// Token: 0x060211C1 RID: 135617 RVA: 0x00492A50 File Offset: 0x00490C50
		public static int Pack(FlatBufferBuilder builder, IWeaponLevelType_UnionUnion _o)
		{
			IWeaponLevelType_Union type = _o.Type;
			if (type == IWeaponLevelType_Union.IWeaponLevelType)
			{
				return IWeaponLevelType.Pack(builder, _o.AsIWeaponLevelType()).Value;
			}
			if (type != IWeaponLevelType_Union.ISpecifyRoleWeaponLevel)
			{
				return 0;
			}
			return ISpecifyRoleWeaponLevel.Pack(builder, _o.AsISpecifyRoleWeaponLevel()).Value;
		}
	}
}
