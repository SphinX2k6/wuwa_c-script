using System;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C8C RID: 19596
	public class VisibleStateUtil : IStaticVariableResetter
	{
		// Token: 0x06030E27 RID: 200231 RVA: 0x00DA25F4 File Offset: 0x00DA07F4
		public static int SetVisible(int visibleState, bool bVisible, int type = 0)
		{
			if (bVisible)
			{
				return visibleState & ~(1 << type);
			}
			return visibleState | 1 << type;
		}

		// Token: 0x06030E28 RID: 200232 RVA: 0x00DA260B File Offset: 0x00DA080B
		public static bool GetVisible(int visibleState)
		{
			return visibleState == 0;
		}

		// Token: 0x06030E29 RID: 200233 RVA: 0x00DA2611 File Offset: 0x00DA0811
		public static bool GetVisibleByType(int visibleState, int type)
		{
			return (visibleState & 1 << type) == 0;
		}

		// Token: 0x06030E2A RID: 200234 RVA: 0x00DA261E File Offset: 0x00DA081E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030E2B RID: 200235 RVA: 0x00DA2620 File Offset: 0x00DA0820
		public static void ResetStaticDefaultValue()
		{
		}
	}
}
