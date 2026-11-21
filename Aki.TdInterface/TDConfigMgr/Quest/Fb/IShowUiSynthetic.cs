using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F7 RID: 5367
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiSynthetic : IShowUiCrafting
	{
		// Token: 0x06007993 RID: 31123 RVA: 0x001227E1 File Offset: 0x001209E1
		[NullableContext(0)]
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

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x00122800 File Offset: 0x00120A00
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x00122810 File Offset: 0x00120A10
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

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x00122888 File Offset: 0x00120A88
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

		// Token: 0x040045EF RID: 17903
		private IShowUiSynthetic Instance;

		// Token: 0x040045F0 RID: 17904
		private List<int> _EntityIdsCache;

		// Token: 0x040045F1 RID: 17905
		private bool _EntityIdsInited;

		// Token: 0x040045F2 RID: 17906
		private List<int> _ProductIdsCache;

		// Token: 0x040045F3 RID: 17907
		private bool _ProductIdsInited;
	}
}
