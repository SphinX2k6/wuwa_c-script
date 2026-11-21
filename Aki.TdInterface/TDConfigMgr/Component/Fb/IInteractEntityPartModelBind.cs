using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B4A RID: 2890
	public class IInteractEntityPartModelBind : IInteractEntityPartBindBase
	{
		// Token: 0x06004200 RID: 16896 RVA: 0x000A7CD9 File Offset: 0x000A5ED9
		public static IInteractEntityPartModelBind Create(IInteractEntityPartModelBind? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartModelBind
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x000A7CF8 File Offset: 0x000A5EF8
		public override EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x000A7D08 File Offset: 0x000A5F08
		public virtual List<IInteractEntityPartModelOptionPoint> OptionPoints
		{
			get
			{
				if (this._OptionPointsInited)
				{
					return this._OptionPointsCache;
				}
				this._OptionPointsInited = true;
				int optionPointsLength = this.Instance.OptionPointsLength;
				this._OptionPointsCache = new List<IInteractEntityPartModelOptionPoint>(optionPointsLength);
				for (int i = 0; i < optionPointsLength; i++)
				{
					this._OptionPointsCache.Add(IInteractEntityPartModelOptionPoint.Create(this.Instance.OptionPoints(i)));
				}
				return this._OptionPointsCache;
			}
		}

		// Token: 0x04002487 RID: 9351
		private IInteractEntityPartModelBind Instance;

		// Token: 0x04002488 RID: 9352
		private List<IInteractEntityPartModelOptionPoint> _OptionPointsCache;

		// Token: 0x04002489 RID: 9353
		private bool _OptionPointsInited;
	}
}
