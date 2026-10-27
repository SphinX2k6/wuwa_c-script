using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002644 RID: 9796
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityClientVisible : ActionParams
	{
		// Token: 0x0600DBC6 RID: 56262 RVA: 0x0020B562 File Offset: 0x00209762
		public static SetEntityClientVisible Create(ISetEntityClientVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0600DBC7 RID: 56263 RVA: 0x0020B584 File Offset: 0x00209784
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x0020B5E8 File Offset: 0x002097E8
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x04007A20 RID: 31264
		private ISetEntityClientVisible Instance;

		// Token: 0x04007A21 RID: 31265
		private List<int> _EntityIdsCache;

		// Token: 0x04007A22 RID: 31266
		private bool _EntityIdsInited;
	}
}
