using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572E RID: 22318
	public class IPhotoTargetComponentT
	{
		// Token: 0x1700A652 RID: 42578
		// (get) Token: 0x060255B6 RID: 153014 RVA: 0x00527A1C File Offset: 0x00525C1C
		// (set) Token: 0x060255B7 RID: 153015 RVA: 0x00527A24 File Offset: 0x00525C24
		public bool Disabled { get; set; }

		// Token: 0x1700A653 RID: 42579
		// (get) Token: 0x060255B8 RID: 153016 RVA: 0x00527A2D File Offset: 0x00525C2D
		// (set) Token: 0x060255B9 RID: 153017 RVA: 0x00527A35 File Offset: 0x00525C35
		public List<IVectorInfoT> RequiredPoints { get; set; }

		// Token: 0x1700A654 RID: 42580
		// (get) Token: 0x060255BA RID: 153018 RVA: 0x00527A3E File Offset: 0x00525C3E
		// (set) Token: 0x060255BB RID: 153019 RVA: 0x00527A46 File Offset: 0x00525C46
		public TPhotoTargetCaptureUiUnion TargetCapturePromptUi { get; set; }

		// Token: 0x1700A655 RID: 42581
		// (get) Token: 0x060255BC RID: 153020 RVA: 0x00527A4F File Offset: 0x00525C4F
		// (set) Token: 0x060255BD RID: 153021 RVA: 0x00527A57 File Offset: 0x00525C57
		public List<int> RayCastIgnoreEntities { get; set; }

		// Token: 0x1700A656 RID: 42582
		// (get) Token: 0x060255BE RID: 153022 RVA: 0x00527A60 File Offset: 0x00525C60
		// (set) Token: 0x060255BF RID: 153023 RVA: 0x00527A68 File Offset: 0x00525C68
		public byte NullMask { get; set; }

		// Token: 0x060255C0 RID: 153024 RVA: 0x00527A71 File Offset: 0x00525C71
		public IPhotoTargetComponentT()
		{
			this.Disabled = false;
			this.RequiredPoints = null;
			this.TargetCapturePromptUi = null;
			this.RayCastIgnoreEntities = null;
			this.NullMask = 0;
		}
	}
}
