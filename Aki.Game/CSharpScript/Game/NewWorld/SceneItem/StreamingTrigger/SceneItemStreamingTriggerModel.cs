using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger
{
	// Token: 0x02006257 RID: 25175
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneItemStreamingTriggerModel : ModelBase
	{
		// Token: 0x0603CBEE RID: 248814 RVA: 0x01171092 File Offset: 0x0116F292
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603CBEF RID: 248815 RVA: 0x01171095 File Offset: 0x0116F295
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

		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x0603CBF0 RID: 248816 RVA: 0x011710C9 File Offset: 0x0116F2C9
		public static SceneItemStreamingTriggerModel Instance
		{
			get
			{
				return SceneItemStreamingTriggerModel._Instance;
			}
		}

		// Token: 0x0603CBF1 RID: 248817 RVA: 0x011710D0 File Offset: 0x0116F2D0
		public static SceneItemStreamingTriggerModel GetOrCreateInstance()
		{
			if (SceneItemStreamingTriggerModel._Instance == null)
			{
				SceneItemStreamingTriggerModel.CreateInstance();
			}
			return SceneItemStreamingTriggerModel._Instance;
		}

		// Token: 0x0603CBF2 RID: 248818 RVA: 0x011710E4 File Offset: 0x0116F2E4
		public static bool CreateInstance()
		{
			if (SceneItemStreamingTriggerModel._Instance != null)
			{
				return true;
			}
			SceneItemStreamingTriggerModel._Instance = new SceneItemStreamingTriggerModel();
			return true;
		}

		// Token: 0x0603CBF3 RID: 248819 RVA: 0x011710FA File Offset: 0x0116F2FA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CBF4 RID: 248820 RVA: 0x011710FC File Offset: 0x0116F2FC
		public static void ResetStaticDefaultValue()
		{
			SceneItemStreamingTriggerModel._Instance = null;
		}

		// Token: 0x0603CBF5 RID: 248821 RVA: 0x01171104 File Offset: 0x0116F304
		static SceneItemStreamingTriggerModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemStreamingTriggerModel.CreateStaticDefaultValue), new Action(SceneItemStreamingTriggerModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402034F RID: 131919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SceneItemStreamingTriggerComponent> Triggers;

		// Token: 0x04020350 RID: 131920
		[Nullable(2)]
		public TimerHandle TimerHandle;

		// Token: 0x04020351 RID: 131921
		[Nullable(2)]
		private static SceneItemStreamingTriggerModel _Instance;
	}
}
