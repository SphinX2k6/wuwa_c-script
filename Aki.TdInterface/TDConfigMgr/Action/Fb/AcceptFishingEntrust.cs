using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002946 RID: 10566
	public class AcceptFishingEntrust : ActionParams
	{
		// Token: 0x0600EAAB RID: 60075 RVA: 0x00229D85 File Offset: 0x00227F85
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

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x0600EAAC RID: 60076 RVA: 0x00229DA4 File Offset: 0x00227FA4
		public virtual int EntrustId
		{
			get
			{
				return this.Instance.EntrustId;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x0600EAAD RID: 60077 RVA: 0x00229DB4 File Offset: 0x00227FB4
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

		// Token: 0x04008152 RID: 33106
		private IAcceptFishingEntrust Instance;
	}
}
