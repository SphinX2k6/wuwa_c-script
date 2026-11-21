using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A48 RID: 10824
	public class IFadeBackgroundUiPrefab : IFadeBackgroundType
	{
		// Token: 0x0600EF0D RID: 61197 RVA: 0x002308EC File Offset: 0x0022EAEC
		public static IFadeBackgroundUiPrefab Create(IFadeBackgroundUiPrefab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x0600EF0E RID: 61198 RVA: 0x0023090B File Offset: 0x0022EB0B
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x0600EF0F RID: 61199 RVA: 0x00230918 File Offset: 0x0022EB18
		public virtual IFadeBackgroundUiPrefabBlackScreenWhiteText PrefabType
		{
			get
			{
				if (this._PrefabTypeInited)
				{
					return this._PrefabTypeCache;
				}
				this._PrefabTypeInited = true;
				this._PrefabTypeCache = IFadeBackgroundUiPrefabBlackScreenWhiteText.Create(this.Instance.PrefabType);
				return this._PrefabTypeCache;
			}
		}

		// Token: 0x04008342 RID: 33602
		private IFadeBackgroundUiPrefab Instance;

		// Token: 0x04008343 RID: 33603
		[Nullable(2)]
		private IFadeBackgroundUiPrefabBlackScreenWhiteText _PrefabTypeCache;

		// Token: 0x04008344 RID: 33604
		private bool _PrefabTypeInited;
	}
}
