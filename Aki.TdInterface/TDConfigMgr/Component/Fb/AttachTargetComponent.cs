using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C84 RID: 3204
	[NullableContext(1)]
	[Nullable(0)]
	public class AttachTargetComponent : IComponentBase
	{
		// Token: 0x06004954 RID: 18772 RVA: 0x000B7E20 File Offset: 0x000B6020
		public static AttachTargetComponent Create(IAttachTargetComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AttachTargetComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x000B7E40 File Offset: 0x000B6040
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

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004956 RID: 18774 RVA: 0x000B7E78 File Offset: 0x000B6078
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x000B7E8E File Offset: 0x000B608E
		public virtual IAttachTarget AttachTarget
		{
			get
			{
				if (this._AttachTargetInited)
				{
					return this._AttachTargetCache;
				}
				this._AttachTargetInited = true;
				this._AttachTargetCache = ComponentReadHelper.ReadAttachTargetComponent_AttachTarget(this.Instance);
				return this._AttachTargetCache;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x000B7EC0 File Offset: 0x000B60C0
		public virtual EAttachRuleType? PosRule
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EAttachRuleType?((EAttachRuleType)this.Instance.PosRule);
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x000B7EF8 File Offset: 0x000B60F8
		public virtual EAttachRuleType? RotRule
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new EAttachRuleType?((EAttachRuleType)this.Instance.RotRule);
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x000B7F2E File Offset: 0x000B612E
		public virtual IAttachTiming AttachTiming
		{
			get
			{
				if (this._AttachTimingInited)
				{
					return this._AttachTimingCache;
				}
				this._AttachTimingInited = true;
				this._AttachTimingCache = ComponentReadHelper.ReadAttachTargetComponent_AttachTiming(this.Instance);
				return this._AttachTimingCache;
			}
		}

		// Token: 0x040029D3 RID: 10707
		private IAttachTargetComponent Instance;

		// Token: 0x040029D4 RID: 10708
		private IAttachTarget _AttachTargetCache;

		// Token: 0x040029D5 RID: 10709
		private bool _AttachTargetInited;

		// Token: 0x040029D6 RID: 10710
		private IAttachTiming _AttachTimingCache;

		// Token: 0x040029D7 RID: 10711
		private bool _AttachTimingInited;
	}
}
