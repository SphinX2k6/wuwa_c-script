using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F26 RID: 3878
	public class IWaterStagnationActorConfig
	{
		// Token: 0x06005723 RID: 22307 RVA: 0x000D5936 File Offset: 0x000D3B36
		public static IWaterStagnationActorConfig Create(IWaterStagnationActorConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaterStagnationActorConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x000D5955 File Offset: 0x000D3B55
		public virtual int SeqRefEntity
		{
			get
			{
				return this.Instance.SeqRefEntity;
			}
		}

		// Token: 0x04003201 RID: 12801
		private IWaterStagnationActorConfig Instance;
	}
}
