using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BC RID: 10172
	public class ITalkOptionRogueRandomEvent : ITalkOptionParamType
	{
		// Token: 0x0600E118 RID: 57624 RVA: 0x00211840 File Offset: 0x0020FA40
		public static ITalkOptionRogueRandomEvent Create(ITalkOptionRogueRandomEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionRogueRandomEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600E119 RID: 57625 RVA: 0x0021185F File Offset: 0x0020FA5F
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600E11A RID: 57626 RVA: 0x0021186C File Offset: 0x0020FA6C
		public virtual int? OptionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.OptionId);
			}
		}

		// Token: 0x04007A5A RID: 31322
		private ITalkOptionRogueRandomEvent Instance;
	}
}
