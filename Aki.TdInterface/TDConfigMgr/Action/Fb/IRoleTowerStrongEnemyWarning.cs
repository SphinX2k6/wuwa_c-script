using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2E RID: 10798
	public class IRoleTowerStrongEnemyWarning : ICommonTipType
	{
		// Token: 0x0600EE9D RID: 61085 RVA: 0x0022FE54 File Offset: 0x0022E054
		public static IRoleTowerStrongEnemyWarning Create(IRoleTowerStrongEnemyWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerStrongEnemyWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x0600EE9E RID: 61086 RVA: 0x0022FE73 File Offset: 0x0022E073
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x0600EE9F RID: 61087 RVA: 0x0022FE80 File Offset: 0x0022E080
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x0600EEA0 RID: 61088 RVA: 0x0022FE8D File Offset: 0x0022E08D
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008310 RID: 33552
		private IRoleTowerStrongEnemyWarning Instance;
	}
}
