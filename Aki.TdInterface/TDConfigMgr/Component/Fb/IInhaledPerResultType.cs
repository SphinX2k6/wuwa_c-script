using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D64 RID: 3428
	public class IInhaledPerResultType
	{
		// Token: 0x06004E0D RID: 19981 RVA: 0x000C1E21 File Offset: 0x000C0021
		[NullableContext(1)]
		public static IInhaledPerResultType Create(IInhaledPerResultType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x000C1E40 File Offset: 0x000C0040
		public virtual EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x04002CBF RID: 11455
		private IInhaledPerResultType Instance;
	}
}
