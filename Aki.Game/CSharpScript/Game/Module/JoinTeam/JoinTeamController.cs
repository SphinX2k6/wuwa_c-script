using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x020057AA RID: 22442
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class JoinTeamController : UiControllerBase
	{
		// Token: 0x0603904E RID: 233550 RVA: 0x00D8D86E File Offset: 0x00D8BA6E
		protected override void OnAddEvents()
		{
		}

		// Token: 0x0603904F RID: 233551 RVA: 0x00D8D870 File Offset: 0x00D8BA70
		protected override void OnRemoveEvents()
		{
		}

		// Token: 0x06039050 RID: 233552 RVA: 0x00D8D874 File Offset: 0x00D8BA74
		[NullableContext(0)]
		public UniTask<bool> OpenJoinTeamView(int roleDescriptionId, bool isTrial = false)
		{
			JoinTeamController.<OpenJoinTeamView>d__2 <OpenJoinTeamView>d__;
			<OpenJoinTeamView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenJoinTeamView>d__.roleDescriptionId = roleDescriptionId;
			<OpenJoinTeamView>d__.isTrial = isTrial;
			<OpenJoinTeamView>d__.<>1__state = -1;
			<OpenJoinTeamView>d__.<>t__builder.Start<JoinTeamController.<OpenJoinTeamView>d__2>(ref <OpenJoinTeamView>d__);
			return <OpenJoinTeamView>d__.<>t__builder.Task;
		}

		// Token: 0x06039051 RID: 233553 RVA: 0x00D8D8C0 File Offset: 0x00D8BAC0
		public void CloseJoinTeamView()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.JoinTeamView))
			{
				UiManager.Instance.CloseView(EUiViewName.JoinTeamView, null);
			}
			JoinTeamModel.Instance.SetRoleDescriptionId(null);
		}

		// Token: 0x170088D6 RID: 35030
		// (get) Token: 0x06039052 RID: 233554 RVA: 0x00D8D901 File Offset: 0x00D8BB01
		public static JoinTeamController Instance
		{
			get
			{
				return JoinTeamController._Instance;
			}
		}

		// Token: 0x06039053 RID: 233555 RVA: 0x00D8D908 File Offset: 0x00D8BB08
		public static JoinTeamController GetOrCreateInstance()
		{
			if (JoinTeamController._Instance == null)
			{
				JoinTeamController.CreateInstance();
			}
			return JoinTeamController._Instance;
		}

		// Token: 0x06039054 RID: 233556 RVA: 0x00D8D91C File Offset: 0x00D8BB1C
		public static bool CreateInstance()
		{
			if (JoinTeamController._Instance != null)
			{
				return true;
			}
			JoinTeamController._Instance = new JoinTeamController();
			return true;
		}

		// Token: 0x06039055 RID: 233557 RVA: 0x00D8D932 File Offset: 0x00D8BB32
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039056 RID: 233558 RVA: 0x00D8D934 File Offset: 0x00D8BB34
		public static void ResetStaticDefaultValue()
		{
			JoinTeamController._Instance = null;
		}

		// Token: 0x06039057 RID: 233559 RVA: 0x00D8D93C File Offset: 0x00D8BB3C
		static JoinTeamController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamController.CreateStaticDefaultValue), new Action(JoinTeamController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DDF6 RID: 122358
		[Nullable(2)]
		private static JoinTeamController _Instance;
	}
}
