using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281B RID: 10267
	public class IVisualNovelRoleConfig
	{
		// Token: 0x0600E488 RID: 58504 RVA: 0x0021C7FC File Offset: 0x0021A9FC
		public static IVisualNovelRoleConfig Create(IVisualNovelRoleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelRoleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x0021C81C File Offset: 0x0021AA1C
		public virtual int? Expression
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Expression);
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0600E48A RID: 58506 RVA: 0x0021C854 File Offset: 0x0021AA54
		public virtual EAvgVisualEffect? VisualEffect
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EAvgVisualEffect?((EAvgVisualEffect)this.Instance.VisualEffect);
			}
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0600E48B RID: 58507 RVA: 0x0021C88C File Offset: 0x0021AA8C
		public virtual bool? HideAvatar
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HideAvatar);
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0600E48C RID: 58508 RVA: 0x0021C8C4 File Offset: 0x0021AAC4
		public virtual bool? HidePortrait
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.HidePortrait);
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x0600E48D RID: 58509 RVA: 0x0021C8FC File Offset: 0x0021AAFC
		public virtual int? CustomLayer
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.CustomLayer);
			}
		}

		// Token: 0x04007D71 RID: 32113
		private IVisualNovelRoleConfig Instance;
	}
}
