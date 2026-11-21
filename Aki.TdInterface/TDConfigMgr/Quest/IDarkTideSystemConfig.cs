using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200105C RID: 4188
	public class IDarkTideSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005C44 RID: 23620 RVA: 0x000E07F4 File Offset: 0x000DE9F4
		private IDarkTideSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x000E082C File Offset: 0x000DEA2C
		public static IDarkTideSystemConfig Create([Nullable(2)] IDarkTideSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x000E083F File Offset: 0x000DEA3F
		public static IDarkTideSystemConfig CreateFromSetValue([Nullable(2)] IDarkTideSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x000E0852 File Offset: 0x000DEA52
		public new IDarkTideSystemConfig_SetValue ToSetValue()
		{
			return new IDarkTideSystemConfig_SetValue
			{
				Type = this.Type,
				Module = this.Module
			};
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06005C48 RID: 23624 RVA: 0x000E0871 File Offset: 0x000DEA71
		// (set) Token: 0x06005C49 RID: 23625 RVA: 0x000E089C File Offset: 0x000DEA9C
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x000E08AC File Offset: 0x000DEAAC
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x000E090D File Offset: 0x000DEB0D
		public virtual IDarkTideBossEventModule Module
		{
			get
			{
				if (this._ModuleInited)
				{
					return this._ModuleCache;
				}
				this._ModuleInited = true;
				if (this.FbInstance != null)
				{
					this._ModuleCache = IDarkTideBossEventModule.Create(this.FbInstance.Module);
				}
				else
				{
					IDarkTideSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._ModuleCache = ((pocoInterface != null) ? pocoInterface.Module : null);
				}
				return this._ModuleCache;
			}
			set
			{
				this.GetOrCreatePoco().Module = value;
				this._ModuleInited = false;
			}
		}

		// Token: 0x04003798 RID: 14232
		[Nullable(2)]
		protected new IDarkTideSystemConfig FbInstance;

		// Token: 0x04003799 RID: 14233
		[Nullable(2)]
		protected new IDarkTideSystemConfig_SetValue PocoInterface;

		// Token: 0x0400379A RID: 14234
		private IDarkTideBossEventModule _ModuleCache;

		// Token: 0x0400379B RID: 14235
		private bool _ModuleInited;
	}
}
