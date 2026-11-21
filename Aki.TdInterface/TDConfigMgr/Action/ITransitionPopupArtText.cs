using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002227 RID: 8743
	public class ITransitionPopupArtText : ITransitionPopupStyle
	{
		// Token: 0x0600BE9E RID: 48798 RVA: 0x001B84B8 File Offset: 0x001B66B8
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

		// Token: 0x0600BE9F RID: 48799 RVA: 0x001B84F0 File Offset: 0x001B66F0
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

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x001B8503 File Offset: 0x001B6703
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

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x001B8516 File Offset: 0x001B6716
		public new ITransitionPopupArtText_SetValue ToSetValue()
		{
			return new ITransitionPopupArtText_SetValue
			{
				Type = this.Type,
				ArtTextType = this.ArtTextType
			};
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600BEA2 RID: 48802 RVA: 0x001B8535 File Offset: 0x001B6735
		// (set) Token: 0x0600BEA3 RID: 48803 RVA: 0x001B8560 File Offset: 0x001B6760
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

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600BEA4 RID: 48804 RVA: 0x001B8570 File Offset: 0x001B6770
		// (set) Token: 0x0600BEA5 RID: 48805 RVA: 0x001B85D1 File Offset: 0x001B67D1
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

		// Token: 0x04007253 RID: 29267
		[Nullable(2)]
		protected new ITransitionPopupArtText FbInstance;

		// Token: 0x04007254 RID: 29268
		[Nullable(2)]
		protected new ITransitionPopupArtText_SetValue PocoInterface;

		// Token: 0x04007255 RID: 29269
		private ITransitionPopupYuanChengArtText _ArtTextTypeCache;

		// Token: 0x04007256 RID: 29270
		private bool _ArtTextTypeInited;
	}
}
