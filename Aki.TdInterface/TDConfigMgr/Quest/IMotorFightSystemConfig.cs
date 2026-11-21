using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001149 RID: 4425
	public class IMotorFightSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060061EC RID: 25068 RVA: 0x000EBE54 File Offset: 0x000EA054
		private IMotorFightSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorFightSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorFightSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorFightSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x000EBE8C File Offset: 0x000EA08C
		public static IMotorFightSystemConfig Create([Nullable(2)] IMotorFightSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorFightSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x000EBE9F File Offset: 0x000EA09F
		public static IMotorFightSystemConfig CreateFromSetValue([Nullable(2)] IMotorFightSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorFightSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x000EBEB2 File Offset: 0x000EA0B2
		public new IMotorFightSystemConfig_SetValue ToSetValue()
		{
			return new IMotorFightSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x060061F0 RID: 25072 RVA: 0x000EBED1 File Offset: 0x000EA0D1
		// (set) Token: 0x060061F1 RID: 25073 RVA: 0x000EBEFC File Offset: 0x000EA0FC
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

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x060061F2 RID: 25074 RVA: 0x000EBF0C File Offset: 0x000EA10C
		// (set) Token: 0x060061F3 RID: 25075 RVA: 0x000EBF9F File Offset: 0x000EA19F
		public virtual List<IMotorFightSystemVar> Vars
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
					List<IMotorFightSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<IMotorFightSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(IMotorFightSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					IMotorFightSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003A9F RID: 15007
		[Nullable(2)]
		protected new IMotorFightSystemConfig FbInstance;

		// Token: 0x04003AA0 RID: 15008
		[Nullable(2)]
		protected new IMotorFightSystemConfig_SetValue PocoInterface;

		// Token: 0x04003AA1 RID: 15009
		private List<IMotorFightSystemVar> _VarsCache;

		// Token: 0x04003AA2 RID: 15010
		private bool _VarsInited;
	}
}
