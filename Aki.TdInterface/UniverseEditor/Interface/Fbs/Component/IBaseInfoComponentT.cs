using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EEA RID: 20202
	public class IBaseInfoComponentT
	{
		// Token: 0x17009126 RID: 37158
		// (get) Token: 0x0601FDFD RID: 130557 RVA: 0x0046FD92 File Offset: 0x0046DF92
		// (set) Token: 0x0601FDFE RID: 130558 RVA: 0x0046FD9A File Offset: 0x0046DF9A
		public bool Disabled { get; set; }

		// Token: 0x17009127 RID: 37159
		// (get) Token: 0x0601FDFF RID: 130559 RVA: 0x0046FDA3 File Offset: 0x0046DFA3
		// (set) Token: 0x0601FE00 RID: 130560 RVA: 0x0046FDAB File Offset: 0x0046DFAB
		public string TidName { get; set; }

		// Token: 0x17009128 RID: 37160
		// (get) Token: 0x0601FE01 RID: 130561 RVA: 0x0046FDB4 File Offset: 0x0046DFB4
		// (set) Token: 0x0601FE02 RID: 130562 RVA: 0x0046FDBC File Offset: 0x0046DFBC
		public bool IsShowNameOnHead { get; set; }

		// Token: 0x17009129 RID: 37161
		// (get) Token: 0x0601FE03 RID: 130563 RVA: 0x0046FDC5 File Offset: 0x0046DFC5
		// (set) Token: 0x0601FE04 RID: 130564 RVA: 0x0046FDCD File Offset: 0x0046DFCD
		public IEntityCategoryT Category { get; set; }

		// Token: 0x1700912A RID: 37162
		// (get) Token: 0x0601FE05 RID: 130565 RVA: 0x0046FDD6 File Offset: 0x0046DFD6
		// (set) Token: 0x0601FE06 RID: 130566 RVA: 0x0046FDDE File Offset: 0x0046DFDE
		public IEntityScanFunctionT ScanFunction { get; set; }

		// Token: 0x1700912B RID: 37163
		// (get) Token: 0x0601FE07 RID: 130567 RVA: 0x0046FDE7 File Offset: 0x0046DFE7
		// (set) Token: 0x0601FE08 RID: 130568 RVA: 0x0046FDEF File Offset: 0x0046DFEF
		public int HeadInfo { get; set; }

		// Token: 0x1700912C RID: 37164
		// (get) Token: 0x0601FE09 RID: 130569 RVA: 0x0046FDF8 File Offset: 0x0046DFF8
		// (set) Token: 0x0601FE0A RID: 130570 RVA: 0x0046FE00 File Offset: 0x0046E000
		public ECamp Camp { get; set; }

		// Token: 0x1700912D RID: 37165
		// (get) Token: 0x0601FE0B RID: 130571 RVA: 0x0046FE09 File Offset: 0x0046E009
		// (set) Token: 0x0601FE0C RID: 130572 RVA: 0x0046FE11 File Offset: 0x0046E011
		public EAoiLayer AoiLayer { get; set; }

		// Token: 0x1700912E RID: 37166
		// (get) Token: 0x0601FE0D RID: 130573 RVA: 0x0046FE1A File Offset: 0x0046E01A
		// (set) Token: 0x0601FE0E RID: 130574 RVA: 0x0046FE22 File Offset: 0x0046E022
		public EAoizRadius AoiZRadius { get; set; }

		// Token: 0x1700912F RID: 37167
		// (get) Token: 0x0601FE0F RID: 130575 RVA: 0x0046FE2B File Offset: 0x0046E02B
		// (set) Token: 0x0601FE10 RID: 130576 RVA: 0x0046FE33 File Offset: 0x0046E033
		public string AoiGroupKey { get; set; }

		// Token: 0x17009130 RID: 37168
		// (get) Token: 0x0601FE11 RID: 130577 RVA: 0x0046FE3C File Offset: 0x0046E03C
		// (set) Token: 0x0601FE12 RID: 130578 RVA: 0x0046FE44 File Offset: 0x0046E044
		public bool IsAoiFitterPlatform { get; set; }

		// Token: 0x17009131 RID: 37169
		// (get) Token: 0x0601FE13 RID: 130579 RVA: 0x0046FE4D File Offset: 0x0046E04D
		// (set) Token: 0x0601FE14 RID: 130580 RVA: 0x0046FE55 File Offset: 0x0046E055
		public ICustomAoizRadiusT CustomAoiZRadius { get; set; }

		// Token: 0x17009132 RID: 37170
		// (get) Token: 0x0601FE15 RID: 130581 RVA: 0x0046FE5E File Offset: 0x0046E05E
		// (set) Token: 0x0601FE16 RID: 130582 RVA: 0x0046FE66 File Offset: 0x0046E066
		public int MapIcon { get; set; }

		// Token: 0x17009133 RID: 37171
		// (get) Token: 0x0601FE17 RID: 130583 RVA: 0x0046FE6F File Offset: 0x0046E06F
		// (set) Token: 0x0601FE18 RID: 130584 RVA: 0x0046FE77 File Offset: 0x0046E077
		public int PackId { get; set; }

		// Token: 0x17009134 RID: 37172
		// (get) Token: 0x0601FE19 RID: 130585 RVA: 0x0046FE80 File Offset: 0x0046E080
		// (set) Token: 0x0601FE1A RID: 130586 RVA: 0x0046FE88 File Offset: 0x0046E088
		public string Occupation { get; set; }

		// Token: 0x17009135 RID: 37173
		// (get) Token: 0x0601FE1B RID: 130587 RVA: 0x0046FE91 File Offset: 0x0046E091
		// (set) Token: 0x0601FE1C RID: 130588 RVA: 0x0046FE99 File Offset: 0x0046E099
		public IHeadStateViewConfigT HeadStateViewConfig { get; set; }

		// Token: 0x17009136 RID: 37174
		// (get) Token: 0x0601FE1D RID: 130589 RVA: 0x0046FEA2 File Offset: 0x0046E0A2
		// (set) Token: 0x0601FE1E RID: 130590 RVA: 0x0046FEAA File Offset: 0x0046E0AA
		public int EntityPropertyId { get; set; }

		// Token: 0x17009137 RID: 37175
		// (get) Token: 0x0601FE1F RID: 130591 RVA: 0x0046FEB3 File Offset: 0x0046E0B3
		// (set) Token: 0x0601FE20 RID: 130592 RVA: 0x0046FEBB File Offset: 0x0046E0BB
		public int FocusPriority { get; set; }

		// Token: 0x17009138 RID: 37176
		// (get) Token: 0x0601FE21 RID: 130593 RVA: 0x0046FEC4 File Offset: 0x0046E0C4
		// (set) Token: 0x0601FE22 RID: 130594 RVA: 0x0046FECC File Offset: 0x0046E0CC
		public EOnlineInteractType OnlineInteractType { get; set; }

		// Token: 0x17009139 RID: 37177
		// (get) Token: 0x0601FE23 RID: 130595 RVA: 0x0046FED5 File Offset: 0x0046E0D5
		// (set) Token: 0x0601FE24 RID: 130596 RVA: 0x0046FEDD File Offset: 0x0046E0DD
		public bool NotAllowHidedByTargetRange { get; set; }

		// Token: 0x1700913A RID: 37178
		// (get) Token: 0x0601FE25 RID: 130597 RVA: 0x0046FEE6 File Offset: 0x0046E0E6
		// (set) Token: 0x0601FE26 RID: 130598 RVA: 0x0046FEEE File Offset: 0x0046E0EE
		public ENpcDensity LowerNpcDensity { get; set; }

		// Token: 0x1700913B RID: 37179
		// (get) Token: 0x0601FE27 RID: 130599 RVA: 0x0046FEF7 File Offset: 0x0046E0F7
		// (set) Token: 0x0601FE28 RID: 130600 RVA: 0x0046FEFF File Offset: 0x0046E0FF
		public List<int> DataLayers { get; set; }

		// Token: 0x1700913C RID: 37180
		// (get) Token: 0x0601FE29 RID: 130601 RVA: 0x0046FF08 File Offset: 0x0046E108
		// (set) Token: 0x0601FE2A RID: 130602 RVA: 0x0046FF10 File Offset: 0x0046E110
		public List<int> ChildEntityIds { get; set; }

		// Token: 0x1700913D RID: 37181
		// (get) Token: 0x0601FE2B RID: 130603 RVA: 0x0046FF19 File Offset: 0x0046E119
		// (set) Token: 0x0601FE2C RID: 130604 RVA: 0x0046FF21 File Offset: 0x0046E121
		public bool IsOnlineStandalone { get; set; }

		// Token: 0x1700913E RID: 37182
		// (get) Token: 0x0601FE2D RID: 130605 RVA: 0x0046FF2A File Offset: 0x0046E12A
		// (set) Token: 0x0601FE2E RID: 130606 RVA: 0x0046FF32 File Offset: 0x0046E132
		public List<string> SpecifiedOnlineStandaloneParentUids { get; set; }

		// Token: 0x1700913F RID: 37183
		// (get) Token: 0x0601FE2F RID: 130607 RVA: 0x0046FF3B File Offset: 0x0046E13B
		// (set) Token: 0x0601FE30 RID: 130608 RVA: 0x0046FF43 File Offset: 0x0046E143
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17009140 RID: 37184
		// (get) Token: 0x0601FE31 RID: 130609 RVA: 0x0046FF4C File Offset: 0x0046E14C
		// (set) Token: 0x0601FE32 RID: 130610 RVA: 0x0046FF54 File Offset: 0x0046E154
		public EEntityUpdateStrategy EntityUpdateStrategy { get; set; }

		// Token: 0x17009141 RID: 37185
		// (get) Token: 0x0601FE33 RID: 130611 RVA: 0x0046FF5D File Offset: 0x0046E15D
		// (set) Token: 0x0601FE34 RID: 130612 RVA: 0x0046FF65 File Offset: 0x0046E165
		public EMaterialUpdateStrategy MaterialUpdateStrategy { get; set; }

		// Token: 0x17009142 RID: 37186
		// (get) Token: 0x0601FE35 RID: 130613 RVA: 0x0046FF6E File Offset: 0x0046E16E
		// (set) Token: 0x0601FE36 RID: 130614 RVA: 0x0046FF76 File Offset: 0x0046E176
		public ETimeScaleModifyStrategy TimeScaleModifyStrategy { get; set; }

		// Token: 0x17009143 RID: 37187
		// (get) Token: 0x0601FE37 RID: 130615 RVA: 0x0046FF7F File Offset: 0x0046E17F
		// (set) Token: 0x0601FE38 RID: 130616 RVA: 0x0046FF87 File Offset: 0x0046E187
		public IEntityGravityConfigT GravityConfig { get; set; }

		// Token: 0x17009144 RID: 37188
		// (get) Token: 0x0601FE39 RID: 130617 RVA: 0x0046FF90 File Offset: 0x0046E190
		// (set) Token: 0x0601FE3A RID: 130618 RVA: 0x0046FF98 File Offset: 0x0046E198
		public List<IHeadInfoChangeDataT> HeadInfoChangeConfig { get; set; }

		// Token: 0x17009145 RID: 37189
		// (get) Token: 0x0601FE3B RID: 130619 RVA: 0x0046FFA1 File Offset: 0x0046E1A1
		// (set) Token: 0x0601FE3C RID: 130620 RVA: 0x0046FFA9 File Offset: 0x0046E1A9
		public bool IsForceDestroy { get; set; }

		// Token: 0x17009146 RID: 37190
		// (get) Token: 0x0601FE3D RID: 130621 RVA: 0x0046FFB2 File Offset: 0x0046E1B2
		// (set) Token: 0x0601FE3E RID: 130622 RVA: 0x0046FFBA File Offset: 0x0046E1BA
		public ITimeScaleConfigT TimeScaleConfig { get; set; }

		// Token: 0x17009147 RID: 37191
		// (get) Token: 0x0601FE3F RID: 130623 RVA: 0x0046FFC3 File Offset: 0x0046E1C3
		// (set) Token: 0x0601FE40 RID: 130624 RVA: 0x0046FFCB File Offset: 0x0046E1CB
		public List<IEntityAttachPointT> EntityAttachPointList { get; set; }

		// Token: 0x17009148 RID: 37192
		// (get) Token: 0x0601FE41 RID: 130625 RVA: 0x0046FFD4 File Offset: 0x0046E1D4
		// (set) Token: 0x0601FE42 RID: 130626 RVA: 0x0046FFDC File Offset: 0x0046E1DC
		public int DelayDestroyDistance { get; set; }

		// Token: 0x17009149 RID: 37193
		// (get) Token: 0x0601FE43 RID: 130627 RVA: 0x0046FFE5 File Offset: 0x0046E1E5
		// (set) Token: 0x0601FE44 RID: 130628 RVA: 0x0046FFED File Offset: 0x0046E1ED
		public EClientEntityMark IsClientEntityFlag { get; set; }

		// Token: 0x1700914A RID: 37194
		// (get) Token: 0x0601FE45 RID: 130629 RVA: 0x0046FFF6 File Offset: 0x0046E1F6
		// (set) Token: 0x0601FE46 RID: 130630 RVA: 0x0046FFFE File Offset: 0x0046E1FE
		public bool KeepAnimationRateWithShadow { get; set; }

		// Token: 0x1700914B RID: 37195
		// (get) Token: 0x0601FE47 RID: 130631 RVA: 0x00470007 File Offset: 0x0046E207
		// (set) Token: 0x0601FE48 RID: 130632 RVA: 0x0047000F File Offset: 0x0046E20F
		public uint NullMask { get; set; }

		// Token: 0x0601FE49 RID: 130633 RVA: 0x00470018 File Offset: 0x0046E218
		public IBaseInfoComponentT()
		{
			this.Disabled = false;
			this.TidName = null;
			this.IsShowNameOnHead = false;
			this.Category = null;
			this.ScanFunction = null;
			this.HeadInfo = 0;
			this.Camp = ECamp.Player;
			this.AoiLayer = EAoiLayer.Default;
			this.AoiZRadius = EAoizRadius.Default;
			this.AoiGroupKey = null;
			this.IsAoiFitterPlatform = false;
			this.CustomAoiZRadius = null;
			this.MapIcon = 0;
			this.PackId = 0;
			this.Occupation = null;
			this.HeadStateViewConfig = null;
			this.EntityPropertyId = 0;
			this.FocusPriority = 0;
			this.OnlineInteractType = EOnlineInteractType.HostOnly;
			this.NotAllowHidedByTargetRange = false;
			this.LowerNpcDensity = ENpcDensity.Middle;
			this.DataLayers = null;
			this.ChildEntityIds = null;
			this.IsOnlineStandalone = false;
			this.SpecifiedOnlineStandaloneParentUids = null;
			this.FixProcessor = null;
			this.EntityUpdateStrategy = EEntityUpdateStrategy.Custom;
			this.MaterialUpdateStrategy = EMaterialUpdateStrategy.Custom;
			this.TimeScaleModifyStrategy = ETimeScaleModifyStrategy.Default;
			this.GravityConfig = null;
			this.HeadInfoChangeConfig = null;
			this.IsForceDestroy = false;
			this.TimeScaleConfig = new ITimeScaleConfigT();
			this.EntityAttachPointList = null;
			this.DelayDestroyDistance = 0;
			this.IsClientEntityFlag = EClientEntityMark.ServerEntity;
			this.KeepAnimationRateWithShadow = false;
			this.NullMask = 0U;
		}
	}
}
