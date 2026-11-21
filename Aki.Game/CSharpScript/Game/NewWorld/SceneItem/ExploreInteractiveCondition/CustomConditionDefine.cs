using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020062B2 RID: 25266
	public class CustomConditionDefine : IStaticVariableResetter
	{
		// Token: 0x0603CFD0 RID: 249808 RVA: 0x011891FE File Offset: 0x011873FE
		[NullableContext(1)]
		public static CustomConditionListener CreateConditionListener(CustomConditionDefine.ECustomConditionType type, Action<bool> onConditionChange)
		{
			return CustomConditionDefine._customConditionMap[type](onConditionChange);
		}

		// Token: 0x0603CFD1 RID: 249809 RVA: 0x01189211 File Offset: 0x01187411
		static CustomConditionDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CustomConditionDefine.CreateStaticDefaultValue), new Action(CustomConditionDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603CFD2 RID: 249810 RVA: 0x01189230 File Offset: 0x01187430
		public static void CreateStaticDefaultValue()
		{
			Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>> dictionary = new Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>>();
			dictionary.Add(CustomConditionDefine.ECustomConditionType.QuantumDiffusion, (Action<bool> onConditionChange) => new QuantumDiffusionConditionListener(onConditionChange));
			CustomConditionDefine._customConditionMap = dictionary;
		}

		// Token: 0x0603CFD3 RID: 249811 RVA: 0x01189262 File Offset: 0x01187462
		public static void ResetStaticDefaultValue()
		{
			CustomConditionDefine._customConditionMap = null;
		}

		// Token: 0x04020574 RID: 132468
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>> _customConditionMap;

		// Token: 0x0200BAC9 RID: 47817
		public enum ECustomConditionType
		{
			// Token: 0x040397FC RID: 235516
			QuantumDiffusion
		}
	}
}
