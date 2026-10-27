using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005374 RID: 21364
	[NullableContext(2)]
	[Nullable(0)]
	public class MusicalInstrumentQteData
	{
		// Token: 0x17008355 RID: 33621
		// (get) Token: 0x0603694C RID: 223564 RVA: 0x00CECB18 File Offset: 0x00CEAD18
		// (set) Token: 0x0603694D RID: 223565 RVA: 0x00CECB20 File Offset: 0x00CEAD20
		public EInstrumentType InstrumentType { get; set; }

		// Token: 0x17008356 RID: 33622
		// (get) Token: 0x0603694E RID: 223566 RVA: 0x00CECB29 File Offset: 0x00CEAD29
		// (set) Token: 0x0603694F RID: 223567 RVA: 0x00CECB31 File Offset: 0x00CEAD31
		public int QteId { get; set; }

		// Token: 0x17008357 RID: 33623
		// (get) Token: 0x06036950 RID: 223568 RVA: 0x00CECB3A File Offset: 0x00CEAD3A
		// (set) Token: 0x06036951 RID: 223569 RVA: 0x00CECB42 File Offset: 0x00CEAD42
		[Nullable(1)]
		public List<MusicalInstrumentQteItemData> ItemDataList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008358 RID: 33624
		// (get) Token: 0x06036952 RID: 223570 RVA: 0x00CECB4B File Offset: 0x00CEAD4B
		// (set) Token: 0x06036953 RID: 223571 RVA: 0x00CECB53 File Offset: 0x00CEAD53
		public string AudioEvent { get; set; }

		// Token: 0x17008359 RID: 33625
		// (get) Token: 0x06036954 RID: 223572 RVA: 0x00CECB5C File Offset: 0x00CEAD5C
		// (set) Token: 0x06036955 RID: 223573 RVA: 0x00CECB64 File Offset: 0x00CEAD64
		public Action<bool> FinishCallback { get; set; }
	}
}
