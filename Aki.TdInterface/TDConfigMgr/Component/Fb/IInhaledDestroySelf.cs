using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D65 RID: 3429
	public class IInhaledDestroySelf : IInhaledPerResultType
	{
		// Token: 0x06004E10 RID: 19984 RVA: 0x000C1E55 File Offset: 0x000C0055
		[NullableContext(1)]
		public static IInhaledDestroySelf Create(IInhaledDestroySelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledDestroySelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06004E11 RID: 19985 RVA: 0x000C1E74 File Offset: 0x000C0074
		public override EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x04002CC0 RID: 11456
		private IInhaledDestroySelf Instance;
	}
}
