using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274A RID: 10058
	public class ICommonTipPrepareCountdown : ICommonTipType
	{
		// Token: 0x0600E020 RID: 57376 RVA: 0x00212BB4 File Offset: 0x00210DB4
		[NullableContext(1)]
		public static ICommonTipPrepareCountdown Create(ICommonTipPrepareCountdown? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipPrepareCountdown
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x0600E021 RID: 57377 RVA: 0x00212BD3 File Offset: 0x00210DD3
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x04007C48 RID: 31816
		private ICommonTipPrepareCountdown Instance;
	}
}
