using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E7B RID: 28283
	public class NpcElementalDetectableComponent : BaseElementalDetectableComponent
	{
		// Token: 0x06044EDB RID: 282331 RVA: 0x01106C39 File Offset: 0x01104E39
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			NpcElementalDetectableComponent npcElementalDetectableComponent = (NpcElementalDetectableComponent)componentTemplate;
			return true;
		}
	}
}
