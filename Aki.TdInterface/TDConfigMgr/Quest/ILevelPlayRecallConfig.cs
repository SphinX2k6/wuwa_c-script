using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF3 RID: 4083
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayRecallConfig : IRecallConfig
	{
		// Token: 0x06005AD8 RID: 23256 RVA: 0x000DC7D0 File Offset: 0x000DA9D0
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

		// Token: 0x06005AD9 RID: 23257 RVA: 0x000DC808 File Offset: 0x000DAA08
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

		// Token: 0x06005ADA RID: 23258 RVA: 0x000DC81B File Offset: 0x000DAA1B
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

		// Token: 0x06005ADB RID: 23259 RVA: 0x000DC82E File Offset: 0x000DAA2E
		public new ILevelPlayRecallConfig_SetValue ToSetValue()
		{
			return new ILevelPlayRecallConfig_SetValue
			{
				RecallId = this.RecallId,
				RecallEntityList = this.RecallEntityList
			};
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x000DC84D File Offset: 0x000DAA4D
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x000DC878 File Offset: 0x000DAA78
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

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x000DC886 File Offset: 0x000DAA86
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x000DC8AD File Offset: 0x000DAAAD
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

		// Token: 0x040036AC RID: 13996
		[Nullable(2)]
		protected new ILevelPlayRecallConfig FbInstance;

		// Token: 0x040036AD RID: 13997
		[Nullable(2)]
		protected new ILevelPlayRecallConfig_SetValue PocoInterface;
	}
}
