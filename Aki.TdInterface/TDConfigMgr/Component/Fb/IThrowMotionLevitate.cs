using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4B RID: 2891
	[NullableContext(2)]
	[Nullable(0)]
	public class IThrowMotionLevitate : IThrowMotion
	{
		// Token: 0x0600429E RID: 17054 RVA: 0x000AA260 File Offset: 0x000A8460
		[NullableContext(1)]
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

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x000AA27F File Offset: 0x000A847F
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x000AA28C File Offset: 0x000A848C
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x000AA299 File Offset: 0x000A8499
		public virtual string VelocityCurve
		{
			get
			{
				return this.Instance.VelocityCurve;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x000AA2A6 File Offset: 0x000A84A6
		public virtual float MoveTime
		{
			get
			{
				return this.Instance.MoveTime;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x000AA2B4 File Offset: 0x000A84B4
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

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x000AA2EA File Offset: 0x000A84EA
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

		// Token: 0x04002580 RID: 9600
		private IThrowMotionLevitate Instance;

		// Token: 0x04002581 RID: 9601
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x04002582 RID: 9602
		private bool _RenderTrajectoryConfigInited;
	}
}
