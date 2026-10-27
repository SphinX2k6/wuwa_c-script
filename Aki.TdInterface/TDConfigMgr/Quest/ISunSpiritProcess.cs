using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001150 RID: 4432
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritProcess
	{
		// Token: 0x060064B8 RID: 25784 RVA: 0x000F20A8 File Offset: 0x000F02A8
		private ISunSpiritProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritProcess_SetValue());
			}
			return result;
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x000F20E0 File Offset: 0x000F02E0
		public static ISunSpiritProcess Create([Nullable(2)] ISunSpiritProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x000F20F3 File Offset: 0x000F02F3
		public static ISunSpiritProcess CreateFromSetValue([Nullable(2)] ISunSpiritProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x000F2106 File Offset: 0x000F0306
		public ISunSpiritProcess_SetValue ToSetValue()
		{
			return new ISunSpiritProcess_SetValue
			{
				LauncherId = this.LauncherId,
				IsRecycle = this.IsRecycle
			};
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x060064BC RID: 25788 RVA: 0x000F2125 File Offset: 0x000F0325
		// (set) Token: 0x060064BD RID: 25789 RVA: 0x000F2150 File Offset: 0x000F0350
		public virtual int LauncherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LauncherId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LauncherId;
			}
			set
			{
				this.GetOrCreatePoco().LauncherId = value;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x060064BE RID: 25790 RVA: 0x000F2160 File Offset: 0x000F0360
		// (set) Token: 0x060064BF RID: 25791 RVA: 0x000F219A File Offset: 0x000F039A
		public virtual bool? IsRecycle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRecycle;
				}
				ISunSpiritProcess_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRecycle;
			}
			set
			{
				this.GetOrCreatePoco().IsRecycle = value;
			}
		}

		// Token: 0x04003C7E RID: 15486
		[Nullable(2)]
		protected ISunSpiritProcess FbInstance;

		// Token: 0x04003C7F RID: 15487
		[Nullable(2)]
		protected ISunSpiritProcess_SetValue PocoInterface;
	}
}
