using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D43 RID: 11587
	public class IHandInHandInitiatorType
	{
		// Token: 0x0600FD0C RID: 64780 RVA: 0x00248F52 File Offset: 0x00247152
		public static IHandInHandInitiatorType Create(IHandInHandInitiatorType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInHandInitiatorType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x0600FD0D RID: 64781 RVA: 0x00248F71 File Offset: 0x00247171
		public virtual EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008A25 RID: 35365
		private IHandInHandInitiatorType Instance;
	}
}
