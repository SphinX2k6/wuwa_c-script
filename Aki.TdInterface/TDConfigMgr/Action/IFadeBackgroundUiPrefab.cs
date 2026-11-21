using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BEA RID: 7146
	[JsonConverter(typeof(IFadeBackgroundUiPrefabConverter))]
	public class IFadeBackgroundUiPrefab : IFadeBackgroundType
	{
		// Token: 0x060097B8 RID: 38840 RVA: 0x0016065C File Offset: 0x0015E85C
		private IFadeBackgroundUiPrefab_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundUiPrefab 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundUiPrefab_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundUiPrefab_SetValue());
			}
			return result;
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x00160694 File Offset: 0x0015E894
		public static IFadeBackgroundUiPrefab Create([Nullable(2)] IFadeBackgroundUiPrefab instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefab
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x001606A7 File Offset: 0x0015E8A7
		public static IFadeBackgroundUiPrefab CreateFromSetValue([Nullable(2)] IFadeBackgroundUiPrefab_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundUiPrefab
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x001606BA File Offset: 0x0015E8BA
		public new IFadeBackgroundUiPrefab_SetValue ToSetValue()
		{
			return new IFadeBackgroundUiPrefab_SetValue
			{
				Type = this.Type,
				PrefabType = this.PrefabType
			};
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x060097BC RID: 38844 RVA: 0x001606D9 File Offset: 0x0015E8D9
		// (set) Token: 0x060097BD RID: 38845 RVA: 0x00160704 File Offset: 0x0015E904
		public override EFadeBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFadeBackgroundType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x060097BE RID: 38846 RVA: 0x00160714 File Offset: 0x0015E914
		// (set) Token: 0x060097BF RID: 38847 RVA: 0x00160775 File Offset: 0x0015E975
		public virtual IFadeBackgroundUiPrefabBlackScreenWhiteText PrefabType
		{
			get
			{
				if (this._PrefabTypeInited)
				{
					return this._PrefabTypeCache;
				}
				this._PrefabTypeInited = true;
				if (this.FbInstance != null)
				{
					this._PrefabTypeCache = IFadeBackgroundUiPrefabBlackScreenWhiteText.Create(this.FbInstance.PrefabType);
				}
				else
				{
					IFadeBackgroundUiPrefab_SetValue pocoInterface = this.PocoInterface;
					this._PrefabTypeCache = ((pocoInterface != null) ? pocoInterface.PrefabType : null);
				}
				return this._PrefabTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().PrefabType = value;
				this._PrefabTypeInited = false;
			}
		}

		// Token: 0x04005D87 RID: 23943
		[Nullable(2)]
		protected new IFadeBackgroundUiPrefab FbInstance;

		// Token: 0x04005D88 RID: 23944
		[Nullable(2)]
		protected new IFadeBackgroundUiPrefab_SetValue PocoInterface;

		// Token: 0x04005D89 RID: 23945
		private IFadeBackgroundUiPrefabBlackScreenWhiteText _PrefabTypeCache;

		// Token: 0x04005D8A RID: 23946
		private bool _PrefabTypeInited;
	}
}
