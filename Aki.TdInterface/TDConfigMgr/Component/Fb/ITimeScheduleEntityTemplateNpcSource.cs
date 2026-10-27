using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE0 RID: 3552
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleEntityTemplateNpcSource : ITimeScheduleNpcSource
	{
		// Token: 0x06005085 RID: 20613 RVA: 0x000C6D81 File Offset: 0x000C4F81
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

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x000C6DA0 File Offset: 0x000C4FA0
		public override ETimeScheduleNpcSourceType Type
		{
			get
			{
				return (ETimeScheduleNpcSourceType)this.Instance.Type;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x000C6DB0 File Offset: 0x000C4FB0
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

		// Token: 0x04002E39 RID: 11833
		private ITimeScheduleEntityTemplateNpcSource Instance;

		// Token: 0x04002E3A RID: 11834
		private List<string> _TemplateIdsCache;

		// Token: 0x04002E3B RID: 11835
		private bool _TemplateIdsInited;
	}
}
