using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004792 RID: 18322
	public class TUseSkillCheckUnion
	{
		// Token: 0x17007FB7 RID: 32695
		// (get) Token: 0x0601AF9D RID: 110493 RVA: 0x003D2D20 File Offset: 0x003D0F20
		// (set) Token: 0x0601AF9E RID: 110494 RVA: 0x003D2D28 File Offset: 0x003D0F28
		public TUseSkillCheck Type { get; set; }

		// Token: 0x17007FB8 RID: 32696
		// (get) Token: 0x0601AF9F RID: 110495 RVA: 0x003D2D31 File Offset: 0x003D0F31
		// (set) Token: 0x0601AFA0 RID: 110496 RVA: 0x003D2D39 File Offset: 0x003D0F39
		public object Value { get; set; }

		// Token: 0x0601AFA1 RID: 110497 RVA: 0x003D2D42 File Offset: 0x003D0F42
		public TUseSkillCheckUnion()
		{
			this.Type = TUseSkillCheck.NONE;
			this.Value = null;
		}

		// Token: 0x0601AFA2 RID: 110498 RVA: 0x003D2D58 File Offset: 0x003D0F58
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AFA3 RID: 110499 RVA: 0x003D2D6A File Offset: 0x003D0F6A
		public IUseSkillCheckByFollowShooterSkillIdT AsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.As<IUseSkillCheckByFollowShooterSkillIdT>();
		}

		// Token: 0x0601AFA4 RID: 110500 RVA: 0x003D2D72 File Offset: 0x003D0F72
		public static TUseSkillCheckUnion FromIUseSkillCheckByFollowShooterSkillId(IUseSkillCheckByFollowShooterSkillIdT _iuseskillcheckbyfollowshooterskillid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByFollowShooterSkillId,
				Value = _iuseskillcheckbyfollowshooterskillid
			};
		}

		// Token: 0x0601AFA5 RID: 110501 RVA: 0x003D2D87 File Offset: 0x003D0F87
		public IUseSkillCheckBySkillGenreT AsIUseSkillCheckBySkillGenre()
		{
			return this.As<IUseSkillCheckBySkillGenreT>();
		}

		// Token: 0x0601AFA6 RID: 110502 RVA: 0x003D2D8F File Offset: 0x003D0F8F
		public static TUseSkillCheckUnion FromIUseSkillCheckBySkillGenre(IUseSkillCheckBySkillGenreT _iuseskillcheckbyskillgenre)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckBySkillGenre,
				Value = _iuseskillcheckbyskillgenre
			};
		}

		// Token: 0x0601AFA7 RID: 110503 RVA: 0x003D2DA4 File Offset: 0x003D0FA4
		public IUseSkillCheckBySkillIdT AsIUseSkillCheckBySkillId()
		{
			return this.As<IUseSkillCheckBySkillIdT>();
		}

		// Token: 0x0601AFA8 RID: 110504 RVA: 0x003D2DAC File Offset: 0x003D0FAC
		public static TUseSkillCheckUnion FromIUseSkillCheckBySkillId(IUseSkillCheckBySkillIdT _iuseskillcheckbyskillid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckBySkillId,
				Value = _iuseskillcheckbyskillid
			};
		}

		// Token: 0x0601AFA9 RID: 110505 RVA: 0x003D2DC1 File Offset: 0x003D0FC1
		public IUseSkillCheckByVisionShowIdT AsIUseSkillCheckByVisionShowId()
		{
			return this.As<IUseSkillCheckByVisionShowIdT>();
		}

		// Token: 0x0601AFAA RID: 110506 RVA: 0x003D2DC9 File Offset: 0x003D0FC9
		public static TUseSkillCheckUnion FromIUseSkillCheckByVisionShowId(IUseSkillCheckByVisionShowIdT _iuseskillcheckbyvisionshowid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByVisionShowId,
				Value = _iuseskillcheckbyvisionshowid
			};
		}

		// Token: 0x0601AFAB RID: 110507 RVA: 0x003D2DDE File Offset: 0x003D0FDE
		public IUseSkillCheckByVisionSummonIdT AsIUseSkillCheckByVisionSummonId()
		{
			return this.As<IUseSkillCheckByVisionSummonIdT>();
		}

		// Token: 0x0601AFAC RID: 110508 RVA: 0x003D2DE6 File Offset: 0x003D0FE6
		public static TUseSkillCheckUnion FromIUseSkillCheckByVisionSummonId(IUseSkillCheckByVisionSummonIdT _iuseskillcheckbyvisionsummonid)
		{
			return new TUseSkillCheckUnion
			{
				Type = TUseSkillCheck.IUseSkillCheckByVisionSummonId,
				Value = _iuseskillcheckbyvisionsummonid
			};
		}

		// Token: 0x0601AFAD RID: 110509 RVA: 0x003D2DFC File Offset: 0x003D0FFC
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
