using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001485 RID: 5253
	public class IWordArtConfig
	{
		// Token: 0x06007755 RID: 30549 RVA: 0x0011E43E File Offset: 0x0011C63E
		public static IWordArtConfig Create(IWordArtConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWordArtConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x0011E45D File Offset: 0x0011C65D
		public virtual INumberWordArtEffectiveTargetType EffectiveTarget
		{
			get
			{
				if (this._EffectiveTargetInited)
				{
					return this._EffectiveTargetCache;
				}
				this._EffectiveTargetInited = true;
				this._EffectiveTargetCache = INumberWordArtEffectiveTargetType.Create(this.Instance.EffectiveTarget);
				return this._EffectiveTargetCache;
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x0011E491 File Offset: 0x0011C691
		public virtual IWordArtDefaultResourceType Resource
		{
			get
			{
				if (this._ResourceInited)
				{
					return this._ResourceCache;
				}
				this._ResourceInited = true;
				this._ResourceCache = IWordArtDefaultResourceType.Create(this.Instance.Resource);
				return this._ResourceCache;
			}
		}

		// Token: 0x0400447D RID: 17533
		private IWordArtConfig Instance;

		// Token: 0x0400447E RID: 17534
		[Nullable(2)]
		private INumberWordArtEffectiveTargetType _EffectiveTargetCache;

		// Token: 0x0400447F RID: 17535
		private bool _EffectiveTargetInited;

		// Token: 0x04004480 RID: 17536
		[Nullable(2)]
		private IWordArtDefaultResourceType _ResourceCache;

		// Token: 0x04004481 RID: 17537
		private bool _ResourceInited;
	}
}
