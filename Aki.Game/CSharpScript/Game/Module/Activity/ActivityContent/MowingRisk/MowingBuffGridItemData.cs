using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533C RID: 21308
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffGridItemData : IMowingBuffGridItemData
	{
		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x06035091 RID: 217233 RVA: 0x00ED2707 File Offset: 0x00ED0907
		// (set) Token: 0x06035092 RID: 217234 RVA: 0x00ED270F File Offset: 0x00ED090F
		public int BuffId { get; set; }

		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x06035093 RID: 217235 RVA: 0x00ED2718 File Offset: 0x00ED0918
		// (set) Token: 0x06035094 RID: 217236 RVA: 0x00ED2720 File Offset: 0x00ED0920
		public string QualityPath { get; set; }

		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x06035095 RID: 217237 RVA: 0x00ED2729 File Offset: 0x00ED0929
		// (set) Token: 0x06035096 RID: 217238 RVA: 0x00ED2731 File Offset: 0x00ED0931
		public string IconPath { get; set; }

		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x06035097 RID: 217239 RVA: 0x00ED273A File Offset: 0x00ED093A
		// (set) Token: 0x06035098 RID: 217240 RVA: 0x00ED2742 File Offset: 0x00ED0942
		public string NameTextId { get; set; }

		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x06035099 RID: 217241 RVA: 0x00ED274B File Offset: 0x00ED094B
		// (set) Token: 0x0603509A RID: 217242 RVA: 0x00ED2753 File Offset: 0x00ED0953
		public bool IsShowBackground { get; set; }

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x0603509B RID: 217243 RVA: 0x00ED275C File Offset: 0x00ED095C
		// (set) Token: 0x0603509C RID: 217244 RVA: 0x00ED2764 File Offset: 0x00ED0964
		public bool IsChosen { get; set; }

		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x0603509D RID: 217245 RVA: 0x00ED276D File Offset: 0x00ED096D
		// (set) Token: 0x0603509E RID: 217246 RVA: 0x00ED2775 File Offset: 0x00ED0975
		public bool IsUnlock { get; set; }

		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x0603509F RID: 217247 RVA: 0x00ED277E File Offset: 0x00ED097E
		// (set) Token: 0x060350A0 RID: 217248 RVA: 0x00ED2786 File Offset: 0x00ED0986
		public string LevelContent { get; set; }
	}
}
