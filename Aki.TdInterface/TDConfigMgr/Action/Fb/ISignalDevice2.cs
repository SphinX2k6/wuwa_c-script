using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B30 RID: 11056
	public class ISignalDevice2 : IUiGame
	{
		// Token: 0x0600F32E RID: 62254 RVA: 0x00237FF5 File Offset: 0x002361F5
		public static ISignalDevice2 Create(ISignalDevice2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalDevice2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x0600F32F RID: 62255 RVA: 0x00238014 File Offset: 0x00236214
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x0600F330 RID: 62256 RVA: 0x00238024 File Offset: 0x00236224
		public virtual List<IColorPiece> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IColorPiece>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IColorPiece.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x04008570 RID: 34160
		private ISignalDevice2 Instance;

		// Token: 0x04008571 RID: 34161
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04008572 RID: 34162
		private bool _ConfigInited;
	}
}
