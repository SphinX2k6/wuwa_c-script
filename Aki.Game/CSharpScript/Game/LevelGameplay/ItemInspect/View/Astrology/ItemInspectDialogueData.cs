using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F68 RID: 24424
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ItemInspectDialogueData
	{
		// Token: 0x17006EDC RID: 28380
		// (get) Token: 0x0603ABAC RID: 240556 RVA: 0x0109AB57 File Offset: 0x01098D57
		// (set) Token: 0x0603ABAD RID: 240557 RVA: 0x0109AB5F File Offset: 0x01098D5F
		[RequiredMember]
		public string TextKey { get; set; }

		// Token: 0x17006EDD RID: 28381
		// (get) Token: 0x0603ABAE RID: 240558 RVA: 0x0109AB68 File Offset: 0x01098D68
		// (set) Token: 0x0603ABAF RID: 240559 RVA: 0x0109AB70 File Offset: 0x01098D70
		[Nullable(2)]
		public ITalkItem VoiceTalkItem { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0603ABB0 RID: 240560 RVA: 0x0109AB79 File Offset: 0x01098D79
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ItemInspectDialogueData()
		{
		}
	}
}
