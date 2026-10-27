using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002668 RID: 9832
	public class ICollectibleMarkerType
	{
		// Token: 0x0600DC4F RID: 56399 RVA: 0x0020C545 File Offset: 0x0020A745
		[NullableContext(1)]
		public static ICollectibleMarkerType Create(ICollectibleMarkerType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICollectibleMarkerType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x0020C564 File Offset: 0x0020A764
		public virtual ECollectibleMarkerType Type
		{
			get
			{
				return (ECollectibleMarkerType)this.Instance.Type;
			}
		}

		// Token: 0x04007A6E RID: 31342
		private ICollectibleMarkerType Instance;
	}
}
