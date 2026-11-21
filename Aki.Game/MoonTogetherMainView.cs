using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F78 RID: 8056
[NullableContext(2)]
[Nullable(0)]
public class MoonTogetherMainView : UiTickViewBase
{
	// Token: 0x06013ED4 RID: 81620 RVA: 0x005CFBCF File Offset: 0x005CDDCF
	[NullableContext(1)]
	public MoonTogetherMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013ED5 RID: 81621 RVA: 0x005CFBD8 File Offset: 0x005CDDD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(delegate()
			{
				this.OnCloseButtonClick().Forget();
			}))
		};
	}

	// Token: 0x06013ED6 RID: 81622 RVA: 0x005CFC84 File Offset: 0x005CDE84
	protected override UniTask OnBeforeStartAsync()
	{
		MoonTogetherMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonTogetherMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013ED7 RID: 81623 RVA: 0x005CFCC8 File Offset: 0x005CDEC8
	protected override void OnStart()
	{
		base.GetItem(4).SetUIActive(false);
		this.InviteSkillItem.SetPressCallback(delegate
		{
			this.OnInviteButtonClick().Forget();
		});
		this.ChangeVisionSkillItem.SetPressCallback(delegate
		{
			this.OnChangeVisionButtonClick().Forget();
		});
		this.TakePictureSkillItem.SetPressCallback(new Action(this.OnTakePictureButtonClick));
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			baseTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.默认镜头"]));
		}
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("MoonTogetherCameraRotation");
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetArmLengthAndRotation(Rotator.ZeroRotator);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(Rotator.Create((float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(0) : null).GetValueOrDefault(), (float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(1) : null).GetValueOrDefault(), (float)((intArrayConfig != null) ? intArrayConfig.GetValueOrNull(2) : null).GetValueOrDefault()).ToUeRotator());
		MoonTogetherModel.Instance.IsInMoonTogether = true;
	}

	// Token: 0x06013ED8 RID: 81624 RVA: 0x005CFE14 File Offset: 0x005CE014
	protected override void OnBeforeDestroy()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			baseTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.第一人称镜头"]));
		}
		if (baseTagComponent == null)
		{
			return;
		}
		baseTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["系统.功能.致敬观察索拉里斯.默认镜头"]));
	}

	// Token: 0x06013ED9 RID: 81625 RVA: 0x005CFE80 File Offset: 0x005CE080
	protected override void OnBeforeShow()
	{
		this.IsFirstPerson = false;
		int curInviteRoleId = MoonTogetherModel.Instance.CurInviteRoleId;
		if (curInviteRoleId > 0 && MoonTogetherModel.Instance.IsLinkageRole(curInviteRoleId))
		{
			this.OnInviteLinkageRole();
			return;
		}
		this.OnInviteNormalRole();
	}

	// Token: 0x06013EDA RID: 81626 RVA: 0x005CFEBD File Offset: 0x005CE0BD
	protected override void OnTick(float delta)
	{
		this.ChangeVisionSkillItem.TickSkillCoolDown(delta);
	}

	// Token: 0x06013EDB RID: 81627 RVA: 0x005CFECC File Offset: 0x005CE0CC
	private UniTask OnInviteButtonClick()
	{
		MoonTogetherMainView.<OnInviteButtonClick>d__12 <OnInviteButtonClick>d__;
		<OnInviteButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnInviteButtonClick>d__.<>4__this = this;
		<OnInviteButtonClick>d__.<>1__state = -1;
		<OnInviteButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnInviteButtonClick>d__12>(ref <OnInviteButtonClick>d__);
		return <OnInviteButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x06013EDC RID: 81628 RVA: 0x005CFF10 File Offset: 0x005CE110
	private UniTask OnChangeVisionButtonClick()
	{
		MoonTogetherMainView.<OnChangeVisionButtonClick>d__13 <OnChangeVisionButtonClick>d__;
		<OnChangeVisionButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChangeVisionButtonClick>d__.<>4__this = this;
		<OnChangeVisionButtonClick>d__.<>1__state = -1;
		<OnChangeVisionButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnChangeVisionButtonClick>d__13>(ref <OnChangeVisionButtonClick>d__);
		return <OnChangeVisionButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x06013EDD RID: 81629 RVA: 0x005CFF54 File Offset: 0x005CE154
	private void OnTakePictureButtonClick()
	{
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = true,
			PrepareFullScreenShot = false,
			IsHiddenBattleView = true,
			HandBookPhotoData = null,
			GachaData = null,
			FragmentMemory = null,
			RoleSkinData = null,
			ShareId = 1
		};
		PhotographController.Instance.ScreenShot(param);
	}

	// Token: 0x06013EDE RID: 81630 RVA: 0x005CFFAC File Offset: 0x005CE1AC
	private UniTask OnCloseButtonClick()
	{
		MoonTogetherMainView.<OnCloseButtonClick>d__15 <OnCloseButtonClick>d__;
		<OnCloseButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCloseButtonClick>d__.<>4__this = this;
		<OnCloseButtonClick>d__.<>1__state = -1;
		<OnCloseButtonClick>d__.<>t__builder.Start<MoonTogetherMainView.<OnCloseButtonClick>d__15>(ref <OnCloseButtonClick>d__);
		return <OnCloseButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x06013EDF RID: 81631 RVA: 0x005CFFF0 File Offset: 0x005CE1F0
	public void OnInviteLinkageRole()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconMoonView01");
		ShowerSkillButton inviteSkillItem = this.InviteSkillItem;
		if (inviteSkillItem != null)
		{
			inviteSkillItem.SetSkillIconSprite(resourcePath);
		}
		ShowerSkillButton changeVisionSkillItem = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem != null)
		{
			changeVisionSkillItem.SetButtonInteractive(false);
		}
		ShowerSkillButton changeVisionSkillItem2 = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem2 == null)
		{
			return;
		}
		changeVisionSkillItem2.SetDisabledHint(delegate
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Perspective_switching_disabled_Tips", Array.Empty<object>());
		});
	}

	// Token: 0x06013EE0 RID: 81632 RVA: 0x005D0060 File Offset: 0x005CE260
	public void OnInviteNormalRole()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_IconMoonView02");
		ShowerSkillButton inviteSkillItem = this.InviteSkillItem;
		if (inviteSkillItem != null)
		{
			inviteSkillItem.SetSkillIconSprite(resourcePath);
		}
		ShowerSkillButton changeVisionSkillItem = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem != null)
		{
			changeVisionSkillItem.SetButtonInteractive(true);
		}
		ShowerSkillButton changeVisionSkillItem2 = this.ChangeVisionSkillItem;
		if (changeVisionSkillItem2 == null)
		{
			return;
		}
		changeVisionSkillItem2.SetDisabledHint(null);
	}

	// Token: 0x0400A9CE RID: 43470
	private ShowerSkillButton InviteSkillItem;

	// Token: 0x0400A9CF RID: 43471
	private ShowerSkillButton ChangeVisionSkillItem;

	// Token: 0x0400A9D0 RID: 43472
	private ShowerSkillButton TakePictureSkillItem;

	// Token: 0x0400A9D1 RID: 43473
	private bool IsFirstPerson;

	// Token: 0x0200827D RID: 33405
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A220 RID: 172576
		public const int InviteSkillItem = 0;

		// Token: 0x0402A221 RID: 172577
		public const int ChangeVisionSkillItem = 1;

		// Token: 0x0402A222 RID: 172578
		public const int TakePictureSkillItem = 2;

		// Token: 0x0402A223 RID: 172579
		public const int CloseButton = 3;

		// Token: 0x0402A224 RID: 172580
		public const int NiaItem = 4;
	}
}
