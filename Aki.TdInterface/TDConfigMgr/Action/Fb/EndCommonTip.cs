using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002765 RID: 10085
	[NullableContext(1)]
	[Nullable(0)]
	public class EndCommonTip : ActionParams
	{
		// Token: 0x0600E0AB RID: 57515 RVA: 0x002134B5 File Offset: 0x002116B5
		public static EndCommonTip Create(IEndCommonTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EndCommonTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x002134D4 File Offset: 0x002116D4
		public virtual string Token
		{
			get
			{
				return this.Instance.Token;
			}
		}

		// Token: 0x04007C69 RID: 31849
		private IEndCommonTip Instance;
	}
}
