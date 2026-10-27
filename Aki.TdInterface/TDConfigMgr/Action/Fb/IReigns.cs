using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200283C RID: 10300
	public class IReigns : IUiGame
	{
		// Token: 0x0600E45C RID: 58460 RVA: 0x00219D62 File Offset: 0x00217F62
		[NullableContext(1)]
		public static IReigns Create(IReigns? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReigns
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x0600E45D RID: 58461 RVA: 0x00219D81 File Offset: 0x00217F81
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x0600E45E RID: 58462 RVA: 0x00219D8E File Offset: 0x00217F8E
		public virtual int ReignsId
		{
			get
			{
				return this.Instance.ReignsId;
			}
		}

		// Token: 0x04007E58 RID: 32344
		private IReigns Instance;
	}
}
