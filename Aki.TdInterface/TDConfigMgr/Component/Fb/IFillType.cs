using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6A RID: 3434
	public class IFillType
	{
		// Token: 0x06004E17 RID: 19991 RVA: 0x000C2AC7 File Offset: 0x000C0CC7
		public static IFillType Create(IFillType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFillType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x000C2AE6 File Offset: 0x000C0CE6
		public virtual EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x04002C59 RID: 11353
		private IFillType Instance;
	}
}
