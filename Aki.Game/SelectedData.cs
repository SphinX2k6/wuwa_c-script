using System;

// Token: 0x02000E0D RID: 3597
public class SelectedData : ISelectedData
{
	// Token: 0x17000FEC RID: 4076
	// (get) Token: 0x06009136 RID: 37174 RVA: 0x002B78FE File Offset: 0x002B5AFE
	// (set) Token: 0x06009137 RID: 37175 RVA: 0x002B7906 File Offset: 0x002B5B06
	public int ItemId { get; set; }

	// Token: 0x17000FED RID: 4077
	// (get) Token: 0x06009138 RID: 37176 RVA: 0x002B790F File Offset: 0x002B5B0F
	// (set) Token: 0x06009139 RID: 37177 RVA: 0x002B7917 File Offset: 0x002B5B17
	public int IncId { get; set; }

	// Token: 0x17000FEE RID: 4078
	// (get) Token: 0x0600913A RID: 37178 RVA: 0x002B7920 File Offset: 0x002B5B20
	// (set) Token: 0x0600913B RID: 37179 RVA: 0x002B7928 File Offset: 0x002B5B28
	public int Count { get; set; }

	// Token: 0x17000FEF RID: 4079
	// (get) Token: 0x0600913C RID: 37180 RVA: 0x002B7931 File Offset: 0x002B5B31
	// (set) Token: 0x0600913D RID: 37181 RVA: 0x002B7939 File Offset: 0x002B5B39
	public int SelectedCount { get; set; }

	// Token: 0x17000FF0 RID: 4080
	// (get) Token: 0x0600913E RID: 37182 RVA: 0x002B7942 File Offset: 0x002B5B42
	// (set) Token: 0x0600913F RID: 37183 RVA: 0x002B794A File Offset: 0x002B5B4A
	public bool? OnlyTextFlag { get; set; }
}
