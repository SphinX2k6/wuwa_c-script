using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002077 RID: 8311
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelOptionGroupSolarSchoolExam : IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600B686 RID: 46726 RVA: 0x001A7144 File Offset: 0x001A5344
		private IVisualNovelOptionGroupSolarSchoolExam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelOptionGroupSolarSchoolExam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelOptionGroupSolarSchoolExam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelOptionGroupSolarSchoolExam_SetValue());
			}
			return result;
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x001A717C File Offset: 0x001A537C
		public static IVisualNovelOptionGroupSolarSchoolExam Create([Nullable(2)] IVisualNovelOptionGroupSolarSchoolExam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupSolarSchoolExam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x001A718F File Offset: 0x001A538F
		public static IVisualNovelOptionGroupSolarSchoolExam CreateFromSetValue([Nullable(2)] IVisualNovelOptionGroupSolarSchoolExam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupSolarSchoolExam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x001A71A2 File Offset: 0x001A53A2
		public new IVisualNovelOptionGroupSolarSchoolExam_SetValue ToSetValue()
		{
			return new IVisualNovelOptionGroupSolarSchoolExam_SetValue
			{
				Type = this.Type,
				ExamImageId = this.ExamImageId,
				TrueAnswerOptionIndex = this.TrueAnswerOptionIndex
			};
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600B68A RID: 46730 RVA: 0x001A71CD File Offset: 0x001A53CD
		// (set) Token: 0x0600B68B RID: 46731 RVA: 0x001A71F8 File Offset: 0x001A53F8
		public override EVisualNovelOptionGroupType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelOptionGroupType.SolarSchoolExam;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600B68C RID: 46732 RVA: 0x001A7208 File Offset: 0x001A5408
		// (set) Token: 0x0600B68D RID: 46733 RVA: 0x001A7242 File Offset: 0x001A5442
		public virtual int? ExamImageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExamImageId;
				}
				IVisualNovelOptionGroupSolarSchoolExam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExamImageId;
			}
			set
			{
				this.GetOrCreatePoco().ExamImageId = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600B68E RID: 46734 RVA: 0x001A7250 File Offset: 0x001A5450
		// (set) Token: 0x0600B68F RID: 46735 RVA: 0x001A727B File Offset: 0x001A547B
		public virtual int TrueAnswerOptionIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrueAnswerOptionIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrueAnswerOptionIndex;
			}
			set
			{
				this.GetOrCreatePoco().TrueAnswerOptionIndex = value;
			}
		}

		// Token: 0x04006D9E RID: 28062
		[Nullable(2)]
		protected new IVisualNovelOptionGroupSolarSchoolExam FbInstance;

		// Token: 0x04006D9F RID: 28063
		[Nullable(2)]
		protected new IVisualNovelOptionGroupSolarSchoolExam_SetValue PocoInterface;
	}
}
