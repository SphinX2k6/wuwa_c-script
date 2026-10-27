using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200258F RID: 9615
	public class IVisualNovelActivityActionSolarSchool : IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600D7BF RID: 55231 RVA: 0x00201F36 File Offset: 0x00200136
		[NullableContext(1)]
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

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600D7C0 RID: 55232 RVA: 0x00201F55 File Offset: 0x00200155
		public override EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600D7C1 RID: 55233 RVA: 0x00201F62 File Offset: 0x00200162
		public virtual int SolarSchoolActionId
		{
			get
			{
				return this.Instance.SolarSchoolActionId;
			}
		}

		// Token: 0x0400775D RID: 30557
		private IVisualNovelActivityActionSolarSchool Instance;
	}
}
