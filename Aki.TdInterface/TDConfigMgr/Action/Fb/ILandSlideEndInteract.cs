using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD2 RID: 10962
	public class ILandSlideEndInteract : ILeisureInteractType
	{
		// Token: 0x0600F16C RID: 61804 RVA: 0x0023517E File Offset: 0x0023337E
		public static ILandSlideEndInteract Create(ILandSlideEndInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideEndInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x0600F16D RID: 61805 RVA: 0x0023519D File Offset: 0x0023339D
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x040084A0 RID: 33952
		private ILandSlideEndInteract Instance;
	}
}
