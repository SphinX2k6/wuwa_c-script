using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011CD RID: 4557
	public class IQuestScheduleConfig
	{
		// Token: 0x060065F5 RID: 26101 RVA: 0x000F5564 File Offset: 0x000F3764
		private IQuestScheduleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestScheduleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestScheduleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestScheduleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x000F559C File Offset: 0x000F379C
		public static IQuestScheduleConfig Create([Nullable(2)] IQuestScheduleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x000F55AF File Offset: 0x000F37AF
		public static IQuestScheduleConfig CreateFromSetValue([Nullable(2)] IQuestScheduleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestScheduleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x000F55C4 File Offset: 0x000F37C4
		public IQuestScheduleConfig_SetValue ToSetValue()
		{
			return new IQuestScheduleConfig_SetValue
			{
				UiType = this.UiType,
				MainTitle = this.MainTitle,
				SubTitles = this.SubTitles,
				TrackTarget = this.TrackTarget,
				TrackRadius = this.TrackRadius
			};
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x000F5612 File Offset: 0x000F3812
		// (set) Token: 0x060065FA RID: 26106 RVA: 0x000F563D File Offset: 0x000F383D
		public virtual EQuestScheduleUiType UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				if (this.PocoInterface == null)
				{
					return EQuestScheduleUiType.Task;
				}
				return this.PocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x000F564C File Offset: 0x000F384C
		// (set) Token: 0x060065FC RID: 26108 RVA: 0x000F56AD File Offset: 0x000F38AD
		public virtual IQuestScheduleMainTitle MainTitle
		{
			get
			{
				if (this._MainTitleInited)
				{
					return this._MainTitleCache;
				}
				this._MainTitleInited = true;
				if (this.FbInstance != null)
				{
					this._MainTitleCache = IQuestScheduleMainTitle.Create(this.FbInstance.MainTitle);
				}
				else
				{
					IQuestScheduleConfig_SetValue pocoInterface = this.PocoInterface;
					this._MainTitleCache = ((pocoInterface != null) ? pocoInterface.MainTitle : null);
				}
				return this._MainTitleCache;
			}
			set
			{
				this.GetOrCreatePoco().MainTitle = value;
				this._MainTitleInited = false;
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x000F56C4 File Offset: 0x000F38C4
		// (set) Token: 0x060065FE RID: 26110 RVA: 0x000F5757 File Offset: 0x000F3957
		public virtual List<IQuestScheduleSubTitle> SubTitles
		{
			get
			{
				if (this._SubTitlesInited)
				{
					return this._SubTitlesCache;
				}
				this._SubTitlesInited = true;
				if (this.FbInstance != null)
				{
					List<IQuestScheduleSubTitle> subTitles = this.FbInstance.SubTitles;
					if (subTitles != null)
					{
						this._SubTitlesCache = new List<IQuestScheduleSubTitle>(subTitles.Count);
						for (int i = 0; i < subTitles.Count; i++)
						{
							this._SubTitlesCache.Add(IQuestScheduleSubTitle.Create(subTitles[i]));
						}
					}
				}
				else
				{
					IQuestScheduleConfig_SetValue pocoInterface = this.PocoInterface;
					this._SubTitlesCache = ((pocoInterface != null) ? pocoInterface.SubTitles : null);
				}
				return this._SubTitlesCache;
			}
			set
			{
				this.GetOrCreatePoco().SubTitles = value;
				this._SubTitlesInited = false;
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x000F576C File Offset: 0x000F396C
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x000F57CD File Offset: 0x000F39CD
		[Nullable(2)]
		public virtual ITrackTarget TrackTarget
		{
			[NullableContext(2)]
			get
			{
				if (this._TrackTargetInited)
				{
					return this._TrackTargetCache;
				}
				this._TrackTargetInited = true;
				if (this.FbInstance != null)
				{
					this._TrackTargetCache = ITrackTarget.Create(this.FbInstance.TrackTarget);
				}
				else
				{
					IQuestScheduleConfig_SetValue pocoInterface = this.PocoInterface;
					this._TrackTargetCache = ((pocoInterface != null) ? pocoInterface.TrackTarget : null);
				}
				return this._TrackTargetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TrackTarget = value;
				this._TrackTargetInited = false;
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x000F57E4 File Offset: 0x000F39E4
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x000F5845 File Offset: 0x000F3A45
		[Nullable(2)]
		public virtual ILevelPlayTrackRadius TrackRadius
		{
			[NullableContext(2)]
			get
			{
				if (this._TrackRadiusInited)
				{
					return this._TrackRadiusCache;
				}
				this._TrackRadiusInited = true;
				if (this.FbInstance != null)
				{
					this._TrackRadiusCache = ILevelPlayTrackRadius.Create(this.FbInstance.TrackRadius);
				}
				else
				{
					IQuestScheduleConfig_SetValue pocoInterface = this.PocoInterface;
					this._TrackRadiusCache = ((pocoInterface != null) ? pocoInterface.TrackRadius : null);
				}
				return this._TrackRadiusCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TrackRadius = value;
				this._TrackRadiusInited = false;
			}
		}

		// Token: 0x04003D2B RID: 15659
		[Nullable(2)]
		protected IQuestScheduleConfig FbInstance;

		// Token: 0x04003D2C RID: 15660
		[Nullable(2)]
		protected IQuestScheduleConfig_SetValue PocoInterface;

		// Token: 0x04003D2D RID: 15661
		private IQuestScheduleMainTitle _MainTitleCache;

		// Token: 0x04003D2E RID: 15662
		private bool _MainTitleInited;

		// Token: 0x04003D2F RID: 15663
		private List<IQuestScheduleSubTitle> _SubTitlesCache;

		// Token: 0x04003D30 RID: 15664
		private bool _SubTitlesInited;

		// Token: 0x04003D31 RID: 15665
		private ITrackTarget _TrackTargetCache;

		// Token: 0x04003D32 RID: 15666
		private bool _TrackTargetInited;

		// Token: 0x04003D33 RID: 15667
		private ILevelPlayTrackRadius _TrackRadiusCache;

		// Token: 0x04003D34 RID: 15668
		private bool _TrackRadiusInited;
	}
}
