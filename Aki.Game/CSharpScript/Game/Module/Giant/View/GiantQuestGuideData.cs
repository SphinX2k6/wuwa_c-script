using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200598A RID: 22922
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GiantQuestGuideData : IGiantQuestGuideData
	{
		// Token: 0x17008B64 RID: 35684
		// (get) Token: 0x0603A29C RID: 238236 RVA: 0x00DD3897 File Offset: 0x00DD1A97
		// (set) Token: 0x0603A29D RID: 238237 RVA: 0x00DD389F File Offset: 0x00DD1A9F
		[RequiredMember]
		public int AccessId { get; set; }

		// Token: 0x17008B65 RID: 35685
		// (get) Token: 0x0603A29E RID: 238238 RVA: 0x00DD38A8 File Offset: 0x00DD1AA8
		// (set) Token: 0x0603A29F RID: 238239 RVA: 0x00DD38B0 File Offset: 0x00DD1AB0
		[RequiredMember]
		public List<int> GroupAccessIds { get; set; }

		// Token: 0x17008B66 RID: 35686
		// (get) Token: 0x0603A2A0 RID: 238240 RVA: 0x00DD38B9 File Offset: 0x00DD1AB9
		// (set) Token: 0x0603A2A1 RID: 238241 RVA: 0x00DD38C1 File Offset: 0x00DD1AC1
		[RequiredMember]
		public int SkipConfigId { get; set; }

		// Token: 0x17008B67 RID: 35687
		// (get) Token: 0x0603A2A2 RID: 238242 RVA: 0x00DD38CA File Offset: 0x00DD1ACA
		// (set) Token: 0x0603A2A3 RID: 238243 RVA: 0x00DD38D2 File Offset: 0x00DD1AD2
		[RequiredMember]
		public int AnchorItemId { get; set; }

		// Token: 0x17008B68 RID: 35688
		// (get) Token: 0x0603A2A4 RID: 238244 RVA: 0x00DD38DB File Offset: 0x00DD1ADB
		// (set) Token: 0x0603A2A5 RID: 238245 RVA: 0x00DD38E3 File Offset: 0x00DD1AE3
		[RequiredMember]
		public string DescText { get; set; }

		// Token: 0x17008B69 RID: 35689
		// (get) Token: 0x0603A2A6 RID: 238246 RVA: 0x00DD38EC File Offset: 0x00DD1AEC
		// (set) Token: 0x0603A2A7 RID: 238247 RVA: 0x00DD38F4 File Offset: 0x00DD1AF4
		[RequiredMember]
		public string LockedText { get; set; }

		// Token: 0x17008B6A RID: 35690
		// (get) Token: 0x0603A2A8 RID: 238248 RVA: 0x00DD38FD File Offset: 0x00DD1AFD
		// (set) Token: 0x0603A2A9 RID: 238249 RVA: 0x00DD3905 File Offset: 0x00DD1B05
		[RequiredMember]
		public EGiantQuestGuideState State { get; set; }

		// Token: 0x17008B6B RID: 35691
		// (get) Token: 0x0603A2AA RID: 238250 RVA: 0x00DD390E File Offset: 0x00DD1B0E
		// (set) Token: 0x0603A2AB RID: 238251 RVA: 0x00DD3916 File Offset: 0x00DD1B16
		[RequiredMember]
		public List<IGiantQuestGuideItemInfo> Items { get; set; }

		// Token: 0x17008B6C RID: 35692
		// (get) Token: 0x0603A2AC RID: 238252 RVA: 0x00DD391F File Offset: 0x00DD1B1F
		// (set) Token: 0x0603A2AD RID: 238253 RVA: 0x00DD3927 File Offset: 0x00DD1B27
		[RequiredMember]
		public bool HasNew { get; set; }

		// Token: 0x17008B6D RID: 35693
		// (get) Token: 0x0603A2AE RID: 238254 RVA: 0x00DD3930 File Offset: 0x00DD1B30
		// (set) Token: 0x0603A2AF RID: 238255 RVA: 0x00DD3938 File Offset: 0x00DD1B38
		[RequiredMember]
		public bool HasSkip { get; set; }

		// Token: 0x17008B6E RID: 35694
		// (get) Token: 0x0603A2B0 RID: 238256 RVA: 0x00DD3941 File Offset: 0x00DD1B41
		// (set) Token: 0x0603A2B1 RID: 238257 RVA: 0x00DD3949 File Offset: 0x00DD1B49
		[RequiredMember]
		public Action<IGiantQuestGuideData> OnGoto { get; set; }

		// Token: 0x0603A2B2 RID: 238258 RVA: 0x00DD3952 File Offset: 0x00DD1B52
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantQuestGuideData()
		{
		}
	}
}
