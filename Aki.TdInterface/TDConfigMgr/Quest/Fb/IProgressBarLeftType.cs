using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200147C RID: 5244
	public class IProgressBarLeftType
	{
		// Token: 0x06007735 RID: 30517 RVA: 0x0011E148 File Offset: 0x0011C348
		public static IProgressBarLeftType Create(IProgressBarLeftType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x0011E167 File Offset: 0x0011C367
		public virtual EProgressBarLeftType Type
		{
			get
			{
				return (EProgressBarLeftType)this.Instance.Type;
			}
		}

		// Token: 0x0400446C RID: 17516
		private IProgressBarLeftType Instance;
	}
}
