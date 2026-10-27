using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058BE RID: 22718
	public class InstanceDungeonDataConstants : IStaticVariableResetter
	{
		// Token: 0x06039C2C RID: 236588 RVA: 0x00DBA1A1 File Offset: 0x00DB83A1
		static InstanceDungeonDataConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonDataConstants.CreateStaticDefaultValue), new Action(InstanceDungeonDataConstants.ResetStaticDefaultValue));
		}

		// Token: 0x06039C2D RID: 236589 RVA: 0x00DBA1C0 File Offset: 0x00DB83C0
		public static void CreateStaticDefaultValue()
		{
			InstanceDungeonDataConstants.InstanceLockColor = new FColor?(FColor.FromHex("ADADAD"));
		}

		// Token: 0x06039C2E RID: 236590 RVA: 0x00DBA1D6 File Offset: 0x00DB83D6
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonDataConstants.InstanceLockColor = null;
		}

		// Token: 0x0401E2A9 RID: 123561
		[Nullable(1)]
		public const string INSTANCE_LOCK = "ADADAD";

		// Token: 0x0401E2AA RID: 123562
		public static FColor? InstanceLockColor;
	}
}
