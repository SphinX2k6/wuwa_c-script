using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AA3 RID: 2723
	[NullableContext(1)]
	[Nullable(0)]
	public class EditCustomAoiComponent : IComponentBase
	{
		// Token: 0x06003EB5 RID: 16053 RVA: 0x000A06C2 File Offset: 0x0009E8C2
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

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x000A06E4 File Offset: 0x0009E8E4
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

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x000A071C File Offset: 0x0009E91C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x000A0734 File Offset: 0x0009E934
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

		// Token: 0x040022D4 RID: 8916
		private IEditCustomAoiComponent Instance;

		// Token: 0x040022D5 RID: 8917
		private List<int> _EntitiesCache;

		// Token: 0x040022D6 RID: 8918
		private bool _EntitiesInited;
	}
}
