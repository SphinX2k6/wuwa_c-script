using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DB2 RID: 11698
	public class IAudioTypeBase
	{
		// Token: 0x0600FEDA RID: 65242 RVA: 0x0024BEA8 File Offset: 0x0024A0A8
		public static IAudioTypeBase Create(IAudioTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x0600FEDB RID: 65243 RVA: 0x0024BEC7 File Offset: 0x0024A0C7
		public virtual EAudioType Type
		{
			get
			{
				return (EAudioType)this.Instance.Type;
			}
		}

		// Token: 0x04008B1C RID: 35612
		private IAudioTypeBase Instance;
	}
}
