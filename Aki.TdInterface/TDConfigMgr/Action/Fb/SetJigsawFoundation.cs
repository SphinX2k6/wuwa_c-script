using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002973 RID: 10611
	[NullableContext(1)]
	[Nullable(0)]
	public class SetJigsawFoundation : ActionParams
	{
		// Token: 0x0600EB22 RID: 60194 RVA: 0x00226821 File Offset: 0x00224A21
		public static SetJigsawFoundation Create(ISetJigsawFoundation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetJigsawFoundation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x0600EB23 RID: 60195 RVA: 0x00226840 File Offset: 0x00224A40
		public virtual ISetPieceState Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ISetPieceState.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x04008189 RID: 33161
		private ISetJigsawFoundation Instance;

		// Token: 0x0400818A RID: 33162
		[Nullable(2)]
		private ISetPieceState _ConfigCache;

		// Token: 0x0400818B RID: 33163
		private bool _ConfigInited;
	}
}
