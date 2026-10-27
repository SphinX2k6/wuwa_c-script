using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200275E RID: 10078
	public class ISheriffCriminalArrested : ICommonTipType
	{
		// Token: 0x0600E089 RID: 57481 RVA: 0x002131D6 File Offset: 0x002113D6
		[NullableContext(1)]
		public static ISheriffCriminalArrested Create(ISheriffCriminalArrested? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffCriminalArrested
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x002131F5 File Offset: 0x002113F5
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x0600E08B RID: 57483 RVA: 0x00213202 File Offset: 0x00211402
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007C5C RID: 31836
		private ISheriffCriminalArrested Instance;
	}
}
