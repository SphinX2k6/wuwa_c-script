using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080F RID: 2063
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate : IThrowMotion
	{
		// Token: 0x06002C3F RID: 11327 RVA: 0x00073BA0 File Offset: 0x00071DA0
		[NullableContext(0)]
		private IThrowMotionLevitate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThrowMotionLevitate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThrowMotionLevitate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThrowMotionLevitate_SetValue());
			}
			return result;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00073BD8 File Offset: 0x00071DD8
		[NullableContext(0)]
		public static IThrowMotionLevitate Create([Nullable(2)] IThrowMotionLevitate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowMotionLevitate
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00073BEB File Offset: 0x00071DEB
		[NullableContext(0)]
		public static IThrowMotionLevitate CreateFromSetValue([Nullable(2)] IThrowMotionLevitate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThrowMotionLevitate
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00073C00 File Offset: 0x00071E00
		[NullableContext(0)]
		public new IThrowMotionLevitate_SetValue ToSetValue()
		{
			return new IThrowMotionLevitate_SetValue
			{
				Type = this.Type,
				Velocity = this.Velocity,
				VelocityCurve = this.VelocityCurve,
				MoveTime = this.MoveTime,
				RayRadius = this.RayRadius,
				RenderTrajectoryConfig = this.RenderTrajectoryConfig
			};
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00073C5A File Offset: 0x00071E5A
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x00073C85 File Offset: 0x00071E85
		public override EThrowMotion Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EThrowMotion.Projectile;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00073C93 File Offset: 0x00071E93
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00073CC2 File Offset: 0x00071EC2
		public virtual float Velocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Velocity;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Velocity;
			}
			set
			{
				this.GetOrCreatePoco().Velocity = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00073CD0 File Offset: 0x00071ED0
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x00073CF7 File Offset: 0x00071EF7
		public virtual string VelocityCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VelocityCurve;
				}
				IThrowMotionLevitate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VelocityCurve;
			}
			set
			{
				this.GetOrCreatePoco().VelocityCurve = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00073D05 File Offset: 0x00071F05
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x00073D34 File Offset: 0x00071F34
		public virtual float MoveTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MoveTime;
			}
			set
			{
				this.GetOrCreatePoco().MoveTime = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x00073D44 File Offset: 0x00071F44
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00073D7E File Offset: 0x00071F7E
		public virtual float? RayRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RayRadius;
				}
				IThrowMotionLevitate_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RayRadius;
			}
			set
			{
				this.GetOrCreatePoco().RayRadius = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00073D8C File Offset: 0x00071F8C
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00073DED File Offset: 0x00071FED
		public virtual IRenderTrajectoryConfig RenderTrajectoryConfig
		{
			get
			{
				if (this._RenderTrajectoryConfigInited)
				{
					return this._RenderTrajectoryConfigCache;
				}
				this._RenderTrajectoryConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RenderTrajectoryConfigCache = IRenderTrajectoryConfig.Create(this.FbInstance.RenderTrajectoryConfig);
				}
				else
				{
					IThrowMotionLevitate_SetValue pocoInterface = this.PocoInterface;
					this._RenderTrajectoryConfigCache = ((pocoInterface != null) ? pocoInterface.RenderTrajectoryConfig : null);
				}
				return this._RenderTrajectoryConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RenderTrajectoryConfig = value;
				this._RenderTrajectoryConfigInited = false;
			}
		}

		// Token: 0x04001DA3 RID: 7587
		protected new IThrowMotionLevitate FbInstance;

		// Token: 0x04001DA4 RID: 7588
		protected new IThrowMotionLevitate_SetValue PocoInterface;

		// Token: 0x04001DA5 RID: 7589
		[Nullable(0)]
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x04001DA6 RID: 7590
		private bool _RenderTrajectoryConfigInited;
	}
}
