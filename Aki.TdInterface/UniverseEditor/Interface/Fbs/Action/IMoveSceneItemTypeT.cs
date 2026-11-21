using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729E RID: 29342
	public class IMoveSceneItemTypeT
	{
		// Token: 0x1700D713 RID: 55059
		// (get) Token: 0x06033226 RID: 209446 RVA: 0x006E6516 File Offset: 0x006E4716
		// (set) Token: 0x06033227 RID: 209447 RVA: 0x006E651E File Offset: 0x006E471E
		public EMoveSceneItemType Type { get; set; }

		// Token: 0x06033228 RID: 209448 RVA: 0x006E6527 File Offset: 0x006E4727
		public IMoveSceneItemTypeT()
		{
			this.Type = EMoveSceneItemType.MoveToPoint;
		}
	}
}
