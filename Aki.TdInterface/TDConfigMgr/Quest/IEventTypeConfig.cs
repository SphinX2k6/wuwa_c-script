using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108D RID: 4237
	public class IEventTypeConfig
	{
		// Token: 0x06005D5E RID: 23902 RVA: 0x000E2A04 File Offset: 0x000E0C04
		private IEventTypeConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEventTypeConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEventTypeConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEventTypeConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x000E2A3C File Offset: 0x000E0C3C
		public static IEventTypeConfig Create([Nullable(2)] IEventTypeConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEventTypeConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x000E2A4F File Offset: 0x000E0C4F
		public static IEventTypeConfig CreateFromSetValue([Nullable(2)] IEventTypeConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEventTypeConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x000E2A62 File Offset: 0x000E0C62
		public IEventTypeConfig_SetValue ToSetValue()
		{
			return new IEventTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x000E2A75 File Offset: 0x000E0C75
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x000E2AA0 File Offset: 0x000E0CA0
		public virtual ECommonEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonEventType.VarValueChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400381E RID: 14366
		[Nullable(2)]
		protected IEventTypeConfig FbInstance;

		// Token: 0x0400381F RID: 14367
		[Nullable(2)]
		protected IEventTypeConfig_SetValue PocoInterface;
	}
}
