using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B5E RID: 7006
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemGetUiConfigBase
	{
		// Token: 0x060095FD RID: 38397 RVA: 0x0015A9A8 File Offset: 0x00158BA8
		private IItemGetUiConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemGetUiConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemGetUiConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemGetUiConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x0015A9E0 File Offset: 0x00158BE0
		public static IItemGetUiConfigBase Create([Nullable(2)] IItemGetUiConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemGetUiConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x0015A9F3 File Offset: 0x00158BF3
		public static IItemGetUiConfigBase CreateFromSetValue([Nullable(2)] IItemGetUiConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemGetUiConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x0015AA06 File Offset: 0x00158C06
		public IItemGetUiConfigBase_SetValue ToSetValue()
		{
			return new IItemGetUiConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x06009601 RID: 38401 RVA: 0x0015AA19 File Offset: 0x00158C19
		// (set) Token: 0x06009602 RID: 38402 RVA: 0x0015AA44 File Offset: 0x00158C44
		public virtual EItemGetUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EItemGetUiType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005BBF RID: 23487
		[Nullable(2)]
		protected IItemGetUiConfigBase FbInstance;

		// Token: 0x04005BC0 RID: 23488
		[Nullable(2)]
		protected IItemGetUiConfigBase_SetValue PocoInterface;
	}
}
