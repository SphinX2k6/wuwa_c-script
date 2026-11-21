using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F72 RID: 20338
	public class ICheckIsTrackingCurrentQuestT
	{
		// Token: 0x17009165 RID: 37221
		// (get) Token: 0x0601FA9D RID: 129693 RVA: 0x004670EA File Offset: 0x004652EA
		// (set) Token: 0x0601FA9E RID: 129694 RVA: 0x004670F2 File Offset: 0x004652F2
		public ECondition Type { get; set; }

		// Token: 0x0601FA9F RID: 129695 RVA: 0x004670FB File Offset: 0x004652FB
		public ICheckIsTrackingCurrentQuestT()
		{
			this.Type = ECondition.CompareVar;
		}
	}
}
