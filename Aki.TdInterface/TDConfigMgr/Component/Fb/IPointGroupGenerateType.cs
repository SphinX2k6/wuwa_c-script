using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0D RID: 3341
	public class IPointGroupGenerateType
	{
		// Token: 0x06004C19 RID: 19481 RVA: 0x000BEA91 File Offset: 0x000BCC91
		public static IPointGroupGenerateType Create(IPointGroupGenerateType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointGroupGenerateType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x000BEAB0 File Offset: 0x000BCCB0
		public virtual EPointGroupGenerateType Type
		{
			get
			{
				return (EPointGroupGenerateType)this.Instance.Type;
			}
		}

		// Token: 0x04002B16 RID: 11030
		private IPointGroupGenerateType Instance;
	}
}
