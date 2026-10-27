using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BDA RID: 7130
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntWater : IMechStuntConfigType
	{
		// Token: 0x060098B9 RID: 39097 RVA: 0x0015FD94 File Offset: 0x0015DF94
		private IMechStuntWater_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntWater 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntWater_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntWater_SetValue());
			}
			return result;
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x0015FDCC File Offset: 0x0015DFCC
		public static IMechStuntWater Create([Nullable(2)] IMechStuntWater instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x0015FDDF File Offset: 0x0015DFDF
		public static IMechStuntWater CreateFromSetValue([Nullable(2)] IMechStuntWater_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntWater
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x0015FDF2 File Offset: 0x0015DFF2
		public new IMechStuntWater_SetValue ToSetValue()
		{
			return new IMechStuntWater_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x0015FE05 File Offset: 0x0015E005
		// (set) Token: 0x060098BE RID: 39102 RVA: 0x0015FE30 File Offset: 0x0015E030
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D19 RID: 23833
		[Nullable(2)]
		protected new IMechStuntWater FbInstance;

		// Token: 0x04005D1A RID: 23834
		[Nullable(2)]
		protected new IMechStuntWater_SetValue PocoInterface;
	}
}
