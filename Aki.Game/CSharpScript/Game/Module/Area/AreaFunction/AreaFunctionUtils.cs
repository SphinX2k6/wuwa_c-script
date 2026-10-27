using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Area.AreaFunction
{
	// Token: 0x02005EA8 RID: 24232
	public static class AreaFunctionUtils
	{
		// Token: 0x0603DA8D RID: 252557 RVA: 0x00EE39AC File Offset: 0x00EE1BAC
		[NullableContext(2)]
		public static Entity GetLocalRoleEntity()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return null;
			}
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				return null;
			}
			return characterActorComponent.Entity;
		}
	}
}
