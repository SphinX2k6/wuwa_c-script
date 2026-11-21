using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D62 RID: 19810
	public abstract class TPendingProcess : IStaticVariableResetter
	{
		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x06031B89 RID: 203657
		public abstract EMissionProcessType ProcessType { get; }

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x06031B8A RID: 203658
		public abstract bool IsSkipAnim { get; }

		// Token: 0x06031B8B RID: 203659 RVA: 0x00DE7234 File Offset: 0x00DE5434
		protected TPendingProcess()
		{
			this.ProcessId = ++TPendingProcess.Id;
		}

		// Token: 0x06031B8C RID: 203660 RVA: 0x00DE724F File Offset: 0x00DE544F
		static TPendingProcess()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TPendingProcess.CreateStaticDefaultValue), new Action(TPendingProcess.ResetStaticDefaultValue));
		}

		// Token: 0x06031B8D RID: 203661 RVA: 0x00DE726E File Offset: 0x00DE546E
		public static void CreateStaticDefaultValue()
		{
			TPendingProcess.Id = 0;
		}

		// Token: 0x06031B8E RID: 203662 RVA: 0x00DE7276 File Offset: 0x00DE5476
		public static void ResetStaticDefaultValue()
		{
			TPendingProcess.Id = 0;
		}

		// Token: 0x0401A524 RID: 107812
		private static int Id;

		// Token: 0x0401A525 RID: 107813
		public readonly int ProcessId;
	}
}
