using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200202B RID: 8235
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnlockSystemItemType
	{
		// Token: 0x0600B506 RID: 46342 RVA: 0x001A49C0 File Offset: 0x001A2BC0
		private IUnlockSystemItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockSystemItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockSystemItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockSystemItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x001A49F8 File Offset: 0x001A2BF8
		public static IUnlockSystemItemType Create([Nullable(2)] IUnlockSystemItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x001A4A0B File Offset: 0x001A2C0B
		public static IUnlockSystemItemType CreateFromSetValue([Nullable(2)] IUnlockSystemItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x001A4A1E File Offset: 0x001A2C1E
		public IUnlockSystemItemType_SetValue ToSetValue()
		{
			return new IUnlockSystemItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x001A4A31 File Offset: 0x001A2C31
		// (set) Token: 0x0600B50B RID: 46347 RVA: 0x001A4A5C File Offset: 0x001A2C5C
		public virtual EUnlockSystemItemType Type
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

		// Token: 0x04006D00 RID: 27904
		[Nullable(2)]
		protected IUnlockSystemItemType FbInstance;

		// Token: 0x04006D01 RID: 27905
		[Nullable(2)]
		protected IUnlockSystemItemType_SetValue PocoInterface;
	}
}
