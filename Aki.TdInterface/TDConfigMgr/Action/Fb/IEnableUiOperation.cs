using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C33 RID: 11315
	public class IEnableUiOperation : IUiOperationType
	{
		// Token: 0x0600F8F1 RID: 63729 RVA: 0x00242D1E File Offset: 0x00240F1E
		public static IEnableUiOperation Create(IEnableUiOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableUiOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x00242D3D File Offset: 0x00240F3D
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400881D RID: 34845
		private IEnableUiOperation Instance;
	}
}
