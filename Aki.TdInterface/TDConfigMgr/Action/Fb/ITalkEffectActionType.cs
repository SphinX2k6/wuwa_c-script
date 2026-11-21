using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E2 RID: 10210
	public class ITalkEffectActionType
	{
		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00212B8E File Offset: 0x00210D8E
		public static ITalkEffectActionType Create(ITalkEffectActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x00212BAD File Offset: 0x00210DAD
		public virtual ETalkEffectActionType Type
		{
			get
			{
				return (ETalkEffectActionType)this.Instance.Type;
			}
		}

		// Token: 0x04007AAE RID: 31406
		private ITalkEffectActionType Instance;
	}
}
