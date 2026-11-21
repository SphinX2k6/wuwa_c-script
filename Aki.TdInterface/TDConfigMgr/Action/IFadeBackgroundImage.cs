using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BE4 RID: 7140
	[JsonConverter(typeof(IFadeBackgroundImageConverter))]
	public class IFadeBackgroundImage : IFadeBackgroundType
	{
		// Token: 0x06009794 RID: 38804 RVA: 0x00160190 File Offset: 0x0015E390
		private IFadeBackgroundImage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFadeBackgroundImage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFadeBackgroundImage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFadeBackgroundImage_SetValue());
			}
			return result;
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x001601C8 File Offset: 0x0015E3C8
		public static IFadeBackgroundImage Create([Nullable(2)] IFadeBackgroundImage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundImage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x001601DB File Offset: 0x0015E3DB
		public static IFadeBackgroundImage CreateFromSetValue([Nullable(2)] IFadeBackgroundImage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFadeBackgroundImage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009797 RID: 38807 RVA: 0x001601EE File Offset: 0x0015E3EE
		public new IFadeBackgroundImage_SetValue ToSetValue()
		{
			return new IFadeBackgroundImage_SetValue
			{
				Type = this.Type,
				BackgroundImage = this.BackgroundImage,
				FadeInEffect = this.FadeInEffect,
				FadeOutEffect = this.FadeOutEffect
			};
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009798 RID: 38808 RVA: 0x00160225 File Offset: 0x0015E425
		// (set) Token: 0x06009799 RID: 38809 RVA: 0x00160250 File Offset: 0x0015E450
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

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600979A RID: 38810 RVA: 0x0016025E File Offset: 0x0015E45E
		// (set) Token: 0x0600979B RID: 38811 RVA: 0x00160289 File Offset: 0x0015E489
		public virtual string BackgroundImage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BackgroundImage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BackgroundImage;
			}
			set
			{
				this.GetOrCreatePoco().BackgroundImage = value;
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600979C RID: 38812 RVA: 0x00160298 File Offset: 0x0015E498
		// (set) Token: 0x0600979D RID: 38813 RVA: 0x001602F9 File Offset: 0x0015E4F9
		[Nullable(2)]
		public virtual IFadeBackgroundFadeInEffect FadeInEffect
		{
			[NullableContext(2)]
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
					IFadeBackgroundImage_SetValue pocoInterface = this.PocoInterface;
					this._FadeInEffectCache = ((pocoInterface != null) ? pocoInterface.FadeInEffect : null);
				}
				return this._FadeInEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FadeInEffect = value;
				this._FadeInEffectInited = false;
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600979E RID: 38814 RVA: 0x00160310 File Offset: 0x0015E510
		// (set) Token: 0x0600979F RID: 38815 RVA: 0x00160371 File Offset: 0x0015E571
		[Nullable(2)]
		public virtual IFadeBackgroundFadeOutEffect FadeOutEffect
		{
			[NullableContext(2)]
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
					IFadeBackgroundImage_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutEffectCache = ((pocoInterface != null) ? pocoInterface.FadeOutEffect : null);
				}
				return this._FadeOutEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FadeOutEffect = value;
				this._FadeOutEffectInited = false;
			}
		}

		// Token: 0x04005D70 RID: 23920
		[Nullable(2)]
		protected new IFadeBackgroundImage FbInstance;

		// Token: 0x04005D71 RID: 23921
		[Nullable(2)]
		protected new IFadeBackgroundImage_SetValue PocoInterface;

		// Token: 0x04005D72 RID: 23922
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x04005D73 RID: 23923
		private bool _FadeInEffectInited;

		// Token: 0x04005D74 RID: 23924
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04005D75 RID: 23925
		private bool _FadeOutEffectInited;
	}
}
