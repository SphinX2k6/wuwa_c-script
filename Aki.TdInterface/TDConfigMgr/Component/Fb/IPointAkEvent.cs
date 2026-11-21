using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA4 RID: 2980
	[NullableContext(2)]
	[Nullable(0)]
	public class IPointAkEvent : IAkEventTypeConfig
	{
		// Token: 0x06004427 RID: 17447 RVA: 0x000ACE8E File Offset: 0x000AB08E
		[NullableContext(0)]
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x000ACEAD File Offset: 0x000AB0AD
		public override EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x000ACEBC File Offset: 0x000AB0BC
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

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x000ACF34 File Offset: 0x000AB134
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

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x000ACF6C File Offset: 0x000AB16C
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

		// Token: 0x040025BB RID: 9659
		private IPointAkEvent Instance;

		// Token: 0x040025BC RID: 9660
		private List<int> _PointIdsCache;

		// Token: 0x040025BD RID: 9661
		private bool _PointIdsInited;
	}
}
