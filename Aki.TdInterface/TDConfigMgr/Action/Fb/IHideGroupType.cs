using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A63 RID: 10851
	public class IHideGroupType
	{
		// Token: 0x0600EF98 RID: 61336 RVA: 0x00231EFD File Offset: 0x002300FD
		public static IHideGroupType Create(IHideGroupType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x0600EF99 RID: 61337 RVA: 0x00231F1C File Offset: 0x0023011C
		public virtual EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x040083B7 RID: 33719
		private IHideGroupType Instance;
	}
}
