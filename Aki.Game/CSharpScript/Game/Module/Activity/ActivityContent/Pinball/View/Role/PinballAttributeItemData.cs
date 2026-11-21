using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005280 RID: 21120
	public class PinballAttributeItemData : IPinballAttributeItemData
	{
		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x06034932 RID: 215346 RVA: 0x00EB5483 File Offset: 0x00EB3683
		// (set) Token: 0x06034933 RID: 215347 RVA: 0x00EB548B File Offset: 0x00EB368B
		public bool IsBgShow { get; set; }

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x06034934 RID: 215348 RVA: 0x00EB5494 File Offset: 0x00EB3694
		// (set) Token: 0x06034935 RID: 215349 RVA: 0x00EB549C File Offset: 0x00EB369C
		public PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x06034936 RID: 215350 RVA: 0x00EB54A5 File Offset: 0x00EB36A5
		// (set) Token: 0x06034937 RID: 215351 RVA: 0x00EB54AD File Offset: 0x00EB36AD
		public int AttributeValue { get; set; }
	}
}
