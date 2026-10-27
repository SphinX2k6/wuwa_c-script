using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FC RID: 9468
	public class ISetGlobalTimeScaleType
	{
		// Token: 0x0600D35A RID: 54106 RVA: 0x001F562A File Offset: 0x001F382A
		[NullableContext(1)]
		public static ISetGlobalTimeScaleType Create(ISetGlobalTimeScaleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0600D35B RID: 54107 RVA: 0x001F5649 File Offset: 0x001F3849
		public virtual ESetTimeScaleType Type
		{
			get
			{
				return (ESetTimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x040073E2 RID: 29666
		private ISetGlobalTimeScaleType Instance;
	}
}
