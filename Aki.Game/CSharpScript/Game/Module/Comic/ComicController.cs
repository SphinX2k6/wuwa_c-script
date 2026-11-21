using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B69 RID: 19305
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ComicController : UiControllerBase
	{
		// Token: 0x060303E7 RID: 197607 RVA: 0x00D71C40 File Offset: 0x00D6FE40
		public void OpenComicView(IComicViewOpenParam param)
		{
			UiManager.Instance.OpenView(EUiViewName.CommonComicView, param, null);
		}

		// Token: 0x060303E8 RID: 197608 RVA: 0x00D71C54 File Offset: 0x00D6FE54
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

		// Token: 0x060303E9 RID: 197609 RVA: 0x00D71C97 File Offset: 0x00D6FE97
		protected override bool OnClear()
		{
			this.IsFadeBeforeHide = false;
			return true;
		}

		// Token: 0x170060A4 RID: 24740
		// (get) Token: 0x060303EA RID: 197610 RVA: 0x00D71CA1 File Offset: 0x00D6FEA1
		public static ComicController Instance
		{
			get
			{
				return ComicController._Instance;
			}
		}

		// Token: 0x060303EB RID: 197611 RVA: 0x00D71CA8 File Offset: 0x00D6FEA8
		public static ComicController GetOrCreateInstance()
		{
			if (ComicController._Instance == null)
			{
				ComicController.CreateInstance();
			}
			return ComicController._Instance;
		}

		// Token: 0x060303EC RID: 197612 RVA: 0x00D71CBC File Offset: 0x00D6FEBC
		public static bool CreateInstance()
		{
			if (ComicController._Instance != null)
			{
				return true;
			}
			ComicController._Instance = new ComicController();
			return true;
		}

		// Token: 0x060303ED RID: 197613 RVA: 0x00D71CD2 File Offset: 0x00D6FED2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060303EE RID: 197614 RVA: 0x00D71CD4 File Offset: 0x00D6FED4
		public static void ResetStaticDefaultValue()
		{
			ComicController._Instance = null;
		}

		// Token: 0x060303EF RID: 197615 RVA: 0x00D71CDC File Offset: 0x00D6FEDC
		static ComicController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ComicController.CreateStaticDefaultValue), new Action(ComicController.ResetStaticDefaultValue));
		}

		// Token: 0x04019929 RID: 104745
		public bool IsFadeBeforeHide;

		// Token: 0x0401992A RID: 104746
		[Nullable(2)]
		private static ComicController _Instance;
	}
}
