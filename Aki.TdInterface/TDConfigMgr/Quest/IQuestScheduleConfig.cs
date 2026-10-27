using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200109F RID: 4255
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleConfig
	{
		// Token: 0x06005FFC RID: 24572 RVA: 0x000E8444 File Offset: 0x000E6644
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

		// Token: 0x06005FFD RID: 24573 RVA: 0x000E847C File Offset: 0x000E667C
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

		// Token: 0x06005FFE RID: 24574 RVA: 0x000E848F File Offset: 0x000E668F
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

		// Token: 0x06005FFF RID: 24575 RVA: 0x000E84A4 File Offset: 0x000E66A4
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

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x000E84F2 File Offset: 0x000E66F2
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x000E851D File Offset: 0x000E671D
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

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x000E852C File Offset: 0x000E672C
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x000E858D File Offset: 0x000E678D
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

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x000E85A4 File Offset: 0x000E67A4
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x000E8637 File Offset: 0x000E6837
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

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x000E864C File Offset: 0x000E684C
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x000E86AD File Offset: 0x000E68AD
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

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x000E86C4 File Offset: 0x000E68C4
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x000E8725 File Offset: 0x000E6925
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

		// Token: 0x040039DE RID: 14814
		[Nullable(2)]
		protected IQuestScheduleConfig FbInstance;

		// Token: 0x040039DF RID: 14815
		[Nullable(2)]
		protected IQuestScheduleConfig_SetValue PocoInterface;

		// Token: 0x040039E0 RID: 14816
		private IQuestScheduleMainTitle _MainTitleCache;

		// Token: 0x040039E1 RID: 14817
		private bool _MainTitleInited;

		// Token: 0x040039E2 RID: 14818
		private List<IQuestScheduleSubTitle> _SubTitlesCache;

		// Token: 0x040039E3 RID: 14819
		private bool _SubTitlesInited;

		// Token: 0x040039E4 RID: 14820
		private ITrackTarget _TrackTargetCache;

		// Token: 0x040039E5 RID: 14821
		private bool _TrackTargetInited;

		// Token: 0x040039E6 RID: 14822
		private ILevelPlayTrackRadius _TrackRadiusCache;

		// Token: 0x040039E7 RID: 14823
		private bool _TrackRadiusInited;
	}
}
