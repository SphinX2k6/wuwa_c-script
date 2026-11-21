using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E5 RID: 1509
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo
	{
		// Token: 0x06001EC6 RID: 7878 RVA: 0x00056D28 File Offset: 0x00054F28
		[NullableContext(0)]
		private INpcStandbyShowFinitelyInfo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcStandbyShowFinitelyInfo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcStandbyShowFinitelyInfo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcStandbyShowFinitelyInfo_SetValue());
			}
			return result;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00056D60 File Offset: 0x00054F60
		[NullableContext(0)]
		public static INpcStandbyShowFinitelyInfo Create([Nullable(2)] INpcStandbyShowFinitelyInfo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00056D73 File Offset: 0x00054F73
		[NullableContext(0)]
		public static INpcStandbyShowFinitelyInfo CreateFromSetValue([Nullable(2)] INpcStandbyShowFinitelyInfo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00056D88 File Offset: 0x00054F88
		[NullableContext(0)]
		public INpcStandbyShowFinitelyInfo_SetValue ToSetValue()
		{
			return new INpcStandbyShowFinitelyInfo_SetValue
			{
				Montage = this.Montage,
				RegisteredMontageId = this.RegisteredMontageId,
				FaceExpressionId = this.FaceExpressionId,
				Time = this.Time,
				IgnoreEntityCollision = this.IgnoreEntityCollision
			};
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00056DD6 File Offset: 0x00054FD6
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00056DFD File Offset: 0x00054FFD
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Montage;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00056E0C File Offset: 0x0005500C
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00056E6D File Offset: 0x0005506D
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._RegisteredMontageIdCache = IMontageId.Create(this.FbInstance.RegisteredMontageId);
				}
				else
				{
					INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
					this._RegisteredMontageIdCache = ((pocoInterface != null) ? pocoInterface.RegisteredMontageId : null);
				}
				return this._RegisteredMontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().RegisteredMontageId = value;
				this._RegisteredMontageIdInited = false;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00056E84 File Offset: 0x00055084
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00056EBE File Offset: 0x000550BE
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00056ECC File Offset: 0x000550CC
		// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00056EF7 File Offset: 0x000550F7
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x00056F08 File Offset: 0x00055108
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00056F69 File Offset: 0x00055169
		public virtual IIgnoreEntityIdsCollision IgnoreEntityCollision
		{
			get
			{
				if (this._IgnoreEntityCollisionInited)
				{
					return this._IgnoreEntityCollisionCache;
				}
				this._IgnoreEntityCollisionInited = true;
				if (this.FbInstance != null)
				{
					this._IgnoreEntityCollisionCache = IIgnoreEntityIdsCollision.Create(this.FbInstance.IgnoreEntityCollision);
				}
				else
				{
					INpcStandbyShowFinitelyInfo_SetValue pocoInterface = this.PocoInterface;
					this._IgnoreEntityCollisionCache = ((pocoInterface != null) ? pocoInterface.IgnoreEntityCollision : null);
				}
				return this._IgnoreEntityCollisionCache;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreEntityCollision = value;
				this._IgnoreEntityCollisionInited = false;
			}
		}

		// Token: 0x040015DF RID: 5599
		protected INpcStandbyShowFinitelyInfo FbInstance;

		// Token: 0x040015E0 RID: 5600
		protected INpcStandbyShowFinitelyInfo_SetValue PocoInterface;

		// Token: 0x040015E1 RID: 5601
		[Nullable(0)]
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x040015E2 RID: 5602
		private bool _RegisteredMontageIdInited;

		// Token: 0x040015E3 RID: 5603
		[Nullable(0)]
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x040015E4 RID: 5604
		private bool _IgnoreEntityCollisionInited;
	}
}
