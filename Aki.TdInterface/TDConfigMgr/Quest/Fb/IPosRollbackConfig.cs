using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144C RID: 5196
	public class IPosRollbackConfig
	{
		// Token: 0x06007623 RID: 30243 RVA: 0x0011A2BA File Offset: 0x001184BA
		[NullableContext(1)]
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

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x06007624 RID: 30244 RVA: 0x0011A2DC File Offset: 0x001184DC
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

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x0011A312 File Offset: 0x00118512
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x06007626 RID: 30246 RVA: 0x0011A320 File Offset: 0x00118520
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

		// Token: 0x04004496 RID: 17558
		private IPosRollbackConfig Instance;
	}
}
