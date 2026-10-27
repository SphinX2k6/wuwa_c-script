using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001454 RID: 5204
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayRecallData : IRecallData
	{
		// Token: 0x0600764F RID: 30287 RVA: 0x0011A978 File Offset: 0x00118B78
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

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x0011A997 File Offset: 0x00118B97
		public override ERecallDataType Type
		{
			get
			{
				return (ERecallDataType)this.Instance.Type;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06007651 RID: 30289 RVA: 0x0011A9A4 File Offset: 0x00118BA4
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06007652 RID: 30290 RVA: 0x0011A9B1 File Offset: 0x00118BB1
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

		// Token: 0x040044B0 RID: 17584
		private ILevelPlayRecallData Instance;

		// Token: 0x040044B1 RID: 17585
		[Nullable(2)]
		private ILevelPlayRecallConfig _RecallConfigCache;

		// Token: 0x040044B2 RID: 17586
		private bool _RecallConfigInited;
	}
}
