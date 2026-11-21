using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3D RID: 10813
	public class IEnableLevelPlayConfig
	{
		// Token: 0x0600EEDE RID: 61150 RVA: 0x0023044F File Offset: 0x0022E64F
		public static IEnableLevelPlayConfig Create(IEnableLevelPlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableLevelPlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x0600EEDF RID: 61151 RVA: 0x0023046E File Offset: 0x0022E66E
		public virtual int LevelPlayId
		{
			get
			{
				return this.Instance.LevelPlayId;
			}
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x0600EEE0 RID: 61152 RVA: 0x0023047B File Offset: 0x0022E67B
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04008329 RID: 33577
		private IEnableLevelPlayConfig Instance;
	}
}
