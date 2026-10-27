using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C3 RID: 10435
	public class IEnterMovieCameraType
	{
		// Token: 0x0600E7DA RID: 59354 RVA: 0x00220A71 File Offset: 0x0021EC71
		[NullableContext(1)]
		public static IEnterMovieCameraType Create(IEnterMovieCameraType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterMovieCameraType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x00220A90 File Offset: 0x0021EC90
		public virtual EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x0400802D RID: 32813
		private IEnterMovieCameraType Instance;
	}
}
