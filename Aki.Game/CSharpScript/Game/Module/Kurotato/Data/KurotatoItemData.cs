using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579C RID: 22428
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoItemData
	{
		// Token: 0x06038FB7 RID: 233399 RVA: 0x00D8BBF9 File Offset: 0x00D89DF9
		public KurotatoItemData(KurotatoItem config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x17008893 RID: 34963
		// (get) Token: 0x06038FB8 RID: 233400 RVA: 0x00D8BC0F File Offset: 0x00D89E0F
		// (set) Token: 0x06038FB9 RID: 233401 RVA: 0x00D8BC17 File Offset: 0x00D89E17
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

		// Token: 0x17008894 RID: 34964
		// (get) Token: 0x06038FBA RID: 233402 RVA: 0x00D8BC20 File Offset: 0x00D89E20
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && this.ConditionId != 0 && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 3, this.Id, 0) == 0;
			}
		}

		// Token: 0x06038FBB RID: 233403 RVA: 0x00D8BC50 File Offset: 0x00D89E50
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

		// Token: 0x17008895 RID: 34965
		// (get) Token: 0x06038FBC RID: 233404 RVA: 0x00D8BCB4 File Offset: 0x00D89EB4
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008896 RID: 34966
		// (get) Token: 0x06038FBD RID: 233405 RVA: 0x00D8BCD0 File Offset: 0x00D89ED0
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17008897 RID: 34967
		// (get) Token: 0x06038FBE RID: 233406 RVA: 0x00D8BCEC File Offset: 0x00D89EEC
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17008898 RID: 34968
		// (get) Token: 0x06038FBF RID: 233407 RVA: 0x00D8BD08 File Offset: 0x00D89F08
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

		// Token: 0x17008899 RID: 34969
		// (get) Token: 0x06038FC0 RID: 233408 RVA: 0x00D8BD4C File Offset: 0x00D89F4C
		public int ConditionId
		{
			get
			{
				return this.Config.UnlockConditionId;
			}
		}

		// Token: 0x1700889A RID: 34970
		// (get) Token: 0x06038FC1 RID: 233409 RVA: 0x00D8BD68 File Offset: 0x00D89F68
		public int Quality
		{
			get
			{
				return this.Config.Quality;
			}
		}

		// Token: 0x0401DDB8 RID: 122296
		private readonly KurotatoItem Config;

		// Token: 0x0401DDB9 RID: 122297
		private bool IsUnLockInternal;

		// Token: 0x0401DDBA RID: 122298
		private readonly int ActivityId;
	}
}
