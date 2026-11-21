using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BD6 RID: 11222
	public class IChangeActorMPC : IModifyMaterialConfig
	{
		// Token: 0x0600F747 RID: 63303 RVA: 0x0023FF41 File Offset: 0x0023E141
		public static IChangeActorMPC Create(IChangeActorMPC? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeActorMPC
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x0600F748 RID: 63304 RVA: 0x0023FF60 File Offset: 0x0023E160
		public override EModifyActorMaterialType Type
		{
			get
			{
				return (EModifyActorMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x17004C4A RID: 19530
		// (get) Token: 0x0600F749 RID: 63305 RVA: 0x0023FF6D File Offset: 0x0023E16D
		public virtual string MpcData
		{
			get
			{
				return this.Instance.MpcData;
			}
		}

		// Token: 0x04008766 RID: 34662
		private IChangeActorMPC Instance;
	}
}
