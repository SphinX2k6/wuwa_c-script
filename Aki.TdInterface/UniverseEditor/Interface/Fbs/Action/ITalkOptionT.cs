using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007320 RID: 29472
	public class ITalkOptionT
	{
		// Token: 0x1700DFDC RID: 57308
		// (get) Token: 0x060357C0 RID: 219072 RVA: 0x007499CA File Offset: 0x00747BCA
		// (set) Token: 0x060357C1 RID: 219073 RVA: 0x007499D2 File Offset: 0x00747BD2
		public string TidTalkOption { get; set; }

		// Token: 0x1700DFDD RID: 57309
		// (get) Token: 0x060357C2 RID: 219074 RVA: 0x007499DB File Offset: 0x00747BDB
		// (set) Token: 0x060357C3 RID: 219075 RVA: 0x007499E3 File Offset: 0x00747BE3
		public int TextId { get; set; }

		// Token: 0x1700DFDE RID: 57310
		// (get) Token: 0x060357C4 RID: 219076 RVA: 0x007499EC File Offset: 0x00747BEC
		// (set) Token: 0x060357C5 RID: 219077 RVA: 0x007499F4 File Offset: 0x00747BF4
		public int PlotLineId { get; set; }

		// Token: 0x1700DFDF RID: 57311
		// (get) Token: 0x060357C6 RID: 219078 RVA: 0x007499FD File Offset: 0x00747BFD
		// (set) Token: 0x060357C7 RID: 219079 RVA: 0x00749A05 File Offset: 0x00747C05
		public string PlotLineKey { get; set; }

		// Token: 0x1700DFE0 RID: 57312
		// (get) Token: 0x060357C8 RID: 219080 RVA: 0x00749A0E File Offset: 0x00747C0E
		// (set) Token: 0x060357C9 RID: 219081 RVA: 0x00749A16 File Offset: 0x00747C16
		public int Icon { get; set; }

		// Token: 0x1700DFE1 RID: 57313
		// (get) Token: 0x060357CA RID: 219082 RVA: 0x00749A1F File Offset: 0x00747C1F
		// (set) Token: 0x060357CB RID: 219083 RVA: 0x00749A27 File Offset: 0x00747C27
		public IChangeIconT ChangeIcon { get; set; }

		// Token: 0x1700DFE2 RID: 57314
		// (get) Token: 0x060357CC RID: 219084 RVA: 0x00749A30 File Offset: 0x00747C30
		// (set) Token: 0x060357CD RID: 219085 RVA: 0x00749A38 File Offset: 0x00747C38
		public bool ReadMarkEnabled { get; set; }

		// Token: 0x1700DFE3 RID: 57315
		// (get) Token: 0x060357CE RID: 219086 RVA: 0x00749A41 File Offset: 0x00747C41
		// (set) Token: 0x060357CF RID: 219087 RVA: 0x00749A49 File Offset: 0x00747C49
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700DFE4 RID: 57316
		// (get) Token: 0x060357D0 RID: 219088 RVA: 0x00749A52 File Offset: 0x00747C52
		// (set) Token: 0x060357D1 RID: 219089 RVA: 0x00749A5A File Offset: 0x00747C5A
		public ETalkOptionStyle OptionStyle { get; set; }

		// Token: 0x1700DFE5 RID: 57317
		// (get) Token: 0x060357D2 RID: 219090 RVA: 0x00749A63 File Offset: 0x00747C63
		// (set) Token: 0x060357D3 RID: 219091 RVA: 0x00749A6B File Offset: 0x00747C6B
		public TTalkOptionPreConditionUnion PreCondition { get; set; }

		// Token: 0x1700DFE6 RID: 57318
		// (get) Token: 0x060357D4 RID: 219092 RVA: 0x00749A74 File Offset: 0x00747C74
		// (set) Token: 0x060357D5 RID: 219093 RVA: 0x00749A7C File Offset: 0x00747C7C
		public bool _Folded { get; set; }

		// Token: 0x1700DFE7 RID: 57319
		// (get) Token: 0x060357D6 RID: 219094 RVA: 0x00749A85 File Offset: 0x00747C85
		// (set) Token: 0x060357D7 RID: 219095 RVA: 0x00749A8D File Offset: 0x00747C8D
		public EEditFlag _EditFlag { get; set; }

		// Token: 0x1700DFE8 RID: 57320
		// (get) Token: 0x060357D8 RID: 219096 RVA: 0x00749A96 File Offset: 0x00747C96
		// (set) Token: 0x060357D9 RID: 219097 RVA: 0x00749A9E File Offset: 0x00747C9E
		public IOptionLockTipT OptionLockTip { get; set; }

		// Token: 0x1700DFE9 RID: 57321
		// (get) Token: 0x060357DA RID: 219098 RVA: 0x00749AA7 File Offset: 0x00747CA7
		// (set) Token: 0x060357DB RID: 219099 RVA: 0x00749AAF File Offset: 0x00747CAF
		public TTalkOptionParamUnion TypeParams { get; set; }

		// Token: 0x1700DFEA RID: 57322
		// (get) Token: 0x060357DC RID: 219100 RVA: 0x00749AB8 File Offset: 0x00747CB8
		// (set) Token: 0x060357DD RID: 219101 RVA: 0x00749AC0 File Offset: 0x00747CC0
		public bool HiddenOption { get; set; }

		// Token: 0x1700DFEB RID: 57323
		// (get) Token: 0x060357DE RID: 219102 RVA: 0x00749AC9 File Offset: 0x00747CC9
		// (set) Token: 0x060357DF RID: 219103 RVA: 0x00749AD1 File Offset: 0x00747CD1
		public ushort NullMask { get; set; }

		// Token: 0x060357E0 RID: 219104 RVA: 0x00749ADC File Offset: 0x00747CDC
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
