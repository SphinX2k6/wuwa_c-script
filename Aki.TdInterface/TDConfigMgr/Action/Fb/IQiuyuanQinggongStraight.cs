using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACE RID: 10958
	public class IQiuyuanQinggongStraight : ILeisureInteractType
	{
		// Token: 0x0600F160 RID: 61792 RVA: 0x002350AE File Offset: 0x002332AE
		public static IQiuyuanQinggongStraight Create(IQiuyuanQinggongStraight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongStraight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x0600F161 RID: 61793 RVA: 0x002350CD File Offset: 0x002332CD
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x0400849C RID: 33948
		private IQiuyuanQinggongStraight Instance;
	}
}
