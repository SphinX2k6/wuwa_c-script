using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007915 RID: 30997
	public class ISlideRailEndTypeT
	{
		// Token: 0x1700E35F RID: 58207
		// (get) Token: 0x0603694A RID: 223562 RVA: 0x0074E236 File Offset: 0x0074C436
		// (set) Token: 0x0603694B RID: 223563 RVA: 0x0074E23E File Offset: 0x0074C43E
		public ESlideRailEndType Type { get; set; }

		// Token: 0x0603694C RID: 223564 RVA: 0x0074E247 File Offset: 0x0074C447
		public ISlideRailEndTypeT()
		{
			this.Type = ESlideRailEndType.Player;
		}
	}
}
