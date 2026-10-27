using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BA RID: 10170
	public class ITargetEntity : ITargetEntityType
	{
		// Token: 0x0600E242 RID: 57922 RVA: 0x00216CBE File Offset: 0x00214EBE
		[NullableContext(1)]
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

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x0600E243 RID: 57923 RVA: 0x00216CDD File Offset: 0x00214EDD
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x0600E244 RID: 57924 RVA: 0x00216CEA File Offset: 0x00214EEA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007D7A RID: 32122
		private ITargetEntity Instance;
	}
}
