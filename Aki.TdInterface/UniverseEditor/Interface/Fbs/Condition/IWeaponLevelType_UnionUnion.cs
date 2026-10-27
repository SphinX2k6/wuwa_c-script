using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D22 RID: 19746
	public class IWeaponLevelType_UnionUnion
	{
		// Token: 0x17008F28 RID: 36648
		// (get) Token: 0x0601F570 RID: 128368 RVA: 0x0045EA39 File Offset: 0x0045CC39
		// (set) Token: 0x0601F571 RID: 128369 RVA: 0x0045EA41 File Offset: 0x0045CC41
		public IWeaponLevelType_Union Type { get; set; }

		// Token: 0x17008F29 RID: 36649
		// (get) Token: 0x0601F572 RID: 128370 RVA: 0x0045EA4A File Offset: 0x0045CC4A
		// (set) Token: 0x0601F573 RID: 128371 RVA: 0x0045EA52 File Offset: 0x0045CC52
		public object Value { get; set; }

		// Token: 0x0601F574 RID: 128372 RVA: 0x0045EA5B File Offset: 0x0045CC5B
		public IWeaponLevelType_UnionUnion()
		{
			this.Type = IWeaponLevelType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F575 RID: 128373 RVA: 0x0045EA71 File Offset: 0x0045CC71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F576 RID: 128374 RVA: 0x0045EA83 File Offset: 0x0045CC83
		public IWeaponLevelTypeT AsIWeaponLevelType()
		{
			return this.As<IWeaponLevelTypeT>();
		}

		// Token: 0x0601F577 RID: 128375 RVA: 0x0045EA8B File Offset: 0x0045CC8B
		public static IWeaponLevelType_UnionUnion FromIWeaponLevelType(IWeaponLevelTypeT _iweaponleveltype)
		{
			return new IWeaponLevelType_UnionUnion
			{
				Type = IWeaponLevelType_Union.IWeaponLevelType,
				Value = _iweaponleveltype
			};
		}

		// Token: 0x0601F578 RID: 128376 RVA: 0x0045EAA0 File Offset: 0x0045CCA0
		public ISpecifyRoleWeaponLevelT AsISpecifyRoleWeaponLevel()
		{
			return this.As<ISpecifyRoleWeaponLevelT>();
		}

		// Token: 0x0601F579 RID: 128377 RVA: 0x0045EAA8 File Offset: 0x0045CCA8
		public static IWeaponLevelType_UnionUnion FromISpecifyRoleWeaponLevel(ISpecifyRoleWeaponLevelT _ispecifyroleweaponlevel)
		{
			return new IWeaponLevelType_UnionUnion
			{
				Type = IWeaponLevelType_Union.ISpecifyRoleWeaponLevel,
				Value = _ispecifyroleweaponlevel
			};
		}

		// Token: 0x0601F57A RID: 128378 RVA: 0x0045EAC0 File Offset: 0x0045CCC0
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
