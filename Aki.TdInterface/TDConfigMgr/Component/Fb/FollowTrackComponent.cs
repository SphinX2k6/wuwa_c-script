using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB3 RID: 3251
	public class FollowTrackComponent : IComponentBase
	{
		// Token: 0x06004A47 RID: 19015 RVA: 0x000BADBB File Offset: 0x000B8FBB
		public static FollowTrackComponent Create(IFollowTrackComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowTrackComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x000BADDC File Offset: 0x000B8FDC
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

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x000BAE14 File Offset: 0x000B9014
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x000BAE2A File Offset: 0x000B902A
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06004A4B RID: 19019 RVA: 0x000BAE37 File Offset: 0x000B9037
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x000BAE44 File Offset: 0x000B9044
		public virtual IFollowTrackEndType EndType
		{
			get
			{
				if (this._EndTypeInited)
				{
					return this._EndTypeCache;
				}
				this._EndTypeInited = true;
				this._EndTypeCache = ComponentReadHelper.ReadFollowTrackComponent_EndType(this.Instance);
				return this._EndTypeCache;
			}
		}

		// Token: 0x04002A18 RID: 10776
		private IFollowTrackComponent Instance;

		// Token: 0x04002A19 RID: 10777
		private IFollowTrackEndType _EndTypeCache;

		// Token: 0x04002A1A RID: 10778
		private bool _EndTypeInited;
	}
}
