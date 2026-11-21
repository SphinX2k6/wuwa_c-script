using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001487 RID: 5255
	public class IBindingProgressType
	{
		// Token: 0x06007760 RID: 30560 RVA: 0x0011E59B File Offset: 0x0011C79B
		public static IBindingProgressType Create(IBindingProgressType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBindingProgressType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x0011E5BA File Offset: 0x0011C7BA
		public virtual EBindingProgressType Type
		{
			get
			{
				return (EBindingProgressType)this.Instance.Type;
			}
		}

		// Token: 0x04004489 RID: 17545
		private IBindingProgressType Instance;
	}
}
