using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012CB RID: 4811
	public class IInformationViewType
	{
		// Token: 0x06006E13 RID: 28179 RVA: 0x0010A59A File Offset: 0x0010879A
		[NullableContext(1)]
		public static IInformationViewType Create(IInformationViewType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x0010A5B9 File Offset: 0x001087B9
		public virtual EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x04003F19 RID: 16153
		private IInformationViewType Instance;
	}
}
