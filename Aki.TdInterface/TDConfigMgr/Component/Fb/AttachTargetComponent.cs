using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D66 RID: 3430
	public class AttachTargetComponent : IComponentBase
	{
		// Token: 0x06004E02 RID: 19970 RVA: 0x000C2831 File Offset: 0x000C0A31
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

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x000C2850 File Offset: 0x000C0A50
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

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x000C2888 File Offset: 0x000C0A88
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004E05 RID: 19973 RVA: 0x000C289E File Offset: 0x000C0A9E
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

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x000C28D0 File Offset: 0x000C0AD0
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

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x000C2908 File Offset: 0x000C0B08
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

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x000C293E File Offset: 0x000C0B3E
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

		// Token: 0x04002C4D RID: 11341
		private IAttachTargetComponent Instance;

		// Token: 0x04002C4E RID: 11342
		private IAttachTarget _AttachTargetCache;

		// Token: 0x04002C4F RID: 11343
		private bool _AttachTargetInited;

		// Token: 0x04002C50 RID: 11344
		private IAttachTiming _AttachTimingCache;

		// Token: 0x04002C51 RID: 11345
		private bool _AttachTimingInited;
	}
}
