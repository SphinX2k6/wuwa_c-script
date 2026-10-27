using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002592 RID: 9618
	public class IVisualNovelOptionGroupSolarSchoolExam : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600D7CB RID: 55243 RVA: 0x0020204A File Offset: 0x0020024A
		[NullableContext(1)]
		public static IVisualNovelOptionGroupSolarSchoolExam Create(IVisualNovelOptionGroupSolarSchoolExam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupSolarSchoolExam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600D7CC RID: 55244 RVA: 0x00202069 File Offset: 0x00200269
		public override EVisualNovelOptionGroupType Type
		{
			get
			{
				return (EVisualNovelOptionGroupType)this.Instance.Type;
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600D7CD RID: 55245 RVA: 0x00202078 File Offset: 0x00200278
		public virtual int? ExamImageId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ExamImageId);
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600D7CE RID: 55246 RVA: 0x002020AE File Offset: 0x002002AE
		public virtual int TrueAnswerOptionIndex
		{
			get
			{
				return this.Instance.TrueAnswerOptionIndex;
			}
		}

		// Token: 0x04007762 RID: 30562
		private IVisualNovelOptionGroupSolarSchoolExam Instance;
	}
}
