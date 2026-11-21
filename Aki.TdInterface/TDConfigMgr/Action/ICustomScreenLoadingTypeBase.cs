using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADB RID: 6875
	public class ICustomScreenLoadingTypeBase
	{
		// Token: 0x0600920B RID: 37387 RVA: 0x00156648 File Offset: 0x00154848
		private ICustomScreenLoadingTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenLoadingTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenLoadingTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenLoadingTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00156680 File Offset: 0x00154880
		public static ICustomScreenLoadingTypeBase Create([Nullable(2)] ICustomScreenLoadingTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x00156693 File Offset: 0x00154893
		public static ICustomScreenLoadingTypeBase CreateFromSetValue([Nullable(2)] ICustomScreenLoadingTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenLoadingTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x001566A6 File Offset: 0x001548A6
		public ICustomScreenLoadingTypeBase_SetValue ToSetValue()
		{
			return new ICustomScreenLoadingTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x001566B9 File Offset: 0x001548B9
		// (set) Token: 0x06009210 RID: 37392 RVA: 0x001566E4 File Offset: 0x001548E4
		public virtual ECustomScreenLoading Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B08 RID: 23304
		[Nullable(2)]
		protected ICustomScreenLoadingTypeBase FbInstance;

		// Token: 0x04005B09 RID: 23305
		[Nullable(2)]
		protected ICustomScreenLoadingTypeBase_SetValue PocoInterface;
	}
}
