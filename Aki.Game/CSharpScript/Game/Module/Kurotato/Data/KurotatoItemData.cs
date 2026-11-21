using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004773 RID: 18291
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoItemData
	{
		// Token: 0x0602DEC7 RID: 188103 RVA: 0x00CDA975 File Offset: 0x00CD8B75
		public KurotatoItemData(KurotatoItem config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x0602DEC8 RID: 188104 RVA: 0x00CDA98B File Offset: 0x00CD8B8B
		// (set) Token: 0x0602DEC9 RID: 188105 RVA: 0x00CDA993 File Offset: 0x00CD8B93
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

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x0602DECA RID: 188106 RVA: 0x00CDA99C File Offset: 0x00CD8B9C
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 3, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DECB RID: 188107 RVA: 0x00CDA9CC File Offset: 0x00CD8BCC
		public void ReadRedDot(bool emitEvent = true)
		{
			if (!this.IsUnLock)
			{
				return;
			}
			if (!this.HasRedDot)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 3, this.Id, 0, 1);
			if (!emitEvent)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			EventSystem.Instance.Emit(EEventName.OnRefreshKurotatoWeaponAndPropRedDot);
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x0602DECC RID: 188108 RVA: 0x00CDAA30 File Offset: 0x00CD8C30
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x0602DECD RID: 188109 RVA: 0x00CDAA4C File Offset: 0x00CD8C4C
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x0602DECE RID: 188110 RVA: 0x00CDAA68 File Offset: 0x00CD8C68
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x0602DECF RID: 188111 RVA: 0x00CDAA84 File Offset: 0x00CD8C84
		public string[] DescParam
		{
			get
			{
				int descParamsLength = this.Config.DescParamsLength;
				string[] array = new string[descParamsLength];
				for (int i = 0; i < descParamsLength; i++)
				{
					array[i] = this.Config.DescParams(i);
				}
				return array;
			}
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x0602DED0 RID: 188112 RVA: 0x00CDAAC8 File Offset: 0x00CD8CC8
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockConditionId;
			}
		}

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x0602DED1 RID: 188113 RVA: 0x00CDAAE4 File Offset: 0x00CD8CE4
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x0401884E RID: 100430
		private readonly KurotatoItem Config;

		// Token: 0x0401884F RID: 100431
		private bool IsUnLockInternal;

		// Token: 0x04018850 RID: 100432
		private readonly int ActivityId;
	}
}
