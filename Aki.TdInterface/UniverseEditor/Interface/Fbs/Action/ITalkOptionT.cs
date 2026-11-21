using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AF8 RID: 31480
	public class ITalkOptionT
	{
		// Token: 0x1700EBD8 RID: 60376
		// (get) Token: 0x06038AF3 RID: 232179 RVA: 0x007AB552 File Offset: 0x007A9752
		// (set) Token: 0x06038AF4 RID: 232180 RVA: 0x007AB55A File Offset: 0x007A975A
		public string TidTalkOption { get; set; }

		// Token: 0x1700EBD9 RID: 60377
		// (get) Token: 0x06038AF5 RID: 232181 RVA: 0x007AB563 File Offset: 0x007A9763
		// (set) Token: 0x06038AF6 RID: 232182 RVA: 0x007AB56B File Offset: 0x007A976B
		public int TextId { get; set; }

		// Token: 0x1700EBDA RID: 60378
		// (get) Token: 0x06038AF7 RID: 232183 RVA: 0x007AB574 File Offset: 0x007A9774
		// (set) Token: 0x06038AF8 RID: 232184 RVA: 0x007AB57C File Offset: 0x007A977C
		public int PlotLineId { get; set; }

		// Token: 0x1700EBDB RID: 60379
		// (get) Token: 0x06038AF9 RID: 232185 RVA: 0x007AB585 File Offset: 0x007A9785
		// (set) Token: 0x06038AFA RID: 232186 RVA: 0x007AB58D File Offset: 0x007A978D
		public string PlotLineKey { get; set; }

		// Token: 0x1700EBDC RID: 60380
		// (get) Token: 0x06038AFB RID: 232187 RVA: 0x007AB596 File Offset: 0x007A9796
		// (set) Token: 0x06038AFC RID: 232188 RVA: 0x007AB59E File Offset: 0x007A979E
		public int Icon { get; set; }

		// Token: 0x1700EBDD RID: 60381
		// (get) Token: 0x06038AFD RID: 232189 RVA: 0x007AB5A7 File Offset: 0x007A97A7
		// (set) Token: 0x06038AFE RID: 232190 RVA: 0x007AB5AF File Offset: 0x007A97AF
		public IChangeIconT ChangeIcon { get; set; }

		// Token: 0x1700EBDE RID: 60382
		// (get) Token: 0x06038AFF RID: 232191 RVA: 0x007AB5B8 File Offset: 0x007A97B8
		// (set) Token: 0x06038B00 RID: 232192 RVA: 0x007AB5C0 File Offset: 0x007A97C0
		public bool ReadMarkEnabled { get; set; }

		// Token: 0x1700EBDF RID: 60383
		// (get) Token: 0x06038B01 RID: 232193 RVA: 0x007AB5C9 File Offset: 0x007A97C9
		// (set) Token: 0x06038B02 RID: 232194 RVA: 0x007AB5D1 File Offset: 0x007A97D1
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700EBE0 RID: 60384
		// (get) Token: 0x06038B03 RID: 232195 RVA: 0x007AB5DA File Offset: 0x007A97DA
		// (set) Token: 0x06038B04 RID: 232196 RVA: 0x007AB5E2 File Offset: 0x007A97E2
		public ETalkOptionStyle OptionStyle { get; set; }

		// Token: 0x1700EBE1 RID: 60385
		// (get) Token: 0x06038B05 RID: 232197 RVA: 0x007AB5EB File Offset: 0x007A97EB
		// (set) Token: 0x06038B06 RID: 232198 RVA: 0x007AB5F3 File Offset: 0x007A97F3
		public TTalkOptionPreConditionUnion PreCondition { get; set; }

		// Token: 0x1700EBE2 RID: 60386
		// (get) Token: 0x06038B07 RID: 232199 RVA: 0x007AB5FC File Offset: 0x007A97FC
		// (set) Token: 0x06038B08 RID: 232200 RVA: 0x007AB604 File Offset: 0x007A9804
		public bool _Folded { get; set; }

		// Token: 0x1700EBE3 RID: 60387
		// (get) Token: 0x06038B09 RID: 232201 RVA: 0x007AB60D File Offset: 0x007A980D
		// (set) Token: 0x06038B0A RID: 232202 RVA: 0x007AB615 File Offset: 0x007A9815
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700EBE4 RID: 60388
		// (get) Token: 0x06038B0B RID: 232203 RVA: 0x007AB61E File Offset: 0x007A981E
		// (set) Token: 0x06038B0C RID: 232204 RVA: 0x007AB626 File Offset: 0x007A9826
		public IOptionLockTipT OptionLockTip { get; set; }

		// Token: 0x1700EBE5 RID: 60389
		// (get) Token: 0x06038B0D RID: 232205 RVA: 0x007AB62F File Offset: 0x007A982F
		// (set) Token: 0x06038B0E RID: 232206 RVA: 0x007AB637 File Offset: 0x007A9837
		public TTalkOptionParamUnion TypeParams { get; set; }

		// Token: 0x1700EBE6 RID: 60390
		// (get) Token: 0x06038B0F RID: 232207 RVA: 0x007AB640 File Offset: 0x007A9840
		// (set) Token: 0x06038B10 RID: 232208 RVA: 0x007AB648 File Offset: 0x007A9848
		public bool HiddenOption { get; set; }

		// Token: 0x1700EBE7 RID: 60391
		// (get) Token: 0x06038B11 RID: 232209 RVA: 0x007AB651 File Offset: 0x007A9851
		// (set) Token: 0x06038B12 RID: 232210 RVA: 0x007AB659 File Offset: 0x007A9859
		public ushort NullMask { get; set; }

		// Token: 0x06038B13 RID: 232211 RVA: 0x007AB664 File Offset: 0x007A9864
		public ITalkOptionT()
		{
			this.TidTalkOption = null;
			this.TextId = 0;
			this.PlotLineId = 0;
			this.PlotLineKey = null;
			this.Icon = 0;
			this.ChangeIcon = null;
			this.ReadMarkEnabled = false;
			this.Actions = null;
			this.OptionStyle = ETalkOptionStyle.Default;
			this.PreCondition = null;
			this._Folded = false;
			this._EditFlag = EEditFlag.Add;
			this.OptionLockTip = null;
			this.TypeParams = null;
			this.HiddenOption = false;
			this.NullMask = 0;
		}
	}
}
