using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D78 RID: 28024
	public class IPostAkEventMusicSubtitleT
	{
		// Token: 0x1700D118 RID: 53528
		// (get) Token: 0x0603180C RID: 202764 RVA: 0x006B60E2 File Offset: 0x006B42E2
		// (set) Token: 0x0603180D RID: 202765 RVA: 0x006B60EA File Offset: 0x006B42EA
		public EPostAkEvent Type { get; set; }

		// Token: 0x1700D119 RID: 53529
		// (get) Token: 0x0603180E RID: 202766 RVA: 0x006B60F3 File Offset: 0x006B42F3
		// (set) Token: 0x0603180F RID: 202767 RVA: 0x006B60FB File Offset: 0x006B42FB
		public string MusicSubtitleGroupTag { get; set; }

		// Token: 0x1700D11A RID: 53530
		// (get) Token: 0x06031810 RID: 202768 RVA: 0x006B6104 File Offset: 0x006B4304
		// (set) Token: 0x06031811 RID: 202769 RVA: 0x006B610C File Offset: 0x006B430C
		public string AkEvent { get; set; }

		// Token: 0x1700D11B RID: 53531
		// (get) Token: 0x06031812 RID: 202770 RVA: 0x006B6115 File Offset: 0x006B4315
		// (set) Token: 0x06031813 RID: 202771 RVA: 0x006B611D File Offset: 0x006B431D
		public bool IsLoop { get; set; }

		// Token: 0x1700D11C RID: 53532
		// (get) Token: 0x06031814 RID: 202772 RVA: 0x006B6126 File Offset: 0x006B4326
		// (set) Token: 0x06031815 RID: 202773 RVA: 0x006B612E File Offset: 0x006B432E
		public bool IsEndAkEvent { get; set; }

		// Token: 0x1700D11D RID: 53533
		// (get) Token: 0x06031816 RID: 202774 RVA: 0x006B6137 File Offset: 0x006B4337
		// (set) Token: 0x06031817 RID: 202775 RVA: 0x006B613F File Offset: 0x006B433F
		public byte NullMask { get; set; }

		// Token: 0x06031818 RID: 202776 RVA: 0x006B6148 File Offset: 0x006B4348
		public IPostAkEventMusicSubtitleT()
		{
			this.Type = EPostAkEvent.Global;
			this.MusicSubtitleGroupTag = null;
			this.AkEvent = null;
			this.IsLoop = false;
			this.IsEndAkEvent = false;
			this.NullMask = 0;
		}
	}
}
