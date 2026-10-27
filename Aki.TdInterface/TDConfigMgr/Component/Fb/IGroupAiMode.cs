using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D55 RID: 3413
	public class IGroupAiMode
	{
		// Token: 0x06004DCD RID: 19917 RVA: 0x000C1683 File Offset: 0x000BF883
		[NullableContext(1)]
		public static IGroupAiMode Create(IGroupAiMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x000C16A2 File Offset: 0x000BF8A2
		public virtual EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x04002C9A RID: 11418
		private IGroupAiMode Instance;
	}
}
