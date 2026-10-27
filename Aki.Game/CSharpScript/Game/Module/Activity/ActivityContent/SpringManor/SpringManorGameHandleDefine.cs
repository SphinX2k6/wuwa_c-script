using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006030 RID: 24624
	public class SpringManorGameHandleDefine : IStaticVariableResetter
	{
		// Token: 0x0603E50E RID: 255246 RVA: 0x00F0CC52 File Offset: 0x00F0AE52
		static SpringManorGameHandleDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorGameHandleDefine.CreateStaticDefaultValue), new Action(SpringManorGameHandleDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603E50F RID: 255247 RVA: 0x00F0CC71 File Offset: 0x00F0AE71
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

		// Token: 0x0603E510 RID: 255248 RVA: 0x00F0CCAD File Offset: 0x00F0AEAD
		public static void ResetStaticDefaultValue()
		{
			SpringManorGameHandleDefine.springManorGameHandleDefine = null;
		}

		// Token: 0x0402090A RID: 133386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<ESpringFunctionType, SpringManorGameHandleBase> springManorGameHandleDefine;
	}
}
