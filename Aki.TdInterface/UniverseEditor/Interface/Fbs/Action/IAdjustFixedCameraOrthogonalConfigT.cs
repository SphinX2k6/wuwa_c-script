using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006150 RID: 24912
	public class IAdjustFixedCameraOrthogonalConfigT
	{
		// Token: 0x1700B8CC RID: 47308
		// (get) Token: 0x0602AC42 RID: 175170 RVA: 0x005E54AF File Offset: 0x005E36AF
		// (set) Token: 0x0602AC43 RID: 175171 RVA: 0x005E54B7 File Offset: 0x005E36B7
		public IVectorInfoT BasePoint { get; set; }

		// Token: 0x1700B8CD RID: 47309
		// (get) Token: 0x0602AC44 RID: 175172 RVA: 0x005E54C0 File Offset: 0x005E36C0
		// (set) Token: 0x0602AC45 RID: 175173 RVA: 0x005E54C8 File Offset: 0x005E36C8
		public float FadeInTime { get; set; }

		// Token: 0x1700B8CE RID: 47310
		// (get) Token: 0x0602AC46 RID: 175174 RVA: 0x005E54D1 File Offset: 0x005E36D1
		// (set) Token: 0x0602AC47 RID: 175175 RVA: 0x005E54D9 File Offset: 0x005E36D9
		public float FadeOutTime { get; set; }

		// Token: 0x1700B8CF RID: 47311
		// (get) Token: 0x0602AC48 RID: 175176 RVA: 0x005E54E2 File Offset: 0x005E36E2
		// (set) Token: 0x0602AC49 RID: 175177 RVA: 0x005E54EA File Offset: 0x005E36EA
		public byte NullMask { get; set; }

		// Token: 0x0602AC4A RID: 175178 RVA: 0x005E54F3 File Offset: 0x005E36F3
		public IAdjustFixedCameraOrthogonalConfigT()
		{
			this.BasePoint = null;
			this.FadeInTime = 0f;
			this.FadeOutTime = 0f;
			this.NullMask = 0;
		}
	}
}
