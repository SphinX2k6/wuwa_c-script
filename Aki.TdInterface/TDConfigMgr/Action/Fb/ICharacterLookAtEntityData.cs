using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028EA RID: 10474
	public class ICharacterLookAtEntityData : ICharacterLookAtData
	{
		// Token: 0x0600E916 RID: 59670 RVA: 0x00226E32 File Offset: 0x00225032
		public static ICharacterLookAtEntityData Create(ICharacterLookAtEntityData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEntityData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x0600E917 RID: 59671 RVA: 0x00226E51 File Offset: 0x00225051
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x0600E918 RID: 59672 RVA: 0x00226E5E File Offset: 0x0022505E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400806C RID: 32876
		private ICharacterLookAtEntityData Instance;
	}
}
