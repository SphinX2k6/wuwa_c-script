using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B49 RID: 6985
	public class IDollGrab : IUiGame
	{
		// Token: 0x06009467 RID: 37991 RVA: 0x0015A99C File Offset: 0x00158B9C
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

		// Token: 0x06009468 RID: 37992 RVA: 0x0015A9D4 File Offset: 0x00158BD4
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

		// Token: 0x06009469 RID: 37993 RVA: 0x0015A9E7 File Offset: 0x00158BE7
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

		// Token: 0x0600946A RID: 37994 RVA: 0x0015A9FA File Offset: 0x00158BFA
		public new IDollGrab_SetValue ToSetValue()
		{
			return new IDollGrab_SetValue
			{
				Type = this.Type,
				TargetDollGrabMachineId = this.TargetDollGrabMachineId
			};
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0600946B RID: 37995 RVA: 0x0015AA19 File Offset: 0x00158C19
		// (set) Token: 0x0600946C RID: 37996 RVA: 0x0015AA44 File Offset: 0x00158C44
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

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0600946D RID: 37997 RVA: 0x0015AA52 File Offset: 0x00158C52
		// (set) Token: 0x0600946E RID: 37998 RVA: 0x0015AA7D File Offset: 0x00158C7D
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

		// Token: 0x04005C13 RID: 23571
		[Nullable(2)]
		protected new IDollGrab FbInstance;

		// Token: 0x04005C14 RID: 23572
		[Nullable(2)]
		protected new IDollGrab_SetValue PocoInterface;
	}
}
