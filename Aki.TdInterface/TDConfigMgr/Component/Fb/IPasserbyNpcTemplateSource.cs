using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD8 RID: 3288
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcTemplateSource : IPasserbyNpcSource
	{
		// Token: 0x06004B28 RID: 19240 RVA: 0x000BBDDB File Offset: 0x000B9FDB
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

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004B29 RID: 19241 RVA: 0x000BBDFA File Offset: 0x000B9FFA
		public override EPasserbyNpcSource Type
		{
			get
			{
				return (EPasserbyNpcSource)this.Instance.Type;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x000BBE08 File Offset: 0x000BA008
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

		// Token: 0x04002AFB RID: 11003
		private IPasserbyNpcTemplateSource Instance;

		// Token: 0x04002AFC RID: 11004
		private List<string> _TemplateIdsCache;

		// Token: 0x04002AFD RID: 11005
		private bool _TemplateIdsInited;
	}
}
