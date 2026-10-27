using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E0 RID: 10208
	public class IStandControl2 : ILeisureInteractType
	{
		// Token: 0x0600E2E3 RID: 58083 RVA: 0x00217C21 File Offset: 0x00215E21
		[NullableContext(1)]
		public static IStandControl2 Create(IStandControl2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x00217C40 File Offset: 0x00215E40
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC2 RID: 32194
		private IStandControl2 Instance;
	}
}
