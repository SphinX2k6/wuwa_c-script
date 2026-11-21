using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE6 RID: 7142
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundSpineConverter))]
	public class IFadeBackgroundSpine : IFadeBackgroundType
	{
		// Token: 0x060097A2 RID: 38818 RVA: 0x00160398 File Offset: 0x0015E598
		[NullableContext(0)]
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

		// Token: 0x060097A3 RID: 38819 RVA: 0x001603D0 File Offset: 0x0015E5D0
		[NullableContext(0)]
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

		// Token: 0x060097A4 RID: 38820 RVA: 0x001603E3 File Offset: 0x0015E5E3
		[NullableContext(0)]
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

		// Token: 0x060097A5 RID: 38821 RVA: 0x001603F6 File Offset: 0x0015E5F6
		[NullableContext(0)]
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

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x060097A6 RID: 38822 RVA: 0x0016042D File Offset: 0x0015E62D
		// (set) Token: 0x060097A7 RID: 38823 RVA: 0x00160458 File Offset: 0x0015E658
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

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x060097A8 RID: 38824 RVA: 0x00160466 File Offset: 0x0015E666
		// (set) Token: 0x060097A9 RID: 38825 RVA: 0x00160491 File Offset: 0x0015E691
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

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x001604A0 File Offset: 0x0015E6A0
		// (set) Token: 0x060097AB RID: 38827 RVA: 0x00160501 File Offset: 0x0015E701
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

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x00160518 File Offset: 0x0015E718
		// (set) Token: 0x060097AD RID: 38829 RVA: 0x00160579 File Offset: 0x0015E779
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

		// Token: 0x04005D7A RID: 23930
		protected new IFadeBackgroundSpine FbInstance;

		// Token: 0x04005D7B RID: 23931
		protected new IFadeBackgroundSpine_SetValue PocoInterface;

		// Token: 0x04005D7C RID: 23932
		[Nullable(0)]
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04005D7D RID: 23933
		private bool _FadeInEffectInited;

		// Token: 0x04005D7E RID: 23934
		[Nullable(0)]
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04005D7F RID: 23935
		private bool _FadeOutEffectInited;
	}
}
