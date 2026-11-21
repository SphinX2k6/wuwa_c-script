using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3E RID: 2878
	public class IRandomInteractOption
	{
		// Token: 0x060041D1 RID: 16849 RVA: 0x000A782F File Offset: 0x000A5A2F
		public static IRandomInteractOption Create(IRandomInteractOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomInteractOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x000A784E File Offset: 0x000A5A4E
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x000A785B File Offset: 0x000A5A5B
		public virtual IInteractOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IInteractOption.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x04002471 RID: 9329
		private IRandomInteractOption Instance;

		// Token: 0x04002472 RID: 9330
		[Nullable(2)]
		private IInteractOption _OptionCache;

		// Token: 0x04002473 RID: 9331
		private bool _OptionInited;
	}
}
