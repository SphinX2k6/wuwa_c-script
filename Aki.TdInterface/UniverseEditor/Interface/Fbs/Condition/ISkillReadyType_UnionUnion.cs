using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC8 RID: 19656
	public class ISkillReadyType_UnionUnion
	{
		// Token: 0x17008EAC RID: 36524
		// (get) Token: 0x0601F2F9 RID: 127737 RVA: 0x0045A9A5 File Offset: 0x00458BA5
		// (set) Token: 0x0601F2FA RID: 127738 RVA: 0x0045A9AD File Offset: 0x00458BAD
		public ISkillReadyType_Union Type { get; set; }

		// Token: 0x17008EAD RID: 36525
		// (get) Token: 0x0601F2FB RID: 127739 RVA: 0x0045A9B6 File Offset: 0x00458BB6
		// (set) Token: 0x0601F2FC RID: 127740 RVA: 0x0045A9BE File Offset: 0x00458BBE
		public object Value { get; set; }

		// Token: 0x0601F2FD RID: 127741 RVA: 0x0045A9C7 File Offset: 0x00458BC7
		public ISkillReadyType_UnionUnion()
		{
			this.Type = ISkillReadyType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F2FE RID: 127742 RVA: 0x0045A9DD File Offset: 0x00458BDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F2FF RID: 127743 RVA: 0x0045A9EF File Offset: 0x00458BEF
		public ISkillReadyTypeT AsISkillReadyType()
		{
			return this.As<ISkillReadyTypeT>();
		}

		// Token: 0x0601F300 RID: 127744 RVA: 0x0045A9F7 File Offset: 0x00458BF7
		public static ISkillReadyType_UnionUnion FromISkillReadyType(ISkillReadyTypeT _iskillreadytype)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.ISkillReadyType,
				Value = _iskillreadytype
			};
		}

		// Token: 0x0601F301 RID: 127745 RVA: 0x0045AA0C File Offset: 0x00458C0C
		public IUltimateSkillReadyT AsIUltimateSkillReady()
		{
			return this.As<IUltimateSkillReadyT>();
		}

		// Token: 0x0601F302 RID: 127746 RVA: 0x0045AA14 File Offset: 0x00458C14
		public static ISkillReadyType_UnionUnion FromIUltimateSkillReady(IUltimateSkillReadyT _iultimateskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IUltimateSkillReady,
				Value = _iultimateskillready
			};
		}

		// Token: 0x0601F303 RID: 127747 RVA: 0x0045AA29 File Offset: 0x00458C29
		public IESkillReadyT AsIESkillReady()
		{
			return this.As<IESkillReadyT>();
		}

		// Token: 0x0601F304 RID: 127748 RVA: 0x0045AA31 File Offset: 0x00458C31
		public static ISkillReadyType_UnionUnion FromIESkillReady(IESkillReadyT _ieskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IESkillReady,
				Value = _ieskillready
			};
		}

		// Token: 0x0601F305 RID: 127749 RVA: 0x0045AA46 File Offset: 0x00458C46
		public IVisionSkillReadyT AsIVisionSkillReady()
		{
			return this.As<IVisionSkillReadyT>();
		}

		// Token: 0x0601F306 RID: 127750 RVA: 0x0045AA4E File Offset: 0x00458C4E
		public static ISkillReadyType_UnionUnion FromIVisionSkillReady(IVisionSkillReadyT _ivisionskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IVisionSkillReady,
				Value = _ivisionskillready
			};
		}

		// Token: 0x0601F307 RID: 127751 RVA: 0x0045AA64 File Offset: 0x00458C64
		public static int Pack(FlatBufferBuilder builder, ISkillReadyType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISkillReadyType_Union.ISkillReadyType:
				return ISkillReadyType.Pack(builder, _o.AsISkillReadyType()).Value;
			case ISkillReadyType_Union.IUltimateSkillReady:
				return IUltimateSkillReady.Pack(builder, _o.AsIUltimateSkillReady()).Value;
			case ISkillReadyType_Union.IESkillReady:
				return IESkillReady.Pack(builder, _o.AsIESkillReady()).Value;
			case ISkillReadyType_Union.IVisionSkillReady:
				return IVisionSkillReady.Pack(builder, _o.AsIVisionSkillReady()).Value;
			default:
				return 0;
			}
		}
	}
}
