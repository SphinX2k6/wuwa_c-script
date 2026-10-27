using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200286A RID: 10346
	public class IWuWaGoGame : IUiGame
	{
		// Token: 0x0600E546 RID: 58694 RVA: 0x0021B797 File Offset: 0x00219997
		[NullableContext(1)]
		public static IWuWaGoGame Create(IWuWaGoGame? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGame
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x0600E547 RID: 58695 RVA: 0x0021B7B6 File Offset: 0x002199B6
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x0600E548 RID: 58696 RVA: 0x0021B7C3 File Offset: 0x002199C3
		public virtual int LevelCenterId
		{
			get
			{
				return this.Instance.LevelCenterId;
			}
		}

		// Token: 0x04007ECC RID: 32460
		private IWuWaGoGame Instance;
	}
}
