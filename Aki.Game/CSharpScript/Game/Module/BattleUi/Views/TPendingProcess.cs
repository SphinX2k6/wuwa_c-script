using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D80 RID: 23936
	public abstract class TPendingProcess : IStaticVariableResetter
	{
		// Token: 0x17008E53 RID: 36435
		// (get) Token: 0x0603CC2D RID: 248877
		public abstract EMissionProcessType ProcessType { get; }

		// Token: 0x17008E54 RID: 36436
		// (get) Token: 0x0603CC2E RID: 248878
		public abstract bool IsSkipAnim { get; }

		// Token: 0x0603CC2F RID: 248879 RVA: 0x00E969EC File Offset: 0x00E94BEC
		protected TPendingProcess()
		{
			this.ProcessId = ++TPendingProcess.Id;
		}

		// Token: 0x0603CC30 RID: 248880 RVA: 0x00E96A07 File Offset: 0x00E94C07
		static TPendingProcess()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TPendingProcess.CreateStaticDefaultValue), new Action(TPendingProcess.ResetStaticDefaultValue));
		}

		// Token: 0x0603CC31 RID: 248881 RVA: 0x00E96A26 File Offset: 0x00E94C26
		public static void CreateStaticDefaultValue()
		{
			TPendingProcess.Id = 0;
		}

		// Token: 0x0603CC32 RID: 248882 RVA: 0x00E96A2E File Offset: 0x00E94C2E
		public static void ResetStaticDefaultValue()
		{
			TPendingProcess.Id = 0;
		}

		// Token: 0x0401FA6C RID: 129644
		private static int Id;

		// Token: 0x0401FA6D RID: 129645
		public readonly int ProcessId;
	}
}
