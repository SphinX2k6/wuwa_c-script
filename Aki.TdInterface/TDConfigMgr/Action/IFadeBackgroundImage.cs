using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A4F RID: 6735
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IFadeBackgroundImageConverter))]
	public class IFadeBackgroundImage : IFadeBackgroundType
	{
		// Token: 0x0600902A RID: 36906 RVA: 0x00150264 File Offset: 0x0014E464
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

		// Token: 0x0600902B RID: 36907 RVA: 0x0015029C File Offset: 0x0014E49C
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

		// Token: 0x0600902C RID: 36908 RVA: 0x001502AF File Offset: 0x0014E4AF
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

		// Token: 0x0600902D RID: 36909 RVA: 0x001502C2 File Offset: 0x0014E4C2
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

		// Token: 0x17002DF4 RID: 11764
		// (get) Token: 0x0600902E RID: 36910 RVA: 0x001502F9 File Offset: 0x0014E4F9
		// (set) Token: 0x0600902F RID: 36911 RVA: 0x00150324 File Offset: 0x0014E524
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

		// Token: 0x17002DF5 RID: 11765
		// (get) Token: 0x06009030 RID: 36912 RVA: 0x00150332 File Offset: 0x0014E532
		// (set) Token: 0x06009031 RID: 36913 RVA: 0x0015035D File Offset: 0x0014E55D
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

		// Token: 0x17002DF6 RID: 11766
		// (get) Token: 0x06009032 RID: 36914 RVA: 0x0015036C File Offset: 0x0014E56C
		// (set) Token: 0x06009033 RID: 36915 RVA: 0x001503CD File Offset: 0x0014E5CD
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

		// Token: 0x17002DF7 RID: 11767
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x001503E4 File Offset: 0x0014E5E4
		// (set) Token: 0x06009035 RID: 36917 RVA: 0x00150445 File Offset: 0x0014E645
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

		// Token: 0x0400590B RID: 22795
		[Nullable(2)]
		protected new IFadeBackgroundImage FbInstance;

		// Token: 0x0400590C RID: 22796
		[Nullable(2)]
		protected new IFadeBackgroundImage_SetValue PocoInterface;

		// Token: 0x0400590D RID: 22797
		private IFadeBackgroundFadeInEffect _FadeInEffectCache;

		// Token: 0x0400590E RID: 22798
		private bool _FadeInEffectInited;

		// Token: 0x0400590F RID: 22799
		private IFadeBackgroundFadeOutEffect _FadeOutEffectCache;

		// Token: 0x04005910 RID: 22800
		private bool _FadeOutEffectInited;
	}
}
