using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006402 RID: 25602
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRoleData
	{
		// Token: 0x06040671 RID: 263793 RVA: 0x00F94D6C File Offset: 0x00F92F6C
		public MotorFightRoleData(MotorFightRole config)
		{
			this.Config = config;
		}

		// Token: 0x17009451 RID: 37969
		// (get) Token: 0x06040673 RID: 263795 RVA: 0x00F94D84 File Offset: 0x00F92F84
		// (set) Token: 0x06040672 RID: 263794 RVA: 0x00F94D7B File Offset: 0x00F92F7B
		public bool IsUnLock
		{
			get
			{
				return this.IsUnLockInternal;
			}
			set
			{
				this.IsUnLockInternal = value;
			}
		}

		// Token: 0x17009452 RID: 37970
		// (get) Token: 0x06040674 RID: 263796 RVA: 0x00F94D8C File Offset: 0x00F92F8C
		public bool HasRedDot
		{
			get
			{
				if (!this.IsUnLock || this.ConditionId == 0)
				{
					return false;
				}
				HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightRoleClicked, null);
				return player == null || !player.Contains(this.Id);
			}
		}

		// Token: 0x06040675 RID: 263797 RVA: 0x00F94DCC File Offset: 0x00F92FCC
		public void ReadRedDot()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightRoleClicked, null);
			if (player != null)
			{
				player.Add(this.Id);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightRoleClicked, player);
				return;
			}
			HashSet<int> value = new HashSet<int>
			{
				this.Id
			};
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightRoleClicked, value);
		}

		// Token: 0x17009453 RID: 37971
		// (get) Token: 0x06040676 RID: 263798 RVA: 0x00F94E2A File Offset: 0x00F9302A
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17009454 RID: 37972
		// (get) Token: 0x06040677 RID: 263799 RVA: 0x00F94E38 File Offset: 0x00F93038
		public string RoleName
		{
			get
			{
				int trialRole = this.Config.TrialRole;
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(trialRole);
				if (roleConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorFightActivity;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "摩托战斗角色不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", trialRole);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return "";
				}
				return roleConfig.Value.Name;
			}
		}

		// Token: 0x17009455 RID: 37973
		// (get) Token: 0x06040678 RID: 263800 RVA: 0x00F94EAA File Offset: 0x00F930AA
		public int TrialRoleId
		{
			get
			{
				return this.Config.TrialRole;
			}
		}

		// Token: 0x17009456 RID: 37974
		// (get) Token: 0x06040679 RID: 263801 RVA: 0x00F94EB7 File Offset: 0x00F930B7
		public string GenreDesc
		{
			get
			{
				return this.Config.GenreDesc;
			}
		}

		// Token: 0x17009457 RID: 37975
		// (get) Token: 0x0604067A RID: 263802 RVA: 0x00F94EC4 File Offset: 0x00F930C4
		public string BuffName
		{
			get
			{
				return this.Config.BuffName;
			}
		}

		// Token: 0x17009458 RID: 37976
		// (get) Token: 0x0604067B RID: 263803 RVA: 0x00F94ED1 File Offset: 0x00F930D1
		public string BuffDesc
		{
			get
			{
				return this.Config.BuffDesc;
			}
		}

		// Token: 0x17009459 RID: 37977
		// (get) Token: 0x0604067C RID: 263804 RVA: 0x00F94EDE File Offset: 0x00F930DE
		public string[] BuffDescParams
		{
			get
			{
				return this.Config.BuffDescParam();
			}
		}

		// Token: 0x1700945A RID: 37978
		// (get) Token: 0x0604067D RID: 263805 RVA: 0x00F94EEB File Offset: 0x00F930EB
		public string RoleTexture
		{
			get
			{
				return this.Config.RolePicture;
			}
		}

		// Token: 0x1700945B RID: 37979
		// (get) Token: 0x0604067E RID: 263806 RVA: 0x00F94EF8 File Offset: 0x00F930F8
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x1700945C RID: 37980
		// (get) Token: 0x0604067F RID: 263807 RVA: 0x00F94F05 File Offset: 0x00F93105
		public string AnimPath
		{
			get
			{
				return this.Config.MotorStandAnimPath;
			}
		}

		// Token: 0x040217DF RID: 137183
		private MotorFightRole Config;

		// Token: 0x040217E0 RID: 137184
		private bool IsUnLockInternal;
	}
}
