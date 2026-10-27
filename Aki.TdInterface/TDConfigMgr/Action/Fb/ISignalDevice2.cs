using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200285D RID: 10333
	[NullableContext(1)]
	[Nullable(0)]
	public class ISignalDevice2 : IUiGame
	{
		// Token: 0x0600E509 RID: 58633 RVA: 0x0021B191 File Offset: 0x00219391
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

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x0600E50A RID: 58634 RVA: 0x0021B1B0 File Offset: 0x002193B0
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x0600E50B RID: 58635 RVA: 0x0021B1C0 File Offset: 0x002193C0
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

		// Token: 0x04007EB3 RID: 32435
		private ISignalDevice2 Instance;

		// Token: 0x04007EB4 RID: 32436
		private List<IColorPiece> _ConfigCache;

		// Token: 0x04007EB5 RID: 32437
		private bool _ConfigInited;
	}
}
