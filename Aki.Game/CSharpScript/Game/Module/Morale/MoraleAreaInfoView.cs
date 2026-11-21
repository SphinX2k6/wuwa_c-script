using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Morale.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200437F RID: 17279
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoView : UiViewBase
	{
		// Token: 0x0602BA27 RID: 178727 RVA: 0x00C3FFAE File Offset: 0x00C3E1AE
		public MoraleAreaInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BA28 RID: 178728 RVA: 0x00C3FFC4 File Offset: 0x00C3E1C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnBtnSmallFlagDesc));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(19, new Action(this.OnClickBtnExploreBoxTrack));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602BA29 RID: 178729 RVA: 0x00C402F0 File Offset: 0x00C3E4F0
		private void InitDataParam()
		{
			this.Model = MoraleModel.Instance;
			MoraleAreaInfoView.Params @params = this.OpenParam as MoraleAreaInfoView.Params;
			int areaId = (@params != null) ? @params.AreaId : this.Model.AreaDataList[0].Id;
			this.AreaData = this.Model.GetAreaData(areaId);
			MoraleAreaInfoView.Params params2 = this.OpenParam as MoraleAreaInfoView.Params;
			int flagId = ((params2 != null) ? params2.FlagId : null) ?? this.AreaData.GetDefaultSelectFlagId();
			this.FlagData = this.AreaData.GetFlag(flagId);
		}

		// Token: 0x0602BA2A RID: 178730 RVA: 0x00C40398 File Offset: 0x00C3E598
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaInfoView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaInfoView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA2B RID: 178731 RVA: 0x00C403DC File Offset: 0x00C3E5DC
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			MoraleAreaInfoView.<OnPlayingStartSequenceAsync>d__15 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<MoraleAreaInfoView.<OnPlayingStartSequenceAsync>d__15>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA2C RID: 178732 RVA: 0x00C4041F File Offset: 0x00C3E61F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoraleAreaChangeFlag, new Action<int>(this.EventMoraleAreaChangeFlag));
		}

		// Token: 0x0602BA2D RID: 178733 RVA: 0x00C4043D File Offset: 0x00C3E63D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoraleAreaChangeFlag, new Action<int>(this.EventMoraleAreaChangeFlag));
		}

		// Token: 0x0602BA2E RID: 178734 RVA: 0x00C4045B File Offset: 0x00C3E65B
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x0602BA2F RID: 178735 RVA: 0x00C40463 File Offset: 0x00C3E663
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602BA30 RID: 178736 RVA: 0x00C40465 File Offset: 0x00C3E665
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BA31 RID: 178737 RVA: 0x00C40470 File Offset: 0x00C3E670
		public void UpdateData()
		{
			this.SumLvInfoPanel.UpdateData();
			this.MapPanel.UpdateData();
			this.SelectFlag(this.FlagData);
			this.PopupCaption.SetTitleLocalText(this.AreaData.Config.Name);
			this.UpdateSmallFlagNumPercent();
			this.UpdateFlagBoxNumPercent();
			this.UpdateExploreBoxNumPercent();
		}

		// Token: 0x0602BA32 RID: 178738 RVA: 0x00C404CC File Offset: 0x00C3E6CC
		public void UpdateSmallFlagNumPercent()
		{
			if (!MoraleConfig.Instance.GetMoraleIsShowSmallFlagProgress())
			{
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				bool flag = this.Model.IsMoraleGameOver();
				UUIItem item2 = base.GetItem(3);
				if (item2 != null)
				{
					item2.SetUIActive(!flag);
				}
				if (flag)
				{
					return;
				}
				int areaFlagTotalNum = this.AreaData.GetAreaFlagTotalNum(EMoraleFlagType.Small);
				int areaFlagActiveNum = this.AreaData.GetAreaFlagActiveNum(EMoraleFlagType.Small);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(areaFlagActiveNum);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(areaFlagTotalNum);
				string newText = defaultInterpolatedStringHandler.ToStringAndClear();
				UUIText text = base.GetText(17);
				if (text == null)
				{
					return;
				}
				text.SetText(newText, true);
				return;
			}
		}

		// Token: 0x0602BA33 RID: 178739 RVA: 0x00C4057C File Offset: 0x00C3E77C
		public void UpdateFlagBoxNumPercent()
		{
			int allFlagBoxTotalCount = this.AreaData.GetAllFlagBoxTotalCount();
			int allFlagBoxReceivedCount = this.AreaData.GetAllFlagBoxReceivedCount();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(allFlagBoxReceivedCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(allFlagBoxTotalCount);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(15);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
		}

		// Token: 0x0602BA34 RID: 178740 RVA: 0x00C405E4 File Offset: 0x00C3E7E4
		public void UpdateExploreBoxNumPercent()
		{
			UUIButtonComponent button = base.GetButton(19);
			UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
			UUIItem item = base.GetItem(18);
			if (!MoraleConfig.Instance.GetMoraleHighFlagUnFinishIsShowExploreBoxProgress() && !this.AreaData.HighDifficultyFlagSomeActive())
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(false);
				}
				return;
			}
			int exploreBoxTotalCount = this.AreaData.ExploreBoxTotalCount;
			int exploreBoxReceivedCount = this.AreaData.ExploreBoxReceivedCount;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(exploreBoxReceivedCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(exploreBoxTotalCount);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(16);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(exploreBoxReceivedCount < exploreBoxTotalCount);
			}
		}

		// Token: 0x0602BA35 RID: 178741 RVA: 0x00C406B9 File Offset: 0x00C3E8B9
		public void SelectFlag(MoraleAreaFlagData flagData)
		{
			this.FlagData = flagData;
			this.UpdateSelectFlagState();
			this.FlagMonsterInfoPanel.UpdateData(this.FlagData);
			this.MapPanel.UpdateFlagState();
		}

		// Token: 0x0602BA36 RID: 178742 RVA: 0x00C406E4 File Offset: 0x00C3E8E4
		public void SelectFlagId(int flagId)
		{
			this.FlagData = this.AreaData.GetFlag(flagId);
			this.SelectFlag(this.FlagData);
		}

		// Token: 0x0602BA37 RID: 178743 RVA: 0x00C40704 File Offset: 0x00C3E904
		private void EventMoraleAreaChangeFlag(int flagId)
		{
			this.SelectFlagId(flagId);
		}

		// Token: 0x0602BA38 RID: 178744 RVA: 0x00C40710 File Offset: 0x00C3E910
		public UniTask UpdateMapData()
		{
			MoraleAreaInfoView.<UpdateMapData>d__28 <UpdateMapData>d__;
			<UpdateMapData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMapData>d__.<>4__this = this;
			<UpdateMapData>d__.<>1__state = -1;
			<UpdateMapData>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateMapData>d__28>(ref <UpdateMapData>d__);
			return <UpdateMapData>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA39 RID: 178745 RVA: 0x00C40754 File Offset: 0x00C3E954
		private UniTask UpdateMapBg()
		{
			MoraleAreaInfoView.<UpdateMapBg>d__29 <UpdateMapBg>d__;
			<UpdateMapBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMapBg>d__.<>4__this = this;
			<UpdateMapBg>d__.<>1__state = -1;
			<UpdateMapBg>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateMapBg>d__29>(ref <UpdateMapBg>d__);
			return <UpdateMapBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA3A RID: 178746 RVA: 0x00C40798 File Offset: 0x00C3E998
		private UniTask UpdateDiffLightBg()
		{
			MoraleAreaInfoView.<UpdateDiffLightBg>d__30 <UpdateDiffLightBg>d__;
			<UpdateDiffLightBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateDiffLightBg>d__.<>4__this = this;
			<UpdateDiffLightBg>d__.<>1__state = -1;
			<UpdateDiffLightBg>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateDiffLightBg>d__30>(ref <UpdateDiffLightBg>d__);
			return <UpdateDiffLightBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602BA3B RID: 178747 RVA: 0x00C407DB File Offset: 0x00C3E9DB
		private void OnClickFlagItem(MoraleAreaFlagData flagData)
		{
			this.SelectFlag(flagData);
			this.FlagMonsterInfoPanel.PlayEnter();
			this.UpdateDiffLightBg().Forget();
		}

		// Token: 0x0602BA3C RID: 178748 RVA: 0x00C407FC File Offset: 0x00C3E9FC
		public void UpdateSelectFlagState()
		{
			MoraleAreaFlagData flagData = this.FlagData;
			IReadOnlyList<MoraleAreaFlagData> uiFlagList = this.AreaData.GetUiFlagList();
			for (int i = 0; i < uiFlagList.Count; i++)
			{
				MoraleAreaFlagData moraleAreaFlagData = uiFlagList[i];
				moraleAreaFlagData.SetSelectState(moraleAreaFlagData.Id == flagData.Id);
			}
		}

		// Token: 0x0602BA3D RID: 178749 RVA: 0x00C40848 File Offset: 0x00C3EA48
		private void OnBtnSmallFlagDesc()
		{
			MoraleModel instance = MoraleModel.Instance;
			string descKey = ((instance != null) ? new bool?(instance.IsMoraleGameOver()) : null).GetValueOrDefault() ? "Morale_title_39" : "Morale_title_21";
			this.SmallFlagDescPanel.SetActive(true);
			this.SmallFlagDescPanel.UpdateDesc(descKey);
		}

		// Token: 0x0602BA3E RID: 178750 RVA: 0x00C408A2 File Offset: 0x00C3EAA2
		private void OnClickBtnExploreBoxTrack()
		{
			MoraleModel instance = MoraleModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.TrackAreaExploreBox(this.AreaData.Id);
		}

		// Token: 0x0602BA3F RID: 178751 RVA: 0x00C408BE File Offset: 0x00C3EABE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx([Nullable(new byte[]
		{
			2,
			1
		})] string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "BossFlag"))
			{
				return null;
			}
			MoraleAreaInfoMapPanel mapPanel = this.MapPanel;
			if (mapPanel == null)
			{
				return null;
			}
			return mapPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x040178B8 RID: 96440
		public PopupCaptionItem PopupCaption;

		// Token: 0x040178B9 RID: 96441
		public MoraleSumLvInfoPanel SumLvInfoPanel;

		// Token: 0x040178BA RID: 96442
		public MoraleFlagMonsterInfoPanel FlagMonsterInfoPanel;

		// Token: 0x040178BB RID: 96443
		public MoraleAreaInfoMapPanel MapPanel;

		// Token: 0x040178BC RID: 96444
		public MoraleAreaInfoFlagDescPanel SmallFlagDescPanel;

		// Token: 0x040178BD RID: 96445
		public MoraleAreaData AreaData;

		// Token: 0x040178BE RID: 96446
		public MoraleAreaFlagData FlagData;

		// Token: 0x040178BF RID: 96447
		public MoraleModel Model;

		// Token: 0x040178C0 RID: 96448
		public string LastLightBgPath = "";

		// Token: 0x0200A041 RID: 41025
		[NullableContext(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x06045535 RID: 283957 RVA: 0x014CE282 File Offset: 0x014CC482
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x04031C92 RID: 203922
			[RequiredMember]
			public int AreaId;

			// Token: 0x04031C93 RID: 203923
			public int? FlagId;
		}

		// Token: 0x0200A042 RID: 41026
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04031C95 RID: 203925
			ItemCaption,
			// Token: 0x04031C96 RID: 203926
			ItemLevelInfoPanel,
			// Token: 0x04031C97 RID: 203927
			ItemLeftBottomRoot,
			// Token: 0x04031C98 RID: 203928
			ItemSmallFlagTipsRoot,
			// Token: 0x04031C99 RID: 203929
			ItemFlagInfoPanel,
			// Token: 0x04031C9A RID: 203930
			ItemArea1Pos,
			// Token: 0x04031C9B RID: 203931
			ItemArea2Pos,
			// Token: 0x04031C9C RID: 203932
			ItemArea3Pos,
			// Token: 0x04031C9D RID: 203933
			ItemArea4Pos,
			// Token: 0x04031C9E RID: 203934
			ItemArea5Pos,
			// Token: 0x04031C9F RID: 203935
			TexMapBg,
			// Token: 0x04031CA0 RID: 203936
			TexDiffLight,
			// Token: 0x04031CA1 RID: 203937
			SpriteMapGridBg,
			// Token: 0x04031CA2 RID: 203938
			ItemSmallFlagDesc,
			// Token: 0x04031CA3 RID: 203939
			BtnSmallFlagDesc,
			// Token: 0x04031CA4 RID: 203940
			TxtFlagBoxNumPercent,
			// Token: 0x04031CA5 RID: 203941
			TxtExploreBoxNumPercent,
			// Token: 0x04031CA6 RID: 203942
			TxtSmallFlagNumPercent,
			// Token: 0x04031CA7 RID: 203943
			ItemExploreBoxRoot,
			// Token: 0x04031CA8 RID: 203944
			BtnExploreBoxTrack
		}
	}
}
