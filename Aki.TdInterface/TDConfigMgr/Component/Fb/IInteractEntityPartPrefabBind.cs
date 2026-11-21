using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B49 RID: 2889
	public class IInteractEntityPartPrefabBind : IInteractEntityPartBindBase
	{
		// Token: 0x060041FC RID: 16892 RVA: 0x000A7C3C File Offset: 0x000A5E3C
		public static IInteractEntityPartPrefabBind Create(IInteractEntityPartPrefabBind? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabBind
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x000A7C5B File Offset: 0x000A5E5B
		public override EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x000A7C68 File Offset: 0x000A5E68
		public virtual List<IInteractEntityPartPrefabOptionPoint> OptionPoints
		{
			get
			{
				if (this._OptionPointsInited)
				{
					return this._OptionPointsCache;
				}
				this._OptionPointsInited = true;
				int optionPointsLength = this.Instance.OptionPointsLength;
				this._OptionPointsCache = new List<IInteractEntityPartPrefabOptionPoint>(optionPointsLength);
				for (int i = 0; i < optionPointsLength; i++)
				{
					this._OptionPointsCache.Add(IInteractEntityPartPrefabOptionPoint.Create(this.Instance.OptionPoints(i)));
				}
				return this._OptionPointsCache;
			}
		}

		// Token: 0x04002484 RID: 9348
		private IInteractEntityPartPrefabBind Instance;

		// Token: 0x04002485 RID: 9349
		private List<IInteractEntityPartPrefabOptionPoint> _OptionPointsCache;

		// Token: 0x04002486 RID: 9350
		private bool _OptionPointsInited;
	}
}
