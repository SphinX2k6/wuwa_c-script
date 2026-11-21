using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001411 RID: 5137
	public class IInformationViewType
	{
		// Token: 0x06007491 RID: 29841 RVA: 0x0011882A File Offset: 0x00116A2A
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

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x00118849 File Offset: 0x00116A49
		public virtual EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x04004287 RID: 17031
		private IInformationViewType Instance;
	}
}
