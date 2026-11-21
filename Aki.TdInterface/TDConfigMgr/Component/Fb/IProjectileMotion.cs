using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C15 RID: 3093
	[NullableContext(2)]
	[Nullable(0)]
	public class IProjectileMotion : IThrowMotion
	{
		// Token: 0x060046DA RID: 18138 RVA: 0x000B4102 File Offset: 0x000B2302
		[NullableContext(0)]
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

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x000B4121 File Offset: 0x000B2321
		public override EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x000B412E File Offset: 0x000B232E
		public virtual float Velocity
		{
			get
			{
				return this.Instance.Velocity;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x000B413B File Offset: 0x000B233B
		public virtual float AngularVelocity
		{
			get
			{
				return this.Instance.AngularVelocity;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x000B4148 File Offset: 0x000B2348
		public virtual string CameraShake
		{
			get
			{
				return this.Instance.CameraShake;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x000B4155 File Offset: 0x000B2355
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

		// Token: 0x040027BE RID: 10174
		private IProjectileMotion Instance;

		// Token: 0x040027BF RID: 10175
		private ISpeedCurveMotion _MatchSpeedCurveCache;

		// Token: 0x040027C0 RID: 10176
		private bool _MatchSpeedCurveInited;
	}
}
