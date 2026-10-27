using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001335 RID: 4917
	[NullableContext(1)]
	[Nullable(0)]
	public class IWordArtConfig
	{
		// Token: 0x060070B5 RID: 28853 RVA: 0x0010FED2 File Offset: 0x0010E0D2
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

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x0010FEF1 File Offset: 0x0010E0F1
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

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x060070B7 RID: 28855 RVA: 0x0010FF25 File Offset: 0x0010E125
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

		// Token: 0x04004101 RID: 16641
		private IWordArtConfig Instance;

		// Token: 0x04004102 RID: 16642
		[Nullable(2)]
		private INumberWordArtEffectiveTargetType _EffectiveTargetCache;

		// Token: 0x04004103 RID: 16643
		private bool _EffectiveTargetInited;

		// Token: 0x04004104 RID: 16644
		[Nullable(2)]
		private IWordArtDefaultResourceType _ResourceCache;

		// Token: 0x04004105 RID: 16645
		private bool _ResourceInited;
	}
}
