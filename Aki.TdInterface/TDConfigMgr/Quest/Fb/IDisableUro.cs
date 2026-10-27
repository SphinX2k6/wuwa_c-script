using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F5 RID: 4853
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableUro : ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06006EB7 RID: 28343 RVA: 0x0010B65C File Offset: 0x0010985C
		public static IDisableUro Create(IDisableUro? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUro
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x0010B67B File Offset: 0x0010987B
		public override ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06006EB9 RID: 28345 RVA: 0x0010B688 File Offset: 0x00109888
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x04003F75 RID: 16245
		private IDisableUro Instance;

		// Token: 0x04003F76 RID: 16246
		private List<int> _EntityIdsCache;

		// Token: 0x04003F77 RID: 16247
		private bool _EntityIdsInited;
	}
}
