using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8B RID: 10891
	public class ITrapDefensePlayerOperationRecycleTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600EF4E RID: 61262 RVA: 0x0022CBC4 File Offset: 0x0022ADC4
		[NullableContext(1)]
		public static ITrapDefensePlayerOperationRecycleTrap Create(ITrapDefensePlayerOperationRecycleTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x0600EF4F RID: 61263 RVA: 0x0022CBE3 File Offset: 0x0022ADE3
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040083AB RID: 33707
		private ITrapDefensePlayerOperationRecycleTrap Instance;
	}
}
