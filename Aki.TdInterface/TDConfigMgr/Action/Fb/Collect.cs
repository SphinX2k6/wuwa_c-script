using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002677 RID: 9847
	public class Collect : ActionParams
	{
		// Token: 0x0600DCAD RID: 56493 RVA: 0x0020D250 File Offset: 0x0020B450
		[NullableContext(1)]
		public static Collect Create(ICollect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Collect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x0020D270 File Offset: 0x0020B470
		public virtual int? TargetEntity
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetEntity);
			}
		}

		// Token: 0x04007AA7 RID: 31399
		private ICollect Instance;
	}
}
