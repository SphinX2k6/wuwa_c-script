using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8E RID: 10894
	public class ISelfEntity : ITargetEntityType
	{
		// Token: 0x0600F068 RID: 61544 RVA: 0x00233AD3 File Offset: 0x00231CD3
		public static ISelfEntity Create(ISelfEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x0600F069 RID: 61545 RVA: 0x00233AF2 File Offset: 0x00231CF2
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04008432 RID: 33842
		private ISelfEntity Instance;
	}
}
