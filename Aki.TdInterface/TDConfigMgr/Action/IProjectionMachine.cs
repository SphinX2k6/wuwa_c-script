using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D58 RID: 7512
	[NullableContext(1)]
	[Nullable(0)]
	public class IProjectionMachine : IUiGame
	{
		// Token: 0x0600A11D RID: 41245 RVA: 0x0016F30C File Offset: 0x0016D50C
		private IProjectionMachine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProjectionMachine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProjectionMachine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProjectionMachine_SetValue());
			}
			return result;
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x0016F344 File Offset: 0x0016D544
		public static IProjectionMachine Create([Nullable(2)] IProjectionMachine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectionMachine
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x0016F357 File Offset: 0x0016D557
		public static IProjectionMachine CreateFromSetValue([Nullable(2)] IProjectionMachine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProjectionMachine
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x0016F36C File Offset: 0x0016D56C
		public new IProjectionMachine_SetValue ToSetValue()
		{
			return new IProjectionMachine_SetValue
			{
				Type = this.Type,
				ItemId = this.ItemId,
				PhotoAsset = this.PhotoAsset,
				HideFixedPhoto = this.HideFixedPhoto,
				PhotoFilter = this.PhotoFilter
			};
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600A121 RID: 41249 RVA: 0x0016F3BA File Offset: 0x0016D5BA
		// (set) Token: 0x0600A122 RID: 41250 RVA: 0x0016F3E5 File Offset: 0x0016D5E5
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A123 RID: 41251 RVA: 0x0016F3F3 File Offset: 0x0016D5F3
		// (set) Token: 0x0600A124 RID: 41252 RVA: 0x0016F41E File Offset: 0x0016D61E
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A125 RID: 41253 RVA: 0x0016F42C File Offset: 0x0016D62C
		// (set) Token: 0x0600A126 RID: 41254 RVA: 0x0016F457 File Offset: 0x0016D657
		public virtual string PhotoAsset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhotoAsset;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PhotoAsset;
			}
			set
			{
				this.GetOrCreatePoco().PhotoAsset = value;
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A127 RID: 41255 RVA: 0x0016F468 File Offset: 0x0016D668
		// (set) Token: 0x0600A128 RID: 41256 RVA: 0x0016F4A2 File Offset: 0x0016D6A2
		public virtual bool? HideFixedPhoto
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideFixedPhoto;
				}
				IProjectionMachine_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideFixedPhoto;
			}
			set
			{
				this.GetOrCreatePoco().HideFixedPhoto = value;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x0016F4B0 File Offset: 0x0016D6B0
		// (set) Token: 0x0600A12A RID: 41258 RVA: 0x0016F511 File Offset: 0x0016D711
		[Nullable(2)]
		public virtual IProjectionMachinePhotoFilter PhotoFilter
		{
			[NullableContext(2)]
			get
			{
				if (this._PhotoFilterInited)
				{
					return this._PhotoFilterCache;
				}
				this._PhotoFilterInited = true;
				if (this.FbInstance != null)
				{
					this._PhotoFilterCache = IProjectionMachinePhotoFilter.Create(this.FbInstance.PhotoFilter);
				}
				else
				{
					IProjectionMachine_SetValue pocoInterface = this.PocoInterface;
					this._PhotoFilterCache = ((pocoInterface != null) ? pocoInterface.PhotoFilter : null);
				}
				return this._PhotoFilterCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PhotoFilter = value;
				this._PhotoFilterInited = false;
			}
		}

		// Token: 0x04006100 RID: 24832
		[Nullable(2)]
		protected new IProjectionMachine FbInstance;

		// Token: 0x04006101 RID: 24833
		[Nullable(2)]
		protected new IProjectionMachine_SetValue PocoInterface;

		// Token: 0x04006102 RID: 24834
		private IProjectionMachinePhotoFilter _PhotoFilterCache;

		// Token: 0x04006103 RID: 24835
		private bool _PhotoFilterInited;
	}
}
