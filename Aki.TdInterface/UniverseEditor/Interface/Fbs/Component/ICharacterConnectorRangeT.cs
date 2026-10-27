using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F86 RID: 20358
	public class ICharacterConnectorRangeT
	{
		// Token: 0x17009325 RID: 37669
		// (get) Token: 0x0602053B RID: 132411 RVA: 0x0047F6A4 File Offset: 0x0047D8A4
		// (set) Token: 0x0602053C RID: 132412 RVA: 0x0047F6AC File Offset: 0x0047D8AC
		public ECharacterConnectorLogicType Type { get; set; }

		// Token: 0x17009326 RID: 37670
		// (get) Token: 0x0602053D RID: 132413 RVA: 0x0047F6B5 File Offset: 0x0047D8B5
		// (set) Token: 0x0602053E RID: 132414 RVA: 0x0047F6BD File Offset: 0x0047D8BD
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x17009327 RID: 37671
		// (get) Token: 0x0602053F RID: 132415 RVA: 0x0047F6C6 File Offset: 0x0047D8C6
		// (set) Token: 0x06020540 RID: 132416 RVA: 0x0047F6CE File Offset: 0x0047D8CE
		public int EnterRange { get; set; }

		// Token: 0x17009328 RID: 37672
		// (get) Token: 0x06020541 RID: 132417 RVA: 0x0047F6D7 File Offset: 0x0047D8D7
		// (set) Token: 0x06020542 RID: 132418 RVA: 0x0047F6DF File Offset: 0x0047D8DF
		public int LeaveRange { get; set; }

		// Token: 0x17009329 RID: 37673
		// (get) Token: 0x06020543 RID: 132419 RVA: 0x0047F6E8 File Offset: 0x0047D8E8
		// (set) Token: 0x06020544 RID: 132420 RVA: 0x0047F6F0 File Offset: 0x0047D8F0
		public List<int> TagConditions { get; set; }

		// Token: 0x1700932A RID: 37674
		// (get) Token: 0x06020545 RID: 132421 RVA: 0x0047F6F9 File Offset: 0x0047D8F9
		// (set) Token: 0x06020546 RID: 132422 RVA: 0x0047F701 File Offset: 0x0047D901
		public List<IDynamicEntityMatchT> MatchConditions { get; set; }

		// Token: 0x1700932B RID: 37675
		// (get) Token: 0x06020547 RID: 132423 RVA: 0x0047F70A File Offset: 0x0047D90A
		// (set) Token: 0x06020548 RID: 132424 RVA: 0x0047F712 File Offset: 0x0047D912
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x1700932C RID: 37676
		// (get) Token: 0x06020549 RID: 132425 RVA: 0x0047F71B File Offset: 0x0047D91B
		// (set) Token: 0x0602054A RID: 132426 RVA: 0x0047F723 File Offset: 0x0047D923
		public byte NullMask { get; set; }

		// Token: 0x0602054B RID: 132427 RVA: 0x0047F72C File Offset: 0x0047D92C
		public ICharacterConnectorRangeT()
		{
			this.Type = ECharacterConnectorLogicType.Range;
			this.EffectConfig = null;
			this.EnterRange = 0;
			this.LeaveRange = 0;
			this.TagConditions = null;
			this.MatchConditions = null;
			this.KeepConditions = null;
			this.NullMask = 0;
		}
	}
}
