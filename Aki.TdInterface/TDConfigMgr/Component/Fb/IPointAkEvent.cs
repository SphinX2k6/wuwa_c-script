using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADA RID: 2778
	[NullableContext(2)]
	[Nullable(0)]
	public class IPointAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06003FFD RID: 16381 RVA: 0x000A389A File Offset: 0x000A1A9A
		[NullableContext(1)]
		public static IPointAkEvent Create(IPointAkEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointAkEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x000A38B9 File Offset: 0x000A1AB9
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003FFF RID: 16383 RVA: 0x000A38C8 File Offset: 0x000A1AC8
		public virtual List<int> PointIds
		{
			get
			{
				if (this._PointIdsInited)
				{
					return this._PointIdsCache;
				}
				this._PointIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int pointIdsLength = this.Instance.PointIdsLength;
				this._PointIdsCache = new List<int>(pointIdsLength);
				for (int i = 0; i < pointIdsLength; i++)
				{
					this._PointIdsCache.Add(this.Instance.PointIds(i));
				}
				return this._PointIdsCache;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06004000 RID: 16384 RVA: 0x000A3940 File Offset: 0x000A1B40
		public virtual bool? UseListenerCone
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseListenerCone);
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06004001 RID: 16385 RVA: 0x000A3978 File Offset: 0x000A1B78
		public virtual bool? EnableOcclusion
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableOcclusion);
			}
		}

		// Token: 0x0400239F RID: 9119
		private IPointAkEvent Instance;

		// Token: 0x040023A0 RID: 9120
		private List<int> _PointIdsCache;

		// Token: 0x040023A1 RID: 9121
		private bool _PointIdsInited;
	}
}
