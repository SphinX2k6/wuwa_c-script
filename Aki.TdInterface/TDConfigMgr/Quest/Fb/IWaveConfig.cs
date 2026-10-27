using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F2 RID: 4850
	public class IWaveConfig
	{
		// Token: 0x06006EAE RID: 28334 RVA: 0x0010B599 File Offset: 0x00109799
		[NullableContext(1)]
		public static IWaveConfig Create(IWaveConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaveConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06006EAF RID: 28335 RVA: 0x0010B5B8 File Offset: 0x001097B8
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04003F70 RID: 16240
		private IWaveConfig Instance;
	}
}
