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
	// Token: 0x0200539C RID: 21404
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleAreaInfoView : UiViewBase
	{
		// Token: 0x06036AE1 RID: 223969 RVA: 0x00CF0F06 File Offset: 0x00CEF106
		public MoraleAreaInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036AE2 RID: 223970 RVA: 0x00CF0F1C File Offset: 0x00CEF11C
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

		// Token: 0x06036AE3 RID: 223971 RVA: 0x00CF1248 File Offset: 0x00CEF448
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

		// Token: 0x06036AE4 RID: 223972 RVA: 0x00CF12F0 File Offset: 0x00CEF4F0
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleAreaInfoView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleAreaInfoView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036AE5 RID: 223973 RVA: 0x00CF1334 File Offset: 0x00CEF534
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			MoraleAreaInfoView.<OnPlayingStartSequenceAsync>d__15 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<MoraleAreaInfoView.<OnPlayingStartSequenceAsync>d__15>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036AE6 RID: 223974 RVA: 0x00CF1377 File Offset: 0x00CEF577
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MoraleAreaChangeFlag, new Action<int>(this.EventMoraleAreaChangeFlag));
		}

		// Token: 0x06036AE7 RID: 223975 RVA: 0x00CF1395 File Offset: 0x00CEF595
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MoraleAreaChangeFlag, new Action<int>(this.EventMoraleAreaChangeFlag));
		}

		// Token: 0x06036AE8 RID: 223976 RVA: 0x00CF13B3 File Offset: 0x00CEF5B3
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06036AE9 RID: 223977 RVA: 0x00CF13BB File Offset: 0x00CEF5BB
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06036AEA RID: 223978 RVA: 0x00CF13BD File Offset: 0x00CEF5BD
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036AEB RID: 223979 RVA: 0x00CF13C8 File Offset: 0x00CEF5C8
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

		// Token: 0x06036AEC RID: 223980 RVA: 0x00CF1424 File Offset: 0x00CEF624
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

		// Token: 0x06036AED RID: 223981 RVA: 0x00CF14D4 File Offset: 0x00CEF6D4
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

		// Token: 0x06036AEE RID: 223982 RVA: 0x00CF153C File Offset: 0x00CEF73C
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

		// Token: 0x06036AEF RID: 223983 RVA: 0x00CF1611 File Offset: 0x00CEF811
		public void SelectFlag(MoraleAreaFlagData flagData)
		{
			this.FlagData = flagData;
			this.UpdateSelectFlagState();
			this.FlagMonsterInfoPanel.UpdateData(this.FlagData);
			this.MapPanel.UpdateFlagState();
		}

		// Token: 0x06036AF0 RID: 223984 RVA: 0x00CF163C File Offset: 0x00CEF83C
		public void SelectFlagId(int flagId)
		{
			this.FlagData = this.AreaData.GetFlag(flagId);
			this.SelectFlag(this.FlagData);
		}

		// Token: 0x06036AF1 RID: 223985 RVA: 0x00CF165C File Offset: 0x00CEF85C
		private void EventMoraleAreaChangeFlag(int flagId)
		{
			this.SelectFlagId(flagId);
		}

		// Token: 0x06036AF2 RID: 223986 RVA: 0x00CF1668 File Offset: 0x00CEF868
		public UniTask UpdateMapData()
		{
			MoraleAreaInfoView.<UpdateMapData>d__28 <UpdateMapData>d__;
			<UpdateMapData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMapData>d__.<>4__this = this;
			<UpdateMapData>d__.<>1__state = -1;
			<UpdateMapData>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateMapData>d__28>(ref <UpdateMapData>d__);
			return <UpdateMapData>d__.<>t__builder.Task;
		}

		// Token: 0x06036AF3 RID: 223987 RVA: 0x00CF16AC File Offset: 0x00CEF8AC
		private UniTask UpdateMapBg()
		{
			MoraleAreaInfoView.<UpdateMapBg>d__29 <UpdateMapBg>d__;
			<UpdateMapBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMapBg>d__.<>4__this = this;
			<UpdateMapBg>d__.<>1__state = -1;
			<UpdateMapBg>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateMapBg>d__29>(ref <UpdateMapBg>d__);
			return <UpdateMapBg>d__.<>t__builder.Task;
		}

		// Token: 0x06036AF4 RID: 223988 RVA: 0x00CF16F0 File Offset: 0x00CEF8F0
		private UniTask UpdateDiffLightBg()
		{
			MoraleAreaInfoView.<UpdateDiffLightBg>d__30 <UpdateDiffLightBg>d__;
			<UpdateDiffLightBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateDiffLightBg>d__.<>4__this = this;
			<UpdateDiffLightBg>d__.<>1__state = -1;
			<UpdateDiffLightBg>d__.<>t__builder.Start<MoraleAreaInfoView.<UpdateDiffLightBg>d__30>(ref <UpdateDiffLightBg>d__);
			return <UpdateDiffLightBg>d__.<>t__builder.Task;
		}

		// Token: 0x06036AF5 RID: 223989 RVA: 0x00CF1733 File Offset: 0x00CEF933
		private void OnClickFlagItem(MoraleAreaFlagData flagData)
		{
			this.SelectFlag(flagData);
			this.FlagMonsterInfoPanel.PlayEnter();
			this.UpdateDiffLightBg().Forget();
		}

		// Token: 0x06036AF6 RID: 223990 RVA: 0x00CF1754 File Offset: 0x00CEF954
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

		// Token: 0x06036AF7 RID: 223991 RVA: 0x00CF17A0 File Offset: 0x00CEF9A0
		private void OnBtnSmallFlagDesc()
		{
			MoraleModel instance = MoraleModel.Instance;
			string descKey = ((instance != null) ? new bool?(instance.IsMoraleGameOver()) : null).GetValueOrDefault() ? "Morale_title_39" : "Morale_title_21";
			this.SmallFlagDescPanel.SetActive(true);
			this.SmallFlagDescPanel.UpdateDesc(descKey);
		}

		// Token: 0x06036AF8 RID: 223992 RVA: 0x00CF17FA File Offset: 0x00CEF9FA
		private void OnClickBtnExploreBoxTrack()
		{
			MoraleModel instance = MoraleModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.TrackAreaExploreBox(this.AreaData.Id);
		}

		// Token: 0x06036AF9 RID: 223993 RVA: 0x00CF1816 File Offset: 0x00CEFA16
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

		// Token: 0x0401CE20 RID: 118304
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401CE21 RID: 118305
		public MoraleSumLvInfoPanel SumLvInfoPanel;

		// Token: 0x0401CE22 RID: 118306
		public MoraleFlagMonsterInfoPanel FlagMonsterInfoPanel;

		// Token: 0x0401CE23 RID: 118307
		public MoraleAreaInfoMapPanel MapPanel;

		// Token: 0x0401CE24 RID: 118308
		public MoraleAreaInfoFlagDescPanel SmallFlagDescPanel;

		// Token: 0x0401CE25 RID: 118309
		public MoraleAreaData AreaData;

		// Token: 0x0401CE26 RID: 118310
		public MoraleAreaFlagData FlagData;

		// Token: 0x0401CE27 RID: 118311
		public MoraleModel Model;

		// Token: 0x0401CE28 RID: 118312
		public string LastLightBgPath = "";

		// Token: 0x0200B609 RID: 46601
		[NullableContext(0)]
		[RequiredMember]
		public class Params
		{
			// Token: 0x0604EF38 RID: 323384 RVA: 0x01514716 File Offset: 0x01512916
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public Params()
			{
			}

			// Token: 0x0403723D RID: 225853
			[RequiredMember]
			public int AreaId;

			// Token: 0x0403723E RID: 225854
			public int? FlagId;
		}

		// Token: 0x0200B60A RID: 46602
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04037240 RID: 225856
			ItemCaption,
			// Token: 0x04037241 RID: 225857
			ItemLevelInfoPanel,
			// Token: 0x04037242 RID: 225858
			ItemLeftBottomRoot,
			// Token: 0x04037243 RID: 225859
			ItemSmallFlagTipsRoot,
			// Token: 0x04037244 RID: 225860
			ItemFlagInfoPanel,
			// Token: 0x04037245 RID: 225861
			ItemArea1Pos,
			// Token: 0x04037246 RID: 225862
			ItemArea2Pos,
			// Token: 0x04037247 RID: 225863
			ItemArea3Pos,
			// Token: 0x04037248 RID: 225864
			ItemArea4Pos,
			// Token: 0x04037249 RID: 225865
			ItemArea5Pos,
			// Token: 0x0403724A RID: 225866
			TexMapBg,
			// Token: 0x0403724B RID: 225867
			TexDiffLight,
			// Token: 0x0403724C RID: 225868
			SpriteMapGridBg,
			// Token: 0x0403724D RID: 225869
			ItemSmallFlagDesc,
			// Token: 0x0403724E RID: 225870
			BtnSmallFlagDesc,
			// Token: 0x0403724F RID: 225871
			TxtFlagBoxNumPercent,
			// Token: 0x04037250 RID: 225872
			TxtExploreBoxNumPercent,
			// Token: 0x04037251 RID: 225873
			TxtSmallFlagNumPercent,
			// Token: 0x04037252 RID: 225874
			ItemExploreBoxRoot,
			// Token: 0x04037253 RID: 225875
			BtnExploreBoxTrack
		}
	}
}
