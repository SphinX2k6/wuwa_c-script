using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C3 RID: 4547
	public class IQuestRecallData : IRecallData
	{
		// Token: 0x060065B1 RID: 26033 RVA: 0x000F4CAC File Offset: 0x000F2EAC
		private IQuestRecallData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuestRecallData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuestRecallData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuestRecallData_SetValue());
			}
			return result;
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x000F4CE4 File Offset: 0x000F2EE4
		public static IQuestRecallData Create([Nullable(2)] IQuestRecallData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestRecallData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x000F4CF7 File Offset: 0x000F2EF7
		public static IQuestRecallData CreateFromSetValue([Nullable(2)] IQuestRecallData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuestRecallData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x000F4D0A File Offset: 0x000F2F0A
		public new IQuestRecallData_SetValue ToSetValue()
		{
			return new IQuestRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				RecallConfig = this.RecallConfig
			};
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x000F4D35 File Offset: 0x000F2F35
		// (set) Token: 0x060065B6 RID: 26038 RVA: 0x000F4D60 File Offset: 0x000F2F60
		public override ERecallDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallDataType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x060065B7 RID: 26039 RVA: 0x000F4D6E File Offset: 0x000F2F6E
		// (set) Token: 0x060065B8 RID: 26040 RVA: 0x000F4D99 File Offset: 0x000F2F99
		public override int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x000F4DA8 File Offset: 0x000F2FA8
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x000F4E09 File Offset: 0x000F3009
		public virtual IQuestRecallConfig RecallConfig
		{
			get
			{
				if (this._RecallConfigInited)
				{
					return this._RecallConfigCache;
				}
				this._RecallConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RecallConfigCache = IQuestRecallConfig.Create(this.FbInstance.RecallConfig);
				}
				else
				{
					IQuestRecallData_SetValue pocoInterface = this.PocoInterface;
					this._RecallConfigCache = ((pocoInterface != null) ? pocoInterface.RecallConfig : null);
				}
				return this._RecallConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RecallConfig = value;
				this._RecallConfigInited = false;
			}
		}

		// Token: 0x04003D06 RID: 15622
		[Nullable(2)]
		protected new IQuestRecallData FbInstance;

		// Token: 0x04003D07 RID: 15623
		[Nullable(2)]
		protected new IQuestRecallData_SetValue PocoInterface;

		// Token: 0x04003D08 RID: 15624
		private IQuestRecallConfig _RecallConfigCache;

		// Token: 0x04003D09 RID: 15625
		private bool _RecallConfigInited;
	}
}
