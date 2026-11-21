using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF3 RID: 10995
	public class IPlayMapMusic : IAkEventMapType
	{
		// Token: 0x0600F1F9 RID: 61945 RVA: 0x00235DA3 File Offset: 0x00233FA3
		public static IPlayMapMusic Create(IPlayMapMusic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMapMusic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x0600F1FA RID: 61946 RVA: 0x00235DC2 File Offset: 0x00233FC2
		public override EAkEventMap Type
		{
			get
			{
				return (EAkEventMap)this.Instance.Type;
			}
		}

		// Token: 0x040084D5 RID: 34005
		private IPlayMapMusic Instance;
	}
}
