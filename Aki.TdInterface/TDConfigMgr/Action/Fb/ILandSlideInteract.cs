using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027FE RID: 10238
	public class ILandSlideInteract : ILeisureInteractType
	{
		// Token: 0x0600E344 RID: 58180 RVA: 0x002182E6 File Offset: 0x002164E6
		[NullableContext(1)]
		public static ILandSlideInteract Create(ILandSlideInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700450A RID: 17674
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x00218305 File Offset: 0x00216505
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DE2 RID: 32226
		private ILandSlideInteract Instance;
	}
}
