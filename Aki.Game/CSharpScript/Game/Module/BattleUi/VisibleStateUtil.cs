using System;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005CAA RID: 23722
	public class VisibleStateUtil : IStaticVariableResetter
	{
		// Token: 0x0603BED4 RID: 245460 RVA: 0x00E51F4C File Offset: 0x00E5014C
		public static int SetVisible(int visibleState, bool bVisible, int type = 0)
		{
			if (bVisible)
			{
				return visibleState & ~(1 << type);
			}
			return visibleState | 1 << type;
		}

		// Token: 0x0603BED5 RID: 245461 RVA: 0x00E51F63 File Offset: 0x00E50163
		public static bool GetVisible(int visibleState)
		{
			return visibleState == 0;
		}

		// Token: 0x0603BED6 RID: 245462 RVA: 0x00E51F69 File Offset: 0x00E50169
		public static bool GetVisibleByType(int visibleState, int type)
		{
			return (visibleState & 1 << type) == 0;
		}

		// Token: 0x0603BED7 RID: 245463 RVA: 0x00E51F76 File Offset: 0x00E50176
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BED8 RID: 245464 RVA: 0x00E51F78 File Offset: 0x00E50178
		public static void ResetStaticDefaultValue()
		{
		}
	}
}
