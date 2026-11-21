using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D5 RID: 8661
	public class ITeleControlConfig : IExploreConfig
	{
		// Token: 0x0600BCC2 RID: 48322 RVA: 0x001B4CE0 File Offset: 0x001B2EE0
		private ITeleControlConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleControlConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleControlConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleControlConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x001B4D18 File Offset: 0x001B2F18
		public static ITeleControlConfig Create([Nullable(2)] ITeleControlConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x001B4D2B File Offset: 0x001B2F2B
		public static ITeleControlConfig CreateFromSetValue([Nullable(2)] ITeleControlConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleControlConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x001B4D3E File Offset: 0x001B2F3E
		public new ITeleControlConfig_SetValue ToSetValue()
		{
			return new ITeleControlConfig_SetValue
			{
				Type = this.Type,
				TeleControlType = this.TeleControlType
			};
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x001B4D5D File Offset: 0x001B2F5D
		// (set) Token: 0x0600BCC7 RID: 48327 RVA: 0x001B4D88 File Offset: 0x001B2F88
		public override EExploreStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreStateType.TeleControl;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x001B4D96 File Offset: 0x001B2F96
		// (set) Token: 0x0600BCC9 RID: 48329 RVA: 0x001B4DC1 File Offset: 0x001B2FC1
		public virtual ETeleControlType TeleControlType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleControlType;
				}
				if (this.PocoInterface == null)
				{
					return ETeleControlType.BigWorld;
				}
				return this.PocoInterface.TeleControlType;
			}
			set
			{
				this.GetOrCreatePoco().TeleControlType = value;
			}
		}

		// Token: 0x04007168 RID: 29032
		[Nullable(2)]
		protected new ITeleControlConfig FbInstance;

		// Token: 0x04007169 RID: 29033
		[Nullable(2)]
		protected new ITeleControlConfig_SetValue PocoInterface;
	}
}
