using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052AD RID: 21165
	public class IFollowTrackEndTypeT
	{
		// Token: 0x17009B38 RID: 39736
		// (get) Token: 0x06022823 RID: 141347 RVA: 0x004C89C6 File Offset: 0x004C6BC6
		// (set) Token: 0x06022824 RID: 141348 RVA: 0x004C89CE File Offset: 0x004C6BCE
		public EFollowTrackEndType Type { get; set; }

		// Token: 0x06022825 RID: 141349 RVA: 0x004C89D7 File Offset: 0x004C6BD7
		public IFollowTrackEndTypeT()
		{
			this.Type = EFollowTrackEndType.ToStart;
		}
	}
}
