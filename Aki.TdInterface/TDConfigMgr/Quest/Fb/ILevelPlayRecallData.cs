using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AD RID: 5549
	public class ILevelPlayRecallData : IRecallData
	{
		// Token: 0x06007D1C RID: 32028 RVA: 0x0012955C File Offset: 0x0012775C
		public static ILevelPlayRecallData Create(ILevelPlayRecallData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayRecallData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06007D1D RID: 32029 RVA: 0x0012957B File Offset: 0x0012777B
		public override ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x06007D1E RID: 32030 RVA: 0x00129588 File Offset: 0x00127788
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06007D1F RID: 32031 RVA: 0x00129595 File Offset: 0x00127795
		public virtual ILevelPlayRecallConfig RecallConfig
		{
			get
			{
				if (this._RecallConfigInited)
				{
					return this._RecallConfigCache;
				}
				this._RecallConfigInited = true;
				this._RecallConfigCache = ILevelPlayRecallConfig.Create(this.Instance.RecallConfig);
				return this._RecallConfigCache;
			}
		}

		// Token: 0x04004849 RID: 18505
		private ILevelPlayRecallData Instance;

		// Token: 0x0400484A RID: 18506
		[Nullable(2)]
		private ILevelPlayRecallConfig _RecallConfigCache;

		// Token: 0x0400484B RID: 18507
		private bool _RecallConfigInited;
	}
}
