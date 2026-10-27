using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200140C RID: 5132
	[NullableContext(1)]
	[Nullable(0)]
	public class IAtomicProcessStoveCoreFall : IAtomicProcessBase
	{
		// Token: 0x060074B5 RID: 29877 RVA: 0x001170C7 File Offset: 0x001152C7
		public static IAtomicProcessStoveCoreFall Create(IAtomicProcessStoveCoreFall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAtomicProcessStoveCoreFall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x001170E6 File Offset: 0x001152E6
		public override EAtomicProcess Type
		{
			get
			{
				return (EAtomicProcess)this.Instance.Type;
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x001170F4 File Offset: 0x001152F4
		public virtual List<int> SplineEntityIds
		{
			get
			{
				if (this._SplineEntityIdsInited)
				{
					return this._SplineEntityIdsCache;
				}
				this._SplineEntityIdsInited = true;
				int splineEntityIdsLength = this.Instance.SplineEntityIdsLength;
				this._SplineEntityIdsCache = new List<int>(splineEntityIdsLength);
				for (int i = 0; i < splineEntityIdsLength; i++)
				{
					this._SplineEntityIdsCache.Add(this.Instance.SplineEntityIds(i));
				}
				return this._SplineEntityIdsCache;
			}
		}

		// Token: 0x04004390 RID: 17296
		private IAtomicProcessStoveCoreFall Instance;

		// Token: 0x04004391 RID: 17297
		private List<int> _SplineEntityIdsCache;

		// Token: 0x04004392 RID: 17298
		private bool _SplineEntityIdsInited;
	}
}
