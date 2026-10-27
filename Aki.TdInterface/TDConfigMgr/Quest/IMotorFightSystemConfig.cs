using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200101D RID: 4125
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorFightSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005C0A RID: 23562 RVA: 0x000DF15C File Offset: 0x000DD35C
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

		// Token: 0x06005C0B RID: 23563 RVA: 0x000DF194 File Offset: 0x000DD394
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

		// Token: 0x06005C0C RID: 23564 RVA: 0x000DF1A7 File Offset: 0x000DD3A7
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

		// Token: 0x06005C0D RID: 23565 RVA: 0x000DF1BA File Offset: 0x000DD3BA
		public new IMotorFightSystemConfig_SetValue ToSetValue()
		{
			return new IMotorFightSystemConfig_SetValue
			{
				Type = this.Type,
				Vars = this.Vars
			};
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x000DF1D9 File Offset: 0x000DD3D9
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x000DF204 File Offset: 0x000DD404
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

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x000DF214 File Offset: 0x000DD414
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x000DF2A7 File Offset: 0x000DD4A7
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

		// Token: 0x04003764 RID: 14180
		[Nullable(2)]
		protected new IMotorFightSystemConfig FbInstance;

		// Token: 0x04003765 RID: 14181
		[Nullable(2)]
		protected new IMotorFightSystemConfig_SetValue PocoInterface;

		// Token: 0x04003766 RID: 14182
		private List<IMotorFightSystemVar> _VarsCache;

		// Token: 0x04003767 RID: 14183
		private bool _VarsInited;
	}
}
