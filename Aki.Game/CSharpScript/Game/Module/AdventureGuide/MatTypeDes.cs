using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004EB2 RID: 20146
	public class MatTypeDes : IStaticVariableResetter
	{
		// Token: 0x06032AD0 RID: 207568 RVA: 0x00E37388 File Offset: 0x00E35588
		static MatTypeDes()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MatTypeDes.CreateStaticDefaultValue), new Action(MatTypeDes.ResetStaticDefaultValue));
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x06032AD1 RID: 207569 RVA: 0x00E373A7 File Offset: 0x00E355A7
		[Nullable(1)]
		public static Dictionary<EMatType, string> Values
		{
			[NullableContext(1)]
			get
			{
				return MatTypeDes._values;
			}
		}

		// Token: 0x06032AD2 RID: 207570 RVA: 0x00E373AE File Offset: 0x00E355AE
		public static void CreateStaticDefaultValue()
		{
			Dictionary<EMatType, string> dictionary = new Dictionary<EMatType, string>();
			dictionary[EMatType.All] = "AdventureMatType_All";
			dictionary[EMatType.Weapon] = "AdventureMatType_Weapon";
			dictionary[EMatType.Character] = "AdventureMatType_Character";
			dictionary[EMatType.Experience] = "AdventureMatType_Experience";
			MatTypeDes._values = dictionary;
		}

		// Token: 0x06032AD3 RID: 207571 RVA: 0x00E373EA File Offset: 0x00E355EA
		public static void ResetStaticDefaultValue()
		{
			MatTypeDes._values = null;
		}

		// Token: 0x0401AE25 RID: 110117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EMatType, string> _values;
	}
}
