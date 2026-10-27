using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E89 RID: 28297
	public class IResetFocusConfigT
	{
		// Token: 0x1700D2B7 RID: 53943
		// (get) Token: 0x0603202B RID: 204843 RVA: 0x006C3B87 File Offset: 0x006C1D87
		// (set) Token: 0x0603202C RID: 204844 RVA: 0x006C3B8F File Offset: 0x006C1D8F
		public float FadeInTime { get; set; }

		// Token: 0x1700D2B8 RID: 53944
		// (get) Token: 0x0603202D RID: 204845 RVA: 0x006C3B98 File Offset: 0x006C1D98
		// (set) Token: 0x0603202E RID: 204846 RVA: 0x006C3BA0 File Offset: 0x006C1DA0
		public IBaseCurveT FadeInCurve { get; set; }

		// Token: 0x0603202F RID: 204847 RVA: 0x006C3BA9 File Offset: 0x006C1DA9
		public IResetFocusConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeInCurve = null;
		}
	}
}
