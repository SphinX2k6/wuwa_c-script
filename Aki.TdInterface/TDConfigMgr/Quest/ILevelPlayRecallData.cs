using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF5 RID: 4085
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayRecallData : IRecallData
	{
		// Token: 0x06005AE2 RID: 23266 RVA: 0x000DC8CC File Offset: 0x000DAACC
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

		// Token: 0x06005AE3 RID: 23267 RVA: 0x000DC904 File Offset: 0x000DAB04
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

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000DC917 File Offset: 0x000DAB17
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

		// Token: 0x06005AE5 RID: 23269 RVA: 0x000DC92A File Offset: 0x000DAB2A
		public new ILevelPlayRecallData_SetValue ToSetValue()
		{
			return new ILevelPlayRecallData_SetValue
			{
				Type = this.Type,
				Id = this.Id,
				RecallConfig = this.RecallConfig
			};
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x000DC955 File Offset: 0x000DAB55
		// (set) Token: 0x06005AE7 RID: 23271 RVA: 0x000DC980 File Offset: 0x000DAB80
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

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06005AE8 RID: 23272 RVA: 0x000DC98E File Offset: 0x000DAB8E
		// (set) Token: 0x06005AE9 RID: 23273 RVA: 0x000DC9B9 File Offset: 0x000DABB9
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

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x000DC9C8 File Offset: 0x000DABC8
		// (set) Token: 0x06005AEB RID: 23275 RVA: 0x000DCA29 File Offset: 0x000DAC29
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

		// Token: 0x040036B0 RID: 14000
		[Nullable(2)]
		protected new ILevelPlayRecallData FbInstance;

		// Token: 0x040036B1 RID: 14001
		[Nullable(2)]
		protected new ILevelPlayRecallData_SetValue PocoInterface;

		// Token: 0x040036B2 RID: 14002
		private ILevelPlayRecallConfig _RecallConfigCache;

		// Token: 0x040036B3 RID: 14003
		private bool _RecallConfigInited;
	}
}
