using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005ECD RID: 24269
	public class MatTypeDes : IStaticVariableResetter
	{
		// Token: 0x0603DB40 RID: 252736 RVA: 0x00EE5E3C File Offset: 0x00EE403C
		static MatTypeDes()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatTypeDes.CreateStaticDefaultValue), new Action(MatTypeDes.ResetStaticDefaultValue));
		}

		// Token: 0x17008EE0 RID: 36576
		// (get) Token: 0x0603DB41 RID: 252737 RVA: 0x00EE5E5B File Offset: 0x00EE405B
		[Nullable(1)]
		public static Dictionary<EMatType, string> Values
		{
			[NullableContext(1)]
			get
			{
				return MatTypeDes._values;
			}
		}

		// Token: 0x0603DB42 RID: 252738 RVA: 0x00EE5E62 File Offset: 0x00EE4062
		public static void CreateStaticDefaultValue()
		{
			Dictionary<EMatType, string> dictionary = new Dictionary<EMatType, string>();
			dictionary[EMatType.All] = "AdventureMatType_All";
			dictionary[EMatType.Weapon] = "AdventureMatType_Weapon";
			dictionary[EMatType.Character] = "AdventureMatType_Character";
			dictionary[EMatType.Experience] = "AdventureMatType_Experience";
			MatTypeDes._values = dictionary;
		}

		// Token: 0x0603DB43 RID: 252739 RVA: 0x00EE5E9E File Offset: 0x00EE409E
		public static void ResetStaticDefaultValue()
		{
			MatTypeDes._values = null;
		}

		// Token: 0x0402035E RID: 131934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EMatType, string> _values;
	}
}
