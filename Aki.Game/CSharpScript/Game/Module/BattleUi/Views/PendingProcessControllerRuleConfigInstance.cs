using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D69 RID: 19817
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcessControllerRuleConfigInstance : Singleton
	{
		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x06031BB2 RID: 203698 RVA: 0x00DE7A47 File Offset: 0x00DE5C47
		public static PendingProcessControllerRuleConfigInstance Instance
		{
			get
			{
				if (PendingProcessControllerRuleConfigInstance._instance == null)
				{
					PendingProcessControllerRuleConfigInstance._instance = new PendingProcessControllerRuleConfigInstance();
					PendingProcessControllerRuleConfigInstance._instance.OnInit();
				}
				return PendingProcessControllerRuleConfigInstance._instance;
			}
		}

		// Token: 0x06031BB3 RID: 203699 RVA: 0x00DE7A6A File Offset: 0x00DE5C6A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031BB4 RID: 203700 RVA: 0x00DE7A6C File Offset: 0x00DE5C6C
		public static void ResetStaticDefaultValue()
		{
			PendingProcessControllerRuleConfigInstance instance = PendingProcessControllerRuleConfigInstance._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PendingProcessControllerRuleConfigInstance._instance = null;
		}

		// Token: 0x06031BB5 RID: 203701 RVA: 0x00DE7A85 File Offset: 0x00DE5C85
		static PendingProcessControllerRuleConfigInstance()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcessControllerRuleConfigInstance.CreateStaticDefaultValue), new Action(PendingProcessControllerRuleConfigInstance.ResetStaticDefaultValue));
		}

		// Token: 0x0401A53D RID: 107837
		public readonly IReadOnlyList<PendingProcessControllerRuleConfigBase> PendingProcessExCheckList = new <>z__ReadOnlyArray<PendingProcessControllerRuleConfigBase>(new PendingProcessControllerRuleConfigBase[]
		{
			new SpringManorPendingProcessControllerRuleConfig(),
			new RecallInstancePendingProcessControllerRuleConfig()
		});

		// Token: 0x0401A53E RID: 107838
		[Nullable(2)]
		private static PendingProcessControllerRuleConfigInstance _instance;
	}
}
