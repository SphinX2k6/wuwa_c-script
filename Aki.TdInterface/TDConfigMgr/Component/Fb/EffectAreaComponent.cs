using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D0E RID: 3342
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectAreaComponent : IComponentBase
	{
		// Token: 0x06004C4B RID: 19531 RVA: 0x000BE2D9 File Offset: 0x000BC4D9
		public static EffectAreaComponent Create(IEffectAreaComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EffectAreaComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x000BE2F8 File Offset: 0x000BC4F8
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x000BE330 File Offset: 0x000BC530
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x000BE346 File Offset: 0x000BC546
		public virtual IBuffArea Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IBuffArea.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04002BAD RID: 11181
		private IEffectAreaComponent Instance;

		// Token: 0x04002BAE RID: 11182
		[Nullable(2)]
		private IBuffArea _ConfigCache;

		// Token: 0x04002BAF RID: 11183
		private bool _ConfigInited;
	}
}
