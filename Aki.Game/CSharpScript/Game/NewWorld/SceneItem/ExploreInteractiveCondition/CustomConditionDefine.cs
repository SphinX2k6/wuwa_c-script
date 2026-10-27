using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020071FD RID: 29181
	public class CustomConditionDefine : IStaticVariableResetter
	{
		// Token: 0x060476C8 RID: 292552 RVA: 0x0122F63C File Offset: 0x0122D83C
		[NullableContext(1)]
		public static CustomConditionListener CreateConditionListener(CustomConditionDefine.ECustomConditionType type, Action<bool> onConditionChange)
		{
			return CustomConditionDefine._customConditionMap[type](onConditionChange);
		}

		// Token: 0x060476C9 RID: 292553 RVA: 0x0122F64F File Offset: 0x0122D84F
		static CustomConditionDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CustomConditionDefine.CreateStaticDefaultValue), new Action(CustomConditionDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060476CA RID: 292554 RVA: 0x0122F66E File Offset: 0x0122D86E
		public static void CreateStaticDefaultValue()
		{
			Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>> dictionary = new Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>>();
			dictionary.Add(CustomConditionDefine.ECustomConditionType.QuantumDiffusion, (Action<bool> onConditionChange) => new QuantumDiffusionConditionListener(onConditionChange));
			CustomConditionDefine._customConditionMap = dictionary;
		}

		// Token: 0x060476CB RID: 292555 RVA: 0x0122F6A0 File Offset: 0x0122D8A0
		public static void ResetStaticDefaultValue()
		{
			CustomConditionDefine._customConditionMap = null;
		}

		// Token: 0x04025905 RID: 153861
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<CustomConditionDefine.ECustomConditionType, Func<Action<bool>, CustomConditionListener>> _customConditionMap;

		// Token: 0x0200CF34 RID: 53044
		public enum ECustomConditionType
		{
			// Token: 0x0403E4D7 RID: 255191
			QuantumDiffusion
		}
	}
}
