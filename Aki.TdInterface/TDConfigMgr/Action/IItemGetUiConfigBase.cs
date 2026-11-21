using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D0B RID: 7435
	public class IItemGetUiConfigBase
	{
		// Token: 0x06009DDF RID: 40415 RVA: 0x0016B554 File Offset: 0x00169754
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

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0016B58C File Offset: 0x0016978C
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

		// Token: 0x06009DE1 RID: 40417 RVA: 0x0016B59F File Offset: 0x0016979F
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

		// Token: 0x06009DE2 RID: 40418 RVA: 0x0016B5B2 File Offset: 0x001697B2
		public IItemGetUiConfigBase_SetValue ToSetValue()
		{
			return new IItemGetUiConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x0016B5C5 File Offset: 0x001697C5
		// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x0016B5F0 File Offset: 0x001697F0
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

		// Token: 0x04006058 RID: 24664
		[Nullable(2)]
		protected IItemGetUiConfigBase FbInstance;

		// Token: 0x04006059 RID: 24665
		[Nullable(2)]
		protected IItemGetUiConfigBase_SetValue PocoInterface;
	}
}
