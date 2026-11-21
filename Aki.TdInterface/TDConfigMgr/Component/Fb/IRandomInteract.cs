using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3F RID: 2879
	public class IRandomInteract
	{
		// Token: 0x060041D5 RID: 16853 RVA: 0x000A7897 File Offset: 0x000A5A97
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

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x000A78B6 File Offset: 0x000A5AB6
		public virtual int RandomCount
		{
			get
			{
				return this.Instance.RandomCount;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x000A78C4 File Offset: 0x000A5AC4
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

		// Token: 0x04002474 RID: 9332
		private IRandomInteract Instance;

		// Token: 0x04002475 RID: 9333
		private List<IRandomInteractOption> _OptionsCache;

		// Token: 0x04002476 RID: 9334
		private bool _OptionsInited;
	}
}
