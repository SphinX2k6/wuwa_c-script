using System;
using System.Runtime.CompilerServices;

// Token: 0x02001427 RID: 5159
[NullableContext(2)]
[Nullable(0)]
public class PinballItemDataRole : IPinballItemDataRole
{
	// Token: 0x17000CA3 RID: 3235
	// (get) Token: 0x06009190 RID: 37264 RVA: 0x001F2F31 File Offset: 0x001F1131
	// (set) Token: 0x06009191 RID: 37265 RVA: 0x001F2F39 File Offset: 0x001F1139
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CA4 RID: 3236
	// (get) Token: 0x06009192 RID: 37266 RVA: 0x001F2F42 File Offset: 0x001F1142
	// (set) Token: 0x06009193 RID: 37267 RVA: 0x001F2F4A File Offset: 0x001F114A
	public int Id { get; set; }

	// Token: 0x17000CA5 RID: 3237
	// (get) Token: 0x06009194 RID: 37268 RVA: 0x001F2F53 File Offset: 0x001F1153
	// (set) Token: 0x06009195 RID: 37269 RVA: 0x001F2F5B File Offset: 0x001F115B
	public bool? IsRecommend { get; set; }

	// Token: 0x17000CA6 RID: 3238
	// (get) Token: 0x06009196 RID: 37270 RVA: 0x001F2F64 File Offset: 0x001F1164
	// (set) Token: 0x06009197 RID: 37271 RVA: 0x001F2F6C File Offset: 0x001F116C
	public int? BdId { get; set; }

	// Token: 0x17000CA7 RID: 3239
	// (get) Token: 0x06009198 RID: 37272 RVA: 0x001F2F75 File Offset: 0x001F1175
	// (set) Token: 0x06009199 RID: 37273 RVA: 0x001F2F7D File Offset: 0x001F117D
	public bool? IsLocked { get; set; }

	// Token: 0x17000CA8 RID: 3240
	// (get) Token: 0x0600919A RID: 37274 RVA: 0x001F2F86 File Offset: 0x001F1186
	// (set) Token: 0x0600919B RID: 37275 RVA: 0x001F2F8E File Offset: 0x001F118E
	public bool? IsUnavailable { get; set; }

	// Token: 0x17000CA9 RID: 3241
	// (get) Token: 0x0600919C RID: 37276 RVA: 0x001F2F97 File Offset: 0x001F1197
	// (set) Token: 0x0600919D RID: 37277 RVA: 0x001F2F9F File Offset: 0x001F119F
	public TableTextArgNew BottomText { get; set; }

	// Token: 0x17000CAA RID: 3242
	// (get) Token: 0x0600919E RID: 37278 RVA: 0x001F2FA8 File Offset: 0x001F11A8
	// (set) Token: 0x0600919F RID: 37279 RVA: 0x001F2FB0 File Offset: 0x001F11B0
	public string BottomPlainText { get; set; }

	// Token: 0x17000CAB RID: 3243
	// (get) Token: 0x060091A0 RID: 37280 RVA: 0x001F2FB9 File Offset: 0x001F11B9
	// (set) Token: 0x060091A1 RID: 37281 RVA: 0x001F2FC1 File Offset: 0x001F11C1
	public int? ClassId { get; set; }
}
