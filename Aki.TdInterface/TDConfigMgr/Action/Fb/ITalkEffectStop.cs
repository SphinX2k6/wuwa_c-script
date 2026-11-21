using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E4 RID: 10212
	public class ITalkEffectStop : ITalkEffectActionType
	{
		// Token: 0x0600E1D2 RID: 57810 RVA: 0x00212CA6 File Offset: 0x00210EA6
		public static ITalkEffectStop Create(ITalkEffectStop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectStop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x00212CC5 File Offset: 0x00210EC5
		public override ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600E1D4 RID: 57812 RVA: 0x00212CD4 File Offset: 0x00210ED4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> EffectKeys
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._EffectKeysInited)
				{
					return this._EffectKeysCache;
				}
				this._EffectKeysInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int effectKeysLength = this.Instance.EffectKeysLength;
				this._EffectKeysCache = new List<string>(effectKeysLength);
				for (int i = 0; i < effectKeysLength; i++)
				{
					this._EffectKeysCache.Add(this.Instance.EffectKeys(i));
				}
				return this._EffectKeysCache;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600E1D5 RID: 57813 RVA: 0x00212D4C File Offset: 0x00210F4C
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600E1D6 RID: 57814 RVA: 0x00212D84 File Offset: 0x00210F84
		public virtual bool? ImmediatelyDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ImmediatelyDestroy);
			}
		}

		// Token: 0x04007AB2 RID: 31410
		private ITalkEffectStop Instance;

		// Token: 0x04007AB3 RID: 31411
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _EffectKeysCache;

		// Token: 0x04007AB4 RID: 31412
		private bool _EffectKeysInited;
	}
}
