using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F1 RID: 10225
	public class IPainCoveringHead : ILeisureInteractType
	{
		// Token: 0x0600E319 RID: 58137 RVA: 0x00217FE3 File Offset: 0x002161E3
		[NullableContext(1)]
		public static IPainCoveringHead Create(IPainCoveringHead? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPainCoveringHead
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x0600E31A RID: 58138 RVA: 0x00218002 File Offset: 0x00216202
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DD5 RID: 32213
		private IPainCoveringHead Instance;
	}
}
