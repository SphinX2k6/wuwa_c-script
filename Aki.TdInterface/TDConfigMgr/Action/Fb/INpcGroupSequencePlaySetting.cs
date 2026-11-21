using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4F RID: 11599
	public class INpcGroupSequencePlaySetting
	{
		// Token: 0x0600FD41 RID: 64833 RVA: 0x002493AF File Offset: 0x002475AF
		public static INpcGroupSequencePlaySetting Create(INpcGroupSequencePlaySetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequencePlaySetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x002493CE File Offset: 0x002475CE
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x0600FD43 RID: 64835 RVA: 0x002493DB File Offset: 0x002475DB
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x0600FD44 RID: 64836 RVA: 0x002493E8 File Offset: 0x002475E8
		public virtual bool IsWaitCurrentSequenceFinish
		{
			get
			{
				return this.Instance.IsWaitCurrentSequenceFinish;
			}
		}

		// Token: 0x04008A3D RID: 35389
		private INpcGroupSequencePlaySetting Instance;
	}
}
