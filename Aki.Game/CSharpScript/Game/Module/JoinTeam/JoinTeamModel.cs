using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x02004782 RID: 18306
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class JoinTeamModel : ModelBase
	{
		// Token: 0x0602DF69 RID: 188265 RVA: 0x00CDC71F File Offset: 0x00CDA91F
		public void SetRoleDescriptionId(int? roleDescriptionId)
		{
			this.RoleDescriptionId = roleDescriptionId;
			EventSystem.Instance.Emit(EEventName.OnRefreshJoinTeamRole);
		}

		// Token: 0x0602DF6A RID: 188266 RVA: 0x00CDC738 File Offset: 0x00CDA938
		public int? GetRoleDescriptionId()
		{
			return this.RoleDescriptionId;
		}

		// Token: 0x17005C9F RID: 23711
		// (get) Token: 0x0602DF6B RID: 188267 RVA: 0x00CDC740 File Offset: 0x00CDA940
		public static JoinTeamModel Instance
		{
			get
			{
				return JoinTeamModel._Instance;
			}
		}

		// Token: 0x0602DF6C RID: 188268 RVA: 0x00CDC747 File Offset: 0x00CDA947
		public static JoinTeamModel GetOrCreateInstance()
		{
			if (JoinTeamModel._Instance == null)
			{
				JoinTeamModel.CreateInstance();
			}
			return JoinTeamModel._Instance;
		}

		// Token: 0x0602DF6D RID: 188269 RVA: 0x00CDC75B File Offset: 0x00CDA95B
		public static bool CreateInstance()
		{
			if (JoinTeamModel._Instance != null)
			{
				return true;
			}
			JoinTeamModel._Instance = new JoinTeamModel();
			return true;
		}

		// Token: 0x0602DF6E RID: 188270 RVA: 0x00CDC771 File Offset: 0x00CDA971
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DF6F RID: 188271 RVA: 0x00CDC773 File Offset: 0x00CDA973
		public static void ResetStaticDefaultValue()
		{
			JoinTeamModel._Instance = null;
		}

		// Token: 0x0602DF70 RID: 188272 RVA: 0x00CDC77B File Offset: 0x00CDA97B
		static JoinTeamModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamModel.CreateStaticDefaultValue), new Action(JoinTeamModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401888D RID: 100493
		private int? RoleDescriptionId;

		// Token: 0x0401888E RID: 100494
		[Nullable(2)]
		private static JoinTeamModel _Instance;
	}
}
