using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F5 RID: 5365
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCrafting : IShowUi
	{
		// Token: 0x06007989 RID: 31113 RVA: 0x00122599 File Offset: 0x00120799
		[NullableContext(0)]
		public static IShowUiCrafting Create(IShowUiCrafting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCrafting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x001225B8 File Offset: 0x001207B8
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x001225C8 File Offset: 0x001207C8
		public virtual List<int> EntityIds
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

		// Token: 0x17002743 RID: 10051
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x00122640 File Offset: 0x00120840
		public virtual List<int> ProductIds
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

		// Token: 0x040045E5 RID: 17893
		private IShowUiCrafting Instance;

		// Token: 0x040045E6 RID: 17894
		private List<int> _EntityIdsCache;

		// Token: 0x040045E7 RID: 17895
		private bool _EntityIdsInited;

		// Token: 0x040045E8 RID: 17896
		private List<int> _ProductIdsCache;

		// Token: 0x040045E9 RID: 17897
		private bool _ProductIdsInited;
	}
}
