using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001095 RID: 4245
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestRecallData : IRecallData
	{
		// Token: 0x06005FB8 RID: 24504 RVA: 0x000E7B8C File Offset: 0x000E5D8C
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

		// Token: 0x06005FB9 RID: 24505 RVA: 0x000E7BC4 File Offset: 0x000E5DC4
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

		// Token: 0x06005FBA RID: 24506 RVA: 0x000E7BD7 File Offset: 0x000E5DD7
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

		// Token: 0x06005FBB RID: 24507 RVA: 0x000E7BEA File Offset: 0x000E5DEA
		public new IQuestRecallData_SetValue ToSetValue()
		{
			return new IQuestRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				RecallConfig = this.RecallConfig
			};
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x000E7C15 File Offset: 0x000E5E15
		// (set) Token: 0x06005FBD RID: 24509 RVA: 0x000E7C40 File Offset: 0x000E5E40
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

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x000E7C4E File Offset: 0x000E5E4E
		// (set) Token: 0x06005FBF RID: 24511 RVA: 0x000E7C79 File Offset: 0x000E5E79
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

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x000E7C88 File Offset: 0x000E5E88
		// (set) Token: 0x06005FC1 RID: 24513 RVA: 0x000E7CE9 File Offset: 0x000E5EE9
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

		// Token: 0x040039B9 RID: 14777
		[Nullable(2)]
		protected new IQuestRecallData FbInstance;

		// Token: 0x040039BA RID: 14778
		[Nullable(2)]
		protected new IQuestRecallData_SetValue PocoInterface;

		// Token: 0x040039BB RID: 14779
		private IQuestRecallConfig _RecallConfigCache;

		// Token: 0x040039BC RID: 14780
		private bool _RecallConfigInited;
	}
}
