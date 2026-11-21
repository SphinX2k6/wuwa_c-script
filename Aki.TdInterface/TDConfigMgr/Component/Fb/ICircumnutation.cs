using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C17 RID: 3095
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation : IThrowMotion
	{
		// Token: 0x060046E5 RID: 18149 RVA: 0x000B41D2 File Offset: 0x000B23D2
		[NullableContext(0)]
		public static ICircumnutation Create(ICircumnutation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircumnutation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x000B41F1 File Offset: 0x000B23F1
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060046E7 RID: 18151 RVA: 0x000B41FE File Offset: 0x000B23FE
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x000B420B File Offset: 0x000B240B
		public virtual string VelocityCurve
		{
			get
			{
				return this.Instance.VelocityCurve;
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x000B4218 File Offset: 0x000B2418
		public virtual EDirection Direction
		{
			get
			{
				return (EDirection)this.Instance.Direction;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x000B4225 File Offset: 0x000B2425
		public virtual float AngularVelocity
		{
			get
			{
				return this.Instance.AngularVelocity;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x000B4232 File Offset: 0x000B2432
		public virtual float RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x000B423F File Offset: 0x000B243F
		public virtual string AngularVelocityCurve
		{
			get
			{
				return this.Instance.AngularVelocityCurve;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x000B424C File Offset: 0x000B244C
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

		// Token: 0x040027C2 RID: 10178
		private ICircumnutation Instance;

		// Token: 0x040027C3 RID: 10179
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x040027C4 RID: 10180
		private bool _RenderTrajectoryConfigInited;
	}
}
