using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D56 RID: 3414
	public class IGroupAiModeDefault : IGroupAiMode
	{
		// Token: 0x06004DD0 RID: 19920 RVA: 0x000C16B7 File Offset: 0x000BF8B7
		[NullableContext(1)]
		public static IGroupAiModeDefault Create(IGroupAiModeDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiModeDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x000C16D6 File Offset: 0x000BF8D6
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x04002C9B RID: 11419
		private IGroupAiModeDefault Instance;
	}
}
