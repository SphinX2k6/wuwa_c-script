using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007074 RID: 28788
	public class ISetSpineAnimationTypeT
	{
		// Token: 0x1700D5F7 RID: 54775
		// (get) Token: 0x06032F94 RID: 208788 RVA: 0x006E03B6 File Offset: 0x006DE5B6
		// (set) Token: 0x06032F95 RID: 208789 RVA: 0x006E03BE File Offset: 0x006DE5BE
		public ESetSpineAnimation Type { get; set; }

		// Token: 0x06032F96 RID: 208790 RVA: 0x006E03C7 File Offset: 0x006DE5C7
		public ISetSpineAnimationTypeT()
		{
			this.Type = ESetSpineAnimation.Play;
		}
	}
}
