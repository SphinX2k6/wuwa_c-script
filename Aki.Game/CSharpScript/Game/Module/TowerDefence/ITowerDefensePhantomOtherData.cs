using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B33 RID: 19251
	[NullableContext(1)]
	public interface ITowerDefensePhantomOtherData
	{
		// Token: 0x17007B79 RID: 31609
		// (get) Token: 0x06031DAF RID: 204207
		// (set) Token: 0x06031DB0 RID: 204208
		string NameTextId { get; set; }

		// Token: 0x17007B7A RID: 31610
		// (get) Token: 0x06031DB1 RID: 204209
		// (set) Token: 0x06031DB2 RID: 204210
		string TypeTextId { get; set; }

		// Token: 0x17007B7B RID: 31611
		// (get) Token: 0x06031DB3 RID: 204211
		// (set) Token: 0x06031DB4 RID: 204212
		string TypeIconPath { get; set; }

		// Token: 0x17007B7C RID: 31612
		// (get) Token: 0x06031DB5 RID: 204213
		// (set) Token: 0x06031DB6 RID: 204214
		bool IsLocked { get; set; }
	}
}
