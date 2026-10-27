using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A75 RID: 2677
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomInteract
	{
		// Token: 0x06003DAC RID: 15788 RVA: 0x0009E2DF File Offset: 0x0009C4DF
		public static IRandomInteract Create(IRandomInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x0009E2FE File Offset: 0x0009C4FE
		public virtual int RandomCount
		{
			get
			{
				return this.Instance.RandomCount;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x0009E30C File Offset: 0x0009C50C
		public virtual List<IRandomInteractOption> Options
		{
			get
			{
				if (this._OptionsInited)
				{
					return this._OptionsCache;
				}
				this._OptionsInited = true;
				int optionsLength = this.Instance.OptionsLength;
				this._OptionsCache = new List<IRandomInteractOption>(optionsLength);
				for (int i = 0; i < optionsLength; i++)
				{
					this._OptionsCache.Add(IRandomInteractOption.Create(this.Instance.Options(i)));
				}
				return this._OptionsCache;
			}
		}

		// Token: 0x04002258 RID: 8792
		private IRandomInteract Instance;

		// Token: 0x04002259 RID: 8793
		private List<IRandomInteractOption> _OptionsCache;

		// Token: 0x0400225A RID: 8794
		private bool _OptionsInited;
	}
}
