using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B0 RID: 5296
	public class IPhoneMessageProgressTypeBase
	{
		// Token: 0x0600782C RID: 30764 RVA: 0x0011FF3C File Offset: 0x0011E13C
		public static IPhoneMessageProgressTypeBase Create(IPhoneMessageProgressTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageProgressTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0600782D RID: 30765 RVA: 0x0011FF5B File Offset: 0x0011E15B
		public virtual EPhoneMessageProgressType Type
		{
			get
			{
				return (EPhoneMessageProgressType)this.Instance.Type;
			}
		}

		// Token: 0x04004518 RID: 17688
		private IPhoneMessageProgressTypeBase Instance;
	}
}
