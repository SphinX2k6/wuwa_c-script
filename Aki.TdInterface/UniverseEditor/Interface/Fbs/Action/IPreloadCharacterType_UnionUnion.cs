using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750B RID: 29963
	public class IPreloadCharacterType_UnionUnion
	{
		// Token: 0x1700DC82 RID: 56450
		// (get) Token: 0x060348AD RID: 215213 RVA: 0x007128D9 File Offset: 0x00710AD9
		// (set) Token: 0x060348AE RID: 215214 RVA: 0x007128E1 File Offset: 0x00710AE1
		public IPreloadCharacterType_Union Type { get; set; }

		// Token: 0x1700DC83 RID: 56451
		// (get) Token: 0x060348AF RID: 215215 RVA: 0x007128EA File Offset: 0x00710AEA
		// (set) Token: 0x060348B0 RID: 215216 RVA: 0x007128F2 File Offset: 0x00710AF2
		public object Value { get; set; }

		// Token: 0x060348B1 RID: 215217 RVA: 0x007128FB File Offset: 0x00710AFB
		public IPreloadCharacterType_UnionUnion()
		{
			this.Type = IPreloadCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060348B2 RID: 215218 RVA: 0x00712911 File Offset: 0x00710B11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060348B3 RID: 215219 RVA: 0x00712923 File Offset: 0x00710B23
		public IPreloadCharacterTypeT AsIPreloadCharacterType()
		{
			return this.As<IPreloadCharacterTypeT>();
		}

		// Token: 0x060348B4 RID: 215220 RVA: 0x0071292B File Offset: 0x00710B2B
		public static IPreloadCharacterType_UnionUnion FromIPreloadCharacterType(IPreloadCharacterTypeT _ipreloadcharactertype)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadCharacterType,
				Value = _ipreloadcharactertype
			};
		}

		// Token: 0x060348B5 RID: 215221 RVA: 0x00712940 File Offset: 0x00710B40
		public IPreloadTrialCharacterForSkillT AsIPreloadTrialCharacterForSkill()
		{
			return this.As<IPreloadTrialCharacterForSkillT>();
		}

		// Token: 0x060348B6 RID: 215222 RVA: 0x00712948 File Offset: 0x00710B48
		public static IPreloadCharacterType_UnionUnion FromIPreloadTrialCharacterForSkill(IPreloadTrialCharacterForSkillT _ipreloadtrialcharacterforskill)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadTrialCharacterForSkill,
				Value = _ipreloadtrialcharacterforskill
			};
		}

		// Token: 0x060348B7 RID: 215223 RVA: 0x0071295D File Offset: 0x00710B5D
		public IPreloadPhantomCharacterForSkillT AsIPreloadPhantomCharacterForSkill()
		{
			return this.As<IPreloadPhantomCharacterForSkillT>();
		}

		// Token: 0x060348B8 RID: 215224 RVA: 0x00712965 File Offset: 0x00710B65
		public static IPreloadCharacterType_UnionUnion FromIPreloadPhantomCharacterForSkill(IPreloadPhantomCharacterForSkillT _ipreloadphantomcharacterforskill)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadPhantomCharacterForSkill,
				Value = _ipreloadphantomcharacterforskill
			};
		}

		// Token: 0x060348B9 RID: 215225 RVA: 0x0071297A File Offset: 0x00710B7A
		public IPreloadMp4sT AsIPreloadMp4s()
		{
			return this.As<IPreloadMp4sT>();
		}

		// Token: 0x060348BA RID: 215226 RVA: 0x00712982 File Offset: 0x00710B82
		public static IPreloadCharacterType_UnionUnion FromIPreloadMp4s(IPreloadMp4sT _ipreloadmp4s)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadMp4s,
				Value = _ipreloadmp4s
			};
		}

		// Token: 0x060348BB RID: 215227 RVA: 0x00712997 File Offset: 0x00710B97
		public IPreloadFlowsT AsIPreloadFlows()
		{
			return this.As<IPreloadFlowsT>();
		}

		// Token: 0x060348BC RID: 215228 RVA: 0x0071299F File Offset: 0x00710B9F
		public static IPreloadCharacterType_UnionUnion FromIPreloadFlows(IPreloadFlowsT _ipreloadflows)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadFlows,
				Value = _ipreloadflows
			};
		}

		// Token: 0x060348BD RID: 215229 RVA: 0x007129B4 File Offset: 0x00710BB4
		public IPreloadLinkResourceT AsIPreloadLinkResource()
		{
			return this.As<IPreloadLinkResourceT>();
		}

		// Token: 0x060348BE RID: 215230 RVA: 0x007129BC File Offset: 0x00710BBC
		public static IPreloadCharacterType_UnionUnion FromIPreloadLinkResource(IPreloadLinkResourceT _ipreloadlinkresource)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadLinkResource,
				Value = _ipreloadlinkresource
			};
		}

		// Token: 0x060348BF RID: 215231 RVA: 0x007129D4 File Offset: 0x00710BD4
		public static int Pack(FlatBufferBuilder builder, IPreloadCharacterType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPreloadCharacterType_Union.IPreloadCharacterType:
				return IPreloadCharacterType.Pack(builder, _o.AsIPreloadCharacterType()).Value;
			case IPreloadCharacterType_Union.IPreloadTrialCharacterForSkill:
				return IPreloadTrialCharacterForSkill.Pack(builder, _o.AsIPreloadTrialCharacterForSkill()).Value;
			case IPreloadCharacterType_Union.IPreloadPhantomCharacterForSkill:
				return IPreloadPhantomCharacterForSkill.Pack(builder, _o.AsIPreloadPhantomCharacterForSkill()).Value;
			case IPreloadCharacterType_Union.IPreloadMp4s:
				return IPreloadMp4s.Pack(builder, _o.AsIPreloadMp4s()).Value;
			case IPreloadCharacterType_Union.IPreloadFlows:
				return IPreloadFlows.Pack(builder, _o.AsIPreloadFlows()).Value;
			case IPreloadCharacterType_Union.IPreloadLinkResource:
				return IPreloadLinkResource.Pack(builder, _o.AsIPreloadLinkResource()).Value;
			default:
				return 0;
			}
		}
	}
}
