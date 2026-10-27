using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000241 RID: 577
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation : IThrowMotion
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x0002B1E8 File Offset: 0x000293E8
		[NullableContext(1)]
		private ICircumnutation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICircumnutation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICircumnutation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICircumnutation_SetValue());
			}
			return result;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002B220 File Offset: 0x00029420
		[NullableContext(1)]
		public static ICircumnutation Create([Nullable(2)] ICircumnutation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircumnutation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002B233 File Offset: 0x00029433
		[NullableContext(1)]
		public static ICircumnutation CreateFromSetValue([Nullable(2)] ICircumnutation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICircumnutation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002B248 File Offset: 0x00029448
		[NullableContext(1)]
		public new ICircumnutation_SetValue ToSetValue()
		{
			return new ICircumnutation_SetValue
			{
				Type = this.Type,
				Velocity = this.Velocity,
				VelocityCurve = this.VelocityCurve,
				Direction = this.Direction,
				AngularVelocity = this.AngularVelocity,
				RotationSpeed = this.RotationSpeed,
				AngularVelocityCurve = this.AngularVelocityCurve,
				RenderTrajectoryConfig = this.RenderTrajectoryConfig
			};
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002B2BA File Offset: 0x000294BA
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0002B2E5 File Offset: 0x000294E5
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002B2F3 File Offset: 0x000294F3
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0002B322 File Offset: 0x00029522
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002B330 File Offset: 0x00029530
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0002B357 File Offset: 0x00029557
		public virtual string VelocityCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VelocityCurve;
				}
				ICircumnutation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002B365 File Offset: 0x00029565
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002B390 File Offset: 0x00029590
		public virtual EDirection Direction
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Direction;
				}
				if (this.PocoInterface == null)
				{
					return EDirection.Right;
				}
				return this.PocoInterface.Direction;
			}
			set
			{
				this.GetOrCreatePoco().Direction = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002B39E File Offset: 0x0002959E
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x0002B3CD File Offset: 0x000295CD
		public virtual float AngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AngularVelocity;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.AngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().AngularVelocity = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002B3DB File Offset: 0x000295DB
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x0002B40A File Offset: 0x0002960A
		public virtual float RotationSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotationSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RotationSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotationSpeed = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0002B418 File Offset: 0x00029618
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0002B43F File Offset: 0x0002963F
		public virtual string AngularVelocityCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AngularVelocityCurve;
				}
				ICircumnutation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AngularVelocityCurve;
			}
			set
			{
				this.GetOrCreatePoco().AngularVelocityCurve = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002B450 File Offset: 0x00029650
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0002B4B1 File Offset: 0x000296B1
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
					ICircumnutation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000A52 RID: 2642
		protected new ICircumnutation FbInstance;

		// Token: 0x04000A53 RID: 2643
		protected new ICircumnutation_SetValue PocoInterface;

		// Token: 0x04000A54 RID: 2644
		[Nullable(1)]
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x04000A55 RID: 2645
		private bool _RenderTrajectoryConfigInited;
	}
}
