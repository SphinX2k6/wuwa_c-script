using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F02 RID: 16130
	public class IVarDefineT
	{
		// Token: 0x17006D31 RID: 27953
		// (get) Token: 0x06015E33 RID: 89651 RVA: 0x00325F13 File Offset: 0x00324113
		// (set) Token: 0x06015E34 RID: 89652 RVA: 0x00325F1B File Offset: 0x0032411B
		public string Name { get; set; }

		// Token: 0x17006D32 RID: 27954
		// (get) Token: 0x06015E35 RID: 89653 RVA: 0x00325F24 File Offset: 0x00324124
		// (set) Token: 0x06015E36 RID: 89654 RVA: 0x00325F2C File Offset: 0x0032412C
		public EVar Type { get; set; }

		// Token: 0x17006D33 RID: 27955
		// (get) Token: 0x06015E37 RID: 89655 RVA: 0x00325F35 File Offset: 0x00324135
		// (set) Token: 0x06015E38 RID: 89656 RVA: 0x00325F3D File Offset: 0x0032413D
		public TVarValueUnion Value { get; set; }

		// Token: 0x17006D34 RID: 27956
		// (get) Token: 0x06015E39 RID: 89657 RVA: 0x00325F46 File Offset: 0x00324146
		// (set) Token: 0x06015E3A RID: 89658 RVA: 0x00325F4E File Offset: 0x0032414E
		public EVarAccess Access { get; set; }

		// Token: 0x17006D35 RID: 27957
		// (get) Token: 0x06015E3B RID: 89659 RVA: 0x00325F57 File Offset: 0x00324157
		// (set) Token: 0x06015E3C RID: 89660 RVA: 0x00325F5F File Offset: 0x0032415F
		public bool IsIgnoreOnRollBack { get; set; }

		// Token: 0x17006D36 RID: 27958
		// (get) Token: 0x06015E3D RID: 89661 RVA: 0x00325F68 File Offset: 0x00324168
		// (set) Token: 0x06015E3E RID: 89662 RVA: 0x00325F70 File Offset: 0x00324170
		public bool IsClient { get; set; }

		// Token: 0x17006D37 RID: 27959
		// (get) Token: 0x06015E3F RID: 89663 RVA: 0x00325F79 File Offset: 0x00324179
		// (set) Token: 0x06015E40 RID: 89664 RVA: 0x00325F81 File Offset: 0x00324181
		public TVarValidateConfigUnion ValidateConfig { get; set; }

		// Token: 0x17006D38 RID: 27960
		// (get) Token: 0x06015E41 RID: 89665 RVA: 0x00325F8A File Offset: 0x0032418A
		// (set) Token: 0x06015E42 RID: 89666 RVA: 0x00325F92 File Offset: 0x00324192
		public bool IsClientEditable { get; set; }

		// Token: 0x17006D39 RID: 27961
		// (get) Token: 0x06015E43 RID: 89667 RVA: 0x00325F9B File Offset: 0x0032419B
		// (set) Token: 0x06015E44 RID: 89668 RVA: 0x00325FA3 File Offset: 0x003241A3
		public byte NullMask { get; set; }

		// Token: 0x06015E45 RID: 89669 RVA: 0x00325FAC File Offset: 0x003241AC
		public IVarDefineT()
		{
			this.Name = null;
			this.Type = EVar.Boolean;
			this.Value = null;
			this.Access = EVarAccess.Private;
			this.IsIgnoreOnRollBack = false;
			this.IsClient = false;
			this.ValidateConfig = null;
			this.IsClientEditable = false;
			this.NullMask = 0;
		}
	}
}
