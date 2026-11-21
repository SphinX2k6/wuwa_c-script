using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A3 RID: 10659
	public class ISetEntityTag
	{
		// Token: 0x0600EC2E RID: 60462 RVA: 0x0022C4B7 File Offset: 0x0022A6B7
		public static ISetEntityTag Create(ISetEntityTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x0600EC2F RID: 60463 RVA: 0x0022C4D6 File Offset: 0x0022A6D6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x0022C4E3 File Offset: 0x0022A6E3
		public virtual string GameplayTag
		{
			get
			{
				return this.Instance.GameplayTag;
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x0600EC31 RID: 60465 RVA: 0x0022C4F0 File Offset: 0x0022A6F0
		public virtual ESetEntityTagType SetType
		{
			get
			{
				return (ESetEntityTagType)this.Instance.SetType;
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x0600EC32 RID: 60466 RVA: 0x0022C500 File Offset: 0x0022A700
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x0600EC33 RID: 60467 RVA: 0x0022C538 File Offset: 0x0022A738
		public virtual bool? BeforeHide
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.BeforeHide);
			}
		}

		// Token: 0x0400820B RID: 33291
		private ISetEntityTag Instance;
	}
}
