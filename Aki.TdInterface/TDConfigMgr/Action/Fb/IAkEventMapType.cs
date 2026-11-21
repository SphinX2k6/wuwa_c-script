using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF2 RID: 10994
	public class IAkEventMapType
	{
		// Token: 0x0600F1F6 RID: 61942 RVA: 0x00235D6F File Offset: 0x00233F6F
		public static IAkEventMapType Create(IAkEventMapType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventMapType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x0600F1F7 RID: 61943 RVA: 0x00235D8E File Offset: 0x00233F8E
		public virtual EAkEventMap Type
		{
			get
			{
				return (EAkEventMap)this.Instance.Type;
			}
		}

		// Token: 0x040084D4 RID: 34004
		private IAkEventMapType Instance;
	}
}
