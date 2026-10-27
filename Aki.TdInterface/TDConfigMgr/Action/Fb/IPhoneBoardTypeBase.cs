using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AC5 RID: 10949
	public class IPhoneBoardTypeBase
	{
		// Token: 0x0600F03E RID: 61502 RVA: 0x0022E416 File Offset: 0x0022C616
		[NullableContext(1)]
		public static IPhoneBoardTypeBase Create(IPhoneBoardTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneBoardTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x0600F03F RID: 61503 RVA: 0x0022E435 File Offset: 0x0022C635
		public virtual EPhoneBoardType Type
		{
			get
			{
				return (EPhoneBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04008423 RID: 33827
		private IPhoneBoardTypeBase Instance;
	}
}
