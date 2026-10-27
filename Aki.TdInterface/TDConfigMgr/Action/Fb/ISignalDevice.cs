using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285C RID: 10332
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalDevice : IUiGame
	{
		// Token: 0x0600E505 RID: 58629 RVA: 0x0021B0F4 File Offset: 0x002192F4
		public static ISignalDevice Create(ISignalDevice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISignalDevice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x0600E506 RID: 58630 RVA: 0x0021B113 File Offset: 0x00219313
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x0600E507 RID: 58631 RVA: 0x0021B120 File Offset: 0x00219320
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

		// Token: 0x04007EB0 RID: 32432
		private ISignalDevice Instance;

		// Token: 0x04007EB1 RID: 32433
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04007EB2 RID: 32434
		private bool _ConfigInited;
	}
}
