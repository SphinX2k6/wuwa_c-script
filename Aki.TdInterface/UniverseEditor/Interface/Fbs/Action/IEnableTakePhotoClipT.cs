using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D11 RID: 27921
	public class IEnableTakePhotoClipT
	{
		// Token: 0x1700CCE1 RID: 52449
		// (get) Token: 0x06030282 RID: 197250 RVA: 0x0068C8BA File Offset: 0x0068AABA
		// (set) Token: 0x06030283 RID: 197251 RVA: 0x0068C8C2 File Offset: 0x0068AAC2
		public bool Enable { get; set; }

		// Token: 0x06030284 RID: 197252 RVA: 0x0068C8CB File Offset: 0x0068AACB
		public IEnableTakePhotoClipT()
		{
			this.Enable = false;
		}
	}
}
