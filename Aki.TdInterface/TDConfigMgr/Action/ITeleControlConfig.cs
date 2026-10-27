using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F92 RID: 8082
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleControlConfig : IExploreConfig
	{
		// Token: 0x0600B1BE RID: 45502 RVA: 0x0019E930 File Offset: 0x0019CB30
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

		// Token: 0x0600B1BF RID: 45503 RVA: 0x0019E968 File Offset: 0x0019CB68
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

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x0019E97B File Offset: 0x0019CB7B
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

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x0019E98E File Offset: 0x0019CB8E
		public new ITeleControlConfig_SetValue ToSetValue()
		{
			return new ITeleControlConfig_SetValue
			{
				Type = this.Type,
				TeleControlType = this.TeleControlType
			};
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x0019E9AD File Offset: 0x0019CBAD
		// (set) Token: 0x0600B1C3 RID: 45507 RVA: 0x0019E9D8 File Offset: 0x0019CBD8
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

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x0019E9E6 File Offset: 0x0019CBE6
		// (set) Token: 0x0600B1C5 RID: 45509 RVA: 0x0019EA11 File Offset: 0x0019CC11
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

		// Token: 0x04006B6D RID: 27501
		[Nullable(2)]
		protected new ITeleControlConfig FbInstance;

		// Token: 0x04006B6E RID: 27502
		[Nullable(2)]
		protected new ITeleControlConfig_SetValue PocoInterface;
	}
}
