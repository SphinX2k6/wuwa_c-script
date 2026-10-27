using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F95 RID: 3989
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060058DE RID: 22750 RVA: 0x000D8BD8 File Offset: 0x000D6DD8
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

		// Token: 0x060058DF RID: 22751 RVA: 0x000D8C10 File Offset: 0x000D6E10
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

		// Token: 0x060058E0 RID: 22752 RVA: 0x000D8C23 File Offset: 0x000D6E23
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

		// Token: 0x060058E1 RID: 22753 RVA: 0x000D8C36 File Offset: 0x000D6E36
		public new IFlipperSystemConfig_SetValue ToSetValue()
		{
			return new IFlipperSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x000D8C55 File Offset: 0x000D6E55
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x000D8C80 File Offset: 0x000D6E80
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

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x000D8C90 File Offset: 0x000D6E90
		// (set) Token: 0x060058E5 RID: 22757 RVA: 0x000D8D23 File Offset: 0x000D6F23
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

		// Token: 0x040035AC RID: 13740
		[Nullable(2)]
		protected new IFlipperSystemConfig FbInstance;

		// Token: 0x040035AD RID: 13741
		[Nullable(2)]
		protected new IFlipperSystemConfig_SetValue PocoInterface;

		// Token: 0x040035AE RID: 13742
		private List<IFlipperSystemVar> _VarsCache;

		// Token: 0x040035AF RID: 13743
		private bool _VarsInited;
	}
}
