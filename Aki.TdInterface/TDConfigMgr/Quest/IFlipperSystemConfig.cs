using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010BF RID: 4287
	public class IFlipperSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005EB0 RID: 24240 RVA: 0x000E5600 File Offset: 0x000E3800
		private IFlipperSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlipperSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlipperSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlipperSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x000E5638 File Offset: 0x000E3838
		public static IFlipperSystemConfig Create([Nullable(2)] IFlipperSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x000E564B File Offset: 0x000E384B
		public static IFlipperSystemConfig CreateFromSetValue([Nullable(2)] IFlipperSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlipperSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x000E565E File Offset: 0x000E385E
		public new IFlipperSystemConfig_SetValue ToSetValue()
		{
			return new IFlipperSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x000E567D File Offset: 0x000E387D
		// (set) Token: 0x06005EB5 RID: 24245 RVA: 0x000E56A8 File Offset: 0x000E38A8
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x000E56B8 File Offset: 0x000E38B8
		// (set) Token: 0x06005EB7 RID: 24247 RVA: 0x000E574B File Offset: 0x000E394B
		public virtual List<IFlipperSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				if (this.FbInstance != null)
				{
					List<IFlipperSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IFlipperSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IFlipperSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IFlipperSystemConfig_SetValue pocoInterface = this.PocoInterface;
					this._VarsCache = ((pocoInterface != null) ? pocoInterface.Vars : null);
				}
				return this._VarsCache;
			}
			set
			{
				this.GetOrCreatePoco().Vars = value;
				this._VarsInited = false;
			}
		}

		// Token: 0x040038DC RID: 14556
		[Nullable(2)]
		protected new IFlipperSystemConfig FbInstance;

		// Token: 0x040038DD RID: 14557
		[Nullable(2)]
		protected new IFlipperSystemConfig_SetValue PocoInterface;

		// Token: 0x040038DE RID: 14558
		private List<IFlipperSystemVar> _VarsCache;

		// Token: 0x040038DF RID: 14559
		private bool _VarsInited;
	}
}
