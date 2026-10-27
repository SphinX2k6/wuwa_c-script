using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002858 RID: 10328
	[NullableContext(1)]
	[Nullable(0)]
	public class ICipherGameplay : IUiGame
	{
		// Token: 0x0600E4F7 RID: 58615 RVA: 0x0021B00A File Offset: 0x0021920A
		public static ICipherGameplay Create(ICipherGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICipherGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x0021B029 File Offset: 0x00219229
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x0021B036 File Offset: 0x00219236
		public virtual string CipherId
		{
			get
			{
				return this.Instance.CipherId;
			}
		}

		// Token: 0x04007EAC RID: 32428
		private ICipherGameplay Instance;
	}
}
