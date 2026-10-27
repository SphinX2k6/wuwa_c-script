using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000756 RID: 1878
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleCtrlTriggerConfig
	{
		// Token: 0x06002889 RID: 10377 RVA: 0x0006B4A8 File Offset: 0x000696A8
		private ITeleCtrlTriggerConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleCtrlTriggerConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleCtrlTriggerConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleCtrlTriggerConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0006B4E0 File Offset: 0x000696E0
		public static ITeleCtrlTriggerConfig Create([Nullable(2)] ITeleCtrlTriggerConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleCtrlTriggerConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0006B4F3 File Offset: 0x000696F3
		public static ITeleCtrlTriggerConfig CreateFromSetValue([Nullable(2)] ITeleCtrlTriggerConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleCtrlTriggerConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0006B506 File Offset: 0x00069706
		public ITeleCtrlTriggerConfig_SetValue ToSetValue()
		{
			return new ITeleCtrlTriggerConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x0006B519 File Offset: 0x00069719
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x0006B544 File Offset: 0x00069744
		public virtual ETeleCtrlTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleCtrlTriggerType.MechascoutJavelin;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001B3F RID: 6975
		[Nullable(2)]
		protected ITeleCtrlTriggerConfig FbInstance;

		// Token: 0x04001B40 RID: 6976
		[Nullable(2)]
		protected ITeleCtrlTriggerConfig_SetValue PocoInterface;
	}
}
