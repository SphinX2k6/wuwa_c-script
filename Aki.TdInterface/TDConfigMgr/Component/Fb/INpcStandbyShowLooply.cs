using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB2 RID: 2994
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply : INpcStandbyShowMode
	{
		// Token: 0x060044AA RID: 17578 RVA: 0x000AE599 File Offset: 0x000AC799
		[NullableContext(1)]
		public static INpcStandbyShowLooply Create(INpcStandbyShowLooply? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowLooply
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x000AE5B8 File Offset: 0x000AC7B8
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x000AE5C8 File Offset: 0x000AC7C8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._LookAtConfigsInited)
				{
					return this._LookAtConfigsCache;
				}
				this._LookAtConfigsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int lookAtConfigsLength = this.Instance.LookAtConfigsLength;
				this._LookAtConfigsCache = new List<INpcLookAtConfig>(lookAtConfigsLength);
				for (int i = 0; i < lookAtConfigsLength; i++)
				{
					this._LookAtConfigsCache.Add(INpcLookAtConfig.Create(this.Instance.LookAtConfigs(i)));
				}
				return this._LookAtConfigsCache;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x000AE642 File Offset: 0x000AC842
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x000AE64F File Offset: 0x000AC84F
		public virtual IMontageId RegisteredMontageId
		{
			get
			{
				if (this._RegisteredMontageIdInited)
				{
					return this._RegisteredMontageIdCache;
				}
				this._RegisteredMontageIdInited = true;
				this._RegisteredMontageIdCache = IMontageId.Create(this.Instance.RegisteredMontageId);
				return this._RegisteredMontageIdCache;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x000AE684 File Offset: 0x000AC884
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x000AE6BA File Offset: 0x000AC8BA
		public virtual IIgnoreEntityIdsCollision IgnoreEntityCollision
		{
			get
			{
				if (this._IgnoreEntityCollisionInited)
				{
					return this._IgnoreEntityCollisionCache;
				}
				this._IgnoreEntityCollisionInited = true;
				this._IgnoreEntityCollisionCache = IIgnoreEntityIdsCollision.Create(this.Instance.IgnoreEntityCollision);
				return this._IgnoreEntityCollisionCache;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x000AE6F0 File Offset: 0x000AC8F0
		public virtual bool? SetFadeInTimeToZero
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SetFadeInTimeToZero);
			}
		}

		// Token: 0x040026D3 RID: 9939
		private INpcStandbyShowLooply Instance;

		// Token: 0x040026D4 RID: 9940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x040026D5 RID: 9941
		private bool _LookAtConfigsInited;

		// Token: 0x040026D6 RID: 9942
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x040026D7 RID: 9943
		private bool _RegisteredMontageIdInited;

		// Token: 0x040026D8 RID: 9944
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x040026D9 RID: 9945
		private bool _IgnoreEntityCollisionInited;
	}
}
