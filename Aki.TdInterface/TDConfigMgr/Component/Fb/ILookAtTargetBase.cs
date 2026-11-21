using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EBD RID: 3773
	public class ILookAtTargetBase
	{
		// Token: 0x0600550D RID: 21773 RVA: 0x000D128F File Offset: 0x000CF48F
		public static ILookAtTargetBase Create(ILookAtTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x000D12AE File Offset: 0x000CF4AE
		public virtual ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x0400309A RID: 12442
		private ILookAtTargetBase Instance;
	}
}
