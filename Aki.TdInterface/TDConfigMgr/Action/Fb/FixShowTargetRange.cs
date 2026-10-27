using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024E1 RID: 9441
	[NullableContext(1)]
	[Nullable(0)]
	public class FixShowTargetRange : ActionParams
	{
		// Token: 0x0600D2BD RID: 53949 RVA: 0x001F41EC File Offset: 0x001F23EC
		public static FixShowTargetRange Create(IFixShowTargetRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600D2BE RID: 53950 RVA: 0x001F420C File Offset: 0x001F240C
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this._RangeEntitiesInited)
				{
					return this._RangeEntitiesCache;
				}
				this._RangeEntitiesInited = true;
				int rangeEntitiesLength = this.Instance.RangeEntitiesLength;
				this._RangeEntitiesCache = new List<int>(rangeEntitiesLength);
				for (int i = 0; i < rangeEntitiesLength; i++)
				{
					this._RangeEntitiesCache.Add(this.Instance.RangeEntities(i));
				}
				return this._RangeEntitiesCache;
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600D2BF RID: 53951 RVA: 0x001F4270 File Offset: 0x001F2470
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x04007397 RID: 29591
		private IFixShowTargetRange Instance;

		// Token: 0x04007398 RID: 29592
		private List<int> _RangeEntitiesCache;

		// Token: 0x04007399 RID: 29593
		private bool _RangeEntitiesInited;
	}
}
