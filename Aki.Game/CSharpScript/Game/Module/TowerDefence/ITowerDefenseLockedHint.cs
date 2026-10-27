using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B46 RID: 19270
	[NullableContext(1)]
	public interface ITowerDefenseLockedHint
	{
		// Token: 0x17007BD5 RID: 31701
		// (get) Token: 0x06031E71 RID: 204401
		// (set) Token: 0x06031E72 RID: 204402
		string TextId { get; set; }

		// Token: 0x17007BD6 RID: 31702
		// (get) Token: 0x06031E73 RID: 204403
		// (set) Token: 0x06031E74 RID: 204404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		string[] Args { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
