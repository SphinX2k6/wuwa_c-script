using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253C RID: 9532
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkEffectPlay : ITalkEffectActionType
	{
		// Token: 0x0600D46B RID: 54379 RVA: 0x001F7162 File Offset: 0x001F5362
		public static ITalkEffectPlay Create(ITalkEffectPlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectPlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600D46C RID: 54380 RVA: 0x001F7181 File Offset: 0x001F5381
		public override ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600D46D RID: 54381 RVA: 0x001F718E File Offset: 0x001F538E
		public virtual ITalkCommonEffect Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				this._EffectCache = ITalkCommonEffect.Create(this.Instance.Effect);
				return this._EffectCache;
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600D46E RID: 54382 RVA: 0x001F71C4 File Offset: 0x001F53C4
		public virtual bool? KeepPlay
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPlay);
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600D46F RID: 54383 RVA: 0x001F71FA File Offset: 0x001F53FA
		[Nullable(2)]
		public virtual string EffectKey
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EffectKey;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600D470 RID: 54384 RVA: 0x001F7208 File Offset: 0x001F5408
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

		// Token: 0x0400745A RID: 29786
		private ITalkEffectPlay Instance;

		// Token: 0x0400745B RID: 29787
		[Nullable(2)]
		private ITalkCommonEffect _EffectCache;

		// Token: 0x0400745C RID: 29788
		private bool _EffectInited;
	}
}
