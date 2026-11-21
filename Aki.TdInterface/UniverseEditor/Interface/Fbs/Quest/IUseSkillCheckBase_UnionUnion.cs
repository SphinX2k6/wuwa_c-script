using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A4 RID: 18084
	public class IUseSkillCheckBase_UnionUnion
	{
		// Token: 0x17007EA7 RID: 32423
		// (get) Token: 0x0601A8E9 RID: 108777 RVA: 0x003C72D5 File Offset: 0x003C54D5
		// (set) Token: 0x0601A8EA RID: 108778 RVA: 0x003C72DD File Offset: 0x003C54DD
		public IUseSkillCheckBase_Union Type { get; set; }

		// Token: 0x17007EA8 RID: 32424
		// (get) Token: 0x0601A8EB RID: 108779 RVA: 0x003C72E6 File Offset: 0x003C54E6
		// (set) Token: 0x0601A8EC RID: 108780 RVA: 0x003C72EE File Offset: 0x003C54EE
		public object Value { get; set; }

		// Token: 0x0601A8ED RID: 108781 RVA: 0x003C72F7 File Offset: 0x003C54F7
		public IUseSkillCheckBase_UnionUnion()
		{
			this.Type = IUseSkillCheckBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A8EE RID: 108782 RVA: 0x003C730D File Offset: 0x003C550D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A8EF RID: 108783 RVA: 0x003C731F File Offset: 0x003C551F
		public IUseSkillCheckBaseT AsIUseSkillCheckBase()
		{
			return this.As<IUseSkillCheckBaseT>();
		}

		// Token: 0x0601A8F0 RID: 108784 RVA: 0x003C7327 File Offset: 0x003C5527
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBase(IUseSkillCheckBaseT _iuseskillcheckbase)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBase,
				Value = _iuseskillcheckbase
			};
		}

		// Token: 0x0601A8F1 RID: 108785 RVA: 0x003C733C File Offset: 0x003C553C
		public IUseSkillCheckBySkillGenreT AsIUseSkillCheckBySkillGenre()
		{
			return this.As<IUseSkillCheckBySkillGenreT>();
		}

		// Token: 0x0601A8F2 RID: 108786 RVA: 0x003C7344 File Offset: 0x003C5544
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBySkillGenre(IUseSkillCheckBySkillGenreT _iuseskillcheckbyskillgenre)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBySkillGenre,
				Value = _iuseskillcheckbyskillgenre
			};
		}

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x003C7359 File Offset: 0x003C5559
		public IUseSkillCheckBySkillIdT AsIUseSkillCheckBySkillId()
		{
			return this.As<IUseSkillCheckBySkillIdT>();
		}

		// Token: 0x0601A8F4 RID: 108788 RVA: 0x003C7361 File Offset: 0x003C5561
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBySkillId(IUseSkillCheckBySkillIdT _iuseskillcheckbyskillid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBySkillId,
				Value = _iuseskillcheckbyskillid
			};
		}

		// Token: 0x0601A8F5 RID: 108789 RVA: 0x003C7376 File Offset: 0x003C5576
		public IUseSkillCheckByVisionSummonIdT AsIUseSkillCheckByVisionSummonId()
		{
			return this.As<IUseSkillCheckByVisionSummonIdT>();
		}

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x003C737E File Offset: 0x003C557E
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByVisionSummonId(IUseSkillCheckByVisionSummonIdT _iuseskillcheckbyvisionsummonid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByVisionSummonId,
				Value = _iuseskillcheckbyvisionsummonid
			};
		}

		// Token: 0x0601A8F7 RID: 108791 RVA: 0x003C7393 File Offset: 0x003C5593
		public IUseSkillCheckByVisionShowIdT AsIUseSkillCheckByVisionShowId()
		{
			return this.As<IUseSkillCheckByVisionShowIdT>();
		}

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x003C739B File Offset: 0x003C559B
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByVisionShowId(IUseSkillCheckByVisionShowIdT _iuseskillcheckbyvisionshowid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByVisionShowId,
				Value = _iuseskillcheckbyvisionshowid
			};
		}

		// Token: 0x0601A8F9 RID: 108793 RVA: 0x003C73B0 File Offset: 0x003C55B0
		public IUseSkillCheckByFollowShooterSkillIdT AsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.As<IUseSkillCheckByFollowShooterSkillIdT>();
		}

		// Token: 0x0601A8FA RID: 108794 RVA: 0x003C73B8 File Offset: 0x003C55B8
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByFollowShooterSkillId(IUseSkillCheckByFollowShooterSkillIdT _iuseskillcheckbyfollowshooterskillid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByFollowShooterSkillId,
				Value = _iuseskillcheckbyfollowshooterskillid
			};
		}

		// Token: 0x0601A8FB RID: 108795 RVA: 0x003C73D0 File Offset: 0x003C55D0
		public static int Pack(FlatBufferBuilder builder, IUseSkillCheckBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUseSkillCheckBase_Union.IUseSkillCheckBase:
				return IUseSkillCheckBase.Pack(builder, _o.AsIUseSkillCheckBase()).Value;
			case IUseSkillCheckBase_Union.IUseSkillCheckBySkillGenre:
				return IUseSkillCheckBySkillGenre.Pack(builder, _o.AsIUseSkillCheckBySkillGenre()).Value;
			case IUseSkillCheckBase_Union.IUseSkillCheckBySkillId:
				return IUseSkillCheckBySkillId.Pack(builder, _o.AsIUseSkillCheckBySkillId()).Value;
			case IUseSkillCheckBase_Union.IUseSkillCheckByVisionSummonId:
				return IUseSkillCheckByVisionSummonId.Pack(builder, _o.AsIUseSkillCheckByVisionSummonId()).Value;
			case IUseSkillCheckBase_Union.IUseSkillCheckByVisionShowId:
				return IUseSkillCheckByVisionShowId.Pack(builder, _o.AsIUseSkillCheckByVisionShowId()).Value;
			case IUseSkillCheckBase_Union.IUseSkillCheckByFollowShooterSkillId:
				return IUseSkillCheckByFollowShooterSkillId.Pack(builder, _o.AsIUseSkillCheckByFollowShooterSkillId()).Value;
			default:
				return 0;
			}
		}
	}
}
