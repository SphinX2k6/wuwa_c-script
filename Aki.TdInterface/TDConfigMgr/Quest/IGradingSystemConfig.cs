using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010CF RID: 4303
	public class IGradingSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005F10 RID: 24336 RVA: 0x000E6264 File Offset: 0x000E4464
		private IGradingSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGradingSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGradingSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGradingSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x000E629C File Offset: 0x000E449C
		public static IGradingSystemConfig Create([Nullable(2)] IGradingSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGradingSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x000E62AF File Offset: 0x000E44AF
		public static IGradingSystemConfig CreateFromSetValue([Nullable(2)] IGradingSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGradingSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x000E62C2 File Offset: 0x000E44C2
		public new IGradingSystemConfig_SetValue ToSetValue()
		{
			return new IGradingSystemConfig_SetValue
			{
				Type = this.Type,
				GradingSystemId = this.GradingSystemId,
				Vars = this.Vars
			};
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x000E62ED File Offset: 0x000E44ED
		// (set) Token: 0x06005F15 RID: 24341 RVA: 0x000E6318 File Offset: 0x000E4518
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x000E6326 File Offset: 0x000E4526
		// (set) Token: 0x06005F17 RID: 24343 RVA: 0x000E6351 File Offset: 0x000E4551
		public virtual int GradingSystemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GradingSystemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GradingSystemId;
			}
			set
			{
				this.GetOrCreatePoco().GradingSystemId = value;
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x000E6360 File Offset: 0x000E4560
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x000E63F3 File Offset: 0x000E45F3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IGradingSystemVar> Vars
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if (this.FbInstance != null)
				{
					List<IGradingSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IGradingSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IGradingSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IGradingSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._VarsCache = ((pocoInterface != null) ? pocoInterface.Vars : null);
				}
				return this._VarsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Vars = value;
				this._VarsInited = false;
			}
		}

		// Token: 0x04003910 RID: 14608
		[Nullable(2)]
		protected new IGradingSystemConfig FbInstance;

		// Token: 0x04003911 RID: 14609
		[Nullable(2)]
		protected new IGradingSystemConfig_SetValue PocoInterface;

		// Token: 0x04003912 RID: 14610
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IGradingSystemVar> _VarsCache;

		// Token: 0x04003913 RID: 14611
		private bool _VarsInited;
	}
}
