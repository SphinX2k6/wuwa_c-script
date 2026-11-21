using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B53 RID: 6995
	public class IDungeonEventType
	{
		// Token: 0x0600949B RID: 38043 RVA: 0x0015AEF0 File Offset: 0x001590F0
		private IDungeonEventType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDungeonEventType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDungeonEventType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDungeonEventType_SetValue());
			}
			return result;
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x0015AF28 File Offset: 0x00159128
		public static IDungeonEventType Create([Nullable(2)] IDungeonEventType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonEventType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x0015AF3B File Offset: 0x0015913B
		public static IDungeonEventType CreateFromSetValue([Nullable(2)] IDungeonEventType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDungeonEventType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x0015AF4E File Offset: 0x0015914E
		public IDungeonEventType_SetValue ToSetValue()
		{
			return new IDungeonEventType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x0015AF61 File Offset: 0x00159161
		// (set) Token: 0x060094A0 RID: 38048 RVA: 0x0015AF8C File Offset: 0x0015918C
		public virtual EDungeonEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDungeonEventType.RecordTimeStamp;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C28 RID: 23592
		[Nullable(2)]
		protected IDungeonEventType FbInstance;

		// Token: 0x04005C29 RID: 23593
		[Nullable(2)]
		protected IDungeonEventType_SetValue PocoInterface;
	}
}
