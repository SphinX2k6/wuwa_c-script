using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007840 RID: 30784
	public class ISetSpineAnimationTypeT
	{
		// Token: 0x1700E1DA RID: 57818
		// (get) Token: 0x06036235 RID: 221749 RVA: 0x0074096A File Offset: 0x0073EB6A
		// (set) Token: 0x06036236 RID: 221750 RVA: 0x00740972 File Offset: 0x0073EB72
		public ESetSpineAnimation Type { get; set; }

		// Token: 0x06036237 RID: 221751 RVA: 0x0074097B File Offset: 0x0073EB7B
		public ISetSpineAnimationTypeT()
		{
			this.Type = ESetSpineAnimation.Play;
		}
	}
}
