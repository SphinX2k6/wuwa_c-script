using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002683 RID: 9859
	public class AcceptFishingEntrust : ActionParams
	{
		// Token: 0x0600DCD4 RID: 56532 RVA: 0x0020D5E7 File Offset: 0x0020B7E7
		[NullableContext(1)]
		public static AcceptFishingEntrust Create(IAcceptFishingEntrust? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AcceptFishingEntrust
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x0600DCD5 RID: 56533 RVA: 0x0020D606 File Offset: 0x0020B806
		public virtual int EntrustId
		{
			get
			{
				return this.Instance.EntrustId;
			}
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x0600DCD6 RID: 56534 RVA: 0x0020D614 File Offset: 0x0020B814
		public virtual bool? IsAutoTracking
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAutoTracking);
			}
		}

		// Token: 0x04007AB5 RID: 31413
		private IAcceptFishingEntrust Instance;
	}
}
