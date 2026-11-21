using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D89 RID: 28041
	public class IExecClientBattleActionTypeT
	{
		// Token: 0x1700CDAE RID: 52654
		// (get) Token: 0x0603064F RID: 198223 RVA: 0x006938A2 File Offset: 0x00691AA2
		// (set) Token: 0x06030650 RID: 198224 RVA: 0x006938AA File Offset: 0x00691AAA
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x06030651 RID: 198225 RVA: 0x006938B3 File Offset: 0x00691AB3
		public IExecClientBattleActionTypeT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
		}
	}
}
