using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011DA RID: 4570
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060067CE RID: 26574 RVA: 0x000F8484 File Offset: 0x000F6684
		private ITrapDefenseSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x000F84BC File Offset: 0x000F66BC
		public static ITrapDefenseSystemConfig Create([Nullable(2)] ITrapDefenseSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x000F84CF File Offset: 0x000F66CF
		public static ITrapDefenseSystemConfig CreateFromSetValue([Nullable(2)] ITrapDefenseSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x000F84E2 File Offset: 0x000F66E2
		public new ITrapDefenseSystemConfig_SetValue ToSetValue()
		{
			return new ITrapDefenseSystemConfig_SetValue
			{
				Type = this.Type,
				TrapDefenseId = this.TrapDefenseId,
				Vars = this.Vars
			};
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x060067D2 RID: 26578 RVA: 0x000F850D File Offset: 0x000F670D
		// (set) Token: 0x060067D3 RID: 26579 RVA: 0x000F8538 File Offset: 0x000F6738
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

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x000F8546 File Offset: 0x000F6746
		// (set) Token: 0x060067D5 RID: 26581 RVA: 0x000F8571 File Offset: 0x000F6771
		public virtual int TrapDefenseId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrapDefenseId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrapDefenseId;
			}
			set
			{
				this.GetOrCreatePoco().TrapDefenseId = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x000F8580 File Offset: 0x000F6780
		// (set) Token: 0x060067D7 RID: 26583 RVA: 0x000F8613 File Offset: 0x000F6813
		public virtual List<ITrapDefenseSystemVar> Vars
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
					List<ITrapDefenseSystemVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<ITrapDefenseSystemVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(ITrapDefenseSystemVar.Create(vars[i]));
						}
					}
				}
				else
				{
					ITrapDefenseSystemConfig_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04003E40 RID: 15936
		[Nullable(2)]
		protected new ITrapDefenseSystemConfig FbInstance;

		// Token: 0x04003E41 RID: 15937
		[Nullable(2)]
		protected new ITrapDefenseSystemConfig_SetValue PocoInterface;

		// Token: 0x04003E42 RID: 15938
		private List<ITrapDefenseSystemVar> _VarsCache;

		// Token: 0x04003E43 RID: 15939
		private bool _VarsInited;
	}
}
