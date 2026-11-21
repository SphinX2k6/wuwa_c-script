using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E70 RID: 28272
	public class IFlowActorIndexDataT
	{
		// Token: 0x1700CF33 RID: 53043
		// (get) Token: 0x06030D83 RID: 200067 RVA: 0x006A07E7 File Offset: 0x0069E9E7
		// (set) Token: 0x06030D84 RID: 200068 RVA: 0x006A07EF File Offset: 0x0069E9EF
		public int Index { get; set; }

		// Token: 0x1700CF34 RID: 53044
		// (get) Token: 0x06030D85 RID: 200069 RVA: 0x006A07F8 File Offset: 0x0069E9F8
		// (set) Token: 0x06030D86 RID: 200070 RVA: 0x006A0800 File Offset: 0x0069EA00
		public IPosAndRotT Offset { get; set; }

		// Token: 0x1700CF35 RID: 53045
		// (get) Token: 0x06030D87 RID: 200071 RVA: 0x006A0809 File Offset: 0x0069EA09
		// (set) Token: 0x06030D88 RID: 200072 RVA: 0x006A0811 File Offset: 0x0069EA11
		public bool IsUseFixedPosition { get; set; }

		// Token: 0x1700CF36 RID: 53046
		// (get) Token: 0x06030D89 RID: 200073 RVA: 0x006A081A File Offset: 0x0069EA1A
		// (set) Token: 0x06030D8A RID: 200074 RVA: 0x006A0822 File Offset: 0x0069EA22
		public byte NullMask { get; set; }

		// Token: 0x06030D8B RID: 200075 RVA: 0x006A082B File Offset: 0x0069EA2B
		public IFlowActorIndexDataT()
		{
			this.Index = 0;
			this.Offset = null;
			this.IsUseFixedPosition = false;
			this.NullMask = 0;
		}
	}
}
