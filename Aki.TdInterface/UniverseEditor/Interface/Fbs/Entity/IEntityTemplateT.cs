using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Editor;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D6 RID: 18390
	public class IEntityTemplateT
	{
		// Token: 0x1700842A RID: 33834
		// (get) Token: 0x0601C6D7 RID: 116439 RVA: 0x00405DD4 File Offset: 0x00403FD4
		// (set) Token: 0x0601C6D8 RID: 116440 RVA: 0x00405DDC File Offset: 0x00403FDC
		public string ObjType { get; set; }

		// Token: 0x1700842B RID: 33835
		// (get) Token: 0x0601C6D9 RID: 116441 RVA: 0x00405DE5 File Offset: 0x00403FE5
		// (set) Token: 0x0601C6DA RID: 116442 RVA: 0x00405DED File Offset: 0x00403FED
		public List<string> Children { get; set; }

		// Token: 0x1700842C RID: 33836
		// (get) Token: 0x0601C6DB RID: 116443 RVA: 0x00405DF6 File Offset: 0x00403FF6
		// (set) Token: 0x0601C6DC RID: 116444 RVA: 0x00405DFE File Offset: 0x00403FFE
		public List<string> Reference { get; set; }

		// Token: 0x1700842D RID: 33837
		// (get) Token: 0x0601C6DD RID: 116445 RVA: 0x00405E07 File Offset: 0x00404007
		// (set) Token: 0x0601C6DE RID: 116446 RVA: 0x00405E0F File Offset: 0x0040400F
		public List<string> WeakReference { get; set; }

		// Token: 0x1700842E RID: 33838
		// (get) Token: 0x0601C6DF RID: 116447 RVA: 0x00405E18 File Offset: 0x00404018
		// (set) Token: 0x0601C6E0 RID: 116448 RVA: 0x00405E20 File Offset: 0x00404020
		public string Name { get; set; }

		// Token: 0x1700842F RID: 33839
		// (get) Token: 0x0601C6E1 RID: 116449 RVA: 0x00405E29 File Offset: 0x00404029
		// (set) Token: 0x0601C6E2 RID: 116450 RVA: 0x00405E31 File Offset: 0x00404031
		public string BlueprintType { get; set; }

		// Token: 0x17008430 RID: 33840
		// (get) Token: 0x0601C6E3 RID: 116451 RVA: 0x00405E3A File Offset: 0x0040403A
		// (set) Token: 0x0601C6E4 RID: 116452 RVA: 0x00405E42 File Offset: 0x00404042
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x17008431 RID: 33841
		// (get) Token: 0x0601C6E5 RID: 116453 RVA: 0x00405E4B File Offset: 0x0040404B
		// (set) Token: 0x0601C6E6 RID: 116454 RVA: 0x00405E53 File Offset: 0x00404053
		public int Id { get; set; }

		// Token: 0x17008432 RID: 33842
		// (get) Token: 0x0601C6E7 RID: 116455 RVA: 0x00405E5C File Offset: 0x0040405C
		// (set) Token: 0x0601C6E8 RID: 116456 RVA: 0x00405E64 File Offset: 0x00404064
		public string BpPath { get; set; }

		// Token: 0x17008433 RID: 33843
		// (get) Token: 0x0601C6E9 RID: 116457 RVA: 0x00405E6D File Offset: 0x0040406D
		// (set) Token: 0x0601C6EA RID: 116458 RVA: 0x00405E75 File Offset: 0x00404075
		public EEntity EntityType { get; set; }

		// Token: 0x17008434 RID: 33844
		// (get) Token: 0x0601C6EB RID: 116459 RVA: 0x00405E7E File Offset: 0x0040407E
		// (set) Token: 0x0601C6EC RID: 116460 RVA: 0x00405E86 File Offset: 0x00404086
		public IWorldEditorTemplateConfigT WorldEditorTemplateConfig { get; set; }

		// Token: 0x17008435 RID: 33845
		// (get) Token: 0x0601C6ED RID: 116461 RVA: 0x00405E8F File Offset: 0x0040408F
		// (set) Token: 0x0601C6EE RID: 116462 RVA: 0x00405E97 File Offset: 0x00404097
		public EDevelopmentStatus DevelopmentStatus { get; set; }

		// Token: 0x17008436 RID: 33846
		// (get) Token: 0x0601C6EF RID: 116463 RVA: 0x00405EA0 File Offset: 0x004040A0
		// (set) Token: 0x0601C6F0 RID: 116464 RVA: 0x00405EA8 File Offset: 0x004040A8
		public byte NullMask { get; set; }

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x00405EB4 File Offset: 0x004040B4
		public IEntityTemplateT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Name = null;
			this.BlueprintType = null;
			this.ComponentsData = null;
			this.Id = 0;
			this.BpPath = null;
			this.EntityType = EEntity.CharacterEntity;
			this.WorldEditorTemplateConfig = null;
			this.DevelopmentStatus = EDevelopmentStatus.Developing;
			this.NullMask = 0;
		}
	}
}
