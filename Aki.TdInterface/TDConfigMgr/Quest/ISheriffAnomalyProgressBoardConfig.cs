using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125C RID: 4700
	public class ISheriffAnomalyProgressBoardConfig
	{
		// Token: 0x060069EB RID: 27115 RVA: 0x000FDBB8 File Offset: 0x000FBDB8
		private ISheriffAnomalyProgressBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffAnomalyProgressBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffAnomalyProgressBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffAnomalyProgressBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x000FDBF0 File Offset: 0x000FBDF0
		public static ISheriffAnomalyProgressBoardConfig Create([Nullable(2)] ISheriffAnomalyProgressBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x000FDC03 File Offset: 0x000FBE03
		public static ISheriffAnomalyProgressBoardConfig CreateFromSetValue([Nullable(2)] ISheriffAnomalyProgressBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x000FDC16 File Offset: 0x000FBE16
		public ISheriffAnomalyProgressBoardConfig_SetValue ToSetValue()
		{
			return new ISheriffAnomalyProgressBoardConfig_SetValue
			{
				AnomalyId = this.AnomalyId
			};
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x000FDC29 File Offset: 0x000FBE29
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x000FDC54 File Offset: 0x000FBE54
		public virtual int AnomalyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnomalyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AnomalyId;
			}
			set
			{
				this.GetOrCreatePoco().AnomalyId = value;
			}
		}

		// Token: 0x04003F6E RID: 16238
		[Nullable(2)]
		protected ISheriffAnomalyProgressBoardConfig FbInstance;

		// Token: 0x04003F6F RID: 16239
		[Nullable(2)]
		protected ISheriffAnomalyProgressBoardConfig_SetValue PocoInterface;
	}
}
