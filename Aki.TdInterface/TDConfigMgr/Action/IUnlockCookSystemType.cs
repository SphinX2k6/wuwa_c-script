using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002025 RID: 8229
	[NullableContext(1)]
	[Nullable(0)]
	public class IUnlockCookSystemType
	{
		// Token: 0x0600B4EA RID: 46314 RVA: 0x001A4704 File Offset: 0x001A2904
		private IUnlockCookSystemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUnlockCookSystemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUnlockCookSystemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUnlockCookSystemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x001A473C File Offset: 0x001A293C
		public static IUnlockCookSystemType Create([Nullable(2)] IUnlockCookSystemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x001A474F File Offset: 0x001A294F
		public static IUnlockCookSystemType CreateFromSetValue([Nullable(2)] IUnlockCookSystemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x001A4762 File Offset: 0x001A2962
		public IUnlockCookSystemType_SetValue ToSetValue()
		{
			return new IUnlockCookSystemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x001A4775 File Offset: 0x001A2975
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x001A47A0 File Offset: 0x001A29A0
		public virtual EUnlockCookSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUnlockCookSystemType.UnlockCookBook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006CF5 RID: 27893
		[Nullable(2)]
		protected IUnlockCookSystemType FbInstance;

		// Token: 0x04006CF6 RID: 27894
		[Nullable(2)]
		protected IUnlockCookSystemType_SetValue PocoInterface;
	}
}
