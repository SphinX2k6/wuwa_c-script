using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF7 RID: 27895
	public class IPlayerInitiatorT
	{
		// Token: 0x1700CFC0 RID: 53184
		// (get) Token: 0x06031307 RID: 201479 RVA: 0x006AC59E File Offset: 0x006AA79E
		// (set) Token: 0x06031308 RID: 201480 RVA: 0x006AC5A6 File Offset: 0x006AA7A6
		public ENpcGroupPerformInitiatorType Type { get; set; }

		// Token: 0x06031309 RID: 201481 RVA: 0x006AC5AF File Offset: 0x006AA7AF
		public IPlayerInitiatorT()
		{
			this.Type = ENpcGroupPerformInitiatorType.Player;
		}
	}
}
