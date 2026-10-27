using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002768 RID: 10088
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlTrackingOther : IControlTrackingType
	{
		// Token: 0x0600E0B4 RID: 57524 RVA: 0x00213551 File Offset: 0x00211751
		public static IControlTrackingOther Create(IControlTrackingOther? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingOther
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x0600E0B5 RID: 57525 RVA: 0x00213570 File Offset: 0x00211770
		public override EControlTrackingType Type
		{
			get
			{
				return (EControlTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x0600E0B6 RID: 57526 RVA: 0x00213580 File Offset: 0x00211780
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

		// Token: 0x04007C6C RID: 31852
		private IControlTrackingOther Instance;

		// Token: 0x04007C6D RID: 31853
		private List<int> _EntitiesCache;

		// Token: 0x04007C6E RID: 31854
		private bool _EntitiesInited;
	}
}
