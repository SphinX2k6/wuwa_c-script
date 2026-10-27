using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002776 RID: 10102
	[NullableContext(1)]
	[Nullable(0)]
	public class IFadeBackgroundUiPrefab : IFadeBackgroundType
	{
		// Token: 0x0600E0EF RID: 57583 RVA: 0x00213B58 File Offset: 0x00211D58
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

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x0600E0F0 RID: 57584 RVA: 0x00213B77 File Offset: 0x00211D77
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x00213B84 File Offset: 0x00211D84
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

		// Token: 0x04007C8C RID: 31884
		private IFadeBackgroundUiPrefab Instance;

		// Token: 0x04007C8D RID: 31885
		[Nullable(2)]
		private IFadeBackgroundUiPrefabBlackScreenWhiteText _PrefabTypeCache;

		// Token: 0x04007C8E RID: 31886
		private bool _PrefabTypeInited;
	}
}
