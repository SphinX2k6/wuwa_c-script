using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02006DE9 RID: 28137
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ItemInspectDialogueData
	{
		// Token: 0x170099D9 RID: 39385
		// (get) Token: 0x06044A48 RID: 281160 RVA: 0x010F090B File Offset: 0x010EEB0B
		// (set) Token: 0x06044A49 RID: 281161 RVA: 0x010F0913 File Offset: 0x010EEB13
		[RequiredMember]
		public string TextKey { get; set; }

		// Token: 0x170099DA RID: 39386
		// (get) Token: 0x06044A4A RID: 281162 RVA: 0x010F091C File Offset: 0x010EEB1C
		// (set) Token: 0x06044A4B RID: 281163 RVA: 0x010F0924 File Offset: 0x010EEB24
		[Nullable(2)]
		public ITalkItem VoiceTalkItem { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06044A4C RID: 281164 RVA: 0x010F092D File Offset: 0x010EEB2D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ItemInspectDialogueData()
		{
		}
	}
}
