using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002798 RID: 10136
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowHidedGroup : ActionParams
	{
		// Token: 0x0600E19B RID: 57755 RVA: 0x0021574A File Offset: 0x0021394A
		public static ShowHidedGroup Create(IShowHidedGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x0600E19C RID: 57756 RVA: 0x00215769 File Offset: 0x00213969
		public virtual string GroupKey
		{
			get
			{
				return this.Instance.GroupKey;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x0600E19D RID: 57757 RVA: 0x00215776 File Offset: 0x00213976
		public virtual bool DelayShow
		{
			get
			{
				return this.Instance.DelayShow;
			}
		}

		// Token: 0x04007D1C RID: 32028
		private IShowHidedGroup Instance;
	}
}
