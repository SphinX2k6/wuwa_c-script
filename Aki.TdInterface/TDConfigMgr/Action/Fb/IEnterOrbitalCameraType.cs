using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D1 RID: 10449
	public class IEnterOrbitalCameraType
	{
		// Token: 0x0600E812 RID: 59410 RVA: 0x002210CA File Offset: 0x0021F2CA
		[NullableContext(1)]
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

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x0600E813 RID: 59411 RVA: 0x002210E9 File Offset: 0x0021F2E9
		public virtual EEnterOrbitalCameraType Type
		{
			get
			{
				return (EEnterOrbitalCameraType)this.Instance.Type;
			}
		}

		// Token: 0x0400804B RID: 32843
		private IEnterOrbitalCameraType Instance;
	}
}
