using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8D RID: 10893
	public class ITargetEntity : ITargetEntityType
	{
		// Token: 0x0600F064 RID: 61540 RVA: 0x00233A92 File Offset: 0x00231C92
		public static ITargetEntity Create(ITargetEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x0600F065 RID: 61541 RVA: 0x00233AB1 File Offset: 0x00231CB1
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x0600F066 RID: 61542 RVA: 0x00233ABE File Offset: 0x00231CBE
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008431 RID: 33841
		private ITargetEntity Instance;
	}
}
