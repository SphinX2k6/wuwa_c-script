using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB0 RID: 2992
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo
	{
		// Token: 0x0600449D RID: 17565 RVA: 0x000AE392 File Offset: 0x000AC592
		[NullableContext(1)]
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

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x000AE3B1 File Offset: 0x000AC5B1
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x000AE3BE File Offset: 0x000AC5BE
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

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x000AE3F4 File Offset: 0x000AC5F4
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

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x000AE42A File Offset: 0x000AC62A
		public virtual int Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x000AE437 File Offset: 0x000AC637
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

		// Token: 0x040026C9 RID: 9929
		private INpcStandbyShowFinitelyInfo Instance;

		// Token: 0x040026CA RID: 9930
		private IMontageId _RegisteredMontageIdCache;

		// Token: 0x040026CB RID: 9931
		private bool _RegisteredMontageIdInited;

		// Token: 0x040026CC RID: 9932
		private IIgnoreEntityIdsCollision _IgnoreEntityCollisionCache;

		// Token: 0x040026CD RID: 9933
		private bool _IgnoreEntityCollisionInited;
	}
}
