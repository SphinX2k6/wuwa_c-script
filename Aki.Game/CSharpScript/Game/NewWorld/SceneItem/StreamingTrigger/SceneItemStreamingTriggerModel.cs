using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger
{
	// Token: 0x020071A2 RID: 29090
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemStreamingTriggerModel : ModelBase
	{
		// Token: 0x060472F6 RID: 291574 RVA: 0x0121712E File Offset: 0x0121532E
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060472F7 RID: 291575 RVA: 0x01217131 File Offset: 0x01215331
		protected override bool OnClear()
		{
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null)
			{
				timerHandle.Remove();
			}
			this.TimerHandle = null;
			HashSet<SceneItemStreamingTriggerComponent> triggers = this.Triggers;
			if (triggers != null)
			{
				triggers.Clear();
			}
			this.Triggers = null;
			return true;
		}

		// Token: 0x17009D9D RID: 40349
		// (get) Token: 0x060472F8 RID: 291576 RVA: 0x01217165 File Offset: 0x01215365
		public static SceneItemStreamingTriggerModel Instance
		{
			get
			{
				return SceneItemStreamingTriggerModel._Instance;
			}
		}

		// Token: 0x060472F9 RID: 291577 RVA: 0x0121716C File Offset: 0x0121536C
		public static SceneItemStreamingTriggerModel GetOrCreateInstance()
		{
			if (SceneItemStreamingTriggerModel._Instance == null)
			{
				SceneItemStreamingTriggerModel.CreateInstance();
			}
			return SceneItemStreamingTriggerModel._Instance;
		}

		// Token: 0x060472FA RID: 291578 RVA: 0x01217180 File Offset: 0x01215380
		public static bool CreateInstance()
		{
			if (SceneItemStreamingTriggerModel._Instance != null)
			{
				return true;
			}
			SceneItemStreamingTriggerModel._Instance = new SceneItemStreamingTriggerModel();
			return true;
		}

		// Token: 0x060472FB RID: 291579 RVA: 0x01217196 File Offset: 0x01215396
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060472FC RID: 291580 RVA: 0x01217198 File Offset: 0x01215398
		public static void ResetStaticDefaultValue()
		{
			SceneItemStreamingTriggerModel._Instance = null;
		}

		// Token: 0x060472FD RID: 291581 RVA: 0x012171A0 File Offset: 0x012153A0
		static SceneItemStreamingTriggerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemStreamingTriggerModel.CreateStaticDefaultValue), new Action(SceneItemStreamingTriggerModel.ResetStaticDefaultValue));
		}

		// Token: 0x040256E0 RID: 153312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SceneItemStreamingTriggerComponent> Triggers;

		// Token: 0x040256E1 RID: 153313
		[Nullable(2)]
		public TimerHandle TimerHandle;

		// Token: 0x040256E2 RID: 153314
		[Nullable(2)]
		private static SceneItemStreamingTriggerModel _Instance;
	}
}
