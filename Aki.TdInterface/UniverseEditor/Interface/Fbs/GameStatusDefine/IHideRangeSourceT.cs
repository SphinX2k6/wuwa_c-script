using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046FB RID: 18171
	public class IHideRangeSourceT
	{
		// Token: 0x170081F1 RID: 33265
		// (get) Token: 0x0601BD47 RID: 113991 RVA: 0x003F1BF0 File Offset: 0x003EFDF0
		// (set) Token: 0x0601BD48 RID: 113992 RVA: 0x003F1BF8 File Offset: 0x003EFDF8
		public TBehaviorTreeType TreeType { get; set; }

		// Token: 0x170081F2 RID: 33266
		// (get) Token: 0x0601BD49 RID: 113993 RVA: 0x003F1C01 File Offset: 0x003EFE01
		// (set) Token: 0x0601BD4A RID: 113994 RVA: 0x003F1C09 File Offset: 0x003EFE09
		public int TreeId { get; set; }

		// Token: 0x170081F3 RID: 33267
		// (get) Token: 0x0601BD4B RID: 113995 RVA: 0x003F1C12 File Offset: 0x003EFE12
		// (set) Token: 0x0601BD4C RID: 113996 RVA: 0x003F1C1A File Offset: 0x003EFE1A
		public int LevelId { get; set; }

		// Token: 0x170081F4 RID: 33268
		// (get) Token: 0x0601BD4D RID: 113997 RVA: 0x003F1C23 File Offset: 0x003EFE23
		// (set) Token: 0x0601BD4E RID: 113998 RVA: 0x003F1C2B File Offset: 0x003EFE2B
		public int NodeId { get; set; }

		// Token: 0x170081F5 RID: 33269
		// (get) Token: 0x0601BD4F RID: 113999 RVA: 0x003F1C34 File Offset: 0x003EFE34
		// (set) Token: 0x0601BD50 RID: 114000 RVA: 0x003F1C3C File Offset: 0x003EFE3C
		public int ActionId { get; set; }

		// Token: 0x170081F6 RID: 33270
		// (get) Token: 0x0601BD51 RID: 114001 RVA: 0x003F1C45 File Offset: 0x003EFE45
		// (set) Token: 0x0601BD52 RID: 114002 RVA: 0x003F1C4D File Offset: 0x003EFE4D
		public byte NullMask { get; set; }

		// Token: 0x0601BD53 RID: 114003 RVA: 0x003F1C56 File Offset: 0x003EFE56
		public IHideRangeSourceT()
		{
			this.TreeType = TBehaviorTreeType.BehaviorTreeFragment;
			this.TreeId = 0;
			this.LevelId = 0;
			this.NodeId = 0;
			this.ActionId = 0;
			this.NullMask = 0;
		}
	}
}
