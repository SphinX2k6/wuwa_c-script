using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A7F RID: 2687
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartPrefabBind : IInteractEntityPartBindBase
	{
		// Token: 0x06003DD3 RID: 15827 RVA: 0x0009E684 File Offset: 0x0009C884
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x0009E6A3 File Offset: 0x0009C8A3
		public override EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
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

		// Token: 0x04002268 RID: 8808
		private IInteractEntityPartPrefabBind Instance;

		// Token: 0x04002269 RID: 8809
		private List<IInteractEntityPartPrefabOptionPoint> _OptionPointsCache;

		// Token: 0x0400226A RID: 8810
		private bool _OptionPointsInited;
	}
}
