using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.PlotView.PlotSceneView;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046BF RID: 18111
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneUiViewManager : Singleton
	{
		// Token: 0x0602EB6D RID: 191341 RVA: 0x00ACF980 File Offset: 0x00ACDB80
		public void Init()
		{
			SceneUiStorage instance = SceneUiStorage.Instance;
			ValueTuple<string, Func<SceneUiView>, string>[] array = new ValueTuple<string, Func<SceneUiView>, string>[2];
			array[0] = new ValueTuple<string, Func<SceneUiView>, string>("PlotSequenceSceneWordArtView", () => new PlotSequenceSceneWordArtView(), "UiView_MainStoryTextB");
			array[1] = new ValueTuple<string, Func<SceneUiView>, string>("PlotSceneArtWordView", () => new PlotSceneArtWordView(), "UiView_PopupTextAMain");
			instance.Register(array);
		}

		// Token: 0x17007669 RID: 30313
		// (get) Token: 0x0602EB6E RID: 191342 RVA: 0x00ACFA07 File Offset: 0x00ACDC07
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

		// Token: 0x0602EB6F RID: 191343 RVA: 0x00ACFA2A File Offset: 0x00ACDC2A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB70 RID: 191344 RVA: 0x00ACFA2C File Offset: 0x00ACDC2C
		public static void ResetStaticDefaultValue()
		{
			SceneUiViewManager instance = SceneUiViewManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SceneUiViewManager._instance = null;
		}

		// Token: 0x0602EB71 RID: 191345 RVA: 0x00ACFA45 File Offset: 0x00ACDC45
		static SceneUiViewManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneUiViewManager.CreateStaticDefaultValue), new Action(SceneUiViewManager.ResetStaticDefaultValue));
		}

		// Token: 0x040196DD RID: 104157
		[Nullable(2)]
		private static SceneUiViewManager _instance;
	}
}
