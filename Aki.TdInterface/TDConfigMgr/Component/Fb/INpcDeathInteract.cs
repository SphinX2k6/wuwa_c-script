using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C98 RID: 3224
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDeathInteract
	{
		// Token: 0x060049C1 RID: 18881 RVA: 0x000B9D5F File Offset: 0x000B7F5F
		[NullableContext(0)]
		public static INpcDeathInteract Create(INpcDeathInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x000B9D7E File Offset: 0x000B7F7E
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				this._MontageCache = IMontageId.Create(this.Instance.Montage);
				return this._MontageCache;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x000B9DB2 File Offset: 0x000B7FB2
		public virtual string MaterialDa
		{
			get
			{
				return this.Instance.MaterialDa;
			}
		}

		// Token: 0x040029C1 RID: 10689
		private INpcDeathInteract Instance;

		// Token: 0x040029C2 RID: 10690
		private IMontageId _MontageCache;

		// Token: 0x040029C3 RID: 10691
		private bool _MontageInited;
	}
}
