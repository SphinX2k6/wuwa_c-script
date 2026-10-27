using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8F RID: 3471
	public class IWindSourceBase
	{
		// Token: 0x06004EF2 RID: 20210 RVA: 0x000C3CCE File Offset: 0x000C1ECE
		[NullableContext(1)]
		public static IWindSourceBase Create(IWindSourceBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindSourceBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x000C3CED File Offset: 0x000C1EED
		public virtual EWindSourceType Type
		{
			get
			{
				return (EWindSourceType)this.Instance.Type;
			}
		}

		// Token: 0x04002D62 RID: 11618
		private IWindSourceBase Instance;
	}
}
