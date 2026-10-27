using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004248 RID: 16968
	public class IUseSkillCheckBase_UnionUnion
	{
		// Token: 0x17007876 RID: 30838
		// (get) Token: 0x0601917D RID: 102781 RVA: 0x0039BBFD File Offset: 0x00399DFD
		// (set) Token: 0x0601917E RID: 102782 RVA: 0x0039BC05 File Offset: 0x00399E05
		public IUseSkillCheckBase_Union Type { get; set; }

		// Token: 0x17007877 RID: 30839
		// (get) Token: 0x0601917F RID: 102783 RVA: 0x0039BC0E File Offset: 0x00399E0E
		// (set) Token: 0x06019180 RID: 102784 RVA: 0x0039BC16 File Offset: 0x00399E16
		public object Value { get; set; }

		// Token: 0x06019181 RID: 102785 RVA: 0x0039BC1F File Offset: 0x00399E1F
		public IUseSkillCheckBase_UnionUnion()
		{
			this.Type = IUseSkillCheckBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019182 RID: 102786 RVA: 0x0039BC35 File Offset: 0x00399E35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x0039BC47 File Offset: 0x00399E47
		public IUseSkillCheckBaseT AsIUseSkillCheckBase()
		{
			return this.As<IUseSkillCheckBaseT>();
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x0039BC4F File Offset: 0x00399E4F
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBase(IUseSkillCheckBaseT _iuseskillcheckbase)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBase,
				Value = _iuseskillcheckbase
			};
		}

		// Token: 0x06019185 RID: 102789 RVA: 0x0039BC64 File Offset: 0x00399E64
		public IUseSkillCheckBySkillGenreT AsIUseSkillCheckBySkillGenre()
		{
			return this.As<IUseSkillCheckBySkillGenreT>();
		}

		// Token: 0x06019186 RID: 102790 RVA: 0x0039BC6C File Offset: 0x00399E6C
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBySkillGenre(IUseSkillCheckBySkillGenreT _iuseskillcheckbyskillgenre)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBySkillGenre,
				Value = _iuseskillcheckbyskillgenre
			};
		}

		// Token: 0x06019187 RID: 102791 RVA: 0x0039BC81 File Offset: 0x00399E81
		public IUseSkillCheckBySkillIdT AsIUseSkillCheckBySkillId()
		{
			return this.As<IUseSkillCheckBySkillIdT>();
		}

		// Token: 0x06019188 RID: 102792 RVA: 0x0039BC89 File Offset: 0x00399E89
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckBySkillId(IUseSkillCheckBySkillIdT _iuseskillcheckbyskillid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckBySkillId,
				Value = _iuseskillcheckbyskillid
			};
		}

		// Token: 0x06019189 RID: 102793 RVA: 0x0039BC9E File Offset: 0x00399E9E
		public IUseSkillCheckByVisionSummonIdT AsIUseSkillCheckByVisionSummonId()
		{
			return this.As<IUseSkillCheckByVisionSummonIdT>();
		}

		// Token: 0x0601918A RID: 102794 RVA: 0x0039BCA6 File Offset: 0x00399EA6
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByVisionSummonId(IUseSkillCheckByVisionSummonIdT _iuseskillcheckbyvisionsummonid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByVisionSummonId,
				Value = _iuseskillcheckbyvisionsummonid
			};
		}

		// Token: 0x0601918B RID: 102795 RVA: 0x0039BCBB File Offset: 0x00399EBB
		public IUseSkillCheckByVisionShowIdT AsIUseSkillCheckByVisionShowId()
		{
			return this.As<IUseSkillCheckByVisionShowIdT>();
		}

		// Token: 0x0601918C RID: 102796 RVA: 0x0039BCC3 File Offset: 0x00399EC3
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByVisionShowId(IUseSkillCheckByVisionShowIdT _iuseskillcheckbyvisionshowid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByVisionShowId,
				Value = _iuseskillcheckbyvisionshowid
			};
		}

		// Token: 0x0601918D RID: 102797 RVA: 0x0039BCD8 File Offset: 0x00399ED8
		public IUseSkillCheckByFollowShooterSkillIdT AsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.As<IUseSkillCheckByFollowShooterSkillIdT>();
		}

		// Token: 0x0601918E RID: 102798 RVA: 0x0039BCE0 File Offset: 0x00399EE0
		public static IUseSkillCheckBase_UnionUnion FromIUseSkillCheckByFollowShooterSkillId(IUseSkillCheckByFollowShooterSkillIdT _iuseskillcheckbyfollowshooterskillid)
		{
			return new IUseSkillCheckBase_UnionUnion
			{
				Type = IUseSkillCheckBase_Union.IUseSkillCheckByFollowShooterSkillId,
				Value = _iuseskillcheckbyfollowshooterskillid
			};
		}

		// Token: 0x0601918F RID: 102799 RVA: 0x0039BCF8 File Offset: 0x00399EF8
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
