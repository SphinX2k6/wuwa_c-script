using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x0200546F RID: 21615
	public class DropDownLogicCreator : IStaticVariableResetter
	{
		// Token: 0x060372BD RID: 225981 RVA: 0x00D15A77 File Offset: 0x00D13C77
		static DropDownLogicCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropDownLogicCreator.CreateStaticDefaultValue), new Action(DropDownLogicCreator.ResetStaticDefaultValue));
		}

		// Token: 0x060372BE RID: 225982 RVA: 0x00D15A96 File Offset: 0x00D13C96
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

		// Token: 0x060372BF RID: 225983 RVA: 0x00D15ACF File Offset: 0x00D13CCF
		public static void ResetStaticDefaultValue()
		{
			DropDownLogicCreator.LogicMap = null;
		}

		// Token: 0x060372C0 RID: 225984 RVA: 0x00D15AD8 File Offset: 0x00D13CD8
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

		// Token: 0x0401D1A4 RID: 119204
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EFunction, DropDownLogicBase> LogicMap;
	}
}
