using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005388 RID: 21384
	public class MotorFightDefine
	{
		// Token: 0x0401C12C RID: 114988
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EMotorFightAttrShowType, string> motorFightAttrShowTypeToName = new Dictionary<EMotorFightAttrShowType, string>
		{
			{
				EMotorFightAttrShowType.MainGun,
				"MotorFightGame_UIAttriDesc_01"
			},
			{
				EMotorFightAttrShowType.Wingman,
				"MotorFightGame_UIAttriDesc_02"
			},
			{
				EMotorFightAttrShowType.Common,
				"MotorFightGame_UIAttriDesc_03"
			}
		};
	}
}
