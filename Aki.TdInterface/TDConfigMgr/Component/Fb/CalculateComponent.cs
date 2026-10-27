using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5B RID: 2651
	[NullableContext(1)]
	[Nullable(0)]
	public class CalculateComponent : IComponentBase
	{
		// Token: 0x06003D0D RID: 15629 RVA: 0x0009CF8B File Offset: 0x0009B18B
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x0009CFAC File Offset: 0x0009B1AC
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x0009CFFC File Offset: 0x0009B1FC
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

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x0009D068 File Offset: 0x0009B268
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

		// Token: 0x04002202 RID: 8706
		private ICalculateComponent Instance;

		// Token: 0x04002203 RID: 8707
		private List<INumberVar> _VarsCache;

		// Token: 0x04002204 RID: 8708
		private bool _VarsInited;

		// Token: 0x04002205 RID: 8709
		private List<IFunction> _FunctionsCache;

		// Token: 0x04002206 RID: 8710
		private bool _FunctionsInited;
	}
}
