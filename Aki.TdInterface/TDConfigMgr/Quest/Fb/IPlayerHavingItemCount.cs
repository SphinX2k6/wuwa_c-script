using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001338 RID: 4920
	public class IPlayerHavingItemCount : IBindingProgressType
	{
		// Token: 0x060070C3 RID: 28867 RVA: 0x00110063 File Offset: 0x0010E263
		[NullableContext(1)]
		public static IPlayerHavingItemCount Create(IPlayerHavingItemCount? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHavingItemCount
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x060070C4 RID: 28868 RVA: 0x00110082 File Offset: 0x0010E282
		public override EBindingProgressType Type
		{
			get
			{
				return (EBindingProgressType)this.Instance.Type;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x0011008F File Offset: 0x0010E28F
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x0400410E RID: 16654
		private IPlayerHavingItemCount Instance;
	}
}
