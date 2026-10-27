using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6C RID: 3180
	[NullableContext(1)]
	[Nullable(0)]
	public class IAutoGenSequenceConfig
	{
		// Token: 0x060048E2 RID: 18658 RVA: 0x000B6F6D File Offset: 0x000B516D
		public static IAutoGenSequenceConfig Create(IAutoGenSequenceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutoGenSequenceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x000B6F8C File Offset: 0x000B518C
		[Nullable(2)]
		public virtual string SequencePath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x000B6F99 File Offset: 0x000B5199
		public virtual PlayLevelSequence SequenceConfig
		{
			get
			{
				if (this._SequenceConfigInited)
				{
					return this._SequenceConfigCache;
				}
				this._SequenceConfigInited = true;
				this._SequenceConfigCache = PlayLevelSequence.Create(this.Instance.SequenceConfig);
				return this._SequenceConfigCache;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x000B6FCD File Offset: 0x000B51CD
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x0400298D RID: 10637
		private IAutoGenSequenceConfig Instance;

		// Token: 0x0400298E RID: 10638
		[Nullable(2)]
		private PlayLevelSequence _SequenceConfigCache;

		// Token: 0x0400298F RID: 10639
		private bool _SequenceConfigInited;
	}
}
