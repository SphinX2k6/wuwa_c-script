using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7E RID: 3198
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo
	{
		// Token: 0x060048F6 RID: 18678 RVA: 0x000B8456 File Offset: 0x000B6656
		[NullableContext(0)]
		public static INpcStandbyShowFinitelyInfo Create(INpcStandbyShowFinitelyInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcStandbyShowFinitelyInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060048F7 RID: 18679 RVA: 0x000B8475 File Offset: 0x000B6675
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060048F8 RID: 18680 RVA: 0x000B8482 File Offset: 0x000B6682
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

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x000B84B8 File Offset: 0x000B66B8
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x000B84EE File Offset: 0x000B66EE
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x000B84FB File Offset: 0x000B66FB
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

		// Token: 0x04002911 RID: 10513
		private INpcStandbyShowFinitelyInfo Instance;

		// Token: 0x04002912 RID: 10514
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x04002913 RID: 10515
		private bool _RegisteredMontageIdInited;

		// Token: 0x04002914 RID: 10516
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x04002915 RID: 10517
		private bool _IgnoreEntityCollisionInited;
	}
}
