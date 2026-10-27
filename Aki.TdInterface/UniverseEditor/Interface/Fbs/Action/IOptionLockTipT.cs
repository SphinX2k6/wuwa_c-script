using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4C RID: 27724
	public class IOptionLockTipT
	{
		// Token: 0x1700CE7C RID: 52860
		// (get) Token: 0x06030D81 RID: 200065 RVA: 0x006A2984 File Offset: 0x006A0B84
		// (set) Token: 0x06030D82 RID: 200066 RVA: 0x006A298C File Offset: 0x006A0B8C
		public string TidAppendText { get; set; }

		// Token: 0x1700CE7D RID: 52861
		// (get) Token: 0x06030D83 RID: 200067 RVA: 0x006A2995 File Offset: 0x006A0B95
		// (set) Token: 0x06030D84 RID: 200068 RVA: 0x006A299D File Offset: 0x006A0B9D
		public string TidHintText { get; set; }

		// Token: 0x1700CE7E RID: 52862
		// (get) Token: 0x06030D85 RID: 200069 RVA: 0x006A29A6 File Offset: 0x006A0BA6
		// (set) Token: 0x06030D86 RID: 200070 RVA: 0x006A29AE File Offset: 0x006A0BAE
		public int AppendTextId { get; set; }

		// Token: 0x1700CE7F RID: 52863
		// (get) Token: 0x06030D87 RID: 200071 RVA: 0x006A29B7 File Offset: 0x006A0BB7
		// (set) Token: 0x06030D88 RID: 200072 RVA: 0x006A29BF File Offset: 0x006A0BBF
		public int HintTextId { get; set; }

		// Token: 0x1700CE80 RID: 52864
		// (get) Token: 0x06030D89 RID: 200073 RVA: 0x006A29C8 File Offset: 0x006A0BC8
		// (set) Token: 0x06030D8A RID: 200074 RVA: 0x006A29D0 File Offset: 0x006A0BD0
		public byte NullMask { get; set; }

		// Token: 0x06030D8B RID: 200075 RVA: 0x006A29D9 File Offset: 0x006A0BD9
		public IOptionLockTipT()
		{
			this.TidAppendText = null;
			this.TidHintText = null;
			this.AppendTextId = 0;
			this.HintTextId = 0;
			this.NullMask = 0;
		}
	}
}
