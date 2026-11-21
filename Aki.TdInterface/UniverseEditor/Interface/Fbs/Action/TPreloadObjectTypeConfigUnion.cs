using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F8C RID: 32652
	public class TPreloadObjectTypeConfigUnion
	{
		// Token: 0x1700F2D5 RID: 62165
		// (get) Token: 0x0603AD6F RID: 241007 RVA: 0x007E85F2 File Offset: 0x007E67F2
		// (set) Token: 0x0603AD70 RID: 241008 RVA: 0x007E85FA File Offset: 0x007E67FA
		public TPreloadObjectTypeConfig Type { get; set; }

		// Token: 0x1700F2D6 RID: 62166
		// (get) Token: 0x0603AD71 RID: 241009 RVA: 0x007E8603 File Offset: 0x007E6803
		// (set) Token: 0x0603AD72 RID: 241010 RVA: 0x007E860B File Offset: 0x007E680B
		public object Value { get; set; }

		// Token: 0x0603AD73 RID: 241011 RVA: 0x007E8614 File Offset: 0x007E6814
		public TPreloadObjectTypeConfigUnion()
		{
			this.Type = TPreloadObjectTypeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD74 RID: 241012 RVA: 0x007E862A File Offset: 0x007E682A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD75 RID: 241013 RVA: 0x007E863C File Offset: 0x007E683C
		public IPreloadFlowsT AsIPreloadFlows()
		{
			return this.As<IPreloadFlowsT>();
		}

		// Token: 0x0603AD76 RID: 241014 RVA: 0x007E8644 File Offset: 0x007E6844
		public static TPreloadObjectTypeConfigUnion FromIPreloadFlows(IPreloadFlowsT _ipreloadflows)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadFlows,
				Value = _ipreloadflows
			};
		}

		// Token: 0x0603AD77 RID: 241015 RVA: 0x007E8659 File Offset: 0x007E6859
		public IPreloadLinkResourceT AsIPreloadLinkResource()
		{
			return this.As<IPreloadLinkResourceT>();
		}

		// Token: 0x0603AD78 RID: 241016 RVA: 0x007E8661 File Offset: 0x007E6861
		public static TPreloadObjectTypeConfigUnion FromIPreloadLinkResource(IPreloadLinkResourceT _ipreloadlinkresource)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadLinkResource,
				Value = _ipreloadlinkresource
			};
		}

		// Token: 0x0603AD79 RID: 241017 RVA: 0x007E8676 File Offset: 0x007E6876
		public IPreloadMp4sT AsIPreloadMp4s()
		{
			return this.As<IPreloadMp4sT>();
		}

		// Token: 0x0603AD7A RID: 241018 RVA: 0x007E867E File Offset: 0x007E687E
		public static TPreloadObjectTypeConfigUnion FromIPreloadMp4s(IPreloadMp4sT _ipreloadmp4s)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadMp4s,
				Value = _ipreloadmp4s
			};
		}

		// Token: 0x0603AD7B RID: 241019 RVA: 0x007E8693 File Offset: 0x007E6893
		public IPreloadPhantomCharacterForSkillT AsIPreloadPhantomCharacterForSkill()
		{
			return this.As<IPreloadPhantomCharacterForSkillT>();
		}

		// Token: 0x0603AD7C RID: 241020 RVA: 0x007E869B File Offset: 0x007E689B
		public static TPreloadObjectTypeConfigUnion FromIPreloadPhantomCharacterForSkill(IPreloadPhantomCharacterForSkillT _ipreloadphantomcharacterforskill)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadPhantomCharacterForSkill,
				Value = _ipreloadphantomcharacterforskill
			};
		}

		// Token: 0x0603AD7D RID: 241021 RVA: 0x007E86B0 File Offset: 0x007E68B0
		public IPreloadTrialCharacterForSkillT AsIPreloadTrialCharacterForSkill()
		{
			return this.As<IPreloadTrialCharacterForSkillT>();
		}

		// Token: 0x0603AD7E RID: 241022 RVA: 0x007E86B8 File Offset: 0x007E68B8
		public static TPreloadObjectTypeConfigUnion FromIPreloadTrialCharacterForSkill(IPreloadTrialCharacterForSkillT _ipreloadtrialcharacterforskill)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadTrialCharacterForSkill,
				Value = _ipreloadtrialcharacterforskill
			};
		}

		// Token: 0x0603AD7F RID: 241023 RVA: 0x007E86D0 File Offset: 0x007E68D0
		public static int Pack(FlatBufferBuilder builder, TPreloadObjectTypeConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPreloadObjectTypeConfig.IPreloadFlows:
				return IPreloadFlows.Pack(builder, _o.AsIPreloadFlows()).Value;
			case TPreloadObjectTypeConfig.IPreloadLinkResource:
				return IPreloadLinkResource.Pack(builder, _o.AsIPreloadLinkResource()).Value;
			case TPreloadObjectTypeConfig.IPreloadMp4s:
				return IPreloadMp4s.Pack(builder, _o.AsIPreloadMp4s()).Value;
			case TPreloadObjectTypeConfig.IPreloadPhantomCharacterForSkill:
				return IPreloadPhantomCharacterForSkill.Pack(builder, _o.AsIPreloadPhantomCharacterForSkill()).Value;
			case TPreloadObjectTypeConfig.IPreloadTrialCharacterForSkill:
				return IPreloadTrialCharacterForSkill.Pack(builder, _o.AsIPreloadTrialCharacterForSkill()).Value;
			default:
				return 0;
			}
		}
	}
}
