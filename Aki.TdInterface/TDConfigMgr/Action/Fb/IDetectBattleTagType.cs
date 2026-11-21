using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CC RID: 10700
	public class IDetectBattleTagType
	{
		// Token: 0x0600ECDD RID: 60637 RVA: 0x0022D777 File Offset: 0x0022B977
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

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x0600ECDE RID: 60638 RVA: 0x0022D796 File Offset: 0x0022B996
		public virtual EDetectBattleTagType Type
		{
			get
			{
				return (EDetectBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04008260 RID: 33376
		private IDetectBattleTagType Instance;
	}
}
