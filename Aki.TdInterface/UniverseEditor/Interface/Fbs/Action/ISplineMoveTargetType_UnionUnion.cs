using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007194 RID: 29076
	public class ISplineMoveTargetType_UnionUnion
	{
		// Token: 0x1700D7F5 RID: 55285
		// (get) Token: 0x060338CA RID: 211146 RVA: 0x006F16C9 File Offset: 0x006EF8C9
		// (set) Token: 0x060338CB RID: 211147 RVA: 0x006F16D1 File Offset: 0x006EF8D1
		public ISplineMoveTargetType_Union Type { get; set; }

		// Token: 0x1700D7F6 RID: 55286
		// (get) Token: 0x060338CC RID: 211148 RVA: 0x006F16DA File Offset: 0x006EF8DA
		// (set) Token: 0x060338CD RID: 211149 RVA: 0x006F16E2 File Offset: 0x006EF8E2
		public object Value { get; set; }

		// Token: 0x060338CE RID: 211150 RVA: 0x006F16EB File Offset: 0x006EF8EB
		public ISplineMoveTargetType_UnionUnion()
		{
			this.Type = ISplineMoveTargetType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060338CF RID: 211151 RVA: 0x006F1701 File Offset: 0x006EF901
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060338D0 RID: 211152 RVA: 0x006F1713 File Offset: 0x006EF913
		public ISplineMoveTargetTypeT AsISplineMoveTargetType()
		{
			return this.As<ISplineMoveTargetTypeT>();
		}

		// Token: 0x060338D1 RID: 211153 RVA: 0x006F171B File Offset: 0x006EF91B
		public static ISplineMoveTargetType_UnionUnion FromISplineMoveTargetType(ISplineMoveTargetTypeT _isplinemovetargettype)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.ISplineMoveTargetType,
				Value = _isplinemovetargettype
			};
		}

		// Token: 0x060338D2 RID: 211154 RVA: 0x006F1730 File Offset: 0x006EF930
		public IEntitySplineMoveTargetT AsIEntitySplineMoveTarget()
		{
			return this.As<IEntitySplineMoveTargetT>();
		}

		// Token: 0x060338D3 RID: 211155 RVA: 0x006F1738 File Offset: 0x006EF938
		public static ISplineMoveTargetType_UnionUnion FromIEntitySplineMoveTarget(IEntitySplineMoveTargetT _ientitysplinemovetarget)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.IEntitySplineMoveTarget,
				Value = _ientitysplinemovetarget
			};
		}

		// Token: 0x060338D4 RID: 211156 RVA: 0x006F174D File Offset: 0x006EF94D
		public IPlayerSplineMoveTargetT AsIPlayerSplineMoveTarget()
		{
			return this.As<IPlayerSplineMoveTargetT>();
		}

		// Token: 0x060338D5 RID: 211157 RVA: 0x006F1755 File Offset: 0x006EF955
		public static ISplineMoveTargetType_UnionUnion FromIPlayerSplineMoveTarget(IPlayerSplineMoveTargetT _iplayersplinemovetarget)
		{
			return new ISplineMoveTargetType_UnionUnion
			{
				Type = ISplineMoveTargetType_Union.IPlayerSplineMoveTarget,
				Value = _iplayersplinemovetarget
			};
		}

		// Token: 0x060338D6 RID: 211158 RVA: 0x006F176C File Offset: 0x006EF96C
		public static int Pack(FlatBufferBuilder builder, ISplineMoveTargetType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineMoveTargetType_Union.ISplineMoveTargetType:
				return ISplineMoveTargetType.Pack(builder, _o.AsISplineMoveTargetType()).Value;
			case ISplineMoveTargetType_Union.IEntitySplineMoveTarget:
				return IEntitySplineMoveTarget.Pack(builder, _o.AsIEntitySplineMoveTarget()).Value;
			case ISplineMoveTargetType_Union.IPlayerSplineMoveTarget:
				return IPlayerSplineMoveTarget.Pack(builder, _o.AsIPlayerSplineMoveTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
