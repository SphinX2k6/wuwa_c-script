using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA3 RID: 28323
	public interface IElementalFieldBlockTarget
	{
		// Token: 0x17009A79 RID: 39545
		// (get) Token: 0x06045029 RID: 282665
		// (set) Token: 0x0604502A RID: 282666
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

		// Token: 0x17009A7A RID: 39546
		// (get) Token: 0x0604502B RID: 282667
		// (set) Token: 0x0604502C RID: 282668
		ECollisionChannel TargetChannel { get; set; }
	}
}
