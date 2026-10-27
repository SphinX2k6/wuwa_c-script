using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D87 RID: 23943
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcessControllerRuleConfigInstance : Singleton
	{
		// Token: 0x17008E60 RID: 36448
		// (get) Token: 0x0603CC56 RID: 248918 RVA: 0x00E971FF File Offset: 0x00E953FF
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

		// Token: 0x0603CC57 RID: 248919 RVA: 0x00E97222 File Offset: 0x00E95422
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CC58 RID: 248920 RVA: 0x00E97224 File Offset: 0x00E95424
		public static void ResetStaticDefaultValue()
		{
			PendingProcessControllerRuleConfigInstance instance = PendingProcessControllerRuleConfigInstance._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PendingProcessControllerRuleConfigInstance._instance = null;
		}

		// Token: 0x0603CC59 RID: 248921 RVA: 0x00E9723D File Offset: 0x00E9543D
		static PendingProcessControllerRuleConfigInstance()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PendingProcessControllerRuleConfigInstance.CreateStaticDefaultValue), new Action(PendingProcessControllerRuleConfigInstance.ResetStaticDefaultValue));
		}

		// Token: 0x0401FA85 RID: 129669
		public readonly IReadOnlyList<PendingProcessControllerRuleConfigBase> PendingProcessExCheckList = new <>z__ReadOnlyArray<PendingProcessControllerRuleConfigBase>(new PendingProcessControllerRuleConfigBase[]
		{
			new SpringManorPendingProcessControllerRuleConfig(),
			new RecallInstancePendingProcessControllerRuleConfig()
		});

		// Token: 0x0401FA86 RID: 129670
		[Nullable(2)]
		private static PendingProcessControllerRuleConfigInstance _instance;
	}
}
