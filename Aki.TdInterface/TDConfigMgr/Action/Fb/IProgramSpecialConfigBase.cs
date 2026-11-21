using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002898 RID: 10392
	public class IProgramSpecialConfigBase
	{
		// Token: 0x0600E796 RID: 59286 RVA: 0x002241AB File Offset: 0x002223AB
		public static IProgramSpecialConfigBase Create(IProgramSpecialConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgramSpecialConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x0600E797 RID: 59287 RVA: 0x002241CA File Offset: 0x002223CA
		public virtual EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				return (EPlayMovieProgramSpecialConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04007F8C RID: 32652
		private IProgramSpecialConfigBase Instance;
	}
}
