using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B4 RID: 5556
	public class IRecallConditionByTemplate : IRecallConditionBase
	{
		// Token: 0x06007D3A RID: 32058 RVA: 0x00129924 File Offset: 0x00127B24
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

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06007D3B RID: 32059 RVA: 0x00129943 File Offset: 0x00127B43
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x00129950 File Offset: 0x00127B50
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06007D3D RID: 32061 RVA: 0x00129960 File Offset: 0x00127B60
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

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06007D3E RID: 32062 RVA: 0x001299C4 File Offset: 0x00127BC4
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

		// Token: 0x0400485C RID: 18524
		private IRecallConditionByTemplate Instance;

		// Token: 0x0400485D RID: 18525
		private List<string> _TemplatesCache;

		// Token: 0x0400485E RID: 18526
		private bool _TemplatesInited;

		// Token: 0x0400485F RID: 18527
		private List<int> _AreaIdsCache;

		// Token: 0x04004860 RID: 18528
		private bool _AreaIdsInited;
	}
}
