using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B74 RID: 2932
	[NullableContext(2)]
	[Nullable(0)]
	public class AdsorbComponent : IComponentBase
	{
		// Token: 0x0600438D RID: 17293 RVA: 0x000AC2C2 File Offset: 0x000AA4C2
		[NullableContext(1)]
		public static AdsorbComponent Create(IAdsorbComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdsorbComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x000AC2E4 File Offset: 0x000AA4E4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x000AC31C File Offset: 0x000AA51C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x000AC332 File Offset: 0x000AA532
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x000AC33F File Offset: 0x000AA53F
		public virtual float StartVelocity
		{
			get
			{
				return this.Instance.StartVelocity;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x000AC34C File Offset: 0x000AA54C
		public virtual float Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x000AC359 File Offset: 0x000AA559
		public virtual IEntityState ActiveStateCondition
		{
			get
			{
				if (this._ActiveStateConditionInited)
				{
					return this._ActiveStateConditionCache;
				}
				this._ActiveStateConditionInited = true;
				this._ActiveStateConditionCache = IEntityState.Create(this.Instance.ActiveStateCondition);
				return this._ActiveStateConditionCache;
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x000AC38D File Offset: 0x000AA58D
		public virtual int AdsorbLimitedTime
		{
			get
			{
				return this.Instance.AdsorbLimitedTime;
			}
		}

		// Token: 0x0400261B RID: 9755
		private IAdsorbComponent Instance;

		// Token: 0x0400261C RID: 9756
		private IEntityState _ActiveStateConditionCache;

		// Token: 0x0400261D RID: 9757
		private bool _ActiveStateConditionInited;
	}
}
