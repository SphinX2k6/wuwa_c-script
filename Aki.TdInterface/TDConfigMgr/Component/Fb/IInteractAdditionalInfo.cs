using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B40 RID: 2880
	public class IInteractAdditionalInfo
	{
		// Token: 0x060041D9 RID: 16857 RVA: 0x000A7935 File Offset: 0x000A5B35
		public static IInteractAdditionalInfo Create(IInteractAdditionalInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractAdditionalInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x000A7954 File Offset: 0x000A5B54
		public virtual EInteractAdditionalInfoType Type
		{
			get
			{
				return (EInteractAdditionalInfoType)this.Instance.Type;
			}
		}

		// Token: 0x04002477 RID: 9335
		private IInteractAdditionalInfo Instance;
	}
}
