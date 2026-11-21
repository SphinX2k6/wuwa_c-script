using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A7 RID: 21415
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelDetailView : UiViewBase
	{
		// Token: 0x06035443 RID: 218179 RVA: 0x00EE0BEA File Offset: 0x00EDEDEA
		public MotorFightLevelDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035444 RID: 218180 RVA: 0x00EE0BF4 File Offset: 0x00EDEDF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnChangeRoleBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnGotoBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035445 RID: 218181 RVA: 0x00EE0F40 File Offset: 0x00EDF140
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightLevelDetailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightLevelDetailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035446 RID: 218182 RVA: 0x00EE0F84 File Offset: 0x00EDF184
		protected override void OnHandleLoadScene()
		{
			MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorTakeRole);
			int trialRoleId = this.ViewModel.ActivityData.GetMotorFightRoleData(this.ViewModel.SelectedRoleId).TrialRoleId;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleId, true);
			MotorcycleUiModelUtil.Instance.LoadEquippedMotorAndRole(roleDataById.GetRoleId(), roleDataById.GetRoleSkinId(), null);
		}

		// Token: 0x06035447 RID: 218183 RVA: 0x00EE0FE4 File Offset: 0x00EDF1E4
		protected override void OnBeforeShow()
		{
			MotorcycleUiModelUtil.Instance.ShowMotor(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), this.LevelData.LevelName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), this.LevelData.LevelDesc, Array.Empty<object>());
			bool flag = this.LevelData.Type == EMotorFightLevelType.Difficulty;
			bool flag2 = this.LevelData.Type == EMotorFightLevelType.Endless;
			UUIArtText artText = base.GetArtText(10);
			artText.SetUIActive(!flag2);
			artText.SetText(this.LevelData.Number);
			UUIItem uuiitem = artText;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(artText.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.SetTextureByPath(MotorFightConfig.Instance.GetMotorFightLevelType((int)this.LevelData.Type).Value.SelectLevelStateBg, base.GetTexture(4), null, null);
			base.SetTextureByPath(this.LevelData.LevelBg, base.GetTexture(5), null, null);
			UUITexture texture = base.GetTexture(6);
			UUIItem uuiitem2 = texture;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(texture.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			UUISprite sprite = base.GetSprite(7);
			UUIItem uuiitem3 = sprite;
			bool bUseChangeColor3 = flag;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
			UUISprite sprite2 = base.GetSprite(11);
			UUIItem uuiitem4 = sprite2;
			bool bUseChangeColor4 = flag;
			fcolor = new FColor?(sprite2.changeColor);
			uuiitem4.SetChangeColor(bUseChangeColor4, fcolor);
			UUISprite sprite3 = base.GetSprite(12);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(flag2);
			}
			UUIText text = base.GetText(17);
			if (this.LevelData.BestScore != 0)
			{
				text.SetText(this.LevelData.BestScore.ToString(), true);
			}
			this.RefreshRoleInfo();
			UUIItem item = base.GetItem(20);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ViewModel.ActivityData.IsRoleHasRedDot());
		}

		// Token: 0x06035448 RID: 218184 RVA: 0x00EE11CC File Offset: 0x00EDF3CC
		private void RefreshRoleInfo()
		{
			int selectedRoleId = this.ViewModel.SelectedRoleId;
			MotorFightRoleData motorFightRoleData = this.ViewModel.ActivityData.GetMotorFightRoleData(selectedRoleId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), motorFightRoleData.RoleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), motorFightRoleData.BuffName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorFightRoleData.BuffDesc, motorFightRoleData.BuffDescParams);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(motorFightRoleData.TrialRoleId, true);
			MotorcycleUiModelUtil.Instance.RefreshRoleInMotor(roleDataById.GetRoleId(), roleDataById.GetRoleSkinId(), motorFightRoleData.AnimPath);
		}

		// Token: 0x06035449 RID: 218185 RVA: 0x00EE127B File Offset: 0x00EDF47B
		protected override void OnHandleReleaseScene()
		{
			MotorcycleUiModelUtil.Instance.DestroyMotor();
		}

		// Token: 0x0603544A RID: 218186 RVA: 0x00EE1287 File Offset: 0x00EDF487
		private CommonItemSmallItemGrid CreateItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.LevelData.IsFinished)
			};
		}

		// Token: 0x0603544B RID: 218187 RVA: 0x00EE12A0 File Offset: 0x00EDF4A0
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603544C RID: 218188 RVA: 0x00EE12A9 File Offset: 0x00EDF4A9
		private void OnChangeRoleBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRoleSelectView, this.ViewModel, null);
		}

		// Token: 0x0603544D RID: 218189 RVA: 0x00EE12C1 File Offset: 0x00EDF4C1
		private void OnGotoBtnClick()
		{
			MotorFightController.Instance.EnterMotorFightDungeonDirectly(this.LevelData.Id, this.ViewModel.SelectedRoleId, false);
		}

		// Token: 0x0401C173 RID: 115059
		private MotorFightLevelData LevelData;

		// Token: 0x0401C174 RID: 115060
		private MotorFightLevelDetailViewModel ViewModel;

		// Token: 0x0401C175 RID: 115061
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C176 RID: 115062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200B045 RID: 45125
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403677F RID: 223103
			public const int ItemCaption = 0;

			// Token: 0x04036780 RID: 223104
			public const int TextRoleName = 1;

			// Token: 0x04036781 RID: 223105
			public const int TextBuffDesc = 2;

			// Token: 0x04036782 RID: 223106
			public const int BtnChangeRole = 3;

			// Token: 0x04036783 RID: 223107
			public const int TextureBg = 4;

			// Token: 0x04036784 RID: 223108
			public const int TextureInfoBg = 5;

			// Token: 0x04036785 RID: 223109
			public const int TextureTitleBg = 6;

			// Token: 0x04036786 RID: 223110
			public const int SpriteTitleLight = 7;

			// Token: 0x04036787 RID: 223111
			public const int TextLevelName = 8;

			// Token: 0x04036788 RID: 223112
			public const int ItemNumberPanel = 9;

			// Token: 0x04036789 RID: 223113
			public const int ArtNumber = 10;

			// Token: 0x0403678A RID: 223114
			public const int SpriteNumberBg = 11;

			// Token: 0x0403678B RID: 223115
			public const int SpriteEndlessIcon = 12;

			// Token: 0x0403678C RID: 223116
			public const int ItemRewardPanel = 13;

			// Token: 0x0403678D RID: 223117
			public const int TextLevelDesc = 14;

			// Token: 0x0403678E RID: 223118
			public const int LayoutReward = 15;

			// Token: 0x0403678F RID: 223119
			public const int ItemReward = 16;

			// Token: 0x04036790 RID: 223120
			public const int TextScore = 17;

			// Token: 0x04036791 RID: 223121
			public const int BtnGoto = 18;

			// Token: 0x04036792 RID: 223122
			public const int TextBuffName = 19;

			// Token: 0x04036793 RID: 223123
			public const int ItemChangeBtnRedDot = 20;
		}
	}
}
