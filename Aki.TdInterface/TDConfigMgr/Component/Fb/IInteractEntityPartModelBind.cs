using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A80 RID: 2688
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartModelBind : IInteractEntityPartBindBase
	{
		// Token: 0x06003DD7 RID: 15831 RVA: 0x0009E721 File Offset: 0x0009C921
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

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06003DD8 RID: 15832 RVA: 0x0009E740 File Offset: 0x0009C940
		public override EInteractEntityPartBindType Type
		{
			get
			{
				return (EInteractEntityPartBindType)this.Instance.Type;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06003DD9 RID: 15833 RVA: 0x0009E750 File Offset: 0x0009C950
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

		// Token: 0x0400226B RID: 8811
		private IInteractEntityPartModelBind Instance;

		// Token: 0x0400226C RID: 8812
		private List<IInteractEntityPartModelOptionPoint> _OptionPointsCache;

		// Token: 0x0400226D RID: 8813
		private bool _OptionPointsInited;
	}
}
