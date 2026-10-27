using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FB RID: 9467
	public class ITimeScaleType
	{
		// Token: 0x0600D357 RID: 54103 RVA: 0x001F55F6 File Offset: 0x001F37F6
		[NullableContext(1)]
		public static ITimeScaleType Create(ITimeScaleType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600D358 RID: 54104 RVA: 0x001F5615 File Offset: 0x001F3815
		public virtual ETimeScaleType Type
		{
			get
			{
				return (ETimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x040073E1 RID: 29665
		private ITimeScaleType Instance;
	}
}
