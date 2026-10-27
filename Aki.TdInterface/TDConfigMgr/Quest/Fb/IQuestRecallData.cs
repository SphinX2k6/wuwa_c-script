using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001453 RID: 5203
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestRecallData : IRecallData
	{
		// Token: 0x0600764A RID: 30282 RVA: 0x0011A903 File Offset: 0x00118B03
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

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x0011A922 File Offset: 0x00118B22
		public override ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600764C RID: 30284 RVA: 0x0011A92F File Offset: 0x00118B2F
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600764D RID: 30285 RVA: 0x0011A93C File Offset: 0x00118B3C
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

		// Token: 0x040044AD RID: 17581
		private IQuestRecallData Instance;

		// Token: 0x040044AE RID: 17582
		[Nullable(2)]
		private IQuestRecallConfig _RecallConfigCache;

		// Token: 0x040044AF RID: 17583
		private bool _RecallConfigInited;
	}
}
