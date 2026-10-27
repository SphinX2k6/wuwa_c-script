using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020063FF RID: 25599
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightItemData
	{
		// Token: 0x06040641 RID: 263745 RVA: 0x00F9442C File Offset: 0x00F9262C
		public MotorFightItemData(MotorFightItem config, int? count = null)
		{
			this.Config = config;
			this.Count = count;
		}

		// Token: 0x17009432 RID: 37938
		// (get) Token: 0x06040643 RID: 263747 RVA: 0x00F9444B File Offset: 0x00F9264B
		// (set) Token: 0x06040642 RID: 263746 RVA: 0x00F94442 File Offset: 0x00F92642
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

		// Token: 0x17009433 RID: 37939
		// (get) Token: 0x06040644 RID: 263748 RVA: 0x00F94464 File Offset: 0x00F92664
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

		// Token: 0x06040645 RID: 263749 RVA: 0x00F9449C File Offset: 0x00F9269C
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

		// Token: 0x17009434 RID: 37940
		// (get) Token: 0x06040646 RID: 263750 RVA: 0x00F944FA File Offset: 0x00F926FA
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17009435 RID: 37941
		// (get) Token: 0x06040647 RID: 263751 RVA: 0x00F94507 File Offset: 0x00F92707
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17009436 RID: 37942
		// (get) Token: 0x06040648 RID: 263752 RVA: 0x00F94514 File Offset: 0x00F92714
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17009437 RID: 37943
		// (get) Token: 0x06040649 RID: 263753 RVA: 0x00F94521 File Offset: 0x00F92721
		public string[] DescParams
		{
			get
			{
				return this.Config.DescParam();
			}
		}

		// Token: 0x17009438 RID: 37944
		// (get) Token: 0x0604064A RID: 263754 RVA: 0x00F9452E File Offset: 0x00F9272E
		public int Type
		{
			get
			{
				return this.Config.Type;
			}
		}

		// Token: 0x17009439 RID: 37945
		// (get) Token: 0x0604064B RID: 263755 RVA: 0x00F9453B File Offset: 0x00F9273B
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x1700943A RID: 37946
		// (get) Token: 0x0604064C RID: 263756 RVA: 0x00F94548 File Offset: 0x00F92748
		public string Icon
		{
			get
			{
				return this.Config.Icon;
			}
		}

		// Token: 0x1700943B RID: 37947
		// (get) Token: 0x0604064D RID: 263757 RVA: 0x00F94555 File Offset: 0x00F92755
		public string BigIcon
		{
			get
			{
				return this.Config.IconBig;
			}
		}

		// Token: 0x1700943C RID: 37948
		// (get) Token: 0x0604064E RID: 263758 RVA: 0x00F94562 File Offset: 0x00F92762
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockCondition;
			}
		}

		// Token: 0x040217C9 RID: 137161
		private MotorFightItem Config;

		// Token: 0x040217CA RID: 137162
		private bool IsUnLockInternal;

		// Token: 0x040217CB RID: 137163
		public int? Count;
	}
}
