using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000038 RID: 56
	public class CalculateComponent : IComponentBase
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00018FEC File Offset: 0x000171EC
		private CalculateComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CalculateComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CalculateComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CalculateComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00019024 File Offset: 0x00017224
		public static CalculateComponent Create([Nullable(2)] CalculateComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CalculateComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00019037 File Offset: 0x00017237
		public static CalculateComponent CreateFromSetValue([Nullable(2)] CalculateComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CalculateComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001904A File Offset: 0x0001724A
		public new CalculateComponent_SetValue ToSetValue()
		{
			return new CalculateComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Vars = this.Vars,
				Functions = this.Functions
			};
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00019084 File Offset: 0x00017284
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000190BE File Offset: 0x000172BE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CalculateComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000190CC File Offset: 0x000172CC
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000190F6 File Offset: 0x000172F6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00019104 File Offset: 0x00017304
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00019197 File Offset: 0x00017397
		public virtual List<Aki.TDConfigMgr.Action.INumberVar> Vars
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
					List<Aki.TDConfigMgr.Action.Fb.INumberVar> vars = this.FbInstance.Vars;
					if (vars != null)
					{
						this._VarsCache = new List<Aki.TDConfigMgr.Action.INumberVar>(vars.Count);
						for (int i = 0; i < vars.Count; i++)
						{
							this._VarsCache.Add(Aki.TDConfigMgr.Action.INumberVar.Create(vars[i]));
						}
					}
				}
				else
				{
					CalculateComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000191AC File Offset: 0x000173AC
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0001923F File Offset: 0x0001743F
		public virtual List<Aki.TDConfigMgr.Action.IFunction> Functions
		{
			get
			{
				if (this._FunctionsInited)
				{
					return this._FunctionsCache;
				}
				this._FunctionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.IFunction> functions = this.FbInstance.Functions;
					if (functions != null)
					{
						this._FunctionsCache = new List<Aki.TDConfigMgr.Action.IFunction>(functions.Count);
						for (int i = 0; i < functions.Count; i++)
						{
							this._FunctionsCache.Add(Aki.TDConfigMgr.Action.IFunction.Create(functions[i]));
						}
					}
				}
				else
				{
					CalculateComponent_SetValue pocoInterface = this.PocoInterface;
					this._FunctionsCache = ((pocoInterface != null) ? pocoInterface.Functions : null);
				}
				return this._FunctionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Functions = value;
				this._FunctionsInited = false;
			}
		}

		// Token: 0x04000147 RID: 327
		[Nullable(2)]
		protected new CalculateComponent FbInstance;

		// Token: 0x04000148 RID: 328
		[Nullable(2)]
		protected new CalculateComponent_SetValue PocoInterface;

		// Token: 0x04000149 RID: 329
		private List<Aki.TDConfigMgr.Action.INumberVar> _VarsCache;

		// Token: 0x0400014A RID: 330
		private bool _VarsInited;

		// Token: 0x0400014B RID: 331
		private List<Aki.TDConfigMgr.Action.IFunction> _FunctionsCache;

		// Token: 0x0400014C RID: 332
		private bool _FunctionsInited;
	}
}
