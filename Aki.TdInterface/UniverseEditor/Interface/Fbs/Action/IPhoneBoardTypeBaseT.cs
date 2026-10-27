using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C9D RID: 27805
	public class IPhoneBoardTypeBaseT
	{
		// Token: 0x1700CF10 RID: 53008
		// (get) Token: 0x0603100D RID: 200717 RVA: 0x006A6F32 File Offset: 0x006A5132
		// (set) Token: 0x0603100E RID: 200718 RVA: 0x006A6F3A File Offset: 0x006A513A
		public EPhoneBoardType Type { get; set; }

		// Token: 0x0603100F RID: 200719 RVA: 0x006A6F43 File Offset: 0x006A5143
		public IPhoneBoardTypeBaseT()
		{
			this.Type = EPhoneBoardType.MessageBoard;
		}
	}
}
