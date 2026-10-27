using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E4 RID: 10212
	public class IGetUp : ILeisureInteractType
	{
		// Token: 0x0600E2EF RID: 58095 RVA: 0x00217CF1 File Offset: 0x00215EF1
		[NullableContext(1)]
		public static IGetUp Create(IGetUp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetUp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x00217D10 File Offset: 0x00215F10
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC6 RID: 32198
		private IGetUp Instance;
	}
}
