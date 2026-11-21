using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CD RID: 10701
	public class IDetectBattleMonsterOnGround : IDetectBattleTagType
	{
		// Token: 0x0600ECE0 RID: 60640 RVA: 0x0022D7AB File Offset: 0x0022B9AB
		public static IDetectBattleMonsterOnGround Create(IDetectBattleMonsterOnGround? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleMonsterOnGround
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x0600ECE1 RID: 60641 RVA: 0x0022D7CA File Offset: 0x0022B9CA
		public override EDetectBattleTagType Type
		{
			get
			{
				return (EDetectBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04008261 RID: 33377
		private IDetectBattleMonsterOnGround Instance;
	}
}
