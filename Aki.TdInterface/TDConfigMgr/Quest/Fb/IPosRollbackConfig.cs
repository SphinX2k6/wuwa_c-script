using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A4 RID: 5540
	public class IPosRollbackConfig
	{
		// Token: 0x06007CEB RID: 31979 RVA: 0x00128D8E File Offset: 0x00126F8E
		public static IPosRollbackConfig Create(IPosRollbackConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPosRollbackConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x00128DB0 File Offset: 0x00126FB0
		public virtual int? RangeEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RangeEntityId);
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x00128DE6 File Offset: 0x00126FE6
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x06007CEE RID: 31982 RVA: 0x00128DF4 File Offset: 0x00126FF4
		public virtual bool? GravityFlip
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.GravityFlip);
			}
		}

		// Token: 0x0400482C RID: 18476
		private IPosRollbackConfig Instance;
	}
}
