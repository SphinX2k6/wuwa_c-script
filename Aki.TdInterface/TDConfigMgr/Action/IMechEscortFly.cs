using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DAF RID: 7599
	public class IMechEscortFly : ILeisureInteractType
	{
		// Token: 0x0600A161 RID: 41313 RVA: 0x00171E3C File Offset: 0x0017003C
		private IMechEscortFly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechEscortFly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechEscortFly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechEscortFly_SetValue());
			}
			return result;
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00171E74 File Offset: 0x00170074
		public static IMechEscortFly Create([Nullable(2)] IMechEscortFly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechEscortFly
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00171E87 File Offset: 0x00170087
		public static IMechEscortFly CreateFromSetValue([Nullable(2)] IMechEscortFly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechEscortFly
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00171E9A File Offset: 0x0017009A
		public new IMechEscortFly_SetValue ToSetValue()
		{
			return new IMechEscortFly_SetValue
			{
				Type = this.Type,
				TargetEntity = this.TargetEntity,
				TargetSpline = this.TargetSpline,
				EscortPoints = this.EscortPoints
			};
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A165 RID: 41317 RVA: 0x00171ED1 File Offset: 0x001700D1
		// (set) Token: 0x0600A166 RID: 41318 RVA: 0x00171EFC File Offset: 0x001700FC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A167 RID: 41319 RVA: 0x00171F0A File Offset: 0x0017010A
		// (set) Token: 0x0600A168 RID: 41320 RVA: 0x00171F35 File Offset: 0x00170135
		public virtual int TargetEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetEntity;
			}
			set
			{
				this.GetOrCreatePoco().TargetEntity = value;
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A169 RID: 41321 RVA: 0x00171F43 File Offset: 0x00170143
		// (set) Token: 0x0600A16A RID: 41322 RVA: 0x00171F6E File Offset: 0x0017016E
		public virtual int TargetSpline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetSpline;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetSpline;
			}
			set
			{
				this.GetOrCreatePoco().TargetSpline = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A16B RID: 41323 RVA: 0x00171F7C File Offset: 0x0017017C
		// (set) Token: 0x0600A16C RID: 41324 RVA: 0x0017200F File Offset: 0x0017020F
		public virtual List<IMechEscortPoint> EscortPoints
		{
			get
			{
				if (this._EscortPointsInited)
				{
					return this._EscortPointsCache;
				}
				this._EscortPointsInited = true;
				if (this.FbInstance != null)
				{
					List<IMechEscortPoint> escortPoints = this.FbInstance.EscortPoints;
					if (escortPoints != null)
					{
						this._EscortPointsCache = new List<IMechEscortPoint>(escortPoints.Count);
						for (int i = 0; i < escortPoints.Count; i++)
						{
							this._EscortPointsCache.Add(IMechEscortPoint.Create(escortPoints[i]));
						}
					}
				}
				else
				{
					IMechEscortFly_SetValue pocoInterface = this.PocoInterface;
					this._EscortPointsCache = ((pocoInterface != null) ? pocoInterface.EscortPoints : null);
				}
				return this._EscortPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().EscortPoints = value;
				this._EscortPointsInited = false;
			}
		}

		// Token: 0x04006205 RID: 25093
		[Nullable(2)]
		protected new IMechEscortFly FbInstance;

		// Token: 0x04006206 RID: 25094
		[Nullable(2)]
		protected new IMechEscortFly_SetValue PocoInterface;

		// Token: 0x04006207 RID: 25095
		private List<IMechEscortPoint> _EscortPointsCache;

		// Token: 0x04006208 RID: 25096
		private bool _EscortPointsInited;
	}
}
