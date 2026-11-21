using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541C RID: 21532
	public class IBaseInfoComponentT
	{
		// Token: 0x170098A8 RID: 39080
		// (get) Token: 0x06021B6D RID: 138093 RVA: 0x004A6126 File Offset: 0x004A4326
		// (set) Token: 0x06021B6E RID: 138094 RVA: 0x004A612E File Offset: 0x004A432E
		public bool Disabled { get; set; }

		// Token: 0x170098A9 RID: 39081
		// (get) Token: 0x06021B6F RID: 138095 RVA: 0x004A6137 File Offset: 0x004A4337
		// (set) Token: 0x06021B70 RID: 138096 RVA: 0x004A613F File Offset: 0x004A433F
		public string TidName { get; set; }

		// Token: 0x170098AA RID: 39082
		// (get) Token: 0x06021B71 RID: 138097 RVA: 0x004A6148 File Offset: 0x004A4348
		// (set) Token: 0x06021B72 RID: 138098 RVA: 0x004A6150 File Offset: 0x004A4350
		public bool IsShowNameOnHead { get; set; }

		// Token: 0x170098AB RID: 39083
		// (get) Token: 0x06021B73 RID: 138099 RVA: 0x004A6159 File Offset: 0x004A4359
		// (set) Token: 0x06021B74 RID: 138100 RVA: 0x004A6161 File Offset: 0x004A4361
		public IEntityCategoryT Category { get; set; }

		// Token: 0x170098AC RID: 39084
		// (get) Token: 0x06021B75 RID: 138101 RVA: 0x004A616A File Offset: 0x004A436A
		// (set) Token: 0x06021B76 RID: 138102 RVA: 0x004A6172 File Offset: 0x004A4372
		public IEntityScanFunctionT ScanFunction { get; set; }

		// Token: 0x170098AD RID: 39085
		// (get) Token: 0x06021B77 RID: 138103 RVA: 0x004A617B File Offset: 0x004A437B
		// (set) Token: 0x06021B78 RID: 138104 RVA: 0x004A6183 File Offset: 0x004A4383
		public int HeadInfo { get; set; }

		// Token: 0x170098AE RID: 39086
		// (get) Token: 0x06021B79 RID: 138105 RVA: 0x004A618C File Offset: 0x004A438C
		// (set) Token: 0x06021B7A RID: 138106 RVA: 0x004A6194 File Offset: 0x004A4394
		public ECamp Camp { get; set; }

		// Token: 0x170098AF RID: 39087
		// (get) Token: 0x06021B7B RID: 138107 RVA: 0x004A619D File Offset: 0x004A439D
		// (set) Token: 0x06021B7C RID: 138108 RVA: 0x004A61A5 File Offset: 0x004A43A5
		public EAoiLayer AoiLayer { get; set; }

		// Token: 0x170098B0 RID: 39088
		// (get) Token: 0x06021B7D RID: 138109 RVA: 0x004A61AE File Offset: 0x004A43AE
		// (set) Token: 0x06021B7E RID: 138110 RVA: 0x004A61B6 File Offset: 0x004A43B6
		public EAoizRadius AoiZRadius { get; set; }

		// Token: 0x170098B1 RID: 39089
		// (get) Token: 0x06021B7F RID: 138111 RVA: 0x004A61BF File Offset: 0x004A43BF
		// (set) Token: 0x06021B80 RID: 138112 RVA: 0x004A61C7 File Offset: 0x004A43C7
		public string AoiGroupKey { get; set; }

		// Token: 0x170098B2 RID: 39090
		// (get) Token: 0x06021B81 RID: 138113 RVA: 0x004A61D0 File Offset: 0x004A43D0
		// (set) Token: 0x06021B82 RID: 138114 RVA: 0x004A61D8 File Offset: 0x004A43D8
		public bool IsAoiFitterPlatform { get; set; }

		// Token: 0x170098B3 RID: 39091
		// (get) Token: 0x06021B83 RID: 138115 RVA: 0x004A61E1 File Offset: 0x004A43E1
		// (set) Token: 0x06021B84 RID: 138116 RVA: 0x004A61E9 File Offset: 0x004A43E9
		public ICustomAoizRadiusT CustomAoiZRadius { get; set; }

		// Token: 0x170098B4 RID: 39092
		// (get) Token: 0x06021B85 RID: 138117 RVA: 0x004A61F2 File Offset: 0x004A43F2
		// (set) Token: 0x06021B86 RID: 138118 RVA: 0x004A61FA File Offset: 0x004A43FA
		public int MapIcon { get; set; }

		// Token: 0x170098B5 RID: 39093
		// (get) Token: 0x06021B87 RID: 138119 RVA: 0x004A6203 File Offset: 0x004A4403
		// (set) Token: 0x06021B88 RID: 138120 RVA: 0x004A620B File Offset: 0x004A440B
		public int PackId { get; set; }

		// Token: 0x170098B6 RID: 39094
		// (get) Token: 0x06021B89 RID: 138121 RVA: 0x004A6214 File Offset: 0x004A4414
		// (set) Token: 0x06021B8A RID: 138122 RVA: 0x004A621C File Offset: 0x004A441C
		public string Occupation { get; set; }

		// Token: 0x170098B7 RID: 39095
		// (get) Token: 0x06021B8B RID: 138123 RVA: 0x004A6225 File Offset: 0x004A4425
		// (set) Token: 0x06021B8C RID: 138124 RVA: 0x004A622D File Offset: 0x004A442D
		public IHeadStateViewConfigT HeadStateViewConfig { get; set; }

		// Token: 0x170098B8 RID: 39096
		// (get) Token: 0x06021B8D RID: 138125 RVA: 0x004A6236 File Offset: 0x004A4436
		// (set) Token: 0x06021B8E RID: 138126 RVA: 0x004A623E File Offset: 0x004A443E
		public int EntityPropertyId { get; set; }

		// Token: 0x170098B9 RID: 39097
		// (get) Token: 0x06021B8F RID: 138127 RVA: 0x004A6247 File Offset: 0x004A4447
		// (set) Token: 0x06021B90 RID: 138128 RVA: 0x004A624F File Offset: 0x004A444F
		public int FocusPriority { get; set; }

		// Token: 0x170098BA RID: 39098
		// (get) Token: 0x06021B91 RID: 138129 RVA: 0x004A6258 File Offset: 0x004A4458
		// (set) Token: 0x06021B92 RID: 138130 RVA: 0x004A6260 File Offset: 0x004A4460
		public EOnlineInteractType OnlineInteractType { get; set; }

		// Token: 0x170098BB RID: 39099
		// (get) Token: 0x06021B93 RID: 138131 RVA: 0x004A6269 File Offset: 0x004A4469
		// (set) Token: 0x06021B94 RID: 138132 RVA: 0x004A6271 File Offset: 0x004A4471
		public bool NotAllowHidedByTargetRange { get; set; }

		// Token: 0x170098BC RID: 39100
		// (get) Token: 0x06021B95 RID: 138133 RVA: 0x004A627A File Offset: 0x004A447A
		// (set) Token: 0x06021B96 RID: 138134 RVA: 0x004A6282 File Offset: 0x004A4482
		public ENpcDensity LowerNpcDensity { get; set; }

		// Token: 0x170098BD RID: 39101
		// (get) Token: 0x06021B97 RID: 138135 RVA: 0x004A628B File Offset: 0x004A448B
		// (set) Token: 0x06021B98 RID: 138136 RVA: 0x004A6293 File Offset: 0x004A4493
		public List<int> DataLayers { get; set; }

		// Token: 0x170098BE RID: 39102
		// (get) Token: 0x06021B99 RID: 138137 RVA: 0x004A629C File Offset: 0x004A449C
		// (set) Token: 0x06021B9A RID: 138138 RVA: 0x004A62A4 File Offset: 0x004A44A4
		public List<int> ChildEntityIds { get; set; }

		// Token: 0x170098BF RID: 39103
		// (get) Token: 0x06021B9B RID: 138139 RVA: 0x004A62AD File Offset: 0x004A44AD
		// (set) Token: 0x06021B9C RID: 138140 RVA: 0x004A62B5 File Offset: 0x004A44B5
		public bool IsOnlineStandalone { get; set; }

		// Token: 0x170098C0 RID: 39104
		// (get) Token: 0x06021B9D RID: 138141 RVA: 0x004A62BE File Offset: 0x004A44BE
		// (set) Token: 0x06021B9E RID: 138142 RVA: 0x004A62C6 File Offset: 0x004A44C6
		public List<string> SpecifiedOnlineStandaloneParentUids { get; set; }

		// Token: 0x170098C1 RID: 39105
		// (get) Token: 0x06021B9F RID: 138143 RVA: 0x004A62CF File Offset: 0x004A44CF
		// (set) Token: 0x06021BA0 RID: 138144 RVA: 0x004A62D7 File Offset: 0x004A44D7
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170098C2 RID: 39106
		// (get) Token: 0x06021BA1 RID: 138145 RVA: 0x004A62E0 File Offset: 0x004A44E0
		// (set) Token: 0x06021BA2 RID: 138146 RVA: 0x004A62E8 File Offset: 0x004A44E8
		public EEntityUpdateStrategy EntityUpdateStrategy { get; set; }

		// Token: 0x170098C3 RID: 39107
		// (get) Token: 0x06021BA3 RID: 138147 RVA: 0x004A62F1 File Offset: 0x004A44F1
		// (set) Token: 0x06021BA4 RID: 138148 RVA: 0x004A62F9 File Offset: 0x004A44F9
		public EMaterialUpdateStrategy MaterialUpdateStrategy { get; set; }

		// Token: 0x170098C4 RID: 39108
		// (get) Token: 0x06021BA5 RID: 138149 RVA: 0x004A6302 File Offset: 0x004A4502
		// (set) Token: 0x06021BA6 RID: 138150 RVA: 0x004A630A File Offset: 0x004A450A
		public ETimeScaleModifyStrategy TimeScaleModifyStrategy { get; set; }

		// Token: 0x170098C5 RID: 39109
		// (get) Token: 0x06021BA7 RID: 138151 RVA: 0x004A6313 File Offset: 0x004A4513
		// (set) Token: 0x06021BA8 RID: 138152 RVA: 0x004A631B File Offset: 0x004A451B
		public IEntityGravityConfigT GravityConfig { get; set; }

		// Token: 0x170098C6 RID: 39110
		// (get) Token: 0x06021BA9 RID: 138153 RVA: 0x004A6324 File Offset: 0x004A4524
		// (set) Token: 0x06021BAA RID: 138154 RVA: 0x004A632C File Offset: 0x004A452C
		public List<IHeadInfoChangeDataT> HeadInfoChangeConfig { get; set; }

		// Token: 0x170098C7 RID: 39111
		// (get) Token: 0x06021BAB RID: 138155 RVA: 0x004A6335 File Offset: 0x004A4535
		// (set) Token: 0x06021BAC RID: 138156 RVA: 0x004A633D File Offset: 0x004A453D
		public bool IsForceDestroy { get; set; }

		// Token: 0x170098C8 RID: 39112
		// (get) Token: 0x06021BAD RID: 138157 RVA: 0x004A6346 File Offset: 0x004A4546
		// (set) Token: 0x06021BAE RID: 138158 RVA: 0x004A634E File Offset: 0x004A454E
		public ITimeScaleConfigT TimeScaleConfig { get; set; }

		// Token: 0x170098C9 RID: 39113
		// (get) Token: 0x06021BAF RID: 138159 RVA: 0x004A6357 File Offset: 0x004A4557
		// (set) Token: 0x06021BB0 RID: 138160 RVA: 0x004A635F File Offset: 0x004A455F
		public List<IEntityAttachPointT> EntityAttachPointList { get; set; }

		// Token: 0x170098CA RID: 39114
		// (get) Token: 0x06021BB1 RID: 138161 RVA: 0x004A6368 File Offset: 0x004A4568
		// (set) Token: 0x06021BB2 RID: 138162 RVA: 0x004A6370 File Offset: 0x004A4570
		public int DelayDestroyDistance { get; set; }

		// Token: 0x170098CB RID: 39115
		// (get) Token: 0x06021BB3 RID: 138163 RVA: 0x004A6379 File Offset: 0x004A4579
		// (set) Token: 0x06021BB4 RID: 138164 RVA: 0x004A6381 File Offset: 0x004A4581
		public EClientEntityMark IsClientEntityFlag { get; set; }

		// Token: 0x170098CC RID: 39116
		// (get) Token: 0x06021BB5 RID: 138165 RVA: 0x004A638A File Offset: 0x004A458A
		// (set) Token: 0x06021BB6 RID: 138166 RVA: 0x004A6392 File Offset: 0x004A4592
		public bool KeepAnimationRateWithShadow { get; set; }

		// Token: 0x170098CD RID: 39117
		// (get) Token: 0x06021BB7 RID: 138167 RVA: 0x004A639B File Offset: 0x004A459B
		// (set) Token: 0x06021BB8 RID: 138168 RVA: 0x004A63A3 File Offset: 0x004A45A3
		public uint NullMask { get; set; }

		// Token: 0x06021BB9 RID: 138169 RVA: 0x004A63AC File Offset: 0x004A45AC
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
