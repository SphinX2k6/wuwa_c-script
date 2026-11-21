using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544C RID: 21580
	public class IBossStateViewConfigT
	{
		// Token: 0x1700995D RID: 39261
		// (get) Token: 0x06021DDA RID: 138714 RVA: 0x004AB374 File Offset: 0x004A9574
		// (set) Token: 0x06021DDB RID: 138715 RVA: 0x004AB37C File Offset: 0x004A957C
		public EBossStateViewType BossStateViewType { get; set; }

		// Token: 0x1700995E RID: 39262
		// (get) Token: 0x06021DDC RID: 138716 RVA: 0x004AB385 File Offset: 0x004A9585
		// (set) Token: 0x06021DDD RID: 138717 RVA: 0x004AB38D File Offset: 0x004A958D
		public IDoubleViewBossStateViewStyleT BossStateViewStyle { get; set; }

		// Token: 0x1700995F RID: 39263
		// (get) Token: 0x06021DDE RID: 138718 RVA: 0x004AB396 File Offset: 0x004A9596
		// (set) Token: 0x06021DDF RID: 138719 RVA: 0x004AB39E File Offset: 0x004A959E
		public string TidBossSubTitle { get; set; }

		// Token: 0x17009960 RID: 39264
		// (get) Token: 0x06021DE0 RID: 138720 RVA: 0x004AB3A7 File Offset: 0x004A95A7
		// (set) Token: 0x06021DE1 RID: 138721 RVA: 0x004AB3AF File Offset: 0x004A95AF
		public EBossStateInfoShowType BossStateInfoShowType { get; set; }

		// Token: 0x17009961 RID: 39265
		// (get) Token: 0x06021DE2 RID: 138722 RVA: 0x004AB3B8 File Offset: 0x004A95B8
		// (set) Token: 0x06021DE3 RID: 138723 RVA: 0x004AB3C0 File Offset: 0x004A95C0
		public string TidLevelText { get; set; }

		// Token: 0x17009962 RID: 39266
		// (get) Token: 0x06021DE4 RID: 138724 RVA: 0x004AB3C9 File Offset: 0x004A95C9
		// (set) Token: 0x06021DE5 RID: 138725 RVA: 0x004AB3D1 File Offset: 0x004A95D1
		public bool OnlyShowInBattleState { get; set; }

		// Token: 0x17009963 RID: 39267
		// (get) Token: 0x06021DE6 RID: 138726 RVA: 0x004AB3DA File Offset: 0x004A95DA
		// (set) Token: 0x06021DE7 RID: 138727 RVA: 0x004AB3E2 File Offset: 0x004A95E2
		public int ShowDistance { get; set; }

		// Token: 0x17009964 RID: 39268
		// (get) Token: 0x06021DE8 RID: 138728 RVA: 0x004AB3EB File Offset: 0x004A95EB
		// (set) Token: 0x06021DE9 RID: 138729 RVA: 0x004AB3F3 File Offset: 0x004A95F3
		public byte NullMask { get; set; }

		// Token: 0x06021DEA RID: 138730 RVA: 0x004AB3FC File Offset: 0x004A95FC
		public IBossStateViewConfigT()
		{
			this.BossStateViewType = EBossStateViewType.None;
			this.BossStateViewStyle = null;
			this.TidBossSubTitle = null;
			this.BossStateInfoShowType = EBossStateInfoShowType.Common;
			this.TidLevelText = null;
			this.OnlyShowInBattleState = false;
			this.ShowDistance = 0;
			this.NullMask = 0;
		}
	}
}
