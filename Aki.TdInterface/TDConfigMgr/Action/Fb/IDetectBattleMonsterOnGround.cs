using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002706 RID: 9990
	public class IDetectBattleMonsterOnGround : IDetectBattleTagType
	{
		// Token: 0x0600DEF4 RID: 57076 RVA: 0x00210E02 File Offset: 0x0020F002
		[NullableContext(1)]
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

		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x00210E21 File Offset: 0x0020F021
		public override EDetectBattleTagType Type
		{
			get
			{
				return (EDetectBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007BBC RID: 31676
		private IDetectBattleMonsterOnGround Instance;
	}
}
