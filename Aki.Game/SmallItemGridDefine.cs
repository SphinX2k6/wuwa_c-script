using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E65 RID: 3685
public class SmallItemGridDefine : IStaticVariableResetter
{
	// Token: 0x06009397 RID: 37783 RVA: 0x002BEFAB File Offset: 0x002BD1AB
	static SmallItemGridDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SmallItemGridDefine.CreateStaticDefaultValue), new Action(SmallItemGridDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06009398 RID: 37784 RVA: 0x002BEFCC File Offset: 0x002BD1CC
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

	// Token: 0x06009399 RID: 37785 RVA: 0x002BF035 File Offset: 0x002BD235
	public static void ResetStaticDefaultValue()
	{
		SmallItemGridDefine.NormalResIdBySlot = null;
		SmallItemGridDefine.SelfResIdBySlot = null;
	}

	// Token: 0x040056DB RID: 22235
	[Nullable(1)]
	public static Dictionary<EMultiPlayerSlot, string> NormalResIdBySlot;

	// Token: 0x040056DC RID: 22236
	[Nullable(1)]
	public static Dictionary<EMultiPlayerSlot, string> SelfResIdBySlot;
}
