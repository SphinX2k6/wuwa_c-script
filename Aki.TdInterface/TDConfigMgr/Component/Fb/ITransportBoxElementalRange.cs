using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F1F RID: 3871
	public class ITransportBoxElementalRange : IElementalRangeTypeBase
	{
		// Token: 0x06005706 RID: 22278 RVA: 0x000D5584 File Offset: 0x000D3784
		public static ITransportBoxElementalRange Create(ITransportBoxElementalRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransportBoxElementalRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x000D55A3 File Offset: 0x000D37A3
		public override EElementalRangeType Type
		{
			get
			{
				return (EElementalRangeType)this.Instance.Type;
			}
		}

		// Token: 0x040031F0 RID: 12784
		private ITransportBoxElementalRange Instance;
	}
}
