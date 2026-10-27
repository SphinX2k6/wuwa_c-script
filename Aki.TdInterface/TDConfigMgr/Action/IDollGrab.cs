using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019BC RID: 6588
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrab : IUiGame
	{
		// Token: 0x06008D25 RID: 36133 RVA: 0x0014AE90 File Offset: 0x00149090
		private IDollGrab_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrab 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrab_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrab_SetValue());
			}
			return result;
		}

		// Token: 0x06008D26 RID: 36134 RVA: 0x0014AEC8 File Offset: 0x001490C8
		public static IDollGrab Create([Nullable(2)] IDollGrab instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrab
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D27 RID: 36135 RVA: 0x0014AEDB File Offset: 0x001490DB
		public static IDollGrab CreateFromSetValue([Nullable(2)] IDollGrab_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrab
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D28 RID: 36136 RVA: 0x0014AEEE File Offset: 0x001490EE
		public new IDollGrab_SetValue ToSetValue()
		{
			return new IDollGrab_SetValue
			{
				Type = this.Type,
				TargetDollGrabMachineId = this.TargetDollGrabMachineId
			};
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x06008D29 RID: 36137 RVA: 0x0014AF0D File Offset: 0x0014910D
		// (set) Token: 0x06008D2A RID: 36138 RVA: 0x0014AF38 File Offset: 0x00149138
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x0014AF46 File Offset: 0x00149146
		// (set) Token: 0x06008D2C RID: 36140 RVA: 0x0014AF71 File Offset: 0x00149171
		public virtual int TargetDollGrabMachineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetDollGrabMachineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetDollGrabMachineId;
			}
			set
			{
				this.GetOrCreatePoco().TargetDollGrabMachineId = value;
			}
		}

		// Token: 0x040057BE RID: 22462
		[Nullable(2)]
		protected new IDollGrab FbInstance;

		// Token: 0x040057BF RID: 22463
		[Nullable(2)]
		protected new IDollGrab_SetValue PocoInterface;
	}
}
