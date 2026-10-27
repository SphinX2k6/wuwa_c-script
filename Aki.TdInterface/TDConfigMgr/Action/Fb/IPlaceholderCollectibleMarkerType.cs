using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002669 RID: 9833
	public class IPlaceholderCollectibleMarkerType : ICollectibleMarkerType
	{
		// Token: 0x0600DC52 RID: 56402 RVA: 0x0020C579 File Offset: 0x0020A779
		[NullableContext(1)]
		public static IPlaceholderCollectibleMarkerType Create(IPlaceholderCollectibleMarkerType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaceholderCollectibleMarkerType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x0600DC53 RID: 56403 RVA: 0x0020C598 File Offset: 0x0020A798
		public override ECollectibleMarkerType Type
		{
			get
			{
				return (ECollectibleMarkerType)this.Instance.Type;
			}
		}

		// Token: 0x04007A6F RID: 31343
		private IPlaceholderCollectibleMarkerType Instance;
	}
}
