using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200537D RID: 21373
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightItemData
	{
		// Token: 0x06035302 RID: 217858 RVA: 0x00EDB3CC File Offset: 0x00ED95CC
		public MotorFightItemData(MotorFightItem config, int? count = null)
		{
			this.Config = config;
			this.Count = count;
		}

		// Token: 0x17006794 RID: 26516
		// (get) Token: 0x06035304 RID: 217860 RVA: 0x00EDB3EB File Offset: 0x00ED95EB
		// (set) Token: 0x06035303 RID: 217859 RVA: 0x00EDB3E2 File Offset: 0x00ED95E2
		public bool IsUnLock
		{
			get
			{
				return this.IsUnLockInternal || this.Count != null;
			}
			set
			{
				this.IsUnLockInternal = value;
			}
		}

		// Token: 0x17006795 RID: 26517
		// (get) Token: 0x06035305 RID: 217861 RVA: 0x00EDB404 File Offset: 0x00ED9604
		public bool HasItemRedDot
		{
			get
			{
				if (!this.IsUnLock)
				{
					return false;
				}
				HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightItemClicked, null);
				return player == null || !player.Contains(this.Id);
			}
		}

		// Token: 0x06035306 RID: 217862 RVA: 0x00EDB43C File Offset: 0x00ED963C
		public void ReadItemRedDot()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightItemClicked, null);
			if (player != null)
			{
				player.Add(this.Id);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightItemClicked, player);
				return;
			}
			HashSet<int> value = new HashSet<int>
			{
				this.Id
			};
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightItemClicked, value);
		}

		// Token: 0x17006796 RID: 26518
		// (get) Token: 0x06035307 RID: 217863 RVA: 0x00EDB49A File Offset: 0x00ED969A
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006797 RID: 26519
		// (get) Token: 0x06035308 RID: 217864 RVA: 0x00EDB4A7 File Offset: 0x00ED96A7
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17006798 RID: 26520
		// (get) Token: 0x06035309 RID: 217865 RVA: 0x00EDB4B4 File Offset: 0x00ED96B4
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17006799 RID: 26521
		// (get) Token: 0x0603530A RID: 217866 RVA: 0x00EDB4C1 File Offset: 0x00ED96C1
		public string[] DescParams
		{
			get
			{
				return this.Config.DescParam();
			}
		}

		// Token: 0x1700679A RID: 26522
		// (get) Token: 0x0603530B RID: 217867 RVA: 0x00EDB4CE File Offset: 0x00ED96CE
		public int Type
		{
			get
			{
				return this.Config.Type;
			}
		}

		// Token: 0x1700679B RID: 26523
		// (get) Token: 0x0603530C RID: 217868 RVA: 0x00EDB4DB File Offset: 0x00ED96DB
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x1700679C RID: 26524
		// (get) Token: 0x0603530D RID: 217869 RVA: 0x00EDB4E8 File Offset: 0x00ED96E8
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x1700679D RID: 26525
		// (get) Token: 0x0603530E RID: 217870 RVA: 0x00EDB4F5 File Offset: 0x00ED96F5
		public string BigIcon
		{
			get
			{
				return this.Config.IconBig;
			}
		}

		// Token: 0x1700679E RID: 26526
		// (get) Token: 0x0603530F RID: 217871 RVA: 0x00EDB502 File Offset: 0x00ED9702
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x0401C0F8 RID: 114936
		private MotorFightItem Config;

		// Token: 0x0401C0F9 RID: 114937
		private bool IsUnLockInternal;

		// Token: 0x0401C0FA RID: 114938
		public int? Count;
	}
}
