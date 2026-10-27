using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4B RID: 10827
	public class ISystemFunction
	{
		// Token: 0x0600EE50 RID: 61008 RVA: 0x0022B314 File Offset: 0x00229514
		[NullableContext(1)]
		public static ISystemFunction Create(ISystemFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x0600EE51 RID: 61009 RVA: 0x0022B333 File Offset: 0x00229533
		public virtual ESystemFunction Type
		{
			get
			{
				return (ESystemFunction)this.Instance.Type;
			}
		}

		// Token: 0x04008325 RID: 33573
		private ISystemFunction Instance;
	}
}
