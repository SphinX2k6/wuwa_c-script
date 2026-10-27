using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02006A10 RID: 27152
	[NullableContext(1)]
	[Nullable(0)]
	public class StaticSceneModel : ModelBase
	{
		// Token: 0x060438DD RID: 276701 RVA: 0x01087417 File Offset: 0x01085617
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060438DE RID: 276702 RVA: 0x0108741A File Offset: 0x0108561A
		protected override bool OnClear()
		{
			this.IsNotAutoExitSceneCamera = false;
			this.IsForceKeepUi = false;
			return true;
		}

		// Token: 0x170098A8 RID: 39080
		// (get) Token: 0x060438DF RID: 276703 RVA: 0x0108742B File Offset: 0x0108562B
		public static StaticSceneModel Instance
		{
			get
			{
				return StaticSceneModel._Instance;
			}
		}

		// Token: 0x060438E0 RID: 276704 RVA: 0x01087432 File Offset: 0x01085632
		public static StaticSceneModel GetOrCreateInstance()
		{
			if (StaticSceneModel._Instance == null)
			{
				StaticSceneModel.CreateInstance();
			}
			return StaticSceneModel._Instance;
		}

		// Token: 0x060438E1 RID: 276705 RVA: 0x01087446 File Offset: 0x01085646
		public static bool CreateInstance()
		{
			if (StaticSceneModel._Instance != null)
			{
				return true;
			}
			StaticSceneModel._Instance = new StaticSceneModel();
			return true;
		}

		// Token: 0x060438E2 RID: 276706 RVA: 0x0108745C File Offset: 0x0108565C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060438E3 RID: 276707 RVA: 0x0108745E File Offset: 0x0108565E
		public static void ResetStaticDefaultValue()
		{
			StaticSceneModel._Instance = null;
		}

		// Token: 0x060438E4 RID: 276708 RVA: 0x01087466 File Offset: 0x01085666
		static StaticSceneModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(StaticSceneModel.CreateStaticDefaultValue), new Action(StaticSceneModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023465 RID: 144485
		public bool IsNotAutoExitSceneCamera;

		// Token: 0x04023466 RID: 144486
		public bool IsForceKeepUi;

		// Token: 0x04023467 RID: 144487
		[Nullable(2)]
		private static StaticSceneModel _Instance;
	}
}
