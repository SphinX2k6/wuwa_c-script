using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02007315 RID: 29461
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineModel : ModelBase
	{
		// Token: 0x06048501 RID: 296193 RVA: 0x01298F4B File Offset: 0x0129714B
		protected override bool OnInit()
		{
			this.AiStateMachineFactory = new AiStateMachineFactory();
			return true;
		}

		// Token: 0x17009F80 RID: 40832
		// (get) Token: 0x06048502 RID: 296194 RVA: 0x01298F59 File Offset: 0x01297159
		public static AiStateMachineModel Instance
		{
			get
			{
				return AiStateMachineModel._Instance;
			}
		}

		// Token: 0x06048503 RID: 296195 RVA: 0x01298F60 File Offset: 0x01297160
		public static AiStateMachineModel GetOrCreateInstance()
		{
			if (AiStateMachineModel._Instance == null)
			{
				AiStateMachineModel.CreateInstance();
			}
			return AiStateMachineModel._Instance;
		}

		// Token: 0x06048504 RID: 296196 RVA: 0x01298F74 File Offset: 0x01297174
		public static bool CreateInstance()
		{
			if (AiStateMachineModel._Instance != null)
			{
				return true;
			}
			AiStateMachineModel._Instance = new AiStateMachineModel();
			return true;
		}

		// Token: 0x06048505 RID: 296197 RVA: 0x01298F8A File Offset: 0x0129718A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06048506 RID: 296198 RVA: 0x01298F8C File Offset: 0x0129718C
		public static void ResetStaticDefaultValue()
		{
			AiStateMachineModel._Instance = null;
		}

		// Token: 0x06048507 RID: 296199 RVA: 0x01298F94 File Offset: 0x01297194
		static AiStateMachineModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AiStateMachineModel.CreateStaticDefaultValue), new Action(AiStateMachineModel.ResetStaticDefaultValue));
		}

		// Token: 0x040263B0 RID: 156592
		[Nullable(2)]
		public AiStateMachineFactory AiStateMachineFactory;

		// Token: 0x040263B1 RID: 156593
		[Nullable(2)]
		private static AiStateMachineModel _Instance;
	}
}
