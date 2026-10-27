using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED5 RID: 7893
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenCustomInitData : ISubScreenInitData
	{
		// Token: 0x0600A8E4 RID: 43236 RVA: 0x0017D1A8 File Offset: 0x0017B3A8
		private ISubScreenCustomInitData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreenCustomInitData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreenCustomInitData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreenCustomInitData_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x0017D1E0 File Offset: 0x0017B3E0
		public static ISubScreenCustomInitData Create([Nullable(2)] ISubScreenCustomInitData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenCustomInitData
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x0017D1F3 File Offset: 0x0017B3F3
		public static ISubScreenCustomInitData CreateFromSetValue([Nullable(2)] ISubScreenCustomInitData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreenCustomInitData
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x0017D206 File Offset: 0x0017B406
		public new ISubScreenCustomInitData_SetValue ToSetValue()
		{
			return new ISubScreenCustomInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey,
				InitConfig = this.InitConfig
			};
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x0017D231 File Offset: 0x0017B431
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x0017D25C File Offset: 0x0017B45C
		public override ESubScreenInitDataType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubScreenInitDataType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x0017D26A File Offset: 0x0017B46A
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x0017D295 File Offset: 0x0017B495
		public override string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x0017D2A4 File Offset: 0x0017B4A4
		// (set) Token: 0x0600A8ED RID: 43245 RVA: 0x0017D305 File Offset: 0x0017B505
		public virtual ISubScreenConfig InitConfig
		{
			get
			{
				if (this._InitConfigInited)
				{
					return this._InitConfigCache;
				}
				this._InitConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InitConfigCache = ISubScreenConfig.Create(this.FbInstance.InitConfig);
				}
				else
				{
					ISubScreenCustomInitData_SetValue pocoInterface = this.PocoInterface;
					this._InitConfigCache = ((pocoInterface != null) ? pocoInterface.InitConfig : null);
				}
				return this._InitConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InitConfig = value;
				this._InitConfigInited = false;
			}
		}

		// Token: 0x0400648F RID: 25743
		[Nullable(2)]
		protected new ISubScreenCustomInitData FbInstance;

		// Token: 0x04006490 RID: 25744
		[Nullable(2)]
		protected new ISubScreenCustomInitData_SetValue PocoInterface;

		// Token: 0x04006491 RID: 25745
		private ISubScreenConfig _InitConfigCache;

		// Token: 0x04006492 RID: 25746
		private bool _InitConfigInited;
	}
}
