using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B98 RID: 11160
	public class IEnterMovieCameraType
	{
		// Token: 0x0600F609 RID: 62985 RVA: 0x0023D9F1 File Offset: 0x0023BBF1
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

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x0600F60A RID: 62986 RVA: 0x0023DA10 File Offset: 0x0023BC10
		public virtual EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x040086EC RID: 34540
		private IEnterMovieCameraType Instance;
	}
}
