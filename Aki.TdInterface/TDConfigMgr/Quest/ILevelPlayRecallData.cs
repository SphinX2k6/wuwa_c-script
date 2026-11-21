using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001121 RID: 4385
	public class ILevelPlayRecallData : IRecallData
	{
		// Token: 0x060060C2 RID: 24770 RVA: 0x000E950C File Offset: 0x000E770C
		private ILevelPlayRecallData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelPlayRecallData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelPlayRecallData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelPlayRecallData_SetValue());
			}
			return result;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x000E9544 File Offset: 0x000E7744
		public static ILevelPlayRecallData Create([Nullable(2)] ILevelPlayRecallData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayRecallData
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x000E9557 File Offset: 0x000E7757
		public static ILevelPlayRecallData CreateFromSetValue([Nullable(2)] ILevelPlayRecallData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelPlayRecallData
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x000E956A File Offset: 0x000E776A
		public new ILevelPlayRecallData_SetValue ToSetValue()
		{
			return new ILevelPlayRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				RecallConfig = this.RecallConfig
			};
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x060060C6 RID: 24774 RVA: 0x000E9595 File Offset: 0x000E7795
		// (set) Token: 0x060060C7 RID: 24775 RVA: 0x000E95C0 File Offset: 0x000E77C0
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

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x060060C8 RID: 24776 RVA: 0x000E95CE File Offset: 0x000E77CE
		// (set) Token: 0x060060C9 RID: 24777 RVA: 0x000E95F9 File Offset: 0x000E77F9
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

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x060060CA RID: 24778 RVA: 0x000E9608 File Offset: 0x000E7808
		// (set) Token: 0x060060CB RID: 24779 RVA: 0x000E9669 File Offset: 0x000E7869
		public virtual ILevelPlayRecallConfig RecallConfig
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
					this._RecallConfigCache = ILevelPlayRecallConfig.Create(this.FbInstance.RecallConfig);
				}
				else
				{
					ILevelPlayRecallData_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040039E8 RID: 14824
		[Nullable(2)]
		protected new ILevelPlayRecallData FbInstance;

		// Token: 0x040039E9 RID: 14825
		[Nullable(2)]
		protected new ILevelPlayRecallData_SetValue PocoInterface;

		// Token: 0x040039EA RID: 14826
		private ILevelPlayRecallConfig _RecallConfigCache;

		// Token: 0x040039EB RID: 14827
		private bool _RecallConfigInited;
	}
}
