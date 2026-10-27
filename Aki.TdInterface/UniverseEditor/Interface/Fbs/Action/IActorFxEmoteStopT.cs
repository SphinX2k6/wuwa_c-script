using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B4 RID: 24756
	public class IActorFxEmoteStopT
	{
		// Token: 0x1700B677 RID: 46711
		// (get) Token: 0x0602A450 RID: 173136 RVA: 0x005D3B97 File Offset: 0x005D1D97
		// (set) Token: 0x0602A451 RID: 173137 RVA: 0x005D3B9F File Offset: 0x005D1D9F
		public EActorFxEmoteType Type { get; set; }

		// Token: 0x1700B678 RID: 46712
		// (get) Token: 0x0602A452 RID: 173138 RVA: 0x005D3BA8 File Offset: 0x005D1DA8
		// (set) Token: 0x0602A453 RID: 173139 RVA: 0x005D3BB0 File Offset: 0x005D1DB0
		public TActorFxEmoteStopSubTypeUnion StopType { get; set; }

		// Token: 0x1700B679 RID: 46713
		// (get) Token: 0x0602A454 RID: 173140 RVA: 0x005D3BB9 File Offset: 0x005D1DB9
		// (set) Token: 0x0602A455 RID: 173141 RVA: 0x005D3BC1 File Offset: 0x005D1DC1
		public float DelayTime { get; set; }

		// Token: 0x1700B67A RID: 46714
		// (get) Token: 0x0602A456 RID: 173142 RVA: 0x005D3BCA File Offset: 0x005D1DCA
		// (set) Token: 0x0602A457 RID: 173143 RVA: 0x005D3BD2 File Offset: 0x005D1DD2
		public byte NullMask { get; set; }

		// Token: 0x0602A458 RID: 173144 RVA: 0x005D3BDB File Offset: 0x005D1DDB
		public IActorFxEmoteStopT()
		{
			this.Type = EActorFxEmoteType.Play;
			this.StopType = null;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
