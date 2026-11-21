using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002047 RID: 8263
	public class ISetBattleTagConfig
	{
		// Token: 0x0600AF61 RID: 44897 RVA: 0x0018B19C File Offset: 0x0018939C
		private ISetBattleTagConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTagConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTagConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTagConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x0018B1D4 File Offset: 0x001893D4
		public static ISetBattleTagConfig Create([Nullable(2)] ISetBattleTagConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x0018B1E7 File Offset: 0x001893E7
		public static ISetBattleTagConfig CreateFromSetValue([Nullable(2)] ISetBattleTagConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x0018B1FA File Offset: 0x001893FA
		public ISetBattleTagConfig_SetValue ToSetValue()
		{
			return new ISetBattleTagConfig_SetValue
			{
				EntityId = this.EntityId,
				TagConfigId = this.TagConfigId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600AF65 RID: 44901 RVA: 0x0018B225 File Offset: 0x00189425
		// (set) Token: 0x0600AF66 RID: 44902 RVA: 0x0018B250 File Offset: 0x00189450
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x0018B25E File Offset: 0x0018945E
		// (set) Token: 0x0600AF68 RID: 44904 RVA: 0x0018B289 File Offset: 0x00189489
		public virtual int TagConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TagConfigId;
			}
			set
			{
				this.GetOrCreatePoco().TagConfigId = value;
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600AF69 RID: 44905 RVA: 0x0018B298 File Offset: 0x00189498
		// (set) Token: 0x0600AF6A RID: 44906 RVA: 0x0018B2D2 File Offset: 0x001894D2
		public virtual int? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ISetBattleTagConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04006871 RID: 26737
		[Nullable(2)]
		protected ISetBattleTagConfig FbInstance;

		// Token: 0x04006872 RID: 26738
		[Nullable(2)]
		protected ISetBattleTagConfig_SetValue PocoInterface;
	}
}
