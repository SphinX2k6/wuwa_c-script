using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EF RID: 26863
	public class IHideHighlightExploreSkillIconT
	{
		// Token: 0x1700C751 RID: 51025
		// (get) Token: 0x0602EDD5 RID: 191957 RVA: 0x00664BA6 File Offset: 0x00662DA6
		// (set) Token: 0x0602EDD6 RID: 191958 RVA: 0x00664BAE File Offset: 0x00662DAE
		public EHighlightExploreSkillIconType Type { get; set; }

		// Token: 0x1700C752 RID: 51026
		// (get) Token: 0x0602EDD7 RID: 191959 RVA: 0x00664BB7 File Offset: 0x00662DB7
		// (set) Token: 0x0602EDD8 RID: 191960 RVA: 0x00664BBF File Offset: 0x00662DBF
		public EHighlightType HighlightType { get; set; }

		// Token: 0x1700C753 RID: 51027
		// (get) Token: 0x0602EDD9 RID: 191961 RVA: 0x00664BC8 File Offset: 0x00662DC8
		// (set) Token: 0x0602EDDA RID: 191962 RVA: 0x00664BD0 File Offset: 0x00662DD0
		public byte NullMask { get; set; }

		// Token: 0x0602EDDB RID: 191963 RVA: 0x00664BD9 File Offset: 0x00662DD9
		public IHideHighlightExploreSkillIconT()
		{
			this.Type = EHighlightExploreSkillIconType.Show;
			this.HighlightType = EHighlightType.CommonWhite;
			this.NullMask = 0;
		}
	}
}
