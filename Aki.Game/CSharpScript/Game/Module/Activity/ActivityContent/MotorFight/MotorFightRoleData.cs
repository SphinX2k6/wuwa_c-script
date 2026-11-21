using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005380 RID: 21376
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightRoleData
	{
		// Token: 0x06035332 RID: 217906 RVA: 0x00EDBD0C File Offset: 0x00ED9F0C
		public MotorFightRoleData(MotorFightRole config)
		{
			this.Config = config;
		}

		// Token: 0x170067B3 RID: 26547
		// (get) Token: 0x06035334 RID: 217908 RVA: 0x00EDBD24 File Offset: 0x00ED9F24
		// (set) Token: 0x06035333 RID: 217907 RVA: 0x00EDBD1B File Offset: 0x00ED9F1B
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

		// Token: 0x170067B4 RID: 26548
		// (get) Token: 0x06035335 RID: 217909 RVA: 0x00EDBD2C File Offset: 0x00ED9F2C
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

		// Token: 0x06035336 RID: 217910 RVA: 0x00EDBD6C File Offset: 0x00ED9F6C
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

		// Token: 0x170067B5 RID: 26549
		// (get) Token: 0x06035337 RID: 217911 RVA: 0x00EDBDCA File Offset: 0x00ED9FCA
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170067B6 RID: 26550
		// (get) Token: 0x06035338 RID: 217912 RVA: 0x00EDBDD8 File Offset: 0x00ED9FD8
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

		// Token: 0x170067B7 RID: 26551
		// (get) Token: 0x06035339 RID: 217913 RVA: 0x00EDBE4A File Offset: 0x00EDA04A
		public int TrialRoleId
		{
			get
			{
				return this.Config.TrialRole;
			}
		}

		// Token: 0x170067B8 RID: 26552
		// (get) Token: 0x0603533A RID: 217914 RVA: 0x00EDBE57 File Offset: 0x00EDA057
		public string GenreDesc
		{
			get
			{
				return this.Config.GenreDesc;
			}
		}

		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x0603533B RID: 217915 RVA: 0x00EDBE64 File Offset: 0x00EDA064
		public string BuffName
		{
			get
			{
				return this.Config.BuffName;
			}
		}

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x0603533C RID: 217916 RVA: 0x00EDBE71 File Offset: 0x00EDA071
		public string BuffDesc
		{
			get
			{
				return this.Config.BuffDesc;
			}
		}

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x0603533D RID: 217917 RVA: 0x00EDBE7E File Offset: 0x00EDA07E
		public string[] BuffDescParams
		{
			get
			{
				return this.Config.BuffDescParam();
			}
		}

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x0603533E RID: 217918 RVA: 0x00EDBE8B File Offset: 0x00EDA08B
		public string RoleTexture
		{
			get
			{
				return this.Config.RolePicture;
			}
		}

		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x0603533F RID: 217919 RVA: 0x00EDBE98 File Offset: 0x00EDA098
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x06035340 RID: 217920 RVA: 0x00EDBEA5 File Offset: 0x00EDA0A5
		public string AnimPath
		{
			get
			{
				return this.Config.MotorStandAnimPath;
			}
		}

		// Token: 0x0401C10E RID: 114958
		private MotorFightRole Config;

		// Token: 0x0401C10F RID: 114959
		private bool IsUnLockInternal;
	}
}
