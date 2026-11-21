using System;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x02004695 RID: 18069
	public class PendingProcessDefine : IStaticVariableResetter
	{
		// Token: 0x0602D6D9 RID: 186073 RVA: 0x00CB92ED File Offset: 0x00CB74ED
		static PendingProcessDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcessDefine.CreateStaticDefaultValue), new Action(PendingProcessDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602D6DA RID: 186074 RVA: 0x00CB930C File Offset: 0x00CB750C
		public static void CreateStaticDefaultValue()
		{
			PendingProcessDefine.Id = 0;
		}

		// Token: 0x0602D6DB RID: 186075 RVA: 0x00CB9314 File Offset: 0x00CB7514
		public static void ResetStaticDefaultValue()
		{
			PendingProcessDefine.Id = 0;
		}

		// Token: 0x0401853A RID: 99642
		public static int Id;
	}
}
