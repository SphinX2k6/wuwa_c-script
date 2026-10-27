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
	// Token: 0x02006429 RID: 25641
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelDetailView : UiViewBase
	{
		// Token: 0x06040782 RID: 264066 RVA: 0x00F99C4A File Offset: 0x00F97E4A
		public MotorFightLevelDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040783 RID: 264067 RVA: 0x00F99C54 File Offset: 0x00F97E54
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

		// Token: 0x06040784 RID: 264068 RVA: 0x00F99FA0 File Offset: 0x00F981A0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightLevelDetailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightLevelDetailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040785 RID: 264069 RVA: 0x00F99FE4 File Offset: 0x00F981E4
		protected override void OnHandleLoadScene()
		{
			MotorcycleUiModelUtil.Instance.CreateMotor(EUiModelUseWay.MotorTakeRole);
			int trialRoleId = this.ViewModel.ActivityData.GetMotorFightRoleData(this.ViewModel.SelectedRoleId).TrialRoleId;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleId, true);
			MotorcycleUiModelUtil.Instance.LoadEquippedMotorAndRole(roleDataById.GetRoleId(), roleDataById.GetRoleSkinId(), null);
		}

		// Token: 0x06040786 RID: 264070 RVA: 0x00F9A044 File Offset: 0x00F98244
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

		// Token: 0x06040787 RID: 264071 RVA: 0x00F9A22C File Offset: 0x00F9842C
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

		// Token: 0x06040788 RID: 264072 RVA: 0x00F9A2DB File Offset: 0x00F984DB
		protected override void OnHandleReleaseScene()
		{
			MotorcycleUiModelUtil.Instance.DestroyMotor();
		}

		// Token: 0x06040789 RID: 264073 RVA: 0x00F9A2E7 File Offset: 0x00F984E7
		private CommonItemSmallItemGrid CreateItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.LevelData.IsFinished)
			};
		}

		// Token: 0x0604078A RID: 264074 RVA: 0x00F9A300 File Offset: 0x00F98500
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604078B RID: 264075 RVA: 0x00F9A309 File Offset: 0x00F98509
		private void OnChangeRoleBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MotorFightRoleSelectView, this.ViewModel, null);
		}

		// Token: 0x0604078C RID: 264076 RVA: 0x00F9A321 File Offset: 0x00F98521
		private void OnGotoBtnClick()
		{
			MotorFightController.Instance.EnterMotorFightDungeonDirectly(this.LevelData.Id, this.ViewModel.SelectedRoleId, false);
		}

		// Token: 0x04021844 RID: 137284
		private MotorFightLevelData LevelData;

		// Token: 0x04021845 RID: 137285
		private MotorFightLevelDetailViewModel ViewModel;

		// Token: 0x04021846 RID: 137286
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021847 RID: 137287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0200C65E RID: 50782
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BE22 RID: 245282
			public const int ItemCaption = 0;

			// Token: 0x0403BE23 RID: 245283
			public const int TextRoleName = 1;

			// Token: 0x0403BE24 RID: 245284
			public const int TextBuffDesc = 2;

			// Token: 0x0403BE25 RID: 245285
			public const int BtnChangeRole = 3;

			// Token: 0x0403BE26 RID: 245286
			public const int TextureBg = 4;

			// Token: 0x0403BE27 RID: 245287
			public const int TextureInfoBg = 5;

			// Token: 0x0403BE28 RID: 245288
			public const int TextureTitleBg = 6;

			// Token: 0x0403BE29 RID: 245289
			public const int SpriteTitleLight = 7;

			// Token: 0x0403BE2A RID: 245290
			public const int TextLevelName = 8;

			// Token: 0x0403BE2B RID: 245291
			public const int ItemNumberPanel = 9;

			// Token: 0x0403BE2C RID: 245292
			public const int ArtNumber = 10;

			// Token: 0x0403BE2D RID: 245293
			public const int SpriteNumberBg = 11;

			// Token: 0x0403BE2E RID: 245294
			public const int SpriteEndlessIcon = 12;

			// Token: 0x0403BE2F RID: 245295
			public const int ItemRewardPanel = 13;

			// Token: 0x0403BE30 RID: 245296
			public const int TextLevelDesc = 14;

			// Token: 0x0403BE31 RID: 245297
			public const int LayoutReward = 15;

			// Token: 0x0403BE32 RID: 245298
			public const int ItemReward = 16;

			// Token: 0x0403BE33 RID: 245299
			public const int TextScore = 17;

			// Token: 0x0403BE34 RID: 245300
			public const int BtnGoto = 18;

			// Token: 0x0403BE35 RID: 245301
			public const int TextBuffName = 19;

			// Token: 0x0403BE36 RID: 245302
			public const int ItemChangeBtnRedDot = 20;
		}
	}
}
