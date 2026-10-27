using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002027 RID: 8231
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnLockDangoCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600B4F2 RID: 46322 RVA: 0x001A47C0 File Offset: 0x001A29C0
		private IUnLockDangoCollectSystemItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnLockDangoCollectSystemItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnLockDangoCollectSystemItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnLockDangoCollectSystemItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x001A47F8 File Offset: 0x001A29F8
		public static IUnLockDangoCollectSystemItem Create([Nullable(2)] IUnLockDangoCollectSystemItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnLockDangoCollectSystemItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x001A480B File Offset: 0x001A2A0B
		public static IUnLockDangoCollectSystemItem CreateFromSetValue([Nullable(2)] IUnLockDangoCollectSystemItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnLockDangoCollectSystemItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x001A481E File Offset: 0x001A2A1E
		public new IUnLockDangoCollectSystemItem_SetValue ToSetValue()
		{
			return new IUnLockDangoCollectSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600B4F6 RID: 46326 RVA: 0x001A483D File Offset: 0x001A2A3D
		// (set) Token: 0x0600B4F7 RID: 46327 RVA: 0x001A4868 File Offset: 0x001A2A68
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

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600B4F8 RID: 46328 RVA: 0x001A4876 File Offset: 0x001A2A76
		// (set) Token: 0x0600B4F9 RID: 46329 RVA: 0x001A48A1 File Offset: 0x001A2AA1
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

		// Token: 0x04006CF8 RID: 27896
		[Nullable(2)]
		protected new IUnLockDangoCollectSystemItem FbInstance;

		// Token: 0x04006CF9 RID: 27897
		[Nullable(2)]
		protected new IUnLockDangoCollectSystemItem_SetValue PocoInterface;
	}
}
