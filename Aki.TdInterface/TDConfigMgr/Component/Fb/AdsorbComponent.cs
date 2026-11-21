using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C42 RID: 3138
	[NullableContext(2)]
	[Nullable(0)]
	public class AdsorbComponent : IComponentBase
	{
		// Token: 0x060047E6 RID: 18406 RVA: 0x000B6386 File Offset: 0x000B4586
		[NullableContext(0)]
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

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x000B63A8 File Offset: 0x000B45A8
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

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x000B63E0 File Offset: 0x000B45E0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x000B63F6 File Offset: 0x000B45F6
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x000B6403 File Offset: 0x000B4603
		public virtual float StartVelocity
		{
			get
			{
				return this.Instance.StartVelocity;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x000B6410 File Offset: 0x000B4610
		public virtual float Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x000B641D File Offset: 0x000B461D
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x000B6451 File Offset: 0x000B4651
		public virtual int AdsorbLimitedTime
		{
			get
			{
				return this.Instance.AdsorbLimitedTime;
			}
		}

		// Token: 0x04002863 RID: 10339
		private IAdsorbComponent Instance;

		// Token: 0x04002864 RID: 10340
		private IEntityState _ActiveStateConditionCache;

		// Token: 0x04002865 RID: 10341
		private bool _ActiveStateConditionInited;
	}
}
