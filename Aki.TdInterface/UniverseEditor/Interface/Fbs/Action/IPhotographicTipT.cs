using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC4 RID: 27844
	public class IPhotographicTipT
	{
		// Token: 0x1700CF4B RID: 53067
		// (get) Token: 0x06031129 RID: 201001 RVA: 0x006A8E3F File Offset: 0x006A703F
		// (set) Token: 0x0603112A RID: 201002 RVA: 0x006A8E47 File Offset: 0x006A7047
		public ECommonTipType Type { get; set; }

		// Token: 0x1700CF4C RID: 53068
		// (get) Token: 0x0603112B RID: 201003 RVA: 0x006A8E50 File Offset: 0x006A7050
		// (set) Token: 0x0603112C RID: 201004 RVA: 0x006A8E58 File Offset: 0x006A7058
		public string MainText { get; set; }

		// Token: 0x0603112D RID: 201005 RVA: 0x006A8E61 File Offset: 0x006A7061
		public IPhotographicTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
		}
	}
}
