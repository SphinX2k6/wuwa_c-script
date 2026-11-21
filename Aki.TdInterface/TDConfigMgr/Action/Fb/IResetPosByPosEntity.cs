using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DDA RID: 11738
	public class IResetPosByPosEntity : IResetPosType
	{
		// Token: 0x0600FF6B RID: 65387 RVA: 0x0024CDD8 File Offset: 0x0024AFD8
		public static IResetPosByPosEntity Create(IResetPosByPosEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPosByPosEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x0600FF6C RID: 65388 RVA: 0x0024CDF7 File Offset: 0x0024AFF7
		public override EResetPosType Type
		{
			get
			{
				return (EResetPosType)this.Instance.Type;
			}
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x0600FF6D RID: 65389 RVA: 0x0024CE04 File Offset: 0x0024B004
		public virtual int Entity
		{
			get
			{
				return this.Instance.Entity;
			}
		}

		// Token: 0x04008B72 RID: 35698
		private IResetPosByPosEntity Instance;
	}
}
