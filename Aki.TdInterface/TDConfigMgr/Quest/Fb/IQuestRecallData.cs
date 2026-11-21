using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AC RID: 5548
	public class IQuestRecallData : IRecallData
	{
		// Token: 0x06007D17 RID: 32023 RVA: 0x001294E7 File Offset: 0x001276E7
		public static IQuestRecallData Create(IQuestRecallData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRecallData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06007D18 RID: 32024 RVA: 0x00129506 File Offset: 0x00127706
		public override ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06007D19 RID: 32025 RVA: 0x00129513 File Offset: 0x00127713
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06007D1A RID: 32026 RVA: 0x00129520 File Offset: 0x00127720
		public virtual IQuestRecallConfig RecallConfig
		{
			get
			{
				if (this._RecallConfigInited)
				{
					return this._RecallConfigCache;
				}
				this._RecallConfigInited = true;
				this._RecallConfigCache = IQuestRecallConfig.Create(this.Instance.RecallConfig);
				return this._RecallConfigCache;
			}
		}

		// Token: 0x04004846 RID: 18502
		private IQuestRecallData Instance;

		// Token: 0x04004847 RID: 18503
		[Nullable(2)]
		private IQuestRecallConfig _RecallConfigCache;

		// Token: 0x04004848 RID: 18504
		private bool _RecallConfigInited;
	}
}
