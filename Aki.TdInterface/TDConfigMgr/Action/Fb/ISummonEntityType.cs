using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2F RID: 10799
	public class ISummonEntityType
	{
		// Token: 0x0600EDED RID: 60909 RVA: 0x0022AB0D File Offset: 0x00228D0D
		[NullableContext(1)]
		public static ISummonEntityType Create(ISummonEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISummonEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x0600EDEE RID: 60910 RVA: 0x0022AB2C File Offset: 0x00228D2C
		public virtual ESummonEntityType Type
		{
			get
			{
				return (ESummonEntityType)this.Instance.Type;
			}
		}

		// Token: 0x040082F3 RID: 33523
		private ISummonEntityType Instance;
	}
}
