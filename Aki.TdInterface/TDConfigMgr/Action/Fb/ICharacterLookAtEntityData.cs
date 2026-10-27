using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200262A RID: 9770
	public class ICharacterLookAtEntityData : ICharacterLookAtData
	{
		// Token: 0x0600DB48 RID: 56136 RVA: 0x0020A666 File Offset: 0x00208866
		[NullableContext(1)]
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

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x0600DB49 RID: 56137 RVA: 0x0020A685 File Offset: 0x00208885
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0600DB4A RID: 56138 RVA: 0x0020A692 File Offset: 0x00208892
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040079D0 RID: 31184
		private ICharacterLookAtEntityData Instance;
	}
}
