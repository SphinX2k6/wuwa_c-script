using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C34 RID: 7220
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IMoveOperationTypeConverter))]
	public class IMoveOperationType
	{
		// Token: 0x06009AE7 RID: 39655 RVA: 0x00164100 File Offset: 0x00162300
		private IMoveOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00164138 File Offset: 0x00162338
		public static IMoveOperationType Create([Nullable(2)] IMoveOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AE9 RID: 39657 RVA: 0x0016414B File Offset: 0x0016234B
		public static IMoveOperationType CreateFromSetValue([Nullable(2)] IMoveOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x0016415E File Offset: 0x0016235E
		public IMoveOperationType_SetValue ToSetValue()
		{
			return new IMoveOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x06009AEB RID: 39659 RVA: 0x00164171 File Offset: 0x00162371
		// (set) Token: 0x06009AEC RID: 39660 RVA: 0x0016419C File Offset: 0x0016239C
		public virtual EMoveOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E29 RID: 24105
		[Nullable(2)]
		protected IMoveOperationType FbInstance;

		// Token: 0x04005E2A RID: 24106
		[Nullable(2)]
		protected IMoveOperationType_SetValue PocoInterface;
	}
}
