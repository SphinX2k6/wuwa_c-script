using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004330 RID: 17200
	[NullableContext(1)]
	public interface IRemainingData
	{
		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x0602B6E7 RID: 177895
		// (set) Token: 0x0602B6E8 RID: 177896
		string TextId { get; set; }

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x0602B6E9 RID: 177897
		// (set) Token: 0x0602B6EA RID: 177898
		int Count { get; set; }
	}
}
