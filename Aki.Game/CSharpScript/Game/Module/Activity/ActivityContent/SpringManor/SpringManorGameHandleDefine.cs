using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FAE RID: 20398
	public class SpringManorGameHandleDefine : IStaticVariableResetter
	{
		// Token: 0x060331D2 RID: 209362 RVA: 0x00E53A18 File Offset: 0x00E51C18
		static SpringManorGameHandleDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorGameHandleDefine.CreateStaticDefaultValue), new Action(SpringManorGameHandleDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060331D3 RID: 209363 RVA: 0x00E53A37 File Offset: 0x00E51C37
		public static void CreateStaticDefaultValue()
		{
			SpringManorGameHandleDefine.springManorGameHandleDefine = new Dictionary<ESpringFunctionType, SpringManorGameHandleBase>
			{
				{
					ESpringFunctionType.Card,
					new SpringManorGuessJokerHandle()
				},
				{
					ESpringFunctionType.Drink,
					new SpringManorDrinkHandle()
				},
				{
					ESpringFunctionType.Publicity,
					new SpringManorBrochureHandle()
				},
				{
					ESpringFunctionType.Draw,
					new SpringManorDrawHandle()
				}
			};
		}

		// Token: 0x060331D4 RID: 209364 RVA: 0x00E53A73 File Offset: 0x00E51C73
		public static void ResetStaticDefaultValue()
		{
			SpringManorGameHandleDefine.springManorGameHandleDefine = null;
		}

		// Token: 0x0401B237 RID: 111159
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<ESpringFunctionType, SpringManorGameHandleBase> springManorGameHandleDefine;
	}
}
