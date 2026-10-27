using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C2 RID: 25538
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailData : IMowingRiskInstanceDetailData
	{
		// Token: 0x170093C9 RID: 37833
		// (get) Token: 0x060403F2 RID: 263154 RVA: 0x00F8B829 File Offset: 0x00F89A29
		// (set) Token: 0x060403F3 RID: 263155 RVA: 0x00F8B831 File Offset: 0x00F89A31
		public string TitleTextId { get; set; }

		// Token: 0x170093CA RID: 37834
		// (get) Token: 0x060403F4 RID: 263156 RVA: 0x00F8B83A File Offset: 0x00F89A3A
		// (set) Token: 0x060403F5 RID: 263157 RVA: 0x00F8B842 File Offset: 0x00F89A42
		public string ContentTextId { get; set; }

		// Token: 0x170093CB RID: 37835
		// (get) Token: 0x060403F6 RID: 263158 RVA: 0x00F8B84B File Offset: 0x00F89A4B
		// (set) Token: 0x060403F7 RID: 263159 RVA: 0x00F8B853 File Offset: 0x00F89A53
		public IMowingRiskInstanceDetailAttributeItemData[] AttributeList { get; set; }

		// Token: 0x170093CC RID: 37836
		// (get) Token: 0x060403F8 RID: 263160 RVA: 0x00F8B85C File Offset: 0x00F89A5C
		// (set) Token: 0x060403F9 RID: 263161 RVA: 0x00F8B864 File Offset: 0x00F89A64
		public IMowingRiskInstanceDetailLockItemData LockData { get; set; }
	}
}
