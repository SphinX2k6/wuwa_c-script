using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE0 RID: 8160
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupArtText : ITransitionPopupStyle
	{
		// Token: 0x0600B388 RID: 45960 RVA: 0x001A1F4C File Offset: 0x001A014C
		private ITransitionPopupArtText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupArtText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupArtText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupArtText_SetValue());
			}
			return result;
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x001A1F84 File Offset: 0x001A0184
		public static ITransitionPopupArtText Create([Nullable(2)] ITransitionPopupArtText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtText
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x001A1F97 File Offset: 0x001A0197
		public static ITransitionPopupArtText CreateFromSetValue([Nullable(2)] ITransitionPopupArtText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupArtText
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B38B RID: 45963 RVA: 0x001A1FAA File Offset: 0x001A01AA
		public new ITransitionPopupArtText_SetValue ToSetValue()
		{
			return new ITransitionPopupArtText_SetValue
			{
				Type = this.Type,
				ArtTextType = this.ArtTextType
			};
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600B38C RID: 45964 RVA: 0x001A1FC9 File Offset: 0x001A01C9
		// (set) Token: 0x0600B38D RID: 45965 RVA: 0x001A1FF4 File Offset: 0x001A01F4
		public override ETransitionPopupStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x001A2004 File Offset: 0x001A0204
		// (set) Token: 0x0600B38F RID: 45967 RVA: 0x001A2065 File Offset: 0x001A0265
		public virtual ITransitionPopupYuanChengArtText ArtTextType
		{
			get
			{
				if (this._ArtTextTypeInited)
				{
					return this._ArtTextTypeCache;
				}
				this._ArtTextTypeInited = true;
				if (this.FbInstance != null)
				{
					this._ArtTextTypeCache = ITransitionPopupYuanChengArtText.Create(this.FbInstance.ArtTextType);
				}
				else
				{
					ITransitionPopupArtText_SetValue pocoInterface = this.PocoInterface;
					this._ArtTextTypeCache = ((pocoInterface != null) ? pocoInterface.ArtTextType : null);
				}
				return this._ArtTextTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().ArtTextType = value;
				this._ArtTextTypeInited = false;
			}
		}

		// Token: 0x04006C51 RID: 27729
		[Nullable(2)]
		protected new ITransitionPopupArtText FbInstance;

		// Token: 0x04006C52 RID: 27730
		[Nullable(2)]
		protected new ITransitionPopupArtText_SetValue PocoInterface;

		// Token: 0x04006C53 RID: 27731
		private ITransitionPopupYuanChengArtText _ArtTextTypeCache;

		// Token: 0x04006C54 RID: 27732
		private bool _ArtTextTypeInited;
	}
}
