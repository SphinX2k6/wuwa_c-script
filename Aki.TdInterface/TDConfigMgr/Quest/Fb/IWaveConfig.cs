using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001442 RID: 5186
	public class IWaveConfig
	{
		// Token: 0x0600754E RID: 30030 RVA: 0x00119B04 File Offset: 0x00117D04
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

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600754F RID: 30031 RVA: 0x00119B23 File Offset: 0x00117D23
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040042EC RID: 17132
		private IWaveConfig Instance;
	}
}
