using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002272 RID: 8818
	public class IUnlockPhotoMemoryCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600C022 RID: 49186 RVA: 0x001BB02C File Offset: 0x001B922C
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

		// Token: 0x0600C023 RID: 49187 RVA: 0x001BB064 File Offset: 0x001B9264
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

		// Token: 0x0600C024 RID: 49188 RVA: 0x001BB077 File Offset: 0x001B9277
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

		// Token: 0x0600C025 RID: 49189 RVA: 0x001BB08A File Offset: 0x001B928A
		public new IUnlockPhotoMemoryCollectSystemItem_SetValue ToSetValue()
		{
			return new IUnlockPhotoMemoryCollectSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x001BB0A9 File Offset: 0x001B92A9
		// (set) Token: 0x0600C027 RID: 49191 RVA: 0x001BB0D4 File Offset: 0x001B92D4
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

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600C028 RID: 49192 RVA: 0x001BB0E2 File Offset: 0x001B92E2
		// (set) Token: 0x0600C029 RID: 49193 RVA: 0x001BB10D File Offset: 0x001B930D
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

		// Token: 0x04007305 RID: 29445
		[Nullable(2)]
		protected new IUnlockPhotoMemoryCollectSystemItem FbInstance;

		// Token: 0x04007306 RID: 29446
		[Nullable(2)]
		protected new IUnlockPhotoMemoryCollectSystemItem_SetValue PocoInterface;
	}
}
