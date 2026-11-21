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
	// Token: 0x020045FA RID: 17914
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoguePanelRole : UiPanelBase
	{
		// Token: 0x0602D0AF RID: 184495 RVA: 0x00C9868C File Offset: 0x00C9688C
		public MapRoguePanelRole(MapRogueGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
		}

		// Token: 0x0602D0B0 RID: 184496 RVA: 0x00C986E0 File Offset: 0x00C968E0
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

		// Token: 0x0602D0B1 RID: 184497 RVA: 0x00C98794 File Offset: 0x00C96994
		protected override UniTask OnBeforeStartAsync()
		{
			MapRoguePanelRole.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRoguePanelRole.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0B2 RID: 184498 RVA: 0x00C987D7 File Offset: 0x00C969D7
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

		// Token: 0x0602D0B3 RID: 184499 RVA: 0x00C987F4 File Offset: 0x00C969F4
		private UniTask InitRole()
		{
			MapRoguePanelRole.<InitRole>d__13 <InitRole>d__;
			<InitRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRole>d__.<>4__this = this;
			<InitRole>d__.<>1__state = -1;
			<InitRole>d__.<>t__builder.Start<MapRoguePanelRole.<InitRole>d__13>(ref <InitRole>d__);
			return <InitRole>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0B4 RID: 184500 RVA: 0x00C98837 File Offset: 0x00C96A37
		public void SetRoleDirection(bool directionRight)
		{
			this.DirectionRight = directionRight;
			base.GetItem(4).SetUIActive(!directionRight);
			base.GetItem(6).SetUIActive(directionRight);
		}

		// Token: 0x0602D0B5 RID: 184501 RVA: 0x00C98860 File Offset: 0x00C96A60
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

		// Token: 0x0602D0B6 RID: 184502 RVA: 0x00C988E9 File Offset: 0x00C96AE9
		public void SetRolePosItemVisible(bool bVisible)
		{
			base.GetItem(0).SetUIActive(bVisible);
		}

		// Token: 0x0602D0B7 RID: 184503 RVA: 0x00C988F8 File Offset: 0x00C96AF8
		public void SetListRootItem(global::Vector scaleVector)
		{
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIItemScale(scaleVector.ToUeVectorOld());
		}

		// Token: 0x0602D0B8 RID: 184504 RVA: 0x00C98924 File Offset: 0x00C96B24
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

		// Token: 0x0602D0B9 RID: 184505 RVA: 0x00C989CD File Offset: 0x00C96BCD
		private RogueGetListItem CreateProxyFunction()
		{
			return new RogueGetListItem();
		}

		// Token: 0x0602D0BA RID: 184506 RVA: 0x00C989D4 File Offset: 0x00C96BD4
		private bool CheckNext()
		{
			return !this.GameInfo.IsGetItemDataEmpty();
		}

		// Token: 0x040182C5 RID: 99013
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected ListSliderControl<RogueGetListItem> ListSliderControl;

		// Token: 0x040182C6 RID: 99014
		private readonly int ListMaxCount = ConfigCommonParamById.GetIntConfig("MapRogueGetListMaxCount").GetValueOrDefault(1);

		// Token: 0x040182C7 RID: 99015
		private readonly float ListAddItemTime = ConfigCommonParamById.GetFloatConfig("MapRogueGetListIntervalTime").GetValueOrDefault();

		// Token: 0x040182C8 RID: 99016
		private const string MALE_L_SPINE_ATLAS = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroL/Avatar_HeroL.Avatar_HeroL-atlas";

		// Token: 0x040182C9 RID: 99017
		private const string MALE_L_SPINE_SKELETON = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroL/Avatar_HeroL.Avatar_HeroL-data";

		// Token: 0x040182CA RID: 99018
		private const string MALE_R_SPINE_ATLAS = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroR/Avatar_HeroR.Avatar_HeroR-atlas";

		// Token: 0x040182CB RID: 99019
		private const string MALE_R_SPINE_SKELETON = "/Game/Aki/UI/UIResources/Common/Spine/RogueNanzhu/Avatar_HeroR/Avatar_HeroR.Avatar_HeroR-data";

		// Token: 0x040182CC RID: 99020
		protected MapRogueGameInfo GameInfo;

		// Token: 0x040182CD RID: 99021
		protected bool DirectionRight = true;
	}
}
