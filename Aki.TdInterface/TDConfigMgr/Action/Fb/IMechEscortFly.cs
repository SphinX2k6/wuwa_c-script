using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE7 RID: 10983
	public class IMechEscortFly : ILeisureInteractType
	{
		// Token: 0x0600F1C1 RID: 61889 RVA: 0x0023583C File Offset: 0x00233A3C
		public static IMechEscortFly Create(IMechEscortFly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechEscortFly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x0600F1C2 RID: 61890 RVA: 0x0023585B File Offset: 0x00233A5B
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x0600F1C3 RID: 61891 RVA: 0x00235868 File Offset: 0x00233A68
		public virtual int TargetEntity
		{
			get
			{
				return this.Instance.TargetEntity;
			}
		}

		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x0600F1C4 RID: 61892 RVA: 0x00235875 File Offset: 0x00233A75
		public virtual int TargetSpline
		{
			get
			{
				return this.Instance.TargetSpline;
			}
		}

		// Token: 0x170048A4 RID: 18596
		// (get) Token: 0x0600F1C5 RID: 61893 RVA: 0x00235884 File Offset: 0x00233A84
		public virtual List<IMechEscortPoint> EscortPoints
		{
			get
			{
				if (this._EscortPointsInited)
				{
					return this._EscortPointsCache;
				}
				this._EscortPointsInited = true;
				int escortPointsLength = this.Instance.EscortPointsLength;
				this._EscortPointsCache = new List<IMechEscortPoint>(escortPointsLength);
				for (int i = 0; i < escortPointsLength; i++)
				{
					this._EscortPointsCache.Add(IMechEscortPoint.Create(this.Instance.EscortPoints(i)));
				}
				return this._EscortPointsCache;
			}
		}

		// Token: 0x040084C1 RID: 33985
		private IMechEscortFly Instance;

		// Token: 0x040084C2 RID: 33986
		private List<IMechEscortPoint> _EscortPointsCache;

		// Token: 0x040084C3 RID: 33987
		private bool _EscortPointsInited;
	}
}
