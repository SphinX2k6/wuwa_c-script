using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A55 RID: 6741
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundUiPrefabConverter))]
	public class IFadeBackgroundUiPrefab : IFadeBackgroundType
	{
		// Token: 0x0600904E RID: 36942 RVA: 0x00150730 File Offset: 0x0014E930
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

		// Token: 0x0600904F RID: 36943 RVA: 0x00150768 File Offset: 0x0014E968
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

		// Token: 0x06009050 RID: 36944 RVA: 0x0015077B File Offset: 0x0014E97B
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

		// Token: 0x06009051 RID: 36945 RVA: 0x0015078E File Offset: 0x0014E98E
		public new IFadeBackgroundUiPrefab_SetValue ToSetValue()
		{
			return new IFadeBackgroundUiPrefab_SetValue
			{
				Type = this.Type,
				PrefabType = this.PrefabType
			};
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x001507AD File Offset: 0x0014E9AD
		// (set) Token: 0x06009053 RID: 36947 RVA: 0x001507D8 File Offset: 0x0014E9D8
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

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x06009054 RID: 36948 RVA: 0x001507E8 File Offset: 0x0014E9E8
		// (set) Token: 0x06009055 RID: 36949 RVA: 0x00150849 File Offset: 0x0014EA49
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

		// Token: 0x04005922 RID: 22818
		[Nullable(2)]
		protected new IFadeBackgroundUiPrefab FbInstance;

		// Token: 0x04005923 RID: 22819
		[Nullable(2)]
		protected new IFadeBackgroundUiPrefab_SetValue PocoInterface;

		// Token: 0x04005924 RID: 22820
		private IFadeBackgroundUiPrefabBlackScreenWhiteText _PrefabTypeCache;

		// Token: 0x04005925 RID: 22821
		private bool _PrefabTypeInited;
	}
}
