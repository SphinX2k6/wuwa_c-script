using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FD RID: 10493
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeActorMPC : IModifyMaterialConfig
	{
		// Token: 0x0600E903 RID: 59651 RVA: 0x00222D55 File Offset: 0x00220F55
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

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x00222D74 File Offset: 0x00220F74
		public override EModifyActorMaterialType Type
		{
			get
			{
				return (EModifyActorMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x0600E905 RID: 59653 RVA: 0x00222D81 File Offset: 0x00220F81
		public virtual string MpcData
		{
			get
			{
				return this.Instance.MpcData;
			}
		}

		// Token: 0x040080A1 RID: 32929
		private IChangeActorMPC Instance;
	}
}
