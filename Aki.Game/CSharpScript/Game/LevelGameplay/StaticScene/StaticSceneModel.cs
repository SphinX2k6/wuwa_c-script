using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.StaticScene
{
	// Token: 0x02005B6D RID: 23405
	[NullableContext(1)]
	[Nullable(0)]
	public class StaticSceneModel : ModelBase
	{
		// Token: 0x06039929 RID: 235817 RVA: 0x0102BA67 File Offset: 0x01029C67
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603992A RID: 235818 RVA: 0x0102BA6A File Offset: 0x01029C6A
		protected override bool OnClear()
		{
			this.IsNotAutoExitSceneCamera = false;
			this.IsForceKeepUi = false;
			return true;
		}

		// Token: 0x17006D8D RID: 28045
		// (get) Token: 0x0603992B RID: 235819 RVA: 0x0102BA7B File Offset: 0x01029C7B
		public static StaticSceneModel Instance
		{
			get
			{
				return StaticSceneModel._Instance;
			}
		}

		// Token: 0x0603992C RID: 235820 RVA: 0x0102BA82 File Offset: 0x01029C82
		public static StaticSceneModel GetOrCreateInstance()
		{
			if (StaticSceneModel._Instance == null)
			{
				StaticSceneModel.CreateInstance();
			}
			return StaticSceneModel._Instance;
		}

		// Token: 0x0603992D RID: 235821 RVA: 0x0102BA96 File Offset: 0x01029C96
		public static bool CreateInstance()
		{
			if (StaticSceneModel._Instance != null)
			{
				return true;
			}
			StaticSceneModel._Instance = new StaticSceneModel();
			return true;
		}

		// Token: 0x0603992E RID: 235822 RVA: 0x0102BAAC File Offset: 0x01029CAC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603992F RID: 235823 RVA: 0x0102BAAE File Offset: 0x01029CAE
		public static void ResetStaticDefaultValue()
		{
			StaticSceneModel._Instance = null;
		}

		// Token: 0x06039930 RID: 235824 RVA: 0x0102BAB6 File Offset: 0x01029CB6
		static StaticSceneModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(StaticSceneModel.CreateStaticDefaultValue), new Action(StaticSceneModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E657 RID: 124503
		public bool IsNotAutoExitSceneCamera;

		// Token: 0x0401E658 RID: 124504
		public bool IsForceKeepUi;

		// Token: 0x0401E659 RID: 124505
		[Nullable(2)]
		private static StaticSceneModel _Instance;
	}
}
