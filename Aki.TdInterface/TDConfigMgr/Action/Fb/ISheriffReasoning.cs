using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B53 RID: 11091
	public class ISheriffReasoning : IUiGame
	{
		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00239142 File Offset: 0x00237342
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

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x0600F3D4 RID: 62420 RVA: 0x00239161 File Offset: 0x00237361
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x0600F3D5 RID: 62421 RVA: 0x0023916E File Offset: 0x0023736E
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040085BD RID: 34237
		private ISheriffReasoning Instance;
	}
}
