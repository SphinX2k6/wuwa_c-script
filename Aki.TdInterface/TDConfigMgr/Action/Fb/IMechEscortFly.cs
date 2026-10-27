using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002814 RID: 10260
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechEscortFly : ILeisureInteractType
	{
		// Token: 0x0600E39C RID: 58268 RVA: 0x002189D8 File Offset: 0x00216BD8
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

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x0600E39D RID: 58269 RVA: 0x002189F7 File Offset: 0x00216BF7
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00218A04 File Offset: 0x00216C04
		public virtual int TargetEntity
		{
			get
			{
				return this.Instance.TargetEntity;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x0600E39F RID: 58271 RVA: 0x00218A11 File Offset: 0x00216C11
		public virtual int TargetSpline
		{
			get
			{
				return this.Instance.TargetSpline;
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x00218A20 File Offset: 0x00216C20
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

		// Token: 0x04007E04 RID: 32260
		private IMechEscortFly Instance;

		// Token: 0x04007E05 RID: 32261
		private List<IMechEscortPoint> _EscortPointsCache;

		// Token: 0x04007E06 RID: 32262
		private bool _EscortPointsInited;
	}
}
