using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F63 RID: 3939
	[NullableContext(1)]
	[Nullable(0)]
	public class IEventTypeConfig
	{
		// Token: 0x0600578A RID: 22410 RVA: 0x000D5F98 File Offset: 0x000D4198
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

		// Token: 0x0600578B RID: 22411 RVA: 0x000D5FD0 File Offset: 0x000D41D0
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

		// Token: 0x0600578C RID: 22412 RVA: 0x000D5FE3 File Offset: 0x000D41E3
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

		// Token: 0x0600578D RID: 22413 RVA: 0x000D5FF6 File Offset: 0x000D41F6
		public IEventTypeConfig_SetValue ToSetValue()
		{
			return new IEventTypeConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x000D6009 File Offset: 0x000D4209
		// (set) Token: 0x0600578F RID: 22415 RVA: 0x000D6034 File Offset: 0x000D4234
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

		// Token: 0x040034ED RID: 13549
		[Nullable(2)]
		protected IEventTypeConfig FbInstance;

		// Token: 0x040034EE RID: 13550
		[Nullable(2)]
		protected IEventTypeConfig_SetValue PocoInterface;
	}
}
