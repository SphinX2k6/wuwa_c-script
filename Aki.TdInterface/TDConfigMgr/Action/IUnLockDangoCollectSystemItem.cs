using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002270 RID: 8816
	public class IUnLockDangoCollectSystemItem : IUnlockSystemItemType
	{
		// Token: 0x0600C018 RID: 49176 RVA: 0x001BAF2C File Offset: 0x001B912C
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

		// Token: 0x0600C019 RID: 49177 RVA: 0x001BAF64 File Offset: 0x001B9164
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

		// Token: 0x0600C01A RID: 49178 RVA: 0x001BAF77 File Offset: 0x001B9177
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

		// Token: 0x0600C01B RID: 49179 RVA: 0x001BAF8A File Offset: 0x001B918A
		public new IUnLockDangoCollectSystemItem_SetValue ToSetValue()
		{
			return new IUnLockDangoCollectSystemItem_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600C01C RID: 49180 RVA: 0x001BAFA9 File Offset: 0x001B91A9
		// (set) Token: 0x0600C01D RID: 49181 RVA: 0x001BAFD4 File Offset: 0x001B91D4
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

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x001BAFE2 File Offset: 0x001B91E2
		// (set) Token: 0x0600C01F RID: 49183 RVA: 0x001BB00D File Offset: 0x001B920D
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

		// Token: 0x04007301 RID: 29441
		[Nullable(2)]
		protected new IUnLockDangoCollectSystemItem FbInstance;

		// Token: 0x04007302 RID: 29442
		[Nullable(2)]
		protected new IUnLockDangoCollectSystemItem_SetValue PocoInterface;
	}
}
