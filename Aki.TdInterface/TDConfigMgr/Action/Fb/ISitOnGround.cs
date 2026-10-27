using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D5 RID: 10197
	public class ISitOnGround : ILeisureInteractType
	{
		// Token: 0x0600E2A7 RID: 58023 RVA: 0x0021757A File Offset: 0x0021577A
		[NullableContext(1)]
		public static ISitOnGround Create(ISitOnGround? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitOnGround
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x00217599 File Offset: 0x00215799
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DA7 RID: 32167
		private ISitOnGround Instance;
	}
}
