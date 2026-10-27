using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004330 RID: 17200
	public class TUseSkillCheckUnion
	{
		// Token: 0x17007982 RID: 31106
		// (get) Token: 0x0601980F RID: 104463 RVA: 0x003A72F8 File Offset: 0x003A54F8
		// (set) Token: 0x06019810 RID: 104464 RVA: 0x003A7300 File Offset: 0x003A5500
		public TUseSkillCheck Type { get; set; }

		// Token: 0x17007983 RID: 31107
		// (get) Token: 0x06019811 RID: 104465 RVA: 0x003A7309 File Offset: 0x003A5509
		// (set) Token: 0x06019812 RID: 104466 RVA: 0x003A7311 File Offset: 0x003A5511
		public object Value { get; set; }

		// Token: 0x06019813 RID: 104467 RVA: 0x003A731A File Offset: 0x003A551A
		public TUseSkillCheckUnion()
		{
			this.Type = TUseSkillCheck.NONE;
			this.Value = null;
		}

		// Token: 0x06019814 RID: 104468 RVA: 0x003A7330 File Offset: 0x003A5530
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019815 RID: 104469 RVA: 0x003A7342 File Offset: 0x003A5542
		public IUseSkillCheckByFollowShooterSkillIdT AsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.As<IUseSkillCheckByFollowShooterSkillIdT>();
		}

		// Token: 0x06019816 RID: 104470 RVA: 0x003A734A File Offset: 0x003A554A
		public static TUseSkillCheckUnion FromIUseSkillCheckByFollowShooterSkillId(IUseSkillCheckByFollowShooterSkillIdT _iuseskillcheckbyfollowshooterskillid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByFollowShooterSkillId,
				Value = _iuseskillcheckbyfollowshooterskillid
			};
		}

		// Token: 0x06019817 RID: 104471 RVA: 0x003A735F File Offset: 0x003A555F
		public IUseSkillCheckBySkillGenreT AsIUseSkillCheckBySkillGenre()
		{
			return this.As<IUseSkillCheckBySkillGenreT>();
		}

		// Token: 0x06019818 RID: 104472 RVA: 0x003A7367 File Offset: 0x003A5567
		public static TUseSkillCheckUnion FromIUseSkillCheckBySkillGenre(IUseSkillCheckBySkillGenreT _iuseskillcheckbyskillgenre)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckBySkillGenre,
				Value = _iuseskillcheckbyskillgenre
			};
		}

		// Token: 0x06019819 RID: 104473 RVA: 0x003A737C File Offset: 0x003A557C
		public IUseSkillCheckBySkillIdT AsIUseSkillCheckBySkillId()
		{
			return this.As<IUseSkillCheckBySkillIdT>();
		}

		// Token: 0x0601981A RID: 104474 RVA: 0x003A7384 File Offset: 0x003A5584
		public static TUseSkillCheckUnion FromIUseSkillCheckBySkillId(IUseSkillCheckBySkillIdT _iuseskillcheckbyskillid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckBySkillId,
				Value = _iuseskillcheckbyskillid
			};
		}

		// Token: 0x0601981B RID: 104475 RVA: 0x003A7399 File Offset: 0x003A5599
		public IUseSkillCheckByVisionShowIdT AsIUseSkillCheckByVisionShowId()
		{
			return this.As<IUseSkillCheckByVisionShowIdT>();
		}

		// Token: 0x0601981C RID: 104476 RVA: 0x003A73A1 File Offset: 0x003A55A1
		public static TUseSkillCheckUnion FromIUseSkillCheckByVisionShowId(IUseSkillCheckByVisionShowIdT _iuseskillcheckbyvisionshowid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByVisionShowId,
				Value = _iuseskillcheckbyvisionshowid
			};
		}

		// Token: 0x0601981D RID: 104477 RVA: 0x003A73B6 File Offset: 0x003A55B6
		public IUseSkillCheckByVisionSummonIdT AsIUseSkillCheckByVisionSummonId()
		{
			return this.As<IUseSkillCheckByVisionSummonIdT>();
		}

		// Token: 0x0601981E RID: 104478 RVA: 0x003A73BE File Offset: 0x003A55BE
		public static TUseSkillCheckUnion FromIUseSkillCheckByVisionSummonId(IUseSkillCheckByVisionSummonIdT _iuseskillcheckbyvisionsummonid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByVisionSummonId,
				Value = _iuseskillcheckbyvisionsummonid
			};
		}

		// Token: 0x0601981F RID: 104479 RVA: 0x003A73D4 File Offset: 0x003A55D4
		public static int Pack(FlatBufferBuilder builder, TUseSkillCheckUnion _o)
		{
			switch (_o.Type)
			{
			case TUseSkillCheck.IUseSkillCheckByFollowShooterSkillId:
				return IUseSkillCheckByFollowShooterSkillId.Pack(builder, _o.AsIUseSkillCheckByFollowShooterSkillId()).Value;
			case TUseSkillCheck.IUseSkillCheckBySkillGenre:
				return IUseSkillCheckBySkillGenre.Pack(builder, _o.AsIUseSkillCheckBySkillGenre()).Value;
			case TUseSkillCheck.IUseSkillCheckBySkillId:
				return IUseSkillCheckBySkillId.Pack(builder, _o.AsIUseSkillCheckBySkillId()).Value;
			case TUseSkillCheck.IUseSkillCheckByVisionShowId:
				return IUseSkillCheckByVisionShowId.Pack(builder, _o.AsIUseSkillCheckByVisionShowId()).Value;
			case TUseSkillCheck.IUseSkillCheckByVisionSummonId:
				return IUseSkillCheckByVisionSummonId.Pack(builder, _o.AsIUseSkillCheckByVisionSummonId()).Value;
			default:
				return 0;
			}
		}
	}
}
