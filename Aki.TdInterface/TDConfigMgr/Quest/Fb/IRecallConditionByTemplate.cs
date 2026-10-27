using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145B RID: 5211
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByTemplate : IRecallConditionBase
	{
		// Token: 0x0600766D RID: 30317 RVA: 0x0011AD40 File Offset: 0x00118F40
		public static IRecallConditionByTemplate Create(IRecallConditionByTemplate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByTemplate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x0011AD5F File Offset: 0x00118F5F
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600766F RID: 30319 RVA: 0x0011AD6C File Offset: 0x00118F6C
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x0011AD7C File Offset: 0x00118F7C
		public virtual List<string> Templates
		{
			get
			{
				if (this._TemplatesInited)
				{
					return this._TemplatesCache;
				}
				this._TemplatesInited = true;
				int templatesLength = this.Instance.TemplatesLength;
				this._TemplatesCache = new List<string>(templatesLength);
				for (int i = 0; i < templatesLength; i++)
				{
					this._TemplatesCache.Add(this.Instance.Templates(i));
				}
				return this._TemplatesCache;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06007671 RID: 30321 RVA: 0x0011ADE0 File Offset: 0x00118FE0
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x040044C3 RID: 17603
		private IRecallConditionByTemplate Instance;

		// Token: 0x040044C4 RID: 17604
		private List<string> _TemplatesCache;

		// Token: 0x040044C5 RID: 17605
		private bool _TemplatesInited;

		// Token: 0x040044C6 RID: 17606
		private List<int> _AreaIdsCache;

		// Token: 0x040044C7 RID: 17607
		private bool _AreaIdsInited;
	}
}
