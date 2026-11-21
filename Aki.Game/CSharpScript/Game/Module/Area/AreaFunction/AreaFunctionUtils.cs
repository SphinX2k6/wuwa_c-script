using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Area.AreaFunction
{
	// Token: 0x02004E8D RID: 20109
	public static class AreaFunctionUtils
	{
		// Token: 0x06032A1D RID: 207389 RVA: 0x00E34EF8 File Offset: 0x00E330F8
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
