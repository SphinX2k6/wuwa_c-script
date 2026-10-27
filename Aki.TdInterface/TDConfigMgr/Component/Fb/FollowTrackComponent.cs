using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE4 RID: 3044
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowTrackComponent : IComponentBase
	{
		// Token: 0x060045E9 RID: 17897 RVA: 0x000B0C3F File Offset: 0x000AEE3F
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

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x000B0C60 File Offset: 0x000AEE60
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

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x000B0C98 File Offset: 0x000AEE98
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x000B0CAE File Offset: 0x000AEEAE
		public virtual float Range
		{
			get
			{
				return this.Instance.Range;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x000B0CBB File Offset: 0x000AEEBB
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x000B0CC8 File Offset: 0x000AEEC8
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

		// Token: 0x040027CD RID: 10189
		private IFollowTrackComponent Instance;

		// Token: 0x040027CE RID: 10190
		private IFollowTrackEndType _EndTypeCache;

		// Token: 0x040027CF RID: 10191
		private bool _EndTypeInited;
	}
}
