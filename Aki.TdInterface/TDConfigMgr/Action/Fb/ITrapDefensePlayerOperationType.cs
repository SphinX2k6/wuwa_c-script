using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8A RID: 10890
	public class ITrapDefensePlayerOperationType
	{
		// Token: 0x0600EF4B RID: 61259 RVA: 0x0022CB90 File Offset: 0x0022AD90
		[NullableContext(1)]
		public static ITrapDefensePlayerOperationType Create(ITrapDefensePlayerOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x0600EF4C RID: 61260 RVA: 0x0022CBAF File Offset: 0x0022ADAF
		public virtual ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040083AA RID: 33706
		private ITrapDefensePlayerOperationType Instance;
	}
}
