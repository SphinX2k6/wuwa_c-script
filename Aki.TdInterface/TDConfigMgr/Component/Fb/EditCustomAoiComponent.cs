using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6D RID: 2925
	public class EditCustomAoiComponent : IComponentBase
	{
		// Token: 0x060042DF RID: 17119 RVA: 0x000A9CB6 File Offset: 0x000A7EB6
		public static EditCustomAoiComponent Create(IEditCustomAoiComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EditCustomAoiComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x000A9CD8 File Offset: 0x000A7ED8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x000A9D10 File Offset: 0x000A7F10
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x000A9D28 File Offset: 0x000A7F28
		public virtual List<int> Entities
		{
			get
			{
				if (this._EntitiesInited)
				{
					return this._EntitiesCache;
				}
				this._EntitiesInited = true;
				int entitiesLength = this.Instance.EntitiesLength;
				this._EntitiesCache = new List<int>(entitiesLength);
				for (int i = 0; i < entitiesLength; i++)
				{
					this._EntitiesCache.Add(this.Instance.Entities(i));
				}
				return this._EntitiesCache;
			}
		}

		// Token: 0x040024F0 RID: 9456
		private IEditCustomAoiComponent Instance;

		// Token: 0x040024F1 RID: 9457
		private List<int> _EntitiesCache;

		// Token: 0x040024F2 RID: 9458
		private bool _EntitiesInited;
	}
}
