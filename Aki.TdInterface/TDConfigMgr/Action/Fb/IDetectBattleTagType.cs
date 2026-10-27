using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002705 RID: 9989
	public class IDetectBattleTagType
	{
		// Token: 0x0600DEF1 RID: 57073 RVA: 0x00210DCE File Offset: 0x0020EFCE
		[NullableContext(1)]
		public static IDetectBattleTagType Create(IDetectBattleTagType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleTagType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x0600DEF2 RID: 57074 RVA: 0x00210DED File Offset: 0x0020EFED
		public virtual EDetectBattleTagType Type
		{
			get
			{
				return (EDetectBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007BBB RID: 31675
		private IDetectBattleTagType Instance;
	}
}
