using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001462 RID: 5218
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityRefSearchProp
	{
		// Token: 0x060076C3 RID: 30403 RVA: 0x0011BE8E File Offset: 0x0011A08E
		public static IEntityRefSearchProp Create(IEntityRefSearchProp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityRefSearchProp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x0011BEAD File Offset: 0x0011A0AD
		public virtual string SearchText
		{
			get
			{
				return this.Instance.SearchText;
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x060076C5 RID: 30405 RVA: 0x0011BEBC File Offset: 0x0011A0BC
		public virtual int? ResultCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ResultCount);
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x060076C6 RID: 30406 RVA: 0x0011BEF4 File Offset: 0x0011A0F4
		public virtual int? ResultIndex
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ResultIndex);
			}
		}

		// Token: 0x0400450A RID: 17674
		private IEntityRefSearchProp Instance;
	}
}
