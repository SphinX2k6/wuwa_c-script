using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200111F RID: 4383
	public class ILevelPlayRecallConfig : IRecallConfig
	{
		// Token: 0x060060B8 RID: 24760 RVA: 0x000E9410 File Offset: 0x000E7610
		private ILevelPlayRecallConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayRecallConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayRecallConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayRecallConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x000E9448 File Offset: 0x000E7648
		public static ILevelPlayRecallConfig Create([Nullable(2)] ILevelPlayRecallConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayRecallConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x000E945B File Offset: 0x000E765B
		public static ILevelPlayRecallConfig CreateFromSetValue([Nullable(2)] ILevelPlayRecallConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayRecallConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x000E946E File Offset: 0x000E766E
		public new ILevelPlayRecallConfig_SetValue ToSetValue()
		{
			return new ILevelPlayRecallConfig_SetValue
			{
				RecallId = this.RecallId,
				RecallEntityList = this.RecallEntityList
			};
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x060060BC RID: 24764 RVA: 0x000E948D File Offset: 0x000E768D
		// (set) Token: 0x060060BD RID: 24765 RVA: 0x000E94B8 File Offset: 0x000E76B8
		public override int RecallId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RecallId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RecallId;
			}
			set
			{
				this.GetOrCreatePoco().RecallId = value;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x060060BE RID: 24766 RVA: 0x000E94C6 File Offset: 0x000E76C6
		// (set) Token: 0x060060BF RID: 24767 RVA: 0x000E94ED File Offset: 0x000E76ED
		public virtual List<int> RecallEntityList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RecallEntityList;
				}
				ILevelPlayRecallConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RecallEntityList;
			}
			set
			{
				this.GetOrCreatePoco().RecallEntityList = value;
			}
		}

		// Token: 0x040039E4 RID: 14820
		[Nullable(2)]
		protected new ILevelPlayRecallConfig FbInstance;

		// Token: 0x040039E5 RID: 14821
		[Nullable(2)]
		protected new ILevelPlayRecallConfig_SetValue PocoInterface;
	}
}
