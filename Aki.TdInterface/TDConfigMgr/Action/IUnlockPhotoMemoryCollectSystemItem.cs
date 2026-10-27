using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002029 RID: 8233
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnlockPhotoMemoryCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600B4FC RID: 46332 RVA: 0x001A48C0 File Offset: 0x001A2AC0
		private IUnlockPhotoMemoryCollectSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockPhotoMemoryCollectSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockPhotoMemoryCollectSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockPhotoMemoryCollectSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x001A48F8 File Offset: 0x001A2AF8
		public static IUnlockPhotoMemoryCollectSystemItem Create([Nullable(2)] IUnlockPhotoMemoryCollectSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockPhotoMemoryCollectSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x001A490B File Offset: 0x001A2B0B
		public static IUnlockPhotoMemoryCollectSystemItem CreateFromSetValue([Nullable(2)] IUnlockPhotoMemoryCollectSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockPhotoMemoryCollectSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x001A491E File Offset: 0x001A2B1E
		public new IUnlockPhotoMemoryCollectSystemItem_SetValue ToSetValue()
		{
			return new IUnlockPhotoMemoryCollectSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B500 RID: 46336 RVA: 0x001A493D File Offset: 0x001A2B3D
		// (set) Token: 0x0600B501 RID: 46337 RVA: 0x001A4968 File Offset: 0x001A2B68
		public override EUnlockSystemItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockSystemItemType.CookSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B502 RID: 46338 RVA: 0x001A4976 File Offset: 0x001A2B76
		// (set) Token: 0x0600B503 RID: 46339 RVA: 0x001A49A1 File Offset: 0x001A2BA1
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006CFC RID: 27900
		[Nullable(2)]
		protected new IUnlockPhotoMemoryCollectSystemItem FbInstance;

		// Token: 0x04006CFD RID: 27901
		[Nullable(2)]
		protected new IUnlockPhotoMemoryCollectSystemItem_SetValue PocoInterface;
	}
}
