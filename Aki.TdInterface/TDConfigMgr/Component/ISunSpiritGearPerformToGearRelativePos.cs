using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200073F RID: 1855
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritGearPerformToGearRelativePos : ISunSpiritGearPerformConfig
	{
		// Token: 0x06002805 RID: 10245 RVA: 0x0006A2AC File Offset: 0x000684AC
		private ISunSpiritGearPerformToGearRelativePos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritGearPerformToGearRelativePos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritGearPerformToGearRelativePos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritGearPerformToGearRelativePos_SetValue());
			}
			return result;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x0006A2E4 File Offset: 0x000684E4
		public static ISunSpiritGearPerformToGearRelativePos Create([Nullable(2)] ISunSpiritGearPerformToGearRelativePos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformToGearRelativePos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0006A2F7 File Offset: 0x000684F7
		public static ISunSpiritGearPerformToGearRelativePos CreateFromSetValue([Nullable(2)] ISunSpiritGearPerformToGearRelativePos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritGearPerformToGearRelativePos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0006A30A File Offset: 0x0006850A
		public new ISunSpiritGearPerformToGearRelativePos_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformToGearRelativePos_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0006A31D File Offset: 0x0006851D
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x0006A348 File Offset: 0x00068548
		public override ESunSpiritGearPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESunSpiritGearPerformType.ToGearRelativePos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001AF2 RID: 6898
		[Nullable(2)]
		protected new ISunSpiritGearPerformToGearRelativePos FbInstance;

		// Token: 0x04001AF3 RID: 6899
		[Nullable(2)]
		protected new ISunSpiritGearPerformToGearRelativePos_SetValue PocoInterface;
	}
}
