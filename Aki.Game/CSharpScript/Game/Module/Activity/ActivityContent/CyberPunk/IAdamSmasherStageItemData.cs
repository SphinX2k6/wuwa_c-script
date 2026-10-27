using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068B3 RID: 26803
	[NullableContext(1)]
	public interface IAdamSmasherStageItemData
	{
		// Token: 0x170097C8 RID: 38856
		// (get) Token: 0x06042E50 RID: 274000
		int StageId { get; }

		// Token: 0x170097C9 RID: 38857
		// (get) Token: 0x06042E51 RID: 274001
		string IndexText { get; }

		// Token: 0x170097CA RID: 38858
		// (get) Token: 0x06042E52 RID: 274002
		string Name { get; }

		// Token: 0x170097CB RID: 38859
		// (get) Token: 0x06042E53 RID: 274003
		bool IsUnlocked { get; }

		// Token: 0x170097CC RID: 38860
		// (get) Token: 0x06042E54 RID: 274004
		bool IsHard { get; }
	}
}
