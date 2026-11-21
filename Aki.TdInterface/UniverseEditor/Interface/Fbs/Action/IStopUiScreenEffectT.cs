using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C9 RID: 31177
	public class IStopUiScreenEffectT
	{
		// Token: 0x1700E49A RID: 58522
		// (get) Token: 0x06036EF2 RID: 225010 RVA: 0x00758725 File Offset: 0x00756925
		// (set) Token: 0x06036EF3 RID: 225011 RVA: 0x0075872D File Offset: 0x0075692D
		public string EffectDaPath { get; set; }

		// Token: 0x06036EF4 RID: 225012 RVA: 0x00758736 File Offset: 0x00756936
		public IStopUiScreenEffectT()
		{
			this.EffectDaPath = null;
		}
	}
}
