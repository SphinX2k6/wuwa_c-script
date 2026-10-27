using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF4 RID: 8180
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefensePlayerOperationType
	{
		// Token: 0x0600B3EA RID: 46058 RVA: 0x001A2984 File Offset: 0x001A0B84
		private ITrapDefensePlayerOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x001A29BC File Offset: 0x001A0BBC
		public static ITrapDefensePlayerOperationType Create([Nullable(2)] ITrapDefensePlayerOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x001A29CF File Offset: 0x001A0BCF
		public static ITrapDefensePlayerOperationType CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x001A29E2 File Offset: 0x001A0BE2
		public ITrapDefensePlayerOperationType_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600B3EE RID: 46062 RVA: 0x001A29F5 File Offset: 0x001A0BF5
		// (set) Token: 0x0600B3EF RID: 46063 RVA: 0x001A2A20 File Offset: 0x001A0C20
		public virtual ETrapDefensePlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C7C RID: 27772
		[Nullable(2)]
		protected ITrapDefensePlayerOperationType FbInstance;

		// Token: 0x04006C7D RID: 27773
		[Nullable(2)]
		protected ITrapDefensePlayerOperationType_SetValue PocoInterface;
	}
}
