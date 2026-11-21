using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B6 RID: 10166
	[NullableContext(2)]
	[Nullable(0)]
	public class IOptionLockTip
	{
		// Token: 0x0600E101 RID: 57601 RVA: 0x00211687 File Offset: 0x0020F887
		[NullableContext(0)]
		public static IOptionLockTip Create(IOptionLockTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x002116A6 File Offset: 0x0020F8A6
		public virtual string TidAppendText
		{
			get
			{
				return this.Instance.TidAppendText;
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600E103 RID: 57603 RVA: 0x002116B3 File Offset: 0x0020F8B3
		public virtual string TidHintText
		{
			get
			{
				return this.Instance.TidHintText;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600E104 RID: 57604 RVA: 0x002116C0 File Offset: 0x0020F8C0
		public virtual int? AppendTextId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.AppendTextId);
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600E105 RID: 57605 RVA: 0x002116F8 File Offset: 0x0020F8F8
		public virtual int? HintTextId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.HintTextId);
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600E106 RID: 57606 RVA: 0x0021172E File Offset: 0x0020F92E
		public virtual string EdTidAppendText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600E107 RID: 57607 RVA: 0x00211731 File Offset: 0x0020F931
		public virtual string EdTidHintText
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04007A54 RID: 31316
		private IOptionLockTip Instance;
	}
}
