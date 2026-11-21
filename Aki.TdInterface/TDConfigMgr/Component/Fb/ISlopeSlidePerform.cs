using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E93 RID: 3731
	public class ISlopeSlidePerform : ISlidePerformType
	{
		// Token: 0x0600543F RID: 21567 RVA: 0x000CFA6F File Offset: 0x000CDC6F
		public static ISlopeSlidePerform Create(ISlopeSlidePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlopeSlidePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x000CFA8E File Offset: 0x000CDC8E
		public override ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x000CFA9C File Offset: 0x000CDC9C
		public virtual int? TriggerLandingDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TriggerLandingDistance);
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x000CFAD4 File Offset: 0x000CDCD4
		public virtual int? FallbackLandingPointId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FallbackLandingPointId);
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x000CFB0C File Offset: 0x000CDD0C
		public virtual bool? IsAllowJump
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAllowJump);
			}
		}

		// Token: 0x0400303A RID: 12346
		private ISlopeSlidePerform Instance;
	}
}
