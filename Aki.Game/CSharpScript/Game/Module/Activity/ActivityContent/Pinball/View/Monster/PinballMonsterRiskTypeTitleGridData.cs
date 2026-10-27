using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x02006328 RID: 25384
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMonsterRiskTypeTitleGridData : IMultiTemplateGridData<PinballMonsterRiskType, PinballMonsterRiskTypeTitleItem>, IMultiTemplateGridData
	{
		// Token: 0x170092F2 RID: 37618
		// (get) Token: 0x0603FDE0 RID: 261600 RVA: 0x00F74106 File Offset: 0x00F72306
		// (set) Token: 0x0603FDE1 RID: 261601 RVA: 0x00F7410E File Offset: 0x00F7230E
		public PinballMonsterRiskType Data { get; set; }

		// Token: 0x170092F3 RID: 37619
		// (get) Token: 0x0603FDE2 RID: 261602 RVA: 0x00F74117 File Offset: 0x00F72317
		object IMultiTemplateGridData.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0603FDE3 RID: 261603 RVA: 0x00F74124 File Offset: 0x00F72324
		public PinballMonsterRiskTypeTitleGridData(PinballMonsterRiskType data)
		{
			this.Data = data;
		}

		// Token: 0x0603FDE4 RID: 261604 RVA: 0x00F74133 File Offset: 0x00F72333
		public int GetTemplateIndex()
		{
			return 0;
		}

		// Token: 0x0603FDE5 RID: 261605 RVA: 0x00F74136 File Offset: 0x00F72336
		public PinballMonsterRiskTypeTitleItem CreateProxy()
		{
			return new PinballMonsterRiskTypeTitleItem();
		}

		// Token: 0x0603FDE6 RID: 261606 RVA: 0x00F7413D File Offset: 0x00F7233D
		ISyncGridProxy IMultiTemplateGridData.CreateProxy()
		{
			return this.CreateProxy();
		}
	}
}
