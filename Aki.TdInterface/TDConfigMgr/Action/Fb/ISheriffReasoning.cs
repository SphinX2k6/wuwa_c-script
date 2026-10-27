using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287D RID: 10365
	public class ISheriffReasoning : IUiGame
	{
		// Token: 0x0600E5A2 RID: 58786 RVA: 0x0021C1EE File Offset: 0x0021A3EE
		[NullableContext(1)]
		public static ISheriffReasoning Create(ISheriffReasoning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffReasoning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x0021C20D File Offset: 0x0021A40D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x0021C21A File Offset: 0x0021A41A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007EFD RID: 32509
		private ISheriffReasoning Instance;
	}
}
