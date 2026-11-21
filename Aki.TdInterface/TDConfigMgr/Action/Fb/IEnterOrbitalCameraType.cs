using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA6 RID: 11174
	public class IEnterOrbitalCameraType
	{
		// Token: 0x0600F641 RID: 63041 RVA: 0x0023E04A File Offset: 0x0023C24A
		public static IEnterOrbitalCameraType Create(IEnterOrbitalCameraType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0600F642 RID: 63042 RVA: 0x0023E069 File Offset: 0x0023C269
		public virtual EEnterOrbitalCameraType Type
		{
			get
			{
				return (EEnterOrbitalCameraType)this.Instance.Type;
			}
		}

		// Token: 0x0400870A RID: 34570
		private IEnterOrbitalCameraType Instance;
	}
}
