using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E8B RID: 3723
	public class IWindSourceBase
	{
		// Token: 0x06005417 RID: 21527 RVA: 0x000CF51E File Offset: 0x000CD71E
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

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x000CF53D File Offset: 0x000CD73D
		public virtual EWindSourceType Type
		{
			get
			{
				return (EWindSourceType)this.Instance.Type;
			}
		}

		// Token: 0x04003028 RID: 12328
		private IWindSourceBase Instance;
	}
}
