using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005624 RID: 22052
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelRole : UiPanelBase
	{
		// Token: 0x060381B1 RID: 229809 RVA: 0x00D4A944 File Offset: 0x00D48B44
		public MapRoguePanelRole(MapRogueGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
		}

		// Token: 0x060381B2 RID: 229810 RVA: 0x00D4A998 File Offset: 0x00D48B98
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060381B3 RID: 229811 RVA: 0x00D4AA4C File Offset: 0x00D48C4C
		protected override UniTask OnBeforeStartAsync()
		{
			MapRoguePanelRole.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRoguePanelRole.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060381B4 RID: 229812 RVA: 0x00D4AA8F File Offset: 0x00D48C8F
		public void OnTick(float delta)
		{
			if (base.IsShow)
			{
				ListSliderControl<RogueGetListItem> listSliderControl = this.ListSliderControl;
				if (listSliderControl == null)
				{
					return;
				}
				listSliderControl.Tick(delta);
			}
		}

		// Token: 0x060381B5 RID: 229813 RVA: 0x00D4AAAC File Offset: 0x00D48CAC
		private UniTask InitRole()
		{
			MapRoguePanelRole.<InitRole>d__13 <InitRole>d__;
			<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRole>d__.<>4__this = this;
			<InitRole>d__.<>1__state = -1;
			<InitRole>d__.<>t__builder.Start<MapRoguePanelRole.<InitRole>d__13>(ref <InitRole>d__);
			return <InitRole>d__.<>t__builder.Task;
		}

		// Token: 0x060381B6 RID: 229814 RVA: 0x00D4AAEF File Offset: 0x00D48CEF
		public void SetRoleDirection(bool directionRight)
		{
			this.DirectionRight = directionRight;
			base.GetItem(4).SetUIActive(!directionRight);
			base.GetItem(6).SetUIActive(directionRight);
		}

		// Token: 0x060381B7 RID: 229815 RVA: 0x00D4AB18 File Offset: 0x00D48D18
		public void SetRoleAnim(EMapRogueSpineAnim anim, bool loop = true)
		{
			MapRoguePanelRole.<>c__DisplayClass15_0 CS$<>8__locals1 = new MapRoguePanelRole.<>c__DisplayClass15_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.trackEntryL = base.GetSpine(3).SetAnimation(0, anim.ToEnumString(), loop);
			CS$<>8__locals1.trackEntryR = base.GetSpine(5).SetAnimation(0, anim.ToEnumString(), loop);
			if (!loop)
			{
				CS$<>8__locals1.trackEntryL.AnimationComplete.Add(new Action<UTrackEntry>(CS$<>8__locals1.<SetRoleAnim>g__back2Idle|0));
				CS$<>8__locals1.trackEntryR.AnimationComplete.Add(new Action<UTrackEntry>(CS$<>8__locals1.<SetRoleAnim>g__back2Idle|0));
			}
		}

		// Token: 0x060381B8 RID: 229816 RVA: 0x00D4ABA1 File Offset: 0x00D48DA1
		public void SetRolePosItemVisible(bool bVisible)
		{
			base.GetItem(0).SetUIActive(bVisible);
		}

		// Token: 0x060381B9 RID: 229817 RVA: 0x00D4ABB0 File Offset: 0x00D48DB0
		public void SetListRootItem(global::Vector scaleVector)
		{
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIItemScale(scaleVector.ToUeVectorOld());
		}

		// Token: 0x060381BA RID: 229818 RVA: 0x00D4ABDC File Offset: 0x00D48DDC
		private void InitListSlider()
		{
			this.ListSliderControl = new ListSliderControl<RogueGetListItem>(new ListSliderControlData<RogueGetListItem>(base.GetItem(2).GetParentAsUIItem(), new Func<RogueGetListItem>(this.CreateProxyFunction), new Func<bool>(this.CheckNext))
			{
				ChildTemplate = base.GetItem(2),
				MaxShowCount = new int?(this.ListMaxCount),
				AddItemTime = new float?(this.ListAddItemTime),
				TickMode = new ETickItemMode?(ETickItemMode.TickOnlyTop),
				ItemShowTime = ConfigCommonParamById.GetFloatConfig("MapRogueGetListShowTime"),
				ItemSliderTime = ConfigCommonParamById.GetFloatConfig("MapRogueGetListSilderTime")
			});
			this.ListSliderControl.DisEnableParentLayout();
		}

		// Token: 0x060381BB RID: 229819 RVA: 0x00D4AC85 File Offset: 0x00D48E85
		private RogueGetListItem CreateProxyFunction()
		{
			return new RogueGetListItem();
		}

		// Token: 0x060381BC RID: 229820 RVA: 0x00D4AC8C File Offset: 0x00D48E8C
		private bool CheckNext()
		{
			return !this.GameInfo.IsGetItemDataEmpty();
		}

		// Token: 0x0401D83A RID: 120890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected ListSliderControl<RogueGetListItem> ListSliderControl;

		// Token: 0x0401D83B RID: 120891
		private readonly int ListMaxCount = ConfigCommonParamById.GetIntConfig("MapRogueGetListMaxCount").GetValueOrDefault(1);

		// Token: 0x0401D83C RID: 120892
		private readonly float ListAddItemTime = ConfigCommonParamById.GetFloatConfig("MapRogueGetListIntervalTime").GetValueOrDefault();

		// Token: 0x0401D83D RID: 120893
		private const string MALE_L_SPINE_ATLAS = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroL/Avatar_HeroL.Avatar_HeroL-atlas";

		// Token: 0x0401D83E RID: 120894
		private const string MALE_L_SPINE_SKELETON = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroL/Avatar_HeroL.Avatar_HeroL-data";

		// Token: 0x0401D83F RID: 120895
		private const string MALE_R_SPINE_ATLAS = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroR/Avatar_HeroR.Avatar_HeroR-atlas";

		// Token: 0x0401D840 RID: 120896
		private const string MALE_R_SPINE_SKELETON = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroR/Avatar_HeroR.Avatar_HeroR-data";

		// Token: 0x0401D841 RID: 120897
		protected MapRogueGameInfo GameInfo;

		// Token: 0x0401D842 RID: 120898
		protected bool DirectionRight = true;
	}
}
