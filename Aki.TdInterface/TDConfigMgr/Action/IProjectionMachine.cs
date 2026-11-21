using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F69 RID: 8041
	public class IProjectionMachine : IUiGame
	{
		// Token: 0x0600AB09 RID: 43785 RVA: 0x00183730 File Offset: 0x00181930
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

		// Token: 0x0600AB0A RID: 43786 RVA: 0x00183768 File Offset: 0x00181968
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

		// Token: 0x0600AB0B RID: 43787 RVA: 0x0018377B File Offset: 0x0018197B
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

		// Token: 0x0600AB0C RID: 43788 RVA: 0x00183790 File Offset: 0x00181990
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

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x001837DE File Offset: 0x001819DE
		// (set) Token: 0x0600AB0E RID: 43790 RVA: 0x00183809 File Offset: 0x00181A09
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

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x00183817 File Offset: 0x00181A17
		// (set) Token: 0x0600AB10 RID: 43792 RVA: 0x00183842 File Offset: 0x00181A42
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

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600AB11 RID: 43793 RVA: 0x00183850 File Offset: 0x00181A50
		// (set) Token: 0x0600AB12 RID: 43794 RVA: 0x0018387B File Offset: 0x00181A7B
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

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600AB13 RID: 43795 RVA: 0x0018388C File Offset: 0x00181A8C
		// (set) Token: 0x0600AB14 RID: 43796 RVA: 0x001838C6 File Offset: 0x00181AC6
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

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600AB15 RID: 43797 RVA: 0x001838D4 File Offset: 0x00181AD4
		// (set) Token: 0x0600AB16 RID: 43798 RVA: 0x00183935 File Offset: 0x00181B35
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

		// Token: 0x0400667C RID: 26236
		[Nullable(2)]
		protected new IProjectionMachine FbInstance;

		// Token: 0x0400667D RID: 26237
		[Nullable(2)]
		protected new IProjectionMachine_SetValue PocoInterface;

		// Token: 0x0400667E RID: 26238
		private IProjectionMachinePhotoFilter _PhotoFilterCache;

		// Token: 0x0400667F RID: 26239
		private bool _PhotoFilterInited;
	}
}
