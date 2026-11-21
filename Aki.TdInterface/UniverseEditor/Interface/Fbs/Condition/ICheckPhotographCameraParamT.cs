using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA8 RID: 20392
	public class ICheckPhotographCameraParamT
	{
		// Token: 0x170091DB RID: 37339
		// (get) Token: 0x0601FC7F RID: 130175 RVA: 0x0046A7FD File Offset: 0x004689FD
		// (set) Token: 0x0601FC80 RID: 130176 RVA: 0x0046A805 File Offset: 0x00468A05
		public ECondition Type { get; set; }

		// Token: 0x170091DC RID: 37340
		// (get) Token: 0x0601FC81 RID: 130177 RVA: 0x0046A80E File Offset: 0x00468A0E
		// (set) Token: 0x0601FC82 RID: 130178 RVA: 0x0046A816 File Offset: 0x00468A16
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x170091DD RID: 37341
		// (get) Token: 0x0601FC83 RID: 130179 RVA: 0x0046A81F File Offset: 0x00468A1F
		// (set) Token: 0x0601FC84 RID: 130180 RVA: 0x0046A827 File Offset: 0x00468A27
		public List<TPhotographCameraCheckTypeUnion> CameraParam { get; set; }

		// Token: 0x0601FC85 RID: 130181 RVA: 0x0046A830 File Offset: 0x00468A30
		public ICheckPhotographCameraParamT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECommonMatchType.MatchAll;
			this.CameraParam = null;
		}
	}
}
