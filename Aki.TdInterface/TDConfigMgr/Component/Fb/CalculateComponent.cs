using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B24 RID: 2852
	public class CalculateComponent : IComponentBase
	{
		// Token: 0x0600412D RID: 16685 RVA: 0x000A6403 File Offset: 0x000A4603
		public static CalculateComponent Create(ICalculateComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CalculateComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x000A6424 File Offset: 0x000A4624
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x0600412F RID: 16687 RVA: 0x000A645C File Offset: 0x000A465C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x000A6474 File Offset: 0x000A4674
		public virtual List<INumberVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<INumberVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(INumberVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x000A64E0 File Offset: 0x000A46E0
		public virtual List<IFunction> Functions
		{
			get
			{
				if (this._FunctionsInited)
				{
					return this._FunctionsCache;
				}
				this._FunctionsInited = true;
				int functionsLength = this.Instance.FunctionsLength;
				this._FunctionsCache = new List<IFunction>(functionsLength);
				for (int i = 0; i < functionsLength; i++)
				{
					this._FunctionsCache.Add(IFunction.Create(this.Instance.Functions(i)));
				}
				return this._FunctionsCache;
			}
		}

		// Token: 0x04002419 RID: 9241
		private ICalculateComponent Instance;

		// Token: 0x0400241A RID: 9242
		private List<INumberVar> _VarsCache;

		// Token: 0x0400241B RID: 9243
		private bool _VarsInited;

		// Token: 0x0400241C RID: 9244
		private List<IFunction> _FunctionsCache;

		// Token: 0x0400241D RID: 9245
		private bool _FunctionsInited;
	}
}
