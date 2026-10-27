using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002772 RID: 10098
	[NullableContext(2)]
	[Nullable(0)]
	public class IFadeBackgroundSpine : IFadeBackgroundType
	{
		// Token: 0x0600E0DA RID: 57562 RVA: 0x00213977 File Offset: 0x00211B77
		[NullableContext(1)]
		public static IFadeBackgroundSpine Create(IFadeBackgroundSpine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundSpine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x00213996 File Offset: 0x00211B96
		public override EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x002139A3 File Offset: 0x00211BA3
		public virtual int SpineId
		{
			get
			{
				return this.Instance.SpineId;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x002139B0 File Offset: 0x00211BB0
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				this._FadeInEffectCache = IFadeBackgroundFadeInEffect.Create(this.Instance.FadeInEffect);
				return this._FadeInEffectCache;
			}
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x002139E4 File Offset: 0x00211BE4
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				this._FadeOutEffectCache = IFadeBackgroundFadeOutEffect.Create(this.Instance.FadeOutEffect);
				return this._FadeOutEffectCache;
			}
		}

		// Token: 0x04007C80 RID: 31872
		private IFadeBackgroundSpine Instance;

		// Token: 0x04007C81 RID: 31873
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04007C82 RID: 31874
		private bool _FadeInEffectInited;

		// Token: 0x04007C83 RID: 31875
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04007C84 RID: 31876
		private bool _FadeOutEffectInited;
	}
}
