using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5C RID: 10844
	public class INpcGroupPerformInitiatorType
	{
		// Token: 0x0600EE8A RID: 61066 RVA: 0x0022B753 File Offset: 0x00229953
		[NullableContext(1)]
		public static INpcGroupPerformInitiatorType Create(INpcGroupPerformInitiatorType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B94 RID: 19348
		// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x0022B772 File Offset: 0x00229972
		public virtual ENpcGroupPerformInitiatorType Type
		{
			get
			{
				return (ENpcGroupPerformInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x0400833C RID: 33596
		private INpcGroupPerformInitiatorType Instance;
	}
}
