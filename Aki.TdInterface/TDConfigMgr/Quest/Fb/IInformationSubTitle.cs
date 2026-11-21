using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001412 RID: 5138
	public class IInformationSubTitle
	{
		// Token: 0x06007494 RID: 29844 RVA: 0x0011885E File Offset: 0x00116A5E
		public static IInformationSubTitle Create(IInformationSubTitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationSubTitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x0011887D File Offset: 0x00116A7D
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x0011888A File Offset: 0x00116A8A
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x06007497 RID: 29847 RVA: 0x00118897 File Offset: 0x00116A97
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x0011889A File Offset: 0x00116A9A
		[Nullable(2)]
		public virtual string EdTidContent
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004288 RID: 17032
		private IInformationSubTitle Instance;
	}
}
