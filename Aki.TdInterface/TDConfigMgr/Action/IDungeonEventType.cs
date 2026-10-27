using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C6 RID: 6598
	[NullableContext(1)]
	[Nullable(0)]
	public class IDungeonEventType
	{
		// Token: 0x06008D59 RID: 36185 RVA: 0x0014B3E4 File Offset: 0x001495E4
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

		// Token: 0x06008D5A RID: 36186 RVA: 0x0014B41C File Offset: 0x0014961C
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

		// Token: 0x06008D5B RID: 36187 RVA: 0x0014B42F File Offset: 0x0014962F
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

		// Token: 0x06008D5C RID: 36188 RVA: 0x0014B442 File Offset: 0x00149642
		public IDungeonEventType_SetValue ToSetValue()
		{
			return new IDungeonEventType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x0014B455 File Offset: 0x00149655
		// (set) Token: 0x06008D5E RID: 36190 RVA: 0x0014B480 File Offset: 0x00149680
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

		// Token: 0x040057D3 RID: 22483
		[Nullable(2)]
		protected IDungeonEventType FbInstance;

		// Token: 0x040057D4 RID: 22484
		[Nullable(2)]
		protected IDungeonEventType_SetValue PocoInterface;
	}
}
