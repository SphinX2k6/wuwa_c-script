using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007032 RID: 28722
	public class ISetNpcGroupPerformTypeT
	{
		// Token: 0x1700D54A RID: 54602
		// (get) Token: 0x06032CFE RID: 208126 RVA: 0x006DAB4E File Offset: 0x006D8D4E
		// (set) Token: 0x06032CFF RID: 208127 RVA: 0x006DAB56 File Offset: 0x006D8D56
		public ENpcGroupPerformType Type { get; set; }

		// Token: 0x06032D00 RID: 208128 RVA: 0x006DAB5F File Offset: 0x006D8D5F
		public ISetNpcGroupPerformTypeT()
		{
			this.Type = ENpcGroupPerformType.HandInHand;
		}
	}
}
