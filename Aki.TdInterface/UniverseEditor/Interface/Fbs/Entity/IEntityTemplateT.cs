using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Editor;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C3E RID: 19518
	public class IEntityTemplateT
	{
		// Token: 0x17008A75 RID: 35445
		// (get) Token: 0x0601DED4 RID: 122580 RVA: 0x00432724 File Offset: 0x00430924
		// (set) Token: 0x0601DED5 RID: 122581 RVA: 0x0043272C File Offset: 0x0043092C
		public string ObjType { get; set; }

		// Token: 0x17008A76 RID: 35446
		// (get) Token: 0x0601DED6 RID: 122582 RVA: 0x00432735 File Offset: 0x00430935
		// (set) Token: 0x0601DED7 RID: 122583 RVA: 0x0043273D File Offset: 0x0043093D
		public List<string> Children { get; set; }

		// Token: 0x17008A77 RID: 35447
		// (get) Token: 0x0601DED8 RID: 122584 RVA: 0x00432746 File Offset: 0x00430946
		// (set) Token: 0x0601DED9 RID: 122585 RVA: 0x0043274E File Offset: 0x0043094E
		public List<string> Reference { get; set; }

		// Token: 0x17008A78 RID: 35448
		// (get) Token: 0x0601DEDA RID: 122586 RVA: 0x00432757 File Offset: 0x00430957
		// (set) Token: 0x0601DEDB RID: 122587 RVA: 0x0043275F File Offset: 0x0043095F
		public List<string> WeakReference { get; set; }

		// Token: 0x17008A79 RID: 35449
		// (get) Token: 0x0601DEDC RID: 122588 RVA: 0x00432768 File Offset: 0x00430968
		// (set) Token: 0x0601DEDD RID: 122589 RVA: 0x00432770 File Offset: 0x00430970
		public string Name { get; set; }

		// Token: 0x17008A7A RID: 35450
		// (get) Token: 0x0601DEDE RID: 122590 RVA: 0x00432779 File Offset: 0x00430979
		// (set) Token: 0x0601DEDF RID: 122591 RVA: 0x00432781 File Offset: 0x00430981
		public string BlueprintType { get; set; }

		// Token: 0x17008A7B RID: 35451
		// (get) Token: 0x0601DEE0 RID: 122592 RVA: 0x0043278A File Offset: 0x0043098A
		// (set) Token: 0x0601DEE1 RID: 122593 RVA: 0x00432792 File Offset: 0x00430992
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x17008A7C RID: 35452
		// (get) Token: 0x0601DEE2 RID: 122594 RVA: 0x0043279B File Offset: 0x0043099B
		// (set) Token: 0x0601DEE3 RID: 122595 RVA: 0x004327A3 File Offset: 0x004309A3
		public int Id { get; set; }

		// Token: 0x17008A7D RID: 35453
		// (get) Token: 0x0601DEE4 RID: 122596 RVA: 0x004327AC File Offset: 0x004309AC
		// (set) Token: 0x0601DEE5 RID: 122597 RVA: 0x004327B4 File Offset: 0x004309B4
		public string BpPath { get; set; }

		// Token: 0x17008A7E RID: 35454
		// (get) Token: 0x0601DEE6 RID: 122598 RVA: 0x004327BD File Offset: 0x004309BD
		// (set) Token: 0x0601DEE7 RID: 122599 RVA: 0x004327C5 File Offset: 0x004309C5
		public EEntity EntityType { get; set; }

		// Token: 0x17008A7F RID: 35455
		// (get) Token: 0x0601DEE8 RID: 122600 RVA: 0x004327CE File Offset: 0x004309CE
		// (set) Token: 0x0601DEE9 RID: 122601 RVA: 0x004327D6 File Offset: 0x004309D6
		public IWorldEditorTemplateConfigT WorldEditorTemplateConfig { get; set; }

		// Token: 0x17008A80 RID: 35456
		// (get) Token: 0x0601DEEA RID: 122602 RVA: 0x004327DF File Offset: 0x004309DF
		// (set) Token: 0x0601DEEB RID: 122603 RVA: 0x004327E7 File Offset: 0x004309E7
		public EDevelopmentStatus DevelopmentStatus { get; set; }

		// Token: 0x17008A81 RID: 35457
		// (get) Token: 0x0601DEEC RID: 122604 RVA: 0x004327F0 File Offset: 0x004309F0
		// (set) Token: 0x0601DEED RID: 122605 RVA: 0x004327F8 File Offset: 0x004309F8
		public byte NullMask { get; set; }

		// Token: 0x0601DEEE RID: 122606 RVA: 0x00432804 File Offset: 0x00430A04
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
