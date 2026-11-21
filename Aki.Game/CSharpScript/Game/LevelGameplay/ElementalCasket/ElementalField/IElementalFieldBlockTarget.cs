using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006023 RID: 24611
	public interface IElementalFieldBlockTarget
	{
		// Token: 0x17006FB0 RID: 28592
		// (get) Token: 0x0603B1CA RID: 242122
		// (set) Token: 0x0603B1CB RID: 242123
		[Nullable(new byte[]
		{
			1,
			2
		})]
		Func<UPrimitiveComponent, bool> IsBlockTarget { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17006FB1 RID: 28593
		// (get) Token: 0x0603B1CC RID: 242124
		// (set) Token: 0x0603B1CD RID: 242125
		ECollisionChannel TargetChannel { get; set; }
	}
}
