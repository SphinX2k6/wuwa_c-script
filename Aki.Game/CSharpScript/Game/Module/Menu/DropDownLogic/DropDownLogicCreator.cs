using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004452 RID: 17490
	public class DropDownLogicCreator : IStaticVariableResetter
	{
		// Token: 0x0602C206 RID: 180742 RVA: 0x00C64E8F File Offset: 0x00C6308F
		static DropDownLogicCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropDownLogicCreator.CreateStaticDefaultValue), new Action(DropDownLogicCreator.ResetStaticDefaultValue));
		}

		// Token: 0x0602C207 RID: 180743 RVA: 0x00C64EAE File Offset: 0x00C630AE
		public static void CreateStaticDefaultValue()
		{
			DropDownLogicCreator.LogicMap = new Dictionary<EFunction, DropDownLogicBase>
			{
				{
					EFunction.TEXTLANGUAGE,
					new LanguageLogic()
				},
				{
					EFunction.SkillLockEnemyMode,
					new SkillLockEnemyLogic()
				},
				{
					EFunction.RESOURCESTANDARD,
					new ResourceStandardLogic()
				}
			};
		}

		// Token: 0x0602C208 RID: 180744 RVA: 0x00C64EE7 File Offset: 0x00C630E7
		public static void ResetStaticDefaultValue()
		{
			DropDownLogicCreator.LogicMap = null;
		}

		// Token: 0x0602C209 RID: 180745 RVA: 0x00C64EF0 File Offset: 0x00C630F0
		[NullableContext(2)]
		public static DropDownLogicBase GetDropDownLogic(EFunction type)
		{
			DropDownLogicBase result;
			if (!DropDownLogicCreator.LogicMap.TryGetValue(type, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x04017C3D RID: 97341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EFunction, DropDownLogicBase> LogicMap;
	}
}
