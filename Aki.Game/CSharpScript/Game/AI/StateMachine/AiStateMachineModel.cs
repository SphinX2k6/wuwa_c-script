using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02006498 RID: 25752
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineModel : ModelBase
	{
		// Token: 0x0603E94E RID: 256334 RVA: 0x0123B9CB File Offset: 0x01239BCB
		protected override bool OnInit()
		{
			this.AiStateMachineFactory = new AiStateMachineFactory();
			return true;
		}

		// Token: 0x1700771E RID: 30494
		// (get) Token: 0x0603E94F RID: 256335 RVA: 0x0123B9D9 File Offset: 0x01239BD9
		public static AiStateMachineModel Instance
		{
			get
			{
				return AiStateMachineModel._Instance;
			}
		}

		// Token: 0x0603E950 RID: 256336 RVA: 0x0123B9E0 File Offset: 0x01239BE0
		public static AiStateMachineModel GetOrCreateInstance()
		{
			if (AiStateMachineModel._Instance == null)
			{
				AiStateMachineModel.CreateInstance();
			}
			return AiStateMachineModel._Instance;
		}

		// Token: 0x0603E951 RID: 256337 RVA: 0x0123B9F4 File Offset: 0x01239BF4
		public static bool CreateInstance()
		{
			if (AiStateMachineModel._Instance != null)
			{
				return true;
			}
			AiStateMachineModel._Instance = new AiStateMachineModel();
			return true;
		}

		// Token: 0x0603E952 RID: 256338 RVA: 0x0123BA0A File Offset: 0x01239C0A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E953 RID: 256339 RVA: 0x0123BA0C File Offset: 0x01239C0C
		public static void ResetStaticDefaultValue()
		{
			AiStateMachineModel._Instance = null;
		}

		// Token: 0x0603E954 RID: 256340 RVA: 0x0123BA14 File Offset: 0x01239C14
		static AiStateMachineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AiStateMachineModel.CreateStaticDefaultValue), new Action(AiStateMachineModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402169D RID: 136861
		[Nullable(2)]
		public AiStateMachineFactory AiStateMachineFactory;

		// Token: 0x0402169E RID: 136862
		[Nullable(2)]
		private static AiStateMachineModel _Instance;
	}
}
