using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B29 RID: 2857
	public class RefreshSingleComponent : IComponentBase
	{
		// Token: 0x0600414A RID: 16714 RVA: 0x000A67B0 File Offset: 0x000A49B0
		public static RefreshSingleComponent Create(IRefreshSingleComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshSingleComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x000A67D0 File Offset: 0x000A49D0
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x000A6808 File Offset: 0x000A4A08
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x000A681E File Offset: 0x000A4A1E
		public virtual int RefreshInterval
		{
			get
			{
				return this.Instance.RefreshInterval;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x000A682B File Offset: 0x000A4A2B
		public virtual bool DelayRefresh
		{
			get
			{
				return this.Instance.DelayRefresh;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x000A6838 File Offset: 0x000A4A38
		public virtual string TemplateGuid
		{
			get
			{
				return this.Instance.TemplateGuid;
			}
		}

		// Token: 0x0400242A RID: 9258
		private IRefreshSingleComponent Instance;
	}
}
