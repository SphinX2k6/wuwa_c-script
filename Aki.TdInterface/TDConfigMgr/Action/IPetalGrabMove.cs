using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE5 RID: 7909
	public class IPetalGrabMove : ISplineMovePattern
	{
		// Token: 0x0600A853 RID: 43091 RVA: 0x0017E85C File Offset: 0x0017CA5C
		private IPetalGrabMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x0017E894 File Offset: 0x0017CA94
		public static IPetalGrabMove Create([Nullable(2)] IPetalGrabMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x0017E8A7 File Offset: 0x0017CAA7
		public static IPetalGrabMove CreateFromSetValue([Nullable(2)] IPetalGrabMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x0017E8BC File Offset: 0x0017CABC
		public new IPetalGrabMove_SetValue ToSetValue()
		{
			return new IPetalGrabMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				ControlType = this.ControlType
			};
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x0017E92E File Offset: 0x0017CB2E
		// (set) Token: 0x0600A858 RID: 43096 RVA: 0x0017E959 File Offset: 0x0017CB59
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600A859 RID: 43097 RVA: 0x0017E968 File Offset: 0x0017CB68
		// (set) Token: 0x0600A85A RID: 43098 RVA: 0x0017E9A2 File Offset: 0x0017CBA2
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x0017E9B0 File Offset: 0x0017CBB0
		// (set) Token: 0x0600A85C RID: 43100 RVA: 0x0017E9EA File Offset: 0x0017CBEA
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x0017E9F8 File Offset: 0x0017CBF8
		// (set) Token: 0x0600A85E RID: 43102 RVA: 0x0017EA32 File Offset: 0x0017CC32
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600A85F RID: 43103 RVA: 0x0017EA40 File Offset: 0x0017CC40
		// (set) Token: 0x0600A860 RID: 43104 RVA: 0x0017EA7A File Offset: 0x0017CC7A
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600A861 RID: 43105 RVA: 0x0017EA88 File Offset: 0x0017CC88
		// (set) Token: 0x0600A862 RID: 43106 RVA: 0x0017EAC2 File Offset: 0x0017CCC2
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600A863 RID: 43107 RVA: 0x0017EAD0 File Offset: 0x0017CCD0
		// (set) Token: 0x0600A864 RID: 43108 RVA: 0x0017EB0A File Offset: 0x0017CD0A
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600A865 RID: 43109 RVA: 0x0017EB18 File Offset: 0x0017CD18
		// (set) Token: 0x0600A866 RID: 43110 RVA: 0x0017EB79 File Offset: 0x0017CD79
		public virtual IPetalGrabMoveLinear ControlType
		{
			get
			{
				if (this._ControlTypeInited)
				{
					return this._ControlTypeCache;
				}
				this._ControlTypeInited = true;
				if (this.FbInstance != null)
				{
					this._ControlTypeCache = IPetalGrabMoveLinear.Create(this.FbInstance.ControlType);
				}
				else
				{
					IPetalGrabMove_SetValue pocoInterface = this.PocoInterface;
					this._ControlTypeCache = ((pocoInterface != null) ? pocoInterface.ControlType : null);
				}
				return this._ControlTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().ControlType = value;
				this._ControlTypeInited = false;
			}
		}

		// Token: 0x04006535 RID: 25909
		[Nullable(2)]
		protected new IPetalGrabMove FbInstance;

		// Token: 0x04006536 RID: 25910
		[Nullable(2)]
		protected new IPetalGrabMove_SetValue PocoInterface;

		// Token: 0x04006537 RID: 25911
		private IPetalGrabMoveLinear _ControlTypeCache;

		// Token: 0x04006538 RID: 25912
		private bool _ControlTypeInited;
	}
}
