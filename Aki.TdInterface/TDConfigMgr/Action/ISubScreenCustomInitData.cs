using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200210E RID: 8462
	public class ISubScreenCustomInitData : ISubScreenInitData
	{
		// Token: 0x0600B3B6 RID: 46006 RVA: 0x001931A0 File Offset: 0x001913A0
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

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x001931D8 File Offset: 0x001913D8
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

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001931EB File Offset: 0x001913EB
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

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x001931FE File Offset: 0x001913FE
		public new ISubScreenCustomInitData_SetValue ToSetValue()
		{
			return new ISubScreenCustomInitData_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey,
				InitConfig = this.InitConfig
			};
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600B3BA RID: 46010 RVA: 0x00193229 File Offset: 0x00191429
		// (set) Token: 0x0600B3BB RID: 46011 RVA: 0x00193254 File Offset: 0x00191454
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x00193262 File Offset: 0x00191462
		// (set) Token: 0x0600B3BD RID: 46013 RVA: 0x0019328D File Offset: 0x0019148D
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600B3BE RID: 46014 RVA: 0x0019329C File Offset: 0x0019149C
		// (set) Token: 0x0600B3BF RID: 46015 RVA: 0x001932FD File Offset: 0x001914FD
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

		// Token: 0x04006A7E RID: 27262
		[Nullable(2)]
		protected new ISubScreenCustomInitData FbInstance;

		// Token: 0x04006A7F RID: 27263
		[Nullable(2)]
		protected new ISubScreenCustomInitData_SetValue PocoInterface;

		// Token: 0x04006A80 RID: 27264
		private ISubScreenConfig _InitConfigCache;

		// Token: 0x04006A81 RID: 27265
		private bool _InitConfigInited;
	}
}
