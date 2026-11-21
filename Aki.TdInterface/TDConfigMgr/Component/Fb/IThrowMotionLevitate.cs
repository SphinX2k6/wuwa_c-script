using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C19 RID: 3097
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate : IThrowMotion
	{
		// Token: 0x060046F7 RID: 18167 RVA: 0x000B4324 File Offset: 0x000B2524
		[NullableContext(0)]
		public static IThrowMotionLevitate Create(IThrowMotionLevitate? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowMotionLevitate
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x000B4343 File Offset: 0x000B2543
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x000B4350 File Offset: 0x000B2550
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x000B435D File Offset: 0x000B255D
		public virtual string VelocityCurve
		{
			get
			{
				return this.Instance.VelocityCurve;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x000B436A File Offset: 0x000B256A
		public virtual float MoveTime
		{
			get
			{
				return this.Instance.MoveTime;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x000B4378 File Offset: 0x000B2578
		public virtual float? RayRadius
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.RayRadius);
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x000B43AE File Offset: 0x000B25AE
		public virtual IRenderTrajectoryConfig RenderTrajectoryConfig
		{
			get
			{
				if (this._RenderTrajectoryConfigInited)
				{
					return this._RenderTrajectoryConfigCache;
				}
				this._RenderTrajectoryConfigInited = true;
				this._RenderTrajectoryConfigCache = IRenderTrajectoryConfig.Create(this.Instance.RenderTrajectoryConfig);
				return this._RenderTrajectoryConfigCache;
			}
		}

		// Token: 0x040027C8 RID: 10184
		private IThrowMotionLevitate Instance;

		// Token: 0x040027C9 RID: 10185
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x040027CA RID: 10186
		private bool _RenderTrajectoryConfigInited;
	}
}
