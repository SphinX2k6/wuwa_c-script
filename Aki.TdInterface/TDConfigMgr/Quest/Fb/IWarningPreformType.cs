using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001581 RID: 5505
	public class IWarningPreformType
	{
		// Token: 0x06007C2E RID: 31790 RVA: 0x001271D6 File Offset: 0x001253D6
		public static IWarningPreformType Create(IWarningPreformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x06007C2F RID: 31791 RVA: 0x001271F5 File Offset: 0x001253F5
		public virtual EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x04004797 RID: 18327
		private IWarningPreformType Instance;
	}
}
