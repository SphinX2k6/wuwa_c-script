using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E0 RID: 2016
	public class ISunSpiritGearPerformToGearRelativePos : ISunSpiritGearPerformConfig
	{
		// Token: 0x06002B29 RID: 11049 RVA: 0x00071454 File Offset: 0x0006F654
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

		// Token: 0x06002B2A RID: 11050 RVA: 0x0007148C File Offset: 0x0006F68C
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

		// Token: 0x06002B2B RID: 11051 RVA: 0x0007149F File Offset: 0x0006F69F
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

		// Token: 0x06002B2C RID: 11052 RVA: 0x000714B2 File Offset: 0x0006F6B2
		public new ISunSpiritGearPerformToGearRelativePos_SetValue ToSetValue()
		{
			return new ISunSpiritGearPerformToGearRelativePos_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000714C5 File Offset: 0x0006F6C5
		// (set) Token: 0x06002B2E RID: 11054 RVA: 0x000714F0 File Offset: 0x0006F6F0
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

		// Token: 0x04001CF7 RID: 7415
		[Nullable(2)]
		protected new ISunSpiritGearPerformToGearRelativePos FbInstance;

		// Token: 0x04001CF8 RID: 7416
		[Nullable(2)]
		protected new ISunSpiritGearPerformToGearRelativePos_SetValue PocoInterface;
	}
}
