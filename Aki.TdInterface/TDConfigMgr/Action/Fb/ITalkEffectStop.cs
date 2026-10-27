using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253D RID: 9533
	public class ITalkEffectStop : ITalkEffectActionType
	{
		// Token: 0x0600D472 RID: 54386 RVA: 0x001F7246 File Offset: 0x001F5446
		[NullableContext(1)]
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

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600D473 RID: 54387 RVA: 0x001F7265 File Offset: 0x001F5465
		public override ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600D474 RID: 54388 RVA: 0x001F7274 File Offset: 0x001F5474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> EffectKeys
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600D475 RID: 54389 RVA: 0x001F72EC File Offset: 0x001F54EC
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

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600D476 RID: 54390 RVA: 0x001F7324 File Offset: 0x001F5524
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

		// Token: 0x0400745D RID: 29789
		private ITalkEffectStop Instance;

		// Token: 0x0400745E RID: 29790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _EffectKeysCache;

		// Token: 0x0400745F RID: 29791
		private bool _EffectKeysInited;
	}
}
