using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED8 RID: 3800
	public class ITimeScheduleEntityTemplateNpcSource : ITimeScheduleNpcSource
	{
		// Token: 0x0600559E RID: 21918 RVA: 0x000D2501 File Offset: 0x000D0701
		public static ITimeScheduleEntityTemplateNpcSource Create(ITimeScheduleEntityTemplateNpcSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleEntityTemplateNpcSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x000D2520 File Offset: 0x000D0720
		public override ETimeScheduleNpcSourceType Type
		{
			get
			{
				return (ETimeScheduleNpcSourceType)this.Instance.Type;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x000D2530 File Offset: 0x000D0730
		public virtual List<string> TemplateIds
		{
			get
			{
				if (this._TemplateIdsInited)
				{
					return this._TemplateIdsCache;
				}
				this._TemplateIdsInited = true;
				int templateIdsLength = this.Instance.TemplateIdsLength;
				this._TemplateIdsCache = new List<string>(templateIdsLength);
				for (int i = 0; i < templateIdsLength; i++)
				{
					this._TemplateIdsCache.Add(this.Instance.TemplateIds(i));
				}
				return this._TemplateIdsCache;
			}
		}

		// Token: 0x040030FB RID: 12539
		private ITimeScheduleEntityTemplateNpcSource Instance;

		// Token: 0x040030FC RID: 12540
		private List<string> _TemplateIdsCache;

		// Token: 0x040030FD RID: 12541
		private bool _TemplateIdsInited;
	}
}
