using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A22 RID: 10786
	public class INightmareSpawnPointTip : ICommonTipType
	{
		// Token: 0x0600EE5B RID: 61019 RVA: 0x0022FAA0 File Offset: 0x0022DCA0
		public static INightmareSpawnPointTip Create(INightmareSpawnPointTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareSpawnPointTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x0600EE5C RID: 61020 RVA: 0x0022FABF File Offset: 0x0022DCBF
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x0600EE5D RID: 61021 RVA: 0x0022FACC File Offset: 0x0022DCCC
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x0600EE5E RID: 61022 RVA: 0x0022FAD9 File Offset: 0x0022DCD9
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170046C8 RID: 18120
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x0022FAE6 File Offset: 0x0022DCE6
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046C9 RID: 18121
		// (get) Token: 0x0600EE60 RID: 61024 RVA: 0x0022FAE9 File Offset: 0x0022DCE9
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008302 RID: 33538
		private INightmareSpawnPointTip Instance;
	}
}
