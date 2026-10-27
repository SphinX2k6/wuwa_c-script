using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D90 RID: 28048
	public class IPreloadCharacterType_UnionUnion
	{
		// Token: 0x1700D13A RID: 53562
		// (get) Token: 0x060318B1 RID: 202929 RVA: 0x006B71F1 File Offset: 0x006B53F1
		// (set) Token: 0x060318B2 RID: 202930 RVA: 0x006B71F9 File Offset: 0x006B53F9
		public IPreloadCharacterType_Union Type { get; set; }

		// Token: 0x1700D13B RID: 53563
		// (get) Token: 0x060318B3 RID: 202931 RVA: 0x006B7202 File Offset: 0x006B5402
		// (set) Token: 0x060318B4 RID: 202932 RVA: 0x006B720A File Offset: 0x006B540A
		public object Value { get; set; }

		// Token: 0x060318B5 RID: 202933 RVA: 0x006B7213 File Offset: 0x006B5413
		public IPreloadCharacterType_UnionUnion()
		{
			this.Type = IPreloadCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060318B6 RID: 202934 RVA: 0x006B7229 File Offset: 0x006B5429
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060318B7 RID: 202935 RVA: 0x006B723B File Offset: 0x006B543B
		public IPreloadCharacterTypeT AsIPreloadCharacterType()
		{
			return this.As<IPreloadCharacterTypeT>();
		}

		// Token: 0x060318B8 RID: 202936 RVA: 0x006B7243 File Offset: 0x006B5443
		public static IPreloadCharacterType_UnionUnion FromIPreloadCharacterType(IPreloadCharacterTypeT _ipreloadcharactertype)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadCharacterType,
				Value = _ipreloadcharactertype
			};
		}

		// Token: 0x060318B9 RID: 202937 RVA: 0x006B7258 File Offset: 0x006B5458
		public IPreloadTrialCharacterForSkillT AsIPreloadTrialCharacterForSkill()
		{
			return this.As<IPreloadTrialCharacterForSkillT>();
		}

		// Token: 0x060318BA RID: 202938 RVA: 0x006B7260 File Offset: 0x006B5460
		public static IPreloadCharacterType_UnionUnion FromIPreloadTrialCharacterForSkill(IPreloadTrialCharacterForSkillT _ipreloadtrialcharacterforskill)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadTrialCharacterForSkill,
				Value = _ipreloadtrialcharacterforskill
			};
		}

		// Token: 0x060318BB RID: 202939 RVA: 0x006B7275 File Offset: 0x006B5475
		public IPreloadPhantomCharacterForSkillT AsIPreloadPhantomCharacterForSkill()
		{
			return this.As<IPreloadPhantomCharacterForSkillT>();
		}

		// Token: 0x060318BC RID: 202940 RVA: 0x006B727D File Offset: 0x006B547D
		public static IPreloadCharacterType_UnionUnion FromIPreloadPhantomCharacterForSkill(IPreloadPhantomCharacterForSkillT _ipreloadphantomcharacterforskill)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadPhantomCharacterForSkill,
				Value = _ipreloadphantomcharacterforskill
			};
		}

		// Token: 0x060318BD RID: 202941 RVA: 0x006B7292 File Offset: 0x006B5492
		public IPreloadMp4sT AsIPreloadMp4s()
		{
			return this.As<IPreloadMp4sT>();
		}

		// Token: 0x060318BE RID: 202942 RVA: 0x006B729A File Offset: 0x006B549A
		public static IPreloadCharacterType_UnionUnion FromIPreloadMp4s(IPreloadMp4sT _ipreloadmp4s)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadMp4s,
				Value = _ipreloadmp4s
			};
		}

		// Token: 0x060318BF RID: 202943 RVA: 0x006B72AF File Offset: 0x006B54AF
		public IPreloadFlowsT AsIPreloadFlows()
		{
			return this.As<IPreloadFlowsT>();
		}

		// Token: 0x060318C0 RID: 202944 RVA: 0x006B72B7 File Offset: 0x006B54B7
		public static IPreloadCharacterType_UnionUnion FromIPreloadFlows(IPreloadFlowsT _ipreloadflows)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadFlows,
				Value = _ipreloadflows
			};
		}

		// Token: 0x060318C1 RID: 202945 RVA: 0x006B72CC File Offset: 0x006B54CC
		public IPreloadLinkResourceT AsIPreloadLinkResource()
		{
			return this.As<IPreloadLinkResourceT>();
		}

		// Token: 0x060318C2 RID: 202946 RVA: 0x006B72D4 File Offset: 0x006B54D4
		public static IPreloadCharacterType_UnionUnion FromIPreloadLinkResource(IPreloadLinkResourceT _ipreloadlinkresource)
		{
			return new IPreloadCharacterType_UnionUnion
			{
				Type = IPreloadCharacterType_Union.IPreloadLinkResource,
				Value = _ipreloadlinkresource
			};
		}

		// Token: 0x060318C3 RID: 202947 RVA: 0x006B72EC File Offset: 0x006B54EC
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
