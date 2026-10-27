using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A5 RID: 5029
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowUiCook : IShowUiCrafting
	{
		// Token: 0x060072E7 RID: 29415 RVA: 0x00114001 File Offset: 0x00112201
		[NullableContext(1)]
		public static IShowUiCook Create(IShowUiCook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiCook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x00114020 File Offset: 0x00112220
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x00114030 File Offset: 0x00112230
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

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x001140A8 File Offset: 0x001122A8
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

		// Token: 0x04004269 RID: 17001
		private IShowUiCook Instance;

		// Token: 0x0400426A RID: 17002
		private List<int> _EntityIdsCache;

		// Token: 0x0400426B RID: 17003
		private bool _EntityIdsInited;

		// Token: 0x0400426C RID: 17004
		private List<int> _ProductIdsCache;

		// Token: 0x0400426D RID: 17005
		private bool _ProductIdsInited;
	}
}
