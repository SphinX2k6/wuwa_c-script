using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.JoinTeam
{
	// Token: 0x020057AB RID: 22443
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class JoinTeamModel : ModelBase
	{
		// Token: 0x06039059 RID: 233561 RVA: 0x00D8D963 File Offset: 0x00D8BB63
		public void SetRoleDescriptionId(int? roleDescriptionId)
		{
			this.RoleDescriptionId = roleDescriptionId;
			EventSystem.Instance.Emit(EEventName.OnRefreshJoinTeamRole);
		}

		// Token: 0x0603905A RID: 233562 RVA: 0x00D8D97C File Offset: 0x00D8BB7C
		public int? GetRoleDescriptionId()
		{
			return this.RoleDescriptionId;
		}

		// Token: 0x170088D7 RID: 35031
		// (get) Token: 0x0603905B RID: 233563 RVA: 0x00D8D984 File Offset: 0x00D8BB84
		public static JoinTeamModel Instance
		{
			get
			{
				return JoinTeamModel._Instance;
			}
		}

		// Token: 0x0603905C RID: 233564 RVA: 0x00D8D98B File Offset: 0x00D8BB8B
		public static JoinTeamModel GetOrCreateInstance()
		{
			if (JoinTeamModel._Instance == null)
			{
				JoinTeamModel.CreateInstance();
			}
			return JoinTeamModel._Instance;
		}

		// Token: 0x0603905D RID: 233565 RVA: 0x00D8D99F File Offset: 0x00D8BB9F
		public static bool CreateInstance()
		{
			if (JoinTeamModel._Instance != null)
			{
				return true;
			}
			JoinTeamModel._Instance = new JoinTeamModel();
			return true;
		}

		// Token: 0x0603905E RID: 233566 RVA: 0x00D8D9B5 File Offset: 0x00D8BBB5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603905F RID: 233567 RVA: 0x00D8D9B7 File Offset: 0x00D8BBB7
		public static void ResetStaticDefaultValue()
		{
			JoinTeamModel._Instance = null;
		}

		// Token: 0x06039060 RID: 233568 RVA: 0x00D8D9BF File Offset: 0x00D8BBBF
		static JoinTeamModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JoinTeamModel.CreateStaticDefaultValue), new Action(JoinTeamModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DDF7 RID: 122359
		private int? RoleDescriptionId;

		// Token: 0x0401DDF8 RID: 122360
		[Nullable(2)]
		private static JoinTeamModel _Instance;
	}
}
