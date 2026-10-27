using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D9 RID: 9689
	public class IProgramSpecialConfigBase
	{
		// Token: 0x0600D9CE RID: 55758 RVA: 0x00207AF7 File Offset: 0x00205CF7
		[NullableContext(1)]
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

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x0600D9CF RID: 55759 RVA: 0x00207B16 File Offset: 0x00205D16
		public virtual EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				return (EPlayMovieProgramSpecialConfigType)this.Instance.Type;
			}
		}

		// Token: 0x040078F5 RID: 30965
		private IProgramSpecialConfigBase Instance;
	}
}
