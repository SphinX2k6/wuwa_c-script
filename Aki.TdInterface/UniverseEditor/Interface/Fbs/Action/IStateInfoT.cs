using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007993 RID: 31123
	public class IStateInfoT
	{
		// Token: 0x1700E448 RID: 58440
		// (get) Token: 0x06036D68 RID: 224616 RVA: 0x00756094 File Offset: 0x00754294
		// (set) Token: 0x06036D69 RID: 224617 RVA: 0x0075609C File Offset: 0x0075429C
		public string ObjType { get; set; }

		// Token: 0x1700E449 RID: 58441
		// (get) Token: 0x06036D6A RID: 224618 RVA: 0x007560A5 File Offset: 0x007542A5
		// (set) Token: 0x06036D6B RID: 224619 RVA: 0x007560AD File Offset: 0x007542AD
		public List<string> Children { get; set; }

		// Token: 0x1700E44A RID: 58442
		// (get) Token: 0x06036D6C RID: 224620 RVA: 0x007560B6 File Offset: 0x007542B6
		// (set) Token: 0x06036D6D RID: 224621 RVA: 0x007560BE File Offset: 0x007542BE
		public List<string> Reference { get; set; }

		// Token: 0x1700E44B RID: 58443
		// (get) Token: 0x06036D6E RID: 224622 RVA: 0x007560C7 File Offset: 0x007542C7
		// (set) Token: 0x06036D6F RID: 224623 RVA: 0x007560CF File Offset: 0x007542CF
		public List<string> WeakReference { get; set; }

		// Token: 0x1700E44C RID: 58444
		// (get) Token: 0x06036D70 RID: 224624 RVA: 0x007560D8 File Offset: 0x007542D8
		// (set) Token: 0x06036D71 RID: 224625 RVA: 0x007560E0 File Offset: 0x007542E0
		public int Id { get; set; }

		// Token: 0x1700E44D RID: 58445
		// (get) Token: 0x06036D72 RID: 224626 RVA: 0x007560E9 File Offset: 0x007542E9
		// (set) Token: 0x06036D73 RID: 224627 RVA: 0x007560F1 File Offset: 0x007542F1
		public string Name { get; set; }

		// Token: 0x1700E44E RID: 58446
		// (get) Token: 0x06036D74 RID: 224628 RVA: 0x007560FA File Offset: 0x007542FA
		// (set) Token: 0x06036D75 RID: 224629 RVA: 0x00756102 File Offset: 0x00754302
		public bool _Folded { get; set; }

		// Token: 0x1700E44F RID: 58447
		// (get) Token: 0x06036D76 RID: 224630 RVA: 0x0075610B File Offset: 0x0075430B
		// (set) Token: 0x06036D77 RID: 224631 RVA: 0x00756113 File Offset: 0x00754313
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E450 RID: 58448
		// (get) Token: 0x06036D78 RID: 224632 RVA: 0x0075611C File Offset: 0x0075431C
		// (set) Token: 0x06036D79 RID: 224633 RVA: 0x00756124 File Offset: 0x00754324
		public bool KeepBgm { get; set; }

		// Token: 0x1700E451 RID: 58449
		// (get) Token: 0x06036D7A RID: 224634 RVA: 0x0075612D File Offset: 0x0075432D
		// (set) Token: 0x06036D7B RID: 224635 RVA: 0x00756135 File Offset: 0x00754335
		public bool OnlyPlayOnce { get; set; }

		// Token: 0x1700E452 RID: 58450
		// (get) Token: 0x06036D7C RID: 224636 RVA: 0x0075613E File Offset: 0x0075433E
		// (set) Token: 0x06036D7D RID: 224637 RVA: 0x00756146 File Offset: 0x00754346
		public bool KeepInVehicle { get; set; }

		// Token: 0x1700E453 RID: 58451
		// (get) Token: 0x06036D7E RID: 224638 RVA: 0x0075614F File Offset: 0x0075434F
		// (set) Token: 0x06036D7F RID: 224639 RVA: 0x00756157 File Offset: 0x00754357
		public bool AllowMultiReference { get; set; }

		// Token: 0x1700E454 RID: 58452
		// (get) Token: 0x06036D80 RID: 224640 RVA: 0x00756160 File Offset: 0x00754360
		// (set) Token: 0x06036D81 RID: 224641 RVA: 0x00756168 File Offset: 0x00754368
		public bool IgnoreInPlotHandBook { get; set; }

		// Token: 0x1700E455 RID: 58453
		// (get) Token: 0x06036D82 RID: 224642 RVA: 0x00756171 File Offset: 0x00754371
		// (set) Token: 0x06036D83 RID: 224643 RVA: 0x00756179 File Offset: 0x00754379
		public bool DontInterruptMatch { get; set; }

		// Token: 0x1700E456 RID: 58454
		// (get) Token: 0x06036D84 RID: 224644 RVA: 0x00756182 File Offset: 0x00754382
		// (set) Token: 0x06036D85 RID: 224645 RVA: 0x0075618A File Offset: 0x0075438A
		public bool IsPreloadFlow { get; set; }

		// Token: 0x1700E457 RID: 58455
		// (get) Token: 0x06036D86 RID: 224646 RVA: 0x00756193 File Offset: 0x00754393
		// (set) Token: 0x06036D87 RID: 224647 RVA: 0x0075619B File Offset: 0x0075439B
		public bool IsClientFlow { get; set; }

		// Token: 0x1700E458 RID: 58456
		// (get) Token: 0x06036D88 RID: 224648 RVA: 0x007561A4 File Offset: 0x007543A4
		// (set) Token: 0x06036D89 RID: 224649 RVA: 0x007561AC File Offset: 0x007543AC
		public bool _ShowImport { get; set; }

		// Token: 0x1700E459 RID: 58457
		// (get) Token: 0x06036D8A RID: 224650 RVA: 0x007561B5 File Offset: 0x007543B5
		// (set) Token: 0x06036D8B RID: 224651 RVA: 0x007561BD File Offset: 0x007543BD
		public IPosAT PlotPos { get; set; }

		// Token: 0x1700E45A RID: 58458
		// (get) Token: 0x06036D8C RID: 224652 RVA: 0x007561C6 File Offset: 0x007543C6
		// (set) Token: 0x06036D8D RID: 224653 RVA: 0x007561CE File Offset: 0x007543CE
		public IStateProgramSpecialProcessChangeTeamOptimizationT ProgramSpecialProcess { get; set; }

		// Token: 0x1700E45B RID: 58459
		// (get) Token: 0x06036D8E RID: 224654 RVA: 0x007561D7 File Offset: 0x007543D7
		// (set) Token: 0x06036D8F RID: 224655 RVA: 0x007561DF File Offset: 0x007543DF
		public bool UseConditionalText { get; set; }

		// Token: 0x1700E45C RID: 58460
		// (get) Token: 0x06036D90 RID: 224656 RVA: 0x007561E8 File Offset: 0x007543E8
		// (set) Token: 0x06036D91 RID: 224657 RVA: 0x007561F0 File Offset: 0x007543F0
		public List<int> _SelectedIndexes { get; set; }

		// Token: 0x1700E45D RID: 58461
		// (get) Token: 0x06036D92 RID: 224658 RVA: 0x007561F9 File Offset: 0x007543F9
		// (set) Token: 0x06036D93 RID: 224659 RVA: 0x00756201 File Offset: 0x00754401
		public ushort NullMask { get; set; }

		// Token: 0x06036D94 RID: 224660 RVA: 0x0075620C File Offset: 0x0075440C
		public IStateInfoT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Id = 0;
			this.Name = null;
			this._Folded = false;
			this.Actions = null;
			this.KeepBgm = false;
			this.OnlyPlayOnce = false;
			this.KeepInVehicle = false;
			this.AllowMultiReference = false;
			this.IgnoreInPlotHandBook = false;
			this.DontInterruptMatch = false;
			this.IsPreloadFlow = false;
			this.IsClientFlow = false;
			this._ShowImport = false;
			this.PlotPos = null;
			this.ProgramSpecialProcess = null;
			this.UseConditionalText = false;
			this._SelectedIndexes = null;
			this.NullMask = 0;
		}
	}
}
