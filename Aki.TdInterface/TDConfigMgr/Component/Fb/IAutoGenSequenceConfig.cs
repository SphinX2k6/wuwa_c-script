using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4B RID: 3403
	public class IAutoGenSequenceConfig
	{
		// Token: 0x06004D81 RID: 19841 RVA: 0x000C1771 File Offset: 0x000BF971
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

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x000C1790 File Offset: 0x000BF990
		[Nullable(2)]
		public virtual string SequencePath
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x000C179D File Offset: 0x000BF99D
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x000C17D1 File Offset: 0x000BF9D1
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x04002BFA RID: 11258
		private IAutoGenSequenceConfig Instance;

		// Token: 0x04002BFB RID: 11259
		[Nullable(2)]
		private PlayLevelSequence _SequenceConfigCache;

		// Token: 0x04002BFC RID: 11260
		private bool _SequenceConfigInited;
	}
}
