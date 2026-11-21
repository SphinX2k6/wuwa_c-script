using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283D RID: 10301
	public class IVisualNovelActivityActionSolarSchool : IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600E539 RID: 58681 RVA: 0x0021DC6A File Offset: 0x0021BE6A
		public static IVisualNovelActivityActionSolarSchool Create(IVisualNovelActivityActionSolarSchool? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionSolarSchool
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x0600E53A RID: 58682 RVA: 0x0021DC89 File Offset: 0x0021BE89
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x0600E53B RID: 58683 RVA: 0x0021DC96 File Offset: 0x0021BE96
		public virtual int SolarSchoolActionId
		{
			get
			{
				return this.Instance.SolarSchoolActionId;
			}
		}

		// Token: 0x04007DC3 RID: 32195
		private IVisualNovelActivityActionSolarSchool Instance;
	}
}
