using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A9 RID: 5545
	public class IFocusModeSetting
	{
		// Token: 0x06007D0A RID: 32010 RVA: 0x00129341 File Offset: 0x00127541
		public static IFocusModeSetting Create(IFocusModeSetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusModeSetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x00129360 File Offset: 0x00127560
		public virtual bool? CanOpenFocusMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanOpenFocusMode);
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x06007D0C RID: 32012 RVA: 0x00129398 File Offset: 0x00127598
		public virtual bool? IsFocusModeInherit
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFocusModeInherit);
			}
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x001293D0 File Offset: 0x001275D0
		public virtual bool? CanAcceptInFocusMode
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanAcceptInFocusMode);
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x06007D0E RID: 32014 RVA: 0x00129408 File Offset: 0x00127608
		public virtual bool? IsFocusModeWhiteList
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFocusModeWhiteList);
			}
		}

		// Token: 0x04004843 RID: 18499
		private IFocusModeSetting Instance;
	}
}
