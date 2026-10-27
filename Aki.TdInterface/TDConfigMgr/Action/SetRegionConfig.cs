using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D4 RID: 8660
	[NullableContext(1)]
	[Nullable(0)]
	public class SetRegionConfig : ActionParams
	{
		// Token: 0x0600BE51 RID: 48721 RVA: 0x001B63E4 File Offset: 0x001B45E4
		private SetRegionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetRegionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetRegionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetRegionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE52 RID: 48722 RVA: 0x001B641C File Offset: 0x001B461C
		public static SetRegionConfig Create([Nullable(2)] SetRegionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x001B642F File Offset: 0x001B462F
		public static SetRegionConfig CreateFromSetValue([Nullable(2)] SetRegionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetRegionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x001B6442 File Offset: 0x001B4642
		public SetRegionConfig_SetValue ToSetValue()
		{
			return new SetRegionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x001B6455 File Offset: 0x001B4655
		// (set) Token: 0x0600BE56 RID: 48726 RVA: 0x001B6480 File Offset: 0x001B4680
		public virtual ERegionConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERegionConfigType.Mpc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007198 RID: 29080
		[Nullable(2)]
		protected new SetRegionConfig FbInstance;

		// Token: 0x04007199 RID: 29081
		[Nullable(2)]
		protected SetRegionConfig_SetValue PocoInterface;
	}
}
