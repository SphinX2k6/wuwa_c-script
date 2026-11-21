using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B85 RID: 27525
	public class ICustomShowUiT
	{
		// Token: 0x1700C9FC RID: 51708
		// (get) Token: 0x0602F5DD RID: 194013 RVA: 0x00676841 File Offset: 0x00674A41
		// (set) Token: 0x0602F5DE RID: 194014 RVA: 0x00676849 File Offset: 0x00674A49
		public ICustomScreenTextSettingT TextSetting { get; set; }

		// Token: 0x1700C9FD RID: 51709
		// (get) Token: 0x0602F5DF RID: 194015 RVA: 0x00676852 File Offset: 0x00674A52
		// (set) Token: 0x0602F5E0 RID: 194016 RVA: 0x0067685A File Offset: 0x00674A5A
		public bool IsHideCircle { get; set; }

		// Token: 0x1700C9FE RID: 51710
		// (get) Token: 0x0602F5E1 RID: 194017 RVA: 0x00676863 File Offset: 0x00674A63
		// (set) Token: 0x0602F5E2 RID: 194018 RVA: 0x0067686B File Offset: 0x00674A6B
		public byte NullMask { get; set; }

		// Token: 0x0602F5E3 RID: 194019 RVA: 0x00676874 File Offset: 0x00674A74
		public ICustomShowUiT()
		{
			this.TextSetting = null;
			this.IsHideCircle = false;
			this.NullMask = 0;
		}
	}
}
