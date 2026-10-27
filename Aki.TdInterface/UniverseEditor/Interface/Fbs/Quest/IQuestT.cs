using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC6 RID: 16326
	public class IQuestT
	{
		// Token: 0x1700722D RID: 29229
		// (get) Token: 0x0601764D RID: 95821 RVA: 0x00360157 File Offset: 0x0035E357
		// (set) Token: 0x0601764E RID: 95822 RVA: 0x0036015F File Offset: 0x0035E35F
		public string ObjType { get; set; }

		// Token: 0x1700722E RID: 29230
		// (get) Token: 0x0601764F RID: 95823 RVA: 0x00360168 File Offset: 0x0035E368
		// (set) Token: 0x06017650 RID: 95824 RVA: 0x00360170 File Offset: 0x0035E370
		public List<string> Children { get; set; }

		// Token: 0x1700722F RID: 29231
		// (get) Token: 0x06017651 RID: 95825 RVA: 0x00360179 File Offset: 0x0035E379
		// (set) Token: 0x06017652 RID: 95826 RVA: 0x00360181 File Offset: 0x0035E381
		public List<string> Reference { get; set; }

		// Token: 0x17007230 RID: 29232
		// (get) Token: 0x06017653 RID: 95827 RVA: 0x0036018A File Offset: 0x0035E38A
		// (set) Token: 0x06017654 RID: 95828 RVA: 0x00360192 File Offset: 0x0035E392
		public List<string> WeakReference { get; set; }

		// Token: 0x17007231 RID: 29233
		// (get) Token: 0x06017655 RID: 95829 RVA: 0x0036019B File Offset: 0x0035E39B
		// (set) Token: 0x06017656 RID: 95830 RVA: 0x003601A3 File Offset: 0x0035E3A3
		public EQuest Type { get; set; }

		// Token: 0x17007232 RID: 29234
		// (get) Token: 0x06017657 RID: 95831 RVA: 0x003601AC File Offset: 0x0035E3AC
		// (set) Token: 0x06017658 RID: 95832 RVA: 0x003601B4 File Offset: 0x0035E3B4
		public EQuestSubType SubType { get; set; }

		// Token: 0x17007233 RID: 29235
		// (get) Token: 0x06017659 RID: 95833 RVA: 0x003601BD File Offset: 0x0035E3BD
		// (set) Token: 0x0601765A RID: 95834 RVA: 0x003601C5 File Offset: 0x0035E3C5
		public int Id { get; set; }

		// Token: 0x17007234 RID: 29236
		// (get) Token: 0x0601765B RID: 95835 RVA: 0x003601CE File Offset: 0x0035E3CE
		// (set) Token: 0x0601765C RID: 95836 RVA: 0x003601D6 File Offset: 0x0035E3D6
		public int DungeonId { get; set; }

		// Token: 0x17007235 RID: 29237
		// (get) Token: 0x0601765D RID: 95837 RVA: 0x003601DF File Offset: 0x0035E3DF
		// (set) Token: 0x0601765E RID: 95838 RVA: 0x003601E7 File Offset: 0x0035E3E7
		public List<ESystemModuleName> BindSystems { get; set; }

		// Token: 0x17007236 RID: 29238
		// (get) Token: 0x0601765F RID: 95839 RVA: 0x003601F0 File Offset: 0x0035E3F0
		// (set) Token: 0x06017660 RID: 95840 RVA: 0x003601F8 File Offset: 0x0035E3F8
		public string TidName { get; set; }

		// Token: 0x17007237 RID: 29239
		// (get) Token: 0x06017661 RID: 95841 RVA: 0x00360201 File Offset: 0x0035E401
		// (set) Token: 0x06017662 RID: 95842 RVA: 0x00360209 File Offset: 0x0035E409
		public string Key { get; set; }

		// Token: 0x17007238 RID: 29240
		// (get) Token: 0x06017663 RID: 95843 RVA: 0x00360212 File Offset: 0x0035E412
		// (set) Token: 0x06017664 RID: 95844 RVA: 0x0036021A File Offset: 0x0035E41A
		public string TidDesc { get; set; }

		// Token: 0x17007239 RID: 29241
		// (get) Token: 0x06017665 RID: 95845 RVA: 0x00360223 File Offset: 0x0035E423
		// (set) Token: 0x06017666 RID: 95846 RVA: 0x0036022B File Offset: 0x0035E42B
		public EQuestOnlineType OnlineType { get; set; }

		// Token: 0x1700723A RID: 29242
		// (get) Token: 0x06017667 RID: 95847 RVA: 0x00360234 File Offset: 0x0035E434
		// (set) Token: 0x06017668 RID: 95848 RVA: 0x0036023C File Offset: 0x0035E43C
		public bool IsAutoTrack { get; set; }

		// Token: 0x1700723B RID: 29243
		// (get) Token: 0x06017669 RID: 95849 RVA: 0x00360245 File Offset: 0x0035E445
		// (set) Token: 0x0601766A RID: 95850 RVA: 0x0036024D File Offset: 0x0035E44D
		public bool IsAutoCoverCurTrack { get; set; }

		// Token: 0x1700723C RID: 29244
		// (get) Token: 0x0601766B RID: 95851 RVA: 0x00360256 File Offset: 0x0035E456
		// (set) Token: 0x0601766C RID: 95852 RVA: 0x0036025E File Offset: 0x0035E45E
		public int RewardId { get; set; }

		// Token: 0x1700723D RID: 29245
		// (get) Token: 0x0601766D RID: 95853 RVA: 0x00360267 File Offset: 0x0035E467
		// (set) Token: 0x0601766E RID: 95854 RVA: 0x0036026F File Offset: 0x0035E46F
		public EQuestRegion RegionId { get; set; }

		// Token: 0x1700723E RID: 29246
		// (get) Token: 0x0601766F RID: 95855 RVA: 0x00360278 File Offset: 0x0035E478
		// (set) Token: 0x06017670 RID: 95856 RVA: 0x00360280 File Offset: 0x0035E480
		public int ChapterId { get; set; }

		// Token: 0x1700723F RID: 29247
		// (get) Token: 0x06017671 RID: 95857 RVA: 0x00360289 File Offset: 0x0035E489
		// (set) Token: 0x06017672 RID: 95858 RVA: 0x00360291 File Offset: 0x0035E491
		public int TagId { get; set; }

		// Token: 0x17007240 RID: 29248
		// (get) Token: 0x06017673 RID: 95859 RVA: 0x0036029A File Offset: 0x0035E49A
		// (set) Token: 0x06017674 RID: 95860 RVA: 0x003602A2 File Offset: 0x0035E4A2
		public int FunctionId { get; set; }

		// Token: 0x17007241 RID: 29249
		// (get) Token: 0x06017675 RID: 95861 RVA: 0x003602AB File Offset: 0x0035E4AB
		// (set) Token: 0x06017676 RID: 95862 RVA: 0x003602B3 File Offset: 0x0035E4B3
		public string RoleId { get; set; }

		// Token: 0x17007242 RID: 29250
		// (get) Token: 0x06017677 RID: 95863 RVA: 0x003602BC File Offset: 0x0035E4BC
		// (set) Token: 0x06017678 RID: 95864 RVA: 0x003602C4 File Offset: 0x0035E4C4
		public EDistrubuteType DistributeType { get; set; }

		// Token: 0x17007243 RID: 29251
		// (get) Token: 0x06017679 RID: 95865 RVA: 0x003602CD File Offset: 0x0035E4CD
		// (set) Token: 0x0601767A RID: 95866 RVA: 0x003602D5 File Offset: 0x0035E4D5
		public IDistributeParamsT DistributeParams { get; set; }

		// Token: 0x17007244 RID: 29252
		// (get) Token: 0x0601767B RID: 95867 RVA: 0x003602DE File Offset: 0x0035E4DE
		// (set) Token: 0x0601767C RID: 95868 RVA: 0x003602E6 File Offset: 0x0035E4E6
		public bool IsHideAcceptMarkOnNpc { get; set; }

		// Token: 0x17007245 RID: 29253
		// (get) Token: 0x0601767D RID: 95869 RVA: 0x003602EF File Offset: 0x0035E4EF
		// (set) Token: 0x0601767E RID: 95870 RVA: 0x003602F7 File Offset: 0x0035E4F7
		public bool IsHideInTaskList { get; set; }

		// Token: 0x17007246 RID: 29254
		// (get) Token: 0x0601767F RID: 95871 RVA: 0x00360300 File Offset: 0x0035E500
		// (set) Token: 0x06017680 RID: 95872 RVA: 0x00360308 File Offset: 0x0035E508
		public IAccessQuestConditionT ProvideType { get; set; }

		// Token: 0x17007247 RID: 29255
		// (get) Token: 0x06017681 RID: 95873 RVA: 0x00360311 File Offset: 0x0035E511
		// (set) Token: 0x06017682 RID: 95874 RVA: 0x00360319 File Offset: 0x0035E519
		public IAccessQuestConditionT AutoTrackConditions { get; set; }

		// Token: 0x17007248 RID: 29256
		// (get) Token: 0x06017683 RID: 95875 RVA: 0x00360322 File Offset: 0x0035E522
		// (set) Token: 0x06017684 RID: 95876 RVA: 0x0036032A File Offset: 0x0035E52A
		public List<int> RecommendPreQuest { get; set; }

		// Token: 0x17007249 RID: 29257
		// (get) Token: 0x06017685 RID: 95877 RVA: 0x00360333 File Offset: 0x0035E533
		// (set) Token: 0x06017686 RID: 95878 RVA: 0x0036033B File Offset: 0x0035E53B
		public int RecommendationPriority { get; set; }

		// Token: 0x1700724A RID: 29258
		// (get) Token: 0x06017687 RID: 95879 RVA: 0x00360344 File Offset: 0x0035E544
		// (set) Token: 0x06017688 RID: 95880 RVA: 0x0036034C File Offset: 0x0035E54C
		public IQuestUnlockDelayTimeT UnlockDelayTime { get; set; }

		// Token: 0x1700724B RID: 29259
		// (get) Token: 0x06017689 RID: 95881 RVA: 0x00360355 File Offset: 0x0035E555
		// (set) Token: 0x0601768A RID: 95882 RVA: 0x0036035D File Offset: 0x0035E55D
		public IPreShowInfoT PreShowInfo { get; set; }

		// Token: 0x1700724C RID: 29260
		// (get) Token: 0x0601768B RID: 95883 RVA: 0x00360366 File Offset: 0x0035E566
		// (set) Token: 0x0601768C RID: 95884 RVA: 0x0036036E File Offset: 0x0035E56E
		public IAddInteractOptionT AddInteractOption { get; set; }

		// Token: 0x1700724D RID: 29261
		// (get) Token: 0x0601768D RID: 95885 RVA: 0x00360377 File Offset: 0x0035E577
		// (set) Token: 0x0601768E RID: 95886 RVA: 0x0036037F File Offset: 0x0035E57F
		public List<IActionInfoT> ActiveActions { get; set; }

		// Token: 0x1700724E RID: 29262
		// (get) Token: 0x0601768F RID: 95887 RVA: 0x00360388 File Offset: 0x0035E588
		// (set) Token: 0x06017690 RID: 95888 RVA: 0x00360390 File Offset: 0x0035E590
		public List<IActionInfoT> AcceptActions { get; set; }

		// Token: 0x1700724F RID: 29263
		// (get) Token: 0x06017691 RID: 95889 RVA: 0x00360399 File Offset: 0x0035E599
		// (set) Token: 0x06017692 RID: 95890 RVA: 0x003603A1 File Offset: 0x0035E5A1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007250 RID: 29264
		// (get) Token: 0x06017693 RID: 95891 RVA: 0x003603AA File Offset: 0x0035E5AA
		// (set) Token: 0x06017694 RID: 95892 RVA: 0x003603B2 File Offset: 0x0035E5B2
		public List<IActionInfoT> TerminateActions { get; set; }

		// Token: 0x17007251 RID: 29265
		// (get) Token: 0x06017695 RID: 95893 RVA: 0x003603BB File Offset: 0x0035E5BB
		// (set) Token: 0x06017696 RID: 95894 RVA: 0x003603C3 File Offset: 0x0035E5C3
		public List<IActionInfoT> TerminateActions2 { get; set; }

		// Token: 0x17007252 RID: 29266
		// (get) Token: 0x06017697 RID: 95895 RVA: 0x003603CC File Offset: 0x0035E5CC
		// (set) Token: 0x06017698 RID: 95896 RVA: 0x003603D4 File Offset: 0x0035E5D4
		public List<int> ReferenceAllEntity { get; set; }

		// Token: 0x17007253 RID: 29267
		// (get) Token: 0x06017699 RID: 95897 RVA: 0x003603DD File Offset: 0x0035E5DD
		// (set) Token: 0x0601769A RID: 95898 RVA: 0x003603E5 File Offset: 0x0035E5E5
		public int ActivityId { get; set; }

		// Token: 0x17007254 RID: 29268
		// (get) Token: 0x0601769B RID: 95899 RVA: 0x003603EE File Offset: 0x0035E5EE
		// (set) Token: 0x0601769C RID: 95900 RVA: 0x003603F6 File Offset: 0x0035E5F6
		public IFocusModeSettingT FocusModeSetting { get; set; }

		// Token: 0x17007255 RID: 29269
		// (get) Token: 0x0601769D RID: 95901 RVA: 0x003603FF File Offset: 0x0035E5FF
		// (set) Token: 0x0601769E RID: 95902 RVA: 0x00360407 File Offset: 0x0035E607
		public bool DelayDestroy { get; set; }

		// Token: 0x17007256 RID: 29270
		// (get) Token: 0x0601769F RID: 95903 RVA: 0x00360410 File Offset: 0x0035E610
		// (set) Token: 0x060176A0 RID: 95904 RVA: 0x00360418 File Offset: 0x0035E618
		public IBehaviorTreeT Tree { get; set; }

		// Token: 0x17007257 RID: 29271
		// (get) Token: 0x060176A1 RID: 95905 RVA: 0x00360421 File Offset: 0x0035E621
		// (set) Token: 0x060176A2 RID: 95906 RVA: 0x00360429 File Offset: 0x0035E629
		public IQuestRecallConfigT RecallConfig { get; set; }

		// Token: 0x17007258 RID: 29272
		// (get) Token: 0x060176A3 RID: 95907 RVA: 0x00360432 File Offset: 0x0035E632
		// (set) Token: 0x060176A4 RID: 95908 RVA: 0x0036043A File Offset: 0x0035E63A
		public IEntityRefSearchPropT _EntityRefSearch { get; set; }

		// Token: 0x17007259 RID: 29273
		// (get) Token: 0x060176A5 RID: 95909 RVA: 0x00360443 File Offset: 0x0035E643
		// (set) Token: 0x060176A6 RID: 95910 RVA: 0x0036044B File Offset: 0x0035E64B
		public List<string> _HighlightDataPaths { get; set; }

		// Token: 0x1700725A RID: 29274
		// (get) Token: 0x060176A7 RID: 95911 RVA: 0x00360454 File Offset: 0x0035E654
		// (set) Token: 0x060176A8 RID: 95912 RVA: 0x0036045C File Offset: 0x0035E65C
		public string _FocusDataPath { get; set; }

		// Token: 0x1700725B RID: 29275
		// (get) Token: 0x060176A9 RID: 95913 RVA: 0x00360465 File Offset: 0x0035E665
		// (set) Token: 0x060176AA RID: 95914 RVA: 0x0036046D File Offset: 0x0035E66D
		public uint NullMask { get; set; }

		// Token: 0x060176AB RID: 95915 RVA: 0x00360478 File Offset: 0x0035E678
		public IQuestT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Type = EQuest.None;
			this.SubType = EQuestSubType.None;
			this.Id = 0;
			this.DungeonId = 0;
			this.BindSystems = null;
			this.TidName = null;
			this.Key = null;
			this.TidDesc = null;
			this.OnlineType = EQuestOnlineType.SingleHangUpOnline;
			this.IsAutoTrack = false;
			this.IsAutoCoverCurTrack = false;
			this.RewardId = 0;
			this.RegionId = EQuestRegion.None;
			this.ChapterId = 0;
			this.TagId = 0;
			this.FunctionId = 0;
			this.RoleId = null;
			this.DistributeType = EDistrubuteType.Interact;
			this.DistributeParams = null;
			this.IsHideAcceptMarkOnNpc = false;
			this.IsHideInTaskList = false;
			this.ProvideType = null;
			this.AutoTrackConditions = null;
			this.RecommendPreQuest = null;
			this.RecommendationPriority = 0;
			this.UnlockDelayTime = null;
			this.PreShowInfo = null;
			this.AddInteractOption = null;
			this.ActiveActions = null;
			this.AcceptActions = null;
			this.FinishActions = null;
			this.TerminateActions = null;
			this.TerminateActions2 = null;
			this.ReferenceAllEntity = null;
			this.ActivityId = 0;
			this.FocusModeSetting = null;
			this.DelayDestroy = false;
			this.Tree = null;
			this.RecallConfig = null;
			this._EntityRefSearch = null;
			this._HighlightDataPaths = null;
			this._FocusDataPath = null;
			this.NullMask = 0U;
		}
	}
}
