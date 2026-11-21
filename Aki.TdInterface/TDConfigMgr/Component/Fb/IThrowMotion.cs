using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C13 RID: 3091
	public class IThrowMotion
	{
		// Token: 0x060046D4 RID: 18132 RVA: 0x000B409A File Offset: 0x000B229A
		public static IThrowMotion Create(IThrowMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x000B40B9 File Offset: 0x000B22B9
		public virtual EThrowMotion Type
		{
			get
			{
				return (EThrowMotion)this.Instance.Type;
			}
		}

		// Token: 0x040027BC RID: 10172
		private IThrowMotion Instance;
	}
}
