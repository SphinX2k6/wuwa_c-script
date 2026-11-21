using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x02004896 RID: 18582
	public class InstanceDungeonDataConstants : IStaticVariableResetter
	{
		// Token: 0x0602EB4F RID: 191311 RVA: 0x00D090B9 File Offset: 0x00D072B9
		static InstanceDungeonDataConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonDataConstants.CreateStaticDefaultValue), new Action(InstanceDungeonDataConstants.ResetStaticDefaultValue));
		}

		// Token: 0x0602EB50 RID: 191312 RVA: 0x00D090D8 File Offset: 0x00D072D8
		public static void CreateStaticDefaultValue()
		{
			InstanceDungeonDataConstants.InstanceLockColor = new FColor?(FColor.FromHex("ADADAD"));
		}

		// Token: 0x0602EB51 RID: 191313 RVA: 0x00D090EE File Offset: 0x00D072EE
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonDataConstants.InstanceLockColor = null;
		}

		// Token: 0x04018D46 RID: 101702
		[Nullable(1)]
		public const string INSTANCE_LOCK = "ADADAD";

		// Token: 0x04018D47 RID: 101703
		public static FColor? InstanceLockColor;
	}
}
