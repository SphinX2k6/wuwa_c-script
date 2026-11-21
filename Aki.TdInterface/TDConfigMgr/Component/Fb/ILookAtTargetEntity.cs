using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EBE RID: 3774
	public class ILookAtTargetEntity : ILookAtTargetBase
	{
		// Token: 0x06005510 RID: 21776 RVA: 0x000D12C3 File Offset: 0x000CF4C3
		public static ILookAtTargetEntity Create(ILookAtTargetEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x000D12E2 File Offset: 0x000CF4E2
		public override ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x000D12EF File Offset: 0x000CF4EF
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x0400309B RID: 12443
		private ILookAtTargetEntity Instance;
	}
}
