using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019A7 RID: 6567
public class SmallItemGridDefine : IStaticVariableResetter
{
	// Token: 0x0600BF8D RID: 49037 RVA: 0x002B401C File Offset: 0x002B221C
	static SmallItemGridDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SmallItemGridDefine.CreateStaticDefaultValue), new Action(SmallItemGridDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600BF8E RID: 49038 RVA: 0x002B403C File Offset: 0x002B223C
	public static void CreateStaticDefaultValue()
	{
		SmallItemGridDefine.NormalResIdBySlot = new Dictionary<EMultiPlayerSlot, string>
		{
			{
				EMultiPlayerSlot.P1,
				"SP_MapFollowing1"
			},
			{
				EMultiPlayerSlot.P2,
				"SP_MapFollowing2"
			},
			{
				EMultiPlayerSlot.P3,
				"SP_MapFollowing3"
			}
		};
		SmallItemGridDefine.SelfResIdBySlot = new Dictionary<EMultiPlayerSlot, string>
		{
			{
				EMultiPlayerSlot.P1,
				"SP_Online1PIcon_Self"
			},
			{
				EMultiPlayerSlot.P2,
				"SP_Online2PIcon_Self"
			},
			{
				EMultiPlayerSlot.P3,
				"SP_Online3PIcon"
			}
		};
	}

	// Token: 0x0600BF8F RID: 49039 RVA: 0x002B40A5 File Offset: 0x002B22A5
	public static void ResetStaticDefaultValue()
	{
		SmallItemGridDefine.NormalResIdBySlot = null;
		SmallItemGridDefine.SelfResIdBySlot = null;
	}

	// Token: 0x04005629 RID: 22057
	[Nullable(1)]
	public static Dictionary<EMultiPlayerSlot, string> NormalResIdBySlot;

	// Token: 0x0400562A RID: 22058
	[Nullable(1)]
	public static Dictionary<EMultiPlayerSlot, string> SelfResIdBySlot;
}
