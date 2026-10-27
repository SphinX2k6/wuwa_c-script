using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200261D RID: 9757
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeInteractOptionText : ActionParams
	{
		// Token: 0x0600DB11 RID: 56081 RVA: 0x0020A110 File Offset: 0x00208310
		[NullableContext(1)]
		public static ChangeInteractOptionText Create(IChangeInteractOptionText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeInteractOptionText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x0600DB12 RID: 56082 RVA: 0x0020A12F File Offset: 0x0020832F
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x0600DB13 RID: 56083 RVA: 0x0020A13C File Offset: 0x0020833C
		public virtual string EdTidContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040079B7 RID: 31159
		private IChangeInteractOptionText Instance;
	}
}
