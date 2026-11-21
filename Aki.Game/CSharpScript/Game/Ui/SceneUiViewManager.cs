using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.PianoGameplay;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.PlotView.PlotSceneView;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F0 RID: 13808
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiViewManager : Singleton
	{
		// Token: 0x060232B9 RID: 144057 RVA: 0x009FE2A8 File Offset: 0x009FC4A8
		public void Init()
		{
			SceneUiStorage instance = SceneUiStorage.Instance;
			ValueTuple<string, Func<SceneUiView>, string>[] array = new ValueTuple<string, Func<SceneUiView>, string>[4];
			array[0] = new ValueTuple<string, Func<SceneUiView>, string>("PlotSequenceSceneWordArtView", () => new PlotSequenceSceneWordArtView(), "UiView_MainStoryTextB");
			array[1] = new ValueTuple<string, Func<SceneUiView>, string>("PlotSceneArtWordView", () => new PlotSceneArtWordView(), "UiView_PopupTextAMain");
			array[2] = new ValueTuple<string, Func<SceneUiView>, string>("PianoSceneUiView", () => new PianoSceneUiView(), "UiItem_ScreenTxt");
			array[3] = new ValueTuple<string, Func<SceneUiView>, string>("PianoSceneUiViewCover", () => new PianoSceneUiView(), "UiItem_ScreenTxtCover");
			instance.Register(array);
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x060232BA RID: 144058 RVA: 0x009FE399 File Offset: 0x009FC599
		public static SceneUiViewManager Instance
		{
			get
			{
				if (SceneUiViewManager._instance == null)
				{
					SceneUiViewManager._instance = new SceneUiViewManager();
					SceneUiViewManager._instance.OnInit();
				}
				return SceneUiViewManager._instance;
			}
		}

		// Token: 0x060232BB RID: 144059 RVA: 0x009FE3BC File Offset: 0x009FC5BC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060232BC RID: 144060 RVA: 0x009FE3BE File Offset: 0x009FC5BE
		public static void ResetStaticDefaultValue()
		{
			SceneUiViewManager instance = SceneUiViewManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneUiViewManager._instance = null;
		}

		// Token: 0x060232BD RID: 144061 RVA: 0x009FE3D7 File Offset: 0x009FC5D7
		static SceneUiViewManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiViewManager.CreateStaticDefaultValue), new Action(SceneUiViewManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013D84 RID: 81284
		[Nullable(2)]
		private static SceneUiViewManager _instance;
	}
}
