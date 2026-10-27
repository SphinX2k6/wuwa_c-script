using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A6 RID: 5030
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiSynthetic : IShowUiCrafting
	{
		// Token: 0x060072EC RID: 29420 RVA: 0x00114125 File Offset: 0x00112325
		[NullableContext(1)]
		public static IShowUiSynthetic Create(IShowUiSynthetic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiSynthetic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x060072ED RID: 29421 RVA: 0x00114144 File Offset: 0x00112344
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x00114154 File Offset: 0x00112354
		public override List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x001141CC File Offset: 0x001123CC
		public override List<int> ProductIds
		{
			get
			{
				if (this._ProductIdsInited)
				{
					return this._ProductIdsCache;
				}
				this._ProductIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int productIdsLength = this.Instance.ProductIdsLength;
				this._ProductIdsCache = new List<int>(productIdsLength);
				for (int i = 0; i < productIdsLength; i++)
				{
					this._ProductIdsCache.Add(this.Instance.ProductIds(i));
				}
				return this._ProductIdsCache;
			}
		}

		// Token: 0x0400426E RID: 17006
		private IShowUiSynthetic Instance;

		// Token: 0x0400426F RID: 17007
		private List<int> _EntityIdsCache;

		// Token: 0x04004270 RID: 17008
		private bool _EntityIdsInited;

		// Token: 0x04004271 RID: 17009
		private List<int> _ProductIdsCache;

		// Token: 0x04004272 RID: 17010
		private bool _ProductIdsInited;
	}
}
