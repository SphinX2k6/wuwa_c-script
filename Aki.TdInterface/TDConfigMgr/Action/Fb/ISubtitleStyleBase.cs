using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002873 RID: 10355
	public class ISubtitleStyleBase
	{
		// Token: 0x0600E6DC RID: 59100 RVA: 0x00222940 File Offset: 0x00220B40
		public static ISubtitleStyleBase Create(ISubtitleStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x0022295F File Offset: 0x00220B5F
		public virtual ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F23 RID: 32547
		private ISubtitleStyleBase Instance;
	}
}
