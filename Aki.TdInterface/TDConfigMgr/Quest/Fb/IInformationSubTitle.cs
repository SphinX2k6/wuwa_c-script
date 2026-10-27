using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CC RID: 4812
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationSubTitle
	{
		// Token: 0x06006E16 RID: 28182 RVA: 0x0010A5CE File Offset: 0x001087CE
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

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x0010A5ED File Offset: 0x001087ED
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06006E18 RID: 28184 RVA: 0x0010A5FA File Offset: 0x001087FA
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x0010A607 File Offset: 0x00108807
		[Nullable(2)]
		public virtual string EdTidTitle
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x0010A60A File Offset: 0x0010880A
		[Nullable(2)]
		public virtual string EdTidContent
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04003F1A RID: 16154
		private IInformationSubTitle Instance;
	}
}
