using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B47 RID: 2887
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion : IThrowMotion
	{
		// Token: 0x06004281 RID: 17025 RVA: 0x000AA03E File Offset: 0x000A823E
		[NullableContext(1)]
		public static IProjectileMotion Create(IProjectileMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectileMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x000AA05D File Offset: 0x000A825D
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x000AA06A File Offset: 0x000A826A
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x000AA077 File Offset: 0x000A8277
		public virtual float AngularVelocity
		{
			get
			{
				return this.Instance.AngularVelocity;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x000AA084 File Offset: 0x000A8284
		public virtual string CameraShake
		{
			get
			{
				return this.Instance.CameraShake;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x000AA091 File Offset: 0x000A8291
		public virtual ISpeedCurveMotion MatchSpeedCurve
		{
			get
			{
				if (this._MatchSpeedCurveInited)
				{
					return this._MatchSpeedCurveCache;
				}
				this._MatchSpeedCurveInited = true;
				this._MatchSpeedCurveCache = ISpeedCurveMotion.Create(this.Instance.MatchSpeedCurve);
				return this._MatchSpeedCurveCache;
			}
		}

		// Token: 0x04002576 RID: 9590
		private IProjectileMotion Instance;

		// Token: 0x04002577 RID: 9591
		private ISpeedCurveMotion _MatchSpeedCurveCache;

		// Token: 0x04002578 RID: 9592
		private bool _MatchSpeedCurveInited;
	}
}
