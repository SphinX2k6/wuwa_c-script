using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DF RID: 10207
	public class IStandControl : ILeisureInteractType
	{
		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00217BED File Offset: 0x00215DED
		[NullableContext(1)]
		public static IStandControl Create(IStandControl? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStandControl
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x0600E2E1 RID: 58081 RVA: 0x00217C0C File Offset: 0x00215E0C
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC1 RID: 32193
		private IStandControl Instance;
	}
}
