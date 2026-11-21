using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DCE RID: 3534
	public class IPasserbyNpcTemplateSource : IPasserbyNpcSource
	{
		// Token: 0x0600502B RID: 20523 RVA: 0x000C7147 File Offset: 0x000C5347
		public static IPasserbyNpcTemplateSource Create(IPasserbyNpcTemplateSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcTemplateSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x000C7166 File Offset: 0x000C5366
		public override EPasserbyNpcSource Type
		{
			get
			{
				return (EPasserbyNpcSource)this.Instance.Type;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x0600502D RID: 20525 RVA: 0x000C7174 File Offset: 0x000C5374
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

		// Token: 0x04002DAB RID: 11691
		private IPasserbyNpcTemplateSource Instance;

		// Token: 0x04002DAC RID: 11692
		private List<string> _TemplateIdsCache;

		// Token: 0x04002DAD RID: 11693
		private bool _TemplateIdsInited;
	}
}
