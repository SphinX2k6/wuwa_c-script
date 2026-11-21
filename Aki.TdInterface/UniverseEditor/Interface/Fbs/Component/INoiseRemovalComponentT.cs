using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA4 RID: 23460
	public class INoiseRemovalComponentT
	{
		// Token: 0x1700AB7D RID: 43901
		// (get) Token: 0x06026ACD RID: 158413 RVA: 0x0054B8E5 File Offset: 0x00549AE5
		// (set) Token: 0x06026ACE RID: 158414 RVA: 0x0054B8ED File Offset: 0x00549AED
		public bool Disabled { get; set; }

		// Token: 0x1700AB7E RID: 43902
		// (get) Token: 0x06026ACF RID: 158415 RVA: 0x0054B8F6 File Offset: 0x00549AF6
		// (set) Token: 0x06026AD0 RID: 158416 RVA: 0x0054B8FE File Offset: 0x00549AFE
		public List<INoiseRemovalNodeT> Nodes { get; set; }

		// Token: 0x1700AB7F RID: 43903
		// (get) Token: 0x06026AD1 RID: 158417 RVA: 0x0054B907 File Offset: 0x00549B07
		// (set) Token: 0x06026AD2 RID: 158418 RVA: 0x0054B90F File Offset: 0x00549B0F
		public string CompleteState { get; set; }

		// Token: 0x1700AB80 RID: 43904
		// (get) Token: 0x06026AD3 RID: 158419 RVA: 0x0054B918 File Offset: 0x00549B18
		// (set) Token: 0x06026AD4 RID: 158420 RVA: 0x0054B920 File Offset: 0x00549B20
		public TNoiseRemovalBoarderUnion NoiseRemovalBoarder { get; set; }

		// Token: 0x1700AB81 RID: 43905
		// (get) Token: 0x06026AD5 RID: 158421 RVA: 0x0054B929 File Offset: 0x00549B29
		// (set) Token: 0x06026AD6 RID: 158422 RVA: 0x0054B931 File Offset: 0x00549B31
		public int RotationAngle { get; set; }

		// Token: 0x1700AB82 RID: 43906
		// (get) Token: 0x06026AD7 RID: 158423 RVA: 0x0054B93A File Offset: 0x00549B3A
		// (set) Token: 0x06026AD8 RID: 158424 RVA: 0x0054B942 File Offset: 0x00549B42
		public byte NullMask { get; set; }

		// Token: 0x06026AD9 RID: 158425 RVA: 0x0054B94B File Offset: 0x00549B4B
		public INoiseRemovalComponentT()
		{
			this.Disabled = false;
			this.Nodes = null;
			this.CompleteState = null;
			this.NoiseRemovalBoarder = null;
			this.RotationAngle = 0;
			this.NullMask = 0;
		}
	}
}
