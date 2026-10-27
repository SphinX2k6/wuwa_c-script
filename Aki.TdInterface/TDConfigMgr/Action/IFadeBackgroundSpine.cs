using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A51 RID: 6737
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundSpineConverter))]
	public class IFadeBackgroundSpine : IFadeBackgroundType
	{
		// Token: 0x06009038 RID: 36920 RVA: 0x0015046C File Offset: 0x0014E66C
		[NullableContext(1)]
		private IFadeBackgroundSpine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundSpine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundSpine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundSpine_SetValue());
			}
			return result;
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x001504A4 File Offset: 0x0014E6A4
		[NullableContext(1)]
		public static IFadeBackgroundSpine Create([Nullable(2)] IFadeBackgroundSpine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundSpine
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x001504B7 File Offset: 0x0014E6B7
		[NullableContext(1)]
		public static IFadeBackgroundSpine CreateFromSetValue([Nullable(2)] IFadeBackgroundSpine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundSpine
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x001504CA File Offset: 0x0014E6CA
		[NullableContext(1)]
		public new IFadeBackgroundSpine_SetValue ToSetValue()
		{
			return new IFadeBackgroundSpine_SetValue
			{
				Type = this.Type,
				SpineId = this.SpineId,
				FadeInEffect = this.FadeInEffect,
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x00150501 File Offset: 0x0014E701
		// (set) Token: 0x0600903D RID: 36925 RVA: 0x0015052C File Offset: 0x0014E72C
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

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x0015053A File Offset: 0x0014E73A
		// (set) Token: 0x0600903F RID: 36927 RVA: 0x00150565 File Offset: 0x0014E765
		public virtual int SpineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpineId;
			}
			set
			{
				this.GetOrCreatePoco().SpineId = value;
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x00150574 File Offset: 0x0014E774
		// (set) Token: 0x06009041 RID: 36929 RVA: 0x001505D5 File Offset: 0x0014E7D5
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				if (this.FbInstance != null)
				{
					this._FadeInEffectCache = IFadeBackgroundFadeInEffect.Create(this.FbInstance.FadeInEffect);
				}
				else
				{
					IFadeBackgroundSpine_SetValue pocoInterface = this.PocoInterface;
					this._FadeInEffectCache = ((pocoInterface != null) ? pocoInterface.FadeInEffect : null);
				}
				return this._FadeInEffectCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
				this._FadeInEffectInited = false;
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x001505EC File Offset: 0x0014E7EC
		// (set) Token: 0x06009043 RID: 36931 RVA: 0x0015064D File Offset: 0x0014E84D
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutEffectCache = IFadeBackgroundFadeOutEffect.Create(this.FbInstance.FadeOutEffect);
				}
				else
				{
					IFadeBackgroundSpine_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutEffectCache = ((pocoInterface != null) ? pocoInterface.FadeOutEffect : null);
				}
				return this._FadeOutEffectCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
				this._FadeOutEffectInited = false;
			}
		}

		// Token: 0x04005915 RID: 22805
		protected new IFadeBackgroundSpine FbInstance;

		// Token: 0x04005916 RID: 22806
		protected new IFadeBackgroundSpine_SetValue PocoInterface;

		// Token: 0x04005917 RID: 22807
		[Nullable(1)]
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04005918 RID: 22808
		private bool _FadeInEffectInited;

		// Token: 0x04005919 RID: 22809
		[Nullable(1)]
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x0400591A RID: 22810
		private bool _FadeOutEffectInited;
	}
}
