using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x020052A6 RID: 21158
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterRiskTypeTitleGridData : IMultiTemplateGridData<PinballMonsterRiskType, PinballMonsterRiskTypeTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x06034AA1 RID: 215713 RVA: 0x00EBB062 File Offset: 0x00EB9262
		// (set) Token: 0x06034AA2 RID: 215714 RVA: 0x00EBB06A File Offset: 0x00EB926A
		public PinballMonsterRiskType Data { get; set; }

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x06034AA3 RID: 215715 RVA: 0x00EBB073 File Offset: 0x00EB9273
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x06034AA4 RID: 215716 RVA: 0x00EBB080 File Offset: 0x00EB9280
		public PinballMonsterRiskTypeTitleGridData(PinballMonsterRiskType data)
		{
			this.Data = data;
		}

		// Token: 0x06034AA5 RID: 215717 RVA: 0x00EBB08F File Offset: 0x00EB928F
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x06034AA6 RID: 215718 RVA: 0x00EBB092 File Offset: 0x00EB9292
		public PinballMonsterRiskTypeTitleItem CreateProxy()
		{
			return new PinballMonsterRiskTypeTitleItem();
		}

		// Token: 0x06034AA7 RID: 215719 RVA: 0x00EBB099 File Offset: 0x00EB9299
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
