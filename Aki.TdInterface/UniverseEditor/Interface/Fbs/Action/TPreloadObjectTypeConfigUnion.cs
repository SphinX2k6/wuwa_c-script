using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007760 RID: 30560
	public class TPreloadObjectTypeConfigUnion
	{
		// Token: 0x1700E683 RID: 59011
		// (get) Token: 0x06037826 RID: 227366 RVA: 0x00783522 File Offset: 0x00781722
		// (set) Token: 0x06037827 RID: 227367 RVA: 0x0078352A File Offset: 0x0078172A
		public TPreloadObjectTypeConfig Type { get; set; }

		// Token: 0x1700E684 RID: 59012
		// (get) Token: 0x06037828 RID: 227368 RVA: 0x00783533 File Offset: 0x00781733
		// (set) Token: 0x06037829 RID: 227369 RVA: 0x0078353B File Offset: 0x0078173B
		public object Value { get; set; }

		// Token: 0x0603782A RID: 227370 RVA: 0x00783544 File Offset: 0x00781744
		public TPreloadObjectTypeConfigUnion()
		{
			this.Type = TPreloadObjectTypeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603782B RID: 227371 RVA: 0x0078355A File Offset: 0x0078175A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603782C RID: 227372 RVA: 0x0078356C File Offset: 0x0078176C
		public IPreloadFlowsT AsIPreloadFlows()
		{
			return this.As<IPreloadFlowsT>();
		}

		// Token: 0x0603782D RID: 227373 RVA: 0x00783574 File Offset: 0x00781774
		public static TPreloadObjectTypeConfigUnion FromIPreloadFlows(IPreloadFlowsT _ipreloadflows)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadFlows,
				Value = _ipreloadflows
			};
		}

		// Token: 0x0603782E RID: 227374 RVA: 0x00783589 File Offset: 0x00781789
		public IPreloadLinkResourceT AsIPreloadLinkResource()
		{
			return this.As<IPreloadLinkResourceT>();
		}

		// Token: 0x0603782F RID: 227375 RVA: 0x00783591 File Offset: 0x00781791
		public static TPreloadObjectTypeConfigUnion FromIPreloadLinkResource(IPreloadLinkResourceT _ipreloadlinkresource)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadLinkResource,
				Value = _ipreloadlinkresource
			};
		}

		// Token: 0x06037830 RID: 227376 RVA: 0x007835A6 File Offset: 0x007817A6
		public IPreloadMp4sT AsIPreloadMp4s()
		{
			return this.As<IPreloadMp4sT>();
		}

		// Token: 0x06037831 RID: 227377 RVA: 0x007835AE File Offset: 0x007817AE
		public static TPreloadObjectTypeConfigUnion FromIPreloadMp4s(IPreloadMp4sT _ipreloadmp4s)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadMp4s,
				Value = _ipreloadmp4s
			};
		}

		// Token: 0x06037832 RID: 227378 RVA: 0x007835C3 File Offset: 0x007817C3
		public IPreloadPhantomCharacterForSkillT AsIPreloadPhantomCharacterForSkill()
		{
			return this.As<IPreloadPhantomCharacterForSkillT>();
		}

		// Token: 0x06037833 RID: 227379 RVA: 0x007835CB File Offset: 0x007817CB
		public static TPreloadObjectTypeConfigUnion FromIPreloadPhantomCharacterForSkill(IPreloadPhantomCharacterForSkillT _ipreloadphantomcharacterforskill)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadPhantomCharacterForSkill,
				Value = _ipreloadphantomcharacterforskill
			};
		}

		// Token: 0x06037834 RID: 227380 RVA: 0x007835E0 File Offset: 0x007817E0
		public IPreloadTrialCharacterForSkillT AsIPreloadTrialCharacterForSkill()
		{
			return this.As<IPreloadTrialCharacterForSkillT>();
		}

		// Token: 0x06037835 RID: 227381 RVA: 0x007835E8 File Offset: 0x007817E8
		public static TPreloadObjectTypeConfigUnion FromIPreloadTrialCharacterForSkill(IPreloadTrialCharacterForSkillT _ipreloadtrialcharacterforskill)
		{
			return new TPreloadObjectTypeConfigUnion
			{
				Type = TPreloadObjectTypeConfig.IPreloadTrialCharacterForSkill,
				Value = _ipreloadtrialcharacterforskill
			};
		}

		// Token: 0x06037836 RID: 227382 RVA: 0x00783600 File Offset: 0x00781800
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
