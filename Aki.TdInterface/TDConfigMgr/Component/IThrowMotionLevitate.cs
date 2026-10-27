using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076E RID: 1902
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate : IThrowMotion
	{
		// Token: 0x0600291B RID: 10523 RVA: 0x0006C9F8 File Offset: 0x0006ABF8
		[NullableContext(1)]
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

		// Token: 0x0600291C RID: 10524 RVA: 0x0006CA30 File Offset: 0x0006AC30
		[NullableContext(1)]
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

		// Token: 0x0600291D RID: 10525 RVA: 0x0006CA43 File Offset: 0x0006AC43
		[NullableContext(1)]
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

		// Token: 0x0600291E RID: 10526 RVA: 0x0006CA58 File Offset: 0x0006AC58
		[NullableContext(1)]
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

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x0006CAB2 File Offset: 0x0006ACB2
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x0006CADD File Offset: 0x0006ACDD
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x0006CAEB File Offset: 0x0006ACEB
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x0006CB1A File Offset: 0x0006AD1A
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

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x0006CB28 File Offset: 0x0006AD28
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x0006CB4F File Offset: 0x0006AD4F
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0006CB5D File Offset: 0x0006AD5D
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0006CB8C File Offset: 0x0006AD8C
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x0006CB9C File Offset: 0x0006AD9C
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x0006CBD6 File Offset: 0x0006ADD6
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x0006CBE4 File Offset: 0x0006ADE4
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x0006CC45 File Offset: 0x0006AE45
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

		// Token: 0x04001B9E RID: 7070
		protected new IThrowMotionLevitate FbInstance;

		// Token: 0x04001B9F RID: 7071
		protected new IThrowMotionLevitate_SetValue PocoInterface;

		// Token: 0x04001BA0 RID: 7072
		[Nullable(1)]
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x04001BA1 RID: 7073
		private bool _RenderTrajectoryConfigInited;
	}
}
