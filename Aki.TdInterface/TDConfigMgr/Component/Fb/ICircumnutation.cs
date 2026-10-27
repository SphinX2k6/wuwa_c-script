using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B49 RID: 2889
	[NullableContext(2)]
	[Nullable(0)]
	public class ICircumnutation : IThrowMotion
	{
		// Token: 0x0600428C RID: 17036 RVA: 0x000AA10E File Offset: 0x000A830E
		[NullableContext(1)]
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x000AA12D File Offset: 0x000A832D
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x000AA13A File Offset: 0x000A833A
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x000AA147 File Offset: 0x000A8347
		public virtual string VelocityCurve
		{
			get
			{
				return this.Instance.VelocityCurve;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x000AA154 File Offset: 0x000A8354
		public virtual EDirection Direction
		{
			get
			{
				return (EDirection)this.Instance.Direction;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x000AA161 File Offset: 0x000A8361
		public virtual float AngularVelocity
		{
			get
			{
				return this.Instance.AngularVelocity;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x000AA16E File Offset: 0x000A836E
		public virtual float RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x000AA17B File Offset: 0x000A837B
		public virtual string AngularVelocityCurve
		{
			get
			{
				return this.Instance.AngularVelocityCurve;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x000AA188 File Offset: 0x000A8388
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

		// Token: 0x0400257A RID: 9594
		private ICircumnutation Instance;

		// Token: 0x0400257B RID: 9595
		private IRenderTrajectoryConfig _RenderTrajectoryConfigCache;

		// Token: 0x0400257C RID: 9596
		private bool _RenderTrajectoryConfigInited;
	}
}
