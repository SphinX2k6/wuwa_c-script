using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02005B89 RID: 23433
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ComicController : UiControllerBase
	{
		// Token: 0x0603B49A RID: 242842 RVA: 0x00E216D4 File Offset: 0x00E1F8D4
		public void OpenComicView(IComicViewOpenParam param)
		{
			UiManager.Instance.OpenView(EUiViewName.CommonComicView, param, null);
		}

		// Token: 0x0603B49B RID: 242843 RVA: 0x00E216E8 File Offset: 0x00E1F8E8
		[NullableContext(0)]
		public UniTask<bool> OpenComicViewAsync([Nullable(1)] IComicViewOpenParam param)
		{
			ComicController.<OpenComicViewAsync>d__2 <OpenComicViewAsync>d__;
			<OpenComicViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenComicViewAsync>d__.param = param;
			<OpenComicViewAsync>d__.<>1__state = -1;
			<OpenComicViewAsync>d__.<>t__builder.Start<ComicController.<OpenComicViewAsync>d__2>(ref <OpenComicViewAsync>d__);
			return <OpenComicViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B49C RID: 242844 RVA: 0x00E2172B File Offset: 0x00E1F92B
		protected override bool OnClear()
		{
			this.IsFadeBeforeHide = false;
			return true;
		}

		// Token: 0x17008CD2 RID: 36050
		// (get) Token: 0x0603B49D RID: 242845 RVA: 0x00E21735 File Offset: 0x00E1F935
		public static ComicController Instance
		{
			get
			{
				return ComicController._Instance;
			}
		}

		// Token: 0x0603B49E RID: 242846 RVA: 0x00E2173C File Offset: 0x00E1F93C
		public static ComicController GetOrCreateInstance()
		{
			if (ComicController._Instance == null)
			{
				ComicController.CreateInstance();
			}
			return ComicController._Instance;
		}

		// Token: 0x0603B49F RID: 242847 RVA: 0x00E21750 File Offset: 0x00E1F950
		public static bool CreateInstance()
		{
			if (ComicController._Instance != null)
			{
				return true;
			}
			ComicController._Instance = new ComicController();
			return true;
		}

		// Token: 0x0603B4A0 RID: 242848 RVA: 0x00E21766 File Offset: 0x00E1F966
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B4A1 RID: 242849 RVA: 0x00E21768 File Offset: 0x00E1F968
		public static void ResetStaticDefaultValue()
		{
			ComicController._Instance = null;
		}

		// Token: 0x0603B4A2 RID: 242850 RVA: 0x00E21770 File Offset: 0x00E1F970
		static ComicController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComicController.CreateStaticDefaultValue), new Action(ComicController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE78 RID: 126584
		public bool IsFadeBeforeHide;

		// Token: 0x0401EE79 RID: 126585
		[Nullable(2)]
		private static ComicController _Instance;
	}
}
