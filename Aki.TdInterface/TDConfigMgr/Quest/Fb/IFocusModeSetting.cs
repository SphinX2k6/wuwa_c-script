using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001451 RID: 5201
	public class IFocusModeSetting
	{
		// Token: 0x06007640 RID: 30272 RVA: 0x0011A7BD File Offset: 0x001189BD
		[NullableContext(1)]
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

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06007641 RID: 30273 RVA: 0x0011A7DC File Offset: 0x001189DC
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

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06007642 RID: 30274 RVA: 0x0011A814 File Offset: 0x00118A14
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

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06007643 RID: 30275 RVA: 0x0011A84C File Offset: 0x00118A4C
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

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06007644 RID: 30276 RVA: 0x0011A884 File Offset: 0x00118A84
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

		// Token: 0x040044AB RID: 17579
		private IFocusModeSetting Instance;
	}
}
