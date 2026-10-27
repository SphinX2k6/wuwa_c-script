using System;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056BE RID: 22206
	public class PendingProcessDefine : IStaticVariableResetter
	{
		// Token: 0x060387D2 RID: 231378 RVA: 0x00D6B1A5 File Offset: 0x00D693A5
		static PendingProcessDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcessDefine.CreateStaticDefaultValue), new Action(PendingProcessDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060387D3 RID: 231379 RVA: 0x00D6B1C4 File Offset: 0x00D693C4
		public static void CreateStaticDefaultValue()
		{
			PendingProcessDefine.Id = 0;
		}

		// Token: 0x060387D4 RID: 231380 RVA: 0x00D6B1CC File Offset: 0x00D693CC
		public static void ResetStaticDefaultValue()
		{
			PendingProcessDefine.Id = 0;
		}

		// Token: 0x0401DAAD RID: 121517
		public static int Id;
	}
}
