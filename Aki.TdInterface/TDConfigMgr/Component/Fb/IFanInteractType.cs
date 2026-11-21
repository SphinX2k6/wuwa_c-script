using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB0 RID: 3504
	public class IFanInteractType
	{
		// Token: 0x06004FA4 RID: 20388 RVA: 0x000C630B File Offset: 0x000C450B
		public static IFanInteractType Create(IFanInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x000C632A File Offset: 0x000C452A
		public virtual EFanInteractType Type
		{
			get
			{
				return (EFanInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002D67 RID: 11623
		private IFanInteractType Instance;
	}
}
