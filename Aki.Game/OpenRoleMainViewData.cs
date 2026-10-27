using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020028D7 RID: 10455
[NullableContext(2)]
[Nullable(0)]
public class OpenRoleMainViewData : IOpenRoleMainViewData
{
	// Token: 0x17001CF6 RID: 7414
	// (get) Token: 0x06015951 RID: 88401 RVA: 0x00572885 File Offset: 0x00570A85
	// (set) Token: 0x06015952 RID: 88402 RVA: 0x0057288D File Offset: 0x00570A8D
	public ERoleAgentType AgentType { get; set; }

	// Token: 0x17001CF7 RID: 7415
	// (get) Token: 0x06015953 RID: 88403 RVA: 0x00572896 File Offset: 0x00570A96
	// (set) Token: 0x06015954 RID: 88404 RVA: 0x0057289E File Offset: 0x00570A9E
	public int? SelectRoleId { get; set; }

	// Token: 0x17001CF8 RID: 7416
	// (get) Token: 0x06015955 RID: 88405 RVA: 0x005728A7 File Offset: 0x00570AA7
	// (set) Token: 0x06015956 RID: 88406 RVA: 0x005728AF File Offset: 0x00570AAF
	public List<int> RoleIdList { get; set; }

	// Token: 0x17001CF9 RID: 7417
	// (get) Token: 0x06015957 RID: 88407 RVA: 0x005728B8 File Offset: 0x00570AB8
	// (set) Token: 0x06015958 RID: 88408 RVA: 0x005728C0 File Offset: 0x00570AC0
	public EUiTabViewName? OpenTabView { get; set; }

	// Token: 0x17001CFA RID: 7418
	// (get) Token: 0x06015959 RID: 88409 RVA: 0x005728C9 File Offset: 0x00570AC9
	// (set) Token: 0x0601595A RID: 88410 RVA: 0x005728D1 File Offset: 0x00570AD1
	public TOpenViewCallBack FinishCallback { get; set; }

	// Token: 0x17001CFB RID: 7419
	// (get) Token: 0x0601595B RID: 88411 RVA: 0x005728DA File Offset: 0x00570ADA
	// (set) Token: 0x0601595C RID: 88412 RVA: 0x005728E2 File Offset: 0x00570AE2
	public ETeamPositionType? TeamPositionType { get; set; }

	// Token: 0x17001CFC RID: 7420
	// (get) Token: 0x0601595D RID: 88413 RVA: 0x005728EB File Offset: 0x00570AEB
	// (set) Token: 0x0601595E RID: 88414 RVA: 0x005728F3 File Offset: 0x00570AF3
	public ERoleViewSource? Source { get; set; }
}
