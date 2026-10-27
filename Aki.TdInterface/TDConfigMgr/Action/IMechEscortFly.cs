using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC8 RID: 7112
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechEscortFly : ILeisureInteractType
	{
		// Token: 0x0600985D RID: 39005 RVA: 0x0015F37C File Offset: 0x0015D57C
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

		// Token: 0x0600985E RID: 39006 RVA: 0x0015F3B4 File Offset: 0x0015D5B4
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

		// Token: 0x0600985F RID: 39007 RVA: 0x0015F3C7 File Offset: 0x0015D5C7
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

		// Token: 0x06009860 RID: 39008 RVA: 0x0015F3DA File Offset: 0x0015D5DA
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

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x06009861 RID: 39009 RVA: 0x0015F411 File Offset: 0x0015D611
		// (set) Token: 0x06009862 RID: 39010 RVA: 0x0015F43C File Offset: 0x0015D63C
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

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06009863 RID: 39011 RVA: 0x0015F44A File Offset: 0x0015D64A
		// (set) Token: 0x06009864 RID: 39012 RVA: 0x0015F475 File Offset: 0x0015D675
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

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x06009865 RID: 39013 RVA: 0x0015F483 File Offset: 0x0015D683
		// (set) Token: 0x06009866 RID: 39014 RVA: 0x0015F4AE File Offset: 0x0015D6AE
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

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x0015F4BC File Offset: 0x0015D6BC
		// (set) Token: 0x06009868 RID: 39016 RVA: 0x0015F54F File Offset: 0x0015D74F
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

		// Token: 0x04005CF0 RID: 23792
		[Nullable(2)]
		protected new IMechEscortFly FbInstance;

		// Token: 0x04005CF1 RID: 23793
		[Nullable(2)]
		protected new IMechEscortFly_SetValue PocoInterface;

		// Token: 0x04005CF2 RID: 23794
		private List<IMechEscortPoint> _EscortPointsCache;

		// Token: 0x04005CF3 RID: 23795
		private bool _EscortPointsInited;
	}
}
