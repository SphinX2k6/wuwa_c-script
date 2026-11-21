using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C80 RID: 3200
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowLooply : INpcStandbyShowMode
	{
		// Token: 0x06004903 RID: 18691 RVA: 0x000B865D File Offset: 0x000B685D
		[NullableContext(0)]
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x000B867C File Offset: 0x000B687C
		public override ENpcStandbyShowMode Type
		{
			get
			{
				return (ENpcStandbyShowMode)this.Instance.Type;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x000B868C File Offset: 0x000B688C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<INpcLookAtConfig> LookAtConfigs
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x000B8706 File Offset: 0x000B6906
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x000B8713 File Offset: 0x000B6913
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

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x000B8748 File Offset: 0x000B6948
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

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x000B877E File Offset: 0x000B697E
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

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x000B87B4 File Offset: 0x000B69B4
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

		// Token: 0x0400291B RID: 10523
		private INpcStandbyShowLooply Instance;

		// Token: 0x0400291C RID: 10524
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcLookAtConfig> _LookAtConfigsCache;

		// Token: 0x0400291D RID: 10525
		private bool _LookAtConfigsInited;

		// Token: 0x0400291E RID: 10526
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x0400291F RID: 10527
		private bool _RegisteredMontageIdInited;

		// Token: 0x04002920 RID: 10528
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x04002921 RID: 10529
		private bool _IgnoreEntityCollisionInited;
	}
}
