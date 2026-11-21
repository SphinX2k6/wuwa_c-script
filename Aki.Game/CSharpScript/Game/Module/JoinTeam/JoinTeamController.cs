using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x02004781 RID: 18305
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class JoinTeamController : UiControllerBase
	{
		// Token: 0x0602DF5E RID: 188254 RVA: 0x00CDC62A File Offset: 0x00CDA82A
		protected override void OnAddEvents()
		{
		}

		// Token: 0x0602DF5F RID: 188255 RVA: 0x00CDC62C File Offset: 0x00CDA82C
		protected override void OnRemoveEvents()
		{
		}

		// Token: 0x0602DF60 RID: 188256 RVA: 0x00CDC630 File Offset: 0x00CDA830
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

		// Token: 0x0602DF61 RID: 188257 RVA: 0x00CDC67C File Offset: 0x00CDA87C
		public void CloseJoinTeamView()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.JoinTeamView))
			{
				UiManager.Instance.CloseView(EUiViewName.JoinTeamView, null);
			}
			JoinTeamModel.Instance.SetRoleDescriptionId(null);
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x0602DF62 RID: 188258 RVA: 0x00CDC6BD File Offset: 0x00CDA8BD
		public static JoinTeamController Instance
		{
			get
			{
				return JoinTeamController._Instance;
			}
		}

		// Token: 0x0602DF63 RID: 188259 RVA: 0x00CDC6C4 File Offset: 0x00CDA8C4
		public static JoinTeamController GetOrCreateInstance()
		{
			if (JoinTeamController._Instance == null)
			{
				JoinTeamController.CreateInstance();
			}
			return JoinTeamController._Instance;
		}

		// Token: 0x0602DF64 RID: 188260 RVA: 0x00CDC6D8 File Offset: 0x00CDA8D8
		public static bool CreateInstance()
		{
			if (JoinTeamController._Instance != null)
			{
				return true;
			}
			JoinTeamController._Instance = new JoinTeamController();
			return true;
		}

		// Token: 0x0602DF65 RID: 188261 RVA: 0x00CDC6EE File Offset: 0x00CDA8EE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DF66 RID: 188262 RVA: 0x00CDC6F0 File Offset: 0x00CDA8F0
		public static void ResetStaticDefaultValue()
		{
			JoinTeamController._Instance = null;
		}

		// Token: 0x0602DF67 RID: 188263 RVA: 0x00CDC6F8 File Offset: 0x00CDA8F8
		static JoinTeamController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamController.CreateStaticDefaultValue), new Action(JoinTeamController.ResetStaticDefaultValue));
		}

		// Token: 0x0401888C RID: 100492
		[Nullable(2)]
		private static JoinTeamController _Instance;
	}
}
