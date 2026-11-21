using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A1 RID: 22689
	public class SolarSchoolConditionRoleFavorValueFull : ActivityConditionBase
	{
		// Token: 0x17006B46 RID: 27462
		// (get) Token: 0x06037E60 RID: 228960 RVA: 0x00FA0DBE File Offset: 0x00F9EFBE
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E61 RID: 228961 RVA: 0x00FA0DC1 File Offset: 0x00F9EFC1
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.RoleId = p.GetInt("RoleId", 0);
			this.FavorLevel = p.GetInt("FavorLevel", 0);
			return true;
		}

		// Token: 0x06037E62 RID: 228962 RVA: 0x00FA0DE8 File Offset: 0x00F9EFE8
		protected override bool OnCheck()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			return instance.GetConditionFavorLevel(this.RoleId) + 1 == this.FavorLevel && instance.IsConditionFavorValueFull(this.RoleId);
		}

		// Token: 0x06037E63 RID: 228963 RVA: 0x00FA0E1F File Offset: 0x00F9F01F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E64 RID: 228964 RVA: 0x00FA0E3D File Offset: 0x00F9F03D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolFavorChanged, new Action<int>(this.OnFavorChanged));
		}

		// Token: 0x06037E65 RID: 228965 RVA: 0x00FA0E5B File Offset: 0x00F9F05B
		protected override void OnClear()
		{
			this.RoleId = 0;
			this.FavorLevel = 0;
		}

		// Token: 0x06037E66 RID: 228966 RVA: 0x00FA0E6B File Offset: 0x00F9F06B
		private void OnFavorChanged(int roleId)
		{
			if (roleId == this.RoleId)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7EA RID: 120810
		private int RoleId;

		// Token: 0x0401D7EB RID: 120811
		private int FavorLevel;
	}
}
