using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BD RID: 29885
	public class IPlaySpineAnimationT
	{
		// Token: 0x1700DBDE RID: 56286
		// (get) Token: 0x06034617 RID: 214551 RVA: 0x0070DEE1 File Offset: 0x0070C0E1
		// (set) Token: 0x06034618 RID: 214552 RVA: 0x0070DEE9 File Offset: 0x0070C0E9
		public ESetSpineAnimation Type { get; set; }

		// Token: 0x1700DBDF RID: 56287
		// (get) Token: 0x06034619 RID: 214553 RVA: 0x0070DEF2 File Offset: 0x0070C0F2
		// (set) Token: 0x0603461A RID: 214554 RVA: 0x0070DEFA File Offset: 0x0070C0FA
		public string Name { get; set; }

		// Token: 0x1700DBE0 RID: 56288
		// (get) Token: 0x0603461B RID: 214555 RVA: 0x0070DF03 File Offset: 0x0070C103
		// (set) Token: 0x0603461C RID: 214556 RVA: 0x0070DF0B File Offset: 0x0070C10B
		public bool IsLoop { get; set; }

		// Token: 0x0603461D RID: 214557 RVA: 0x0070DF14 File Offset: 0x0070C114
		public IPlaySpineAnimationT()
		{
			this.Type = ESetSpineAnimation.Play;
			this.Name = null;
			this.IsLoop = false;
		}
	}
}
